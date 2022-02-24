using System;
using System.Windows.Forms;

namespace 오버워치팀매칭
{
    public partial class UserAddForm : Form
    {
        MainForm parent;

        public UserAddForm(MainForm _parent)
        {
            InitializeComponent();
            parent = _parent;
        }

        private void btn_addUser_Click(object sender, EventArgs e)
        {
            int result = parent.addUser(tb_name.Text, Int32.Parse(tb_tank.Text), Int32.Parse(tb_dps.Text), Int32.Parse(tb_support.Text));
            switch (result) {
                case 1:
                    MessageBox.Show(tb_name.Text + " 유저를 새로 추가하였습니다.", "알림");
                    this.Close();
                    break;
                case -1:
                    MessageBox.Show(tb_name.Text + " : 이미 존재하는 이름입니다.", "오류");
                    break;
                case -2:
                    MessageBox.Show("이름을 입력해주세요.", "오류");
                    tb_name.Text = "";
                    break;
                case -3:
                    MessageBox.Show("점수를 올바르게 입력해주세요.", "오류");
                    break;
                case -4:
                    MessageBox.Show("유저는 최대 12명까지 추가할 수 있습니다.", "오류");
                    break;
                default:
                    MessageBox.Show("Error, return value = " + Convert.ToString(result));
                    break;
            }
        }

        private void tb_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btn_addUser_Click(sender, e);
            }
        }
        private void tb_onlyDigit(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
