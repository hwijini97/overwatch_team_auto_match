using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace 오버워치팀매칭
{
    public partial class MainForm : Form
    {
        const string dataFileName = "programData"; // 유저 정보 및 세팅 값들을 저장하는 파일 이름
        public List<User> users;
        public Dictionary<string, ScoreByPosition> settings;
        public List<Result> results = new List<Result>();

        private TeamMatcher teamMatcher = new TeamMatcher();
        private Thread dataSavingThread; // 주기적으로 유저 정보 및 주사위 정보를 저장하는 쓰레드

        public MainForm()
        {
            InitializeComponent();
            users = new List<User>();
            settings = new Dictionary<string, ScoreByPosition>();

            // 저장된 파일 불러오는 부분
            if (File.Exists(@".\" + dataFileName + ".dat"))
            {
                string[] dataFile = File.ReadAllLines(@".\" + dataFileName + ".dat");
                if (isValidJsonFile(dataFile))
                {
                    users = JsonConvert.DeserializeObject<List<User>>(dataFile[0]);
                    settings = JsonConvert.DeserializeObject<Dictionary<string, ScoreByPosition>>(dataFile[1]);
                }
            }

            if (settings == null || settings.Count == 0)
            {
                settings = new Dictionary<string, ScoreByPosition>();
                initializeSettings();
            }

            // 추후에 데이터를 파일에서 불러오면
            for (int i=0; i<users.Count; i++)
            {
                listViewUser.Items.Add(new ListViewItem(new string[] {  // listView에도 유저 데이터 추가
                    users[i].name, 
                    users[i].scores.tank.ToString(), 
                    users[i].scores.dps.ToString(), 
                    users[i].scores.support.ToString() }));
            }

            dataSavingThread = new Thread(new ParameterizedThreadStart(saveDataPeriodically)); // 주기적으로 유저 정보 및 설정 정보를 저장하는 쓰레드
            dataSavingThread.Start(2); // 2초에 한 번씩 데이터 저장
        }

        private void initializeSettings()
        {
            settings.Add("bronze1", new ScoreByPosition(5, 6, 4));
            settings.Add("bronze2", new ScoreByPosition(5, 6, 4));
            settings.Add("silver1", new ScoreByPosition(5, 6, 4));
            settings.Add("silver2", new ScoreByPosition(5, 6, 4));
            settings.Add("gold1", new ScoreByPosition(5, 6, 4));
            settings.Add("gold2", new ScoreByPosition(5, 6, 4));
            settings.Add("platinum1", new ScoreByPosition(5, 6, 4));
            settings.Add("platinum2", new ScoreByPosition(5, 6, 4));
            settings.Add("diamond1", new ScoreByPosition(5, 6, 4));
            settings.Add("diamond2", new ScoreByPosition(5, 6, 4));
            settings.Add("master1", new ScoreByPosition(5, 6, 4));
            settings.Add("master2", new ScoreByPosition(5, 6, 4));
            settings.Add("grandmaster1", new ScoreByPosition(5, 6, 4));
            settings.Add("grandmaster2", new ScoreByPosition(5, 6, 4));
        }

        private bool isValidJsonFile(string[] dataFile)
        {
            if(dataFile.Length != 2)
            {
                return false;
            }
            try
            {
                for (int i = 0; i < dataFile.Length; i++)
                {
                    JToken.Parse(dataFile[i]);
                }
            }
            catch (JsonReaderException)
            {
                return false;
            }
            return true;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            UserAddForm form = new UserAddForm(this);
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(this.Location.X + 140, this.Location.Y + 90);
            form.Show();
        }

        public int addUser(String name, int tank, int dps, int support)
        {
            // 중복 검사
            for(int i=0; i<users.Count; i++)
            {
                if(users[i].name == name)
                {
                    return -1;
                }
            }

            // 공백 검사
            if(name.Replace(" ", "") == "")
            {
                return -2;
            }

            // 점수 검사
            if(tank < 0 || dps < 0 || support < 0 || tank > 5000 || dps > 5000 || support > 5000)
            {
                return -3;
            }

            // 최대 유저 수 검사
            if (users.Count > 11)
            {
                return -4;
            }

            // 적절한 닉네임이면 신규 유저 추가
            users.Add(new User(name, tank, dps, support));
            listViewUser.Items.Add(new ListViewItem(new string[] { name, tank.ToString(), dps.ToString(), support.ToString() })); // listView에도 유저 데이터 추가
            return 1;
        }

        private void tb_onlyDigit(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (listViewUser.FocusedItem != null)
            {
                int index = listViewUser.FocusedItem.Index;
                if (MessageBox.Show(users[index].name + " 유저를 삭제하시겠습니까?", "유저 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    listViewUser.Items.RemoveAt(index);
                    users.RemoveAt(index);
                }
            }
            else
            {
                MessageBox.Show("삭제할 유저를 선택해주세요.", "오류");
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            dataSavingThread.Abort();
        }

        private void saveDataPeriodically(object _period) // period 초마다 주기적으로 데이터 저장
        {
            int period = (int)_period;
            if(period < 1)
            {
                MessageBox.Show("saveDataPeriodically() : 1 이상의 정수값만 사용할 수 있습니다.");
                return;
            }
            else
            {
                while (true)
                {
                    Thread.Sleep(period * 1000);
                    string userJsonString = JsonConvert.SerializeObject(users); // 유저 정보
                    string settingJsonString = JsonConvert.SerializeObject(settings); // 설정값 정보

                    using (StreamWriter outputFile = new StreamWriter(@".\" + dataFileName + ".dat"))
                    {
                        outputFile.WriteLine(userJsonString);
                        outputFile.WriteLine(settingJsonString);
                    }
                }
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            SettingForm form = new SettingForm(this);
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(this.Location.X + 140, this.Location.Y + 90);
            form.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (users.Count < 12)
            {
                MessageBox.Show("유저 12명 모두 추가한 뒤 매칭을 돌릴 수 있습니다.", "오류");
                return;
            }

            if (MessageBox.Show("매칭을 시작하시겠습니까?\n(예상 소요시간: 12초)", "안내", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                listViewResult.Items.Clear();
                results = teamMatcher.match(settings, users, 4);
                for (int i = 0; i < Math.Min(results.Count, 100); i++)
                {
                    listViewResult.Items.Add(new ListViewItem(new string[] {
                    Convert.ToString(i + 1),
                    Convert.ToString(results[i].aTeamAverage),
                    Convert.ToString(results[i].bTeamAverage),
                    Convert.ToString(Math.Abs(results[i].aTeamPoint - results[i].bTeamPoint))}));
                }
                if (results.Count == 0)
                {
                    MessageBox.Show("적절한 매칭 결과가 존재하지 않습니다.\n설정값을 바꾸거나 유저들의 점수를 다르게 입력해보세요.", "오류");
                }
            }
        }

        private void listViewResult_DoubleClicked(object sender, EventArgs e)
        {
            ListView lv = sender as ListView;
            ResultForm form = new ResultForm(this, lv.SelectedIndices[0]);
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(this.Location.X + 140, this.Location.Y + 90);
            form.Show();
        }
    }
}
