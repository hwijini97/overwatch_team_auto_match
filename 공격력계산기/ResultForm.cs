using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 오버워치팀매칭
{
    public partial class ResultForm : Form
    {
        MainForm parent;

        public ResultForm(MainForm _parent, string key)
        {
            InitializeComponent();
            parent = _parent;
            mapValues(key);
        }

        private void mapValues(string key)
        {
            List<User> aTeam = parent.results[key].aTeam;
            List<User> bTeam = parent.results[key].bTeam;

            lb_tank_a1.Text = aTeam[0].name.ToString() + " (" + aTeam[0].scores.tank.ToString() + ")";
            lb_tank_a2.Text = aTeam[1].name.ToString() + " (" + aTeam[1].scores.tank.ToString() + ")";
            lb_dps_a1.Text = aTeam[2].name.ToString() + " (" + aTeam[2].scores.tank.ToString() + ")";
            lb_dps_a2.Text = aTeam[3].name.ToString() + " (" + aTeam[3].scores.tank.ToString() + ")";
            lb_support_a1.Text = aTeam[4].name.ToString() + " (" + aTeam[4].scores.tank.ToString() + ")";
            lb_support_a2.Text = aTeam[5].name.ToString() + " (" + aTeam[5].scores.tank.ToString() + ")";

            lb_tank_b1.Text = bTeam[0].name.ToString() + " (" + bTeam[0].scores.tank.ToString() + ")";
            lb_tank_b2.Text = bTeam[1].name.ToString() + " (" + bTeam[1].scores.tank.ToString() + ")";
            lb_dps_b1.Text = bTeam[2].name.ToString() + " (" + bTeam[2].scores.tank.ToString() + ")";
            lb_dps_b2.Text = bTeam[3].name.ToString() + " (" + bTeam[3].scores.tank.ToString() + ")";
            lb_support_b1.Text = bTeam[4].name.ToString() + " (" + bTeam[4].scores.tank.ToString() + ")";
            lb_support_b2.Text = bTeam[5].name.ToString() + " (" + bTeam[5].scores.tank.ToString() + ")";
        }
    }
}
