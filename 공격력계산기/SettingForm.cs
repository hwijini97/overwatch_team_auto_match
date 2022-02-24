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
    public partial class SettingForm : Form
    {
        MainForm parent;

        public SettingForm(MainForm _parent)
        {
            InitializeComponent();
            parent = _parent;

            mapSettings(_parent.settings);
        }

        private void mapSettings(Dictionary<string, ScoreByPosition> settings)
        {
            this.tb_tank_bronze1.Text = settings["bronze1"].tank.ToString();
            this.tb_tank_bronze2.Text = settings["bronze2"].tank.ToString();
            this.tb_tank_silver1.Text = settings["silver1"].tank.ToString();
            this.tb_tank_silver2.Text = settings["silver2"].tank.ToString();
            this.tb_tank_gold1.Text = settings["gold1"].tank.ToString();
            this.tb_tank_gold2.Text = settings["gold2"].tank.ToString();
            this.tb_tank_platinum1.Text = settings["platinum1"].tank.ToString();
            this.tb_tank_platinum2.Text = settings["platinum2"].tank.ToString();
            this.tb_tank_diamond1.Text = settings["diamond1"].tank.ToString();
            this.tb_tank_diamond2.Text = settings["diamond2"].tank.ToString();
            this.tb_tank_master1.Text = settings["master1"].tank.ToString();
            this.tb_tank_master2.Text = settings["master2"].tank.ToString();
            this.tb_tank_grandmaster1.Text = settings["grandmaster1"].tank.ToString();
            this.tb_tank_grandmaster2.Text = settings["grandmaster2"].tank.ToString();

            this.tb_dps_bronze1.Text = settings["bronze1"].dps.ToString();
            this.tb_dps_bronze2.Text = settings["bronze2"].dps.ToString();
            this.tb_dps_silver1.Text = settings["silver1"].dps.ToString();
            this.tb_dps_silver2.Text = settings["silver2"].dps.ToString();
            this.tb_dps_gold1.Text = settings["gold1"].dps.ToString();
            this.tb_dps_gold2.Text = settings["gold2"].dps.ToString();
            this.tb_dps_platinum1.Text = settings["platinum1"].dps.ToString();
            this.tb_dps_platinum2.Text = settings["platinum2"].dps.ToString();
            this.tb_dps_diamond1.Text = settings["diamond1"].dps.ToString();
            this.tb_dps_diamond2.Text = settings["diamond2"].dps.ToString();
            this.tb_dps_master1.Text = settings["master1"].dps.ToString();
            this.tb_dps_master2.Text = settings["master2"].dps.ToString();
            this.tb_dps_grandmaster1.Text = settings["grandmaster1"].dps.ToString();
            this.tb_dps_grandmaster2.Text = settings["grandmaster2"].dps.ToString();

            this.tb_support_bronze1.Text = settings["bronze1"].support.ToString();
            this.tb_support_bronze2.Text = settings["bronze2"].support.ToString();
            this.tb_support_silver1.Text = settings["silver1"].support.ToString();
            this.tb_support_silver2.Text = settings["silver2"].support.ToString();
            this.tb_support_gold1.Text = settings["gold1"].support.ToString();
            this.tb_support_gold2.Text = settings["gold2"].support.ToString();
            this.tb_support_platinum1.Text = settings["platinum1"].support.ToString();
            this.tb_support_platinum2.Text = settings["platinum2"].support.ToString();
            this.tb_support_diamond1.Text = settings["diamond1"].support.ToString();
            this.tb_support_diamond2.Text = settings["diamond2"].support.ToString();
            this.tb_support_master1.Text = settings["master1"].support.ToString();
            this.tb_support_master2.Text = settings["master2"].support.ToString();
            this.tb_support_grandmaster1.Text = settings["grandmaster1"].support.ToString();
            this.tb_support_grandmaster2.Text = settings["grandmaster2"].support.ToString();
        }

        private void tb_onlyDigit(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void PaintLine(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(new Pen(Color.DarkGray, 1F), new Point(0, 66), new Point(150, 66));
            e.Graphics.DrawLine(new Pen(Color.DarkGray, 1F), new Point(0, 132), new Point(150, 132));
        }

        private void tb_tank_bronze1_TextChanged(object sender, System.EventArgs e)
        {
            if (tb_tank_bronze1.Text.Equals(""))
            {
                parent.settings["bronze1"].tank = 0;
            } else
            {
                parent.settings["bronze1"].tank = Convert.ToInt32(tb_tank_bronze1.Text);
            }
        }

        private void tb_tank_bronze2_TextChanged(object sender, EventArgs e)
        {
            if (tb_tank_bronze2.Text.Equals(""))
            {
                parent.settings["bronze2"].tank = 0;
            }
            else
            {
                parent.settings["bronze2"].tank = Convert.ToInt32(tb_tank_bronze2.Text);
            }
        }

        private void tb_tank_silver1_TextChanged(object sender, EventArgs e)
        {
            if (tb_tank_silver1.Text.Equals(""))
            {
                parent.settings["silver1"].tank = 0;
            }
            else
            {
                parent.settings["silver1"].tank = Convert.ToInt32(tb_tank_silver1.Text);
            }
        }

        private void tb_tank_silver2_TextChanged(object sender, EventArgs e)
        {
            if (tb_tank_silver2.Text.Equals(""))
            {
                parent.settings["silver2"].tank = 0;
            }
            else
            {
                parent.settings["silver2"].tank = Convert.ToInt32(tb_tank_silver2.Text);
            }
        }

        private void tb_tank_gold1_TextChanged(object sender, EventArgs e)
        {
            if (tb_tank_gold1.Text.Equals(""))
            {
                parent.settings["gold1"].tank = 0;
            }
            else
            {
                parent.settings["gold1"].tank = Convert.ToInt32(tb_tank_gold1.Text);
            }
        }

        private void tb_tank_gold2_TextChanged(object sender, EventArgs e)
        {
            if (tb_tank_gold2.Text.Equals(""))
            {
                parent.settings["gold2"].tank = 0;
            }
            else
            {
                parent.settings["gold2"].tank = Convert.ToInt32(tb_tank_gold2.Text);
            }
        }

        private void tb_tank_platinum1_TextChanged(object sender, EventArgs e)
        {
            if (tb_tank_platinum1.Text.Equals(""))
            {
                parent.settings["platinum1"].tank = 0;
            }
            else
            {
                parent.settings["platinum1"].tank = Convert.ToInt32(tb_tank_platinum1.Text);
            }
        }

        private void tb_tank_platinum2_TextChanged(object sender, EventArgs e)
        {
            if (tb_tank_platinum2.Text.Equals(""))
            {
                parent.settings["platinum2"].tank = 0;
            }
            else
            {
                parent.settings["platinum2"].tank = Convert.ToInt32(tb_tank_platinum2.Text);
            }
        }

        private void tb_tank_diamond1_TextChanged(object sender, EventArgs e)
        {
            if (tb_tank_diamond1.Text.Equals(""))
            {
                parent.settings["diamond1"].tank = 0;
            }
            else
            {
                parent.settings["diamond1"].tank = Convert.ToInt32(tb_tank_diamond1.Text);
            }
        }

        private void tb_tank_diamond2_TextChanged(object sender, EventArgs e)
        {
            if (tb_tank_diamond2.Text.Equals(""))
            {
                parent.settings["diamond2"].tank = 0;
            }
            else
            {
                parent.settings["diamond2"].tank = Convert.ToInt32(tb_tank_diamond2.Text);
            }
        }

        private void tb_tank_master1_TextChanged(object sender, EventArgs e)
        {
            if (tb_tank_master1.Text.Equals(""))
            {
                parent.settings["master1"].tank = 0;
            }
            else
            {
                parent.settings["master1"].tank = Convert.ToInt32(tb_tank_master1.Text);
            }
        }

        private void tb_tank_master2_TextChanged(object sender, EventArgs e)
        {
            if (tb_tank_master2.Text.Equals(""))
            {
                parent.settings["master2"].tank = 0;
            }
            else
            {
                parent.settings["master2"].tank = Convert.ToInt32(tb_tank_master2.Text);
            }
        }

        private void tb_tank_grandmaster1_TextChanged(object sender, EventArgs e)
        {
            if (tb_tank_grandmaster1.Text.Equals(""))
            {
                parent.settings["grandmaster1"].tank = 0;
            }
            else
            {
                parent.settings["grandmaster1"].tank = Convert.ToInt32(tb_tank_grandmaster1.Text);
            }
        }

        private void tb_tank_grandmaster2_TextChanged(object sender, EventArgs e)
        {
            if (tb_tank_grandmaster2.Text.Equals(""))
            {
                parent.settings["grandmaster2"].tank = 0;
            }
            else
            {
                parent.settings["grandmaster2"].tank = Convert.ToInt32(tb_tank_grandmaster2.Text);
            }
        }

        private void tb_dps_bronze1_TextChanged(object sender, EventArgs e)
        {
            if (tb_dps_bronze1.Text.Equals(""))
            {
                parent.settings["bronze1"].dps = 0;
            }
            else
            {
                parent.settings["bronze1"].dps = Convert.ToInt32(tb_dps_bronze1.Text);
            }
        }

        private void tb_dps_bronze2_TextChanged(object sender, EventArgs e)
        {
            if (tb_dps_bronze2.Text.Equals(""))
            {
                parent.settings["bronze2"].dps = 0;
            }
            else
            {
                parent.settings["bronze2"].dps = Convert.ToInt32(tb_dps_bronze2.Text);
            }
        }

        private void tb_dps_silver1_TextChanged(object sender, EventArgs e)
        {
            if (tb_dps_silver1.Text.Equals(""))
            {
                parent.settings["silver1"].dps = 0;
            }
            else
            {
                parent.settings["silver1"].dps = Convert.ToInt32(tb_dps_silver1.Text);
            }
        }

        private void tb_dps_silver2_TextChanged(object sender, EventArgs e)
        {
            if (tb_dps_silver2.Text.Equals(""))
            {
                parent.settings["silver2"].dps = 0;
            }
            else
            {
                parent.settings["silver2"].dps = Convert.ToInt32(tb_dps_silver2.Text);
            }
        }

        private void tb_dps_gold1_TextChanged(object sender, EventArgs e)
        {
            if (tb_dps_gold1.Text.Equals(""))
            {
                parent.settings["gold1"].dps = 0;
            }
            else
            {
                parent.settings["gold1"].dps = Convert.ToInt32(tb_dps_gold1.Text);
            }
        }

        private void tb_dps_gold2_TextChanged(object sender, EventArgs e)
        {
            if (tb_dps_gold2.Text.Equals(""))
            {
                parent.settings["gold2"].dps = 0;
            }
            else
            {
                parent.settings["gold2"].dps = Convert.ToInt32(tb_dps_gold2.Text);
            }
        }

        private void tb_dps_platinum1_TextChanged(object sender, EventArgs e)
        {
            if (tb_dps_platinum1.Text.Equals(""))
            {
                parent.settings["platinum1"].dps = 0;
            }
            else
            {
                parent.settings["platinum1"].dps = Convert.ToInt32(tb_dps_platinum1.Text);
            }
        }

        private void tb_dps_platinum2_TextChanged(object sender, EventArgs e)
        {
            if (tb_dps_platinum2.Text.Equals(""))
            {
                parent.settings["platinum2"].dps = 0;
            }
            else
            {
                parent.settings["platinum2"].dps = Convert.ToInt32(tb_dps_platinum2.Text);
            }
        }

        private void tb_dps_diamond1_TextChanged(object sender, EventArgs e)
        {
            if (tb_dps_diamond1.Text.Equals(""))
            {
                parent.settings["diamond1"].dps = 0;
            }
            else
            {
                parent.settings["diamond1"].dps = Convert.ToInt32(tb_dps_diamond1.Text);
            }
        }

        private void tb_dps_diamond2_TextChanged(object sender, EventArgs e)
        {
            if (tb_dps_diamond2.Text.Equals(""))
            {
                parent.settings["diamond2"].dps = 0;
            }
            else
            {
                parent.settings["diamond2"].dps = Convert.ToInt32(tb_dps_diamond2.Text);
            }
        }

        private void tb_dps_master1_TextChanged(object sender, EventArgs e)
        {
            if (tb_dps_master1.Text.Equals(""))
            {
                parent.settings["master1"].dps = 0;
            }
            else
            {
                parent.settings["master1"].dps = Convert.ToInt32(tb_dps_master1.Text);
            }
        }

        private void tb_dps_master2_TextChanged(object sender, EventArgs e)
        {
            if (tb_dps_master2.Text.Equals(""))
            {
                parent.settings["master2"].dps = 0;
            }
            else
            {
                parent.settings["master2"].dps = Convert.ToInt32(tb_dps_master2.Text);
            }
        }

        private void tb_dps_grandmaster1_TextChanged(object sender, EventArgs e)
        {
            if (tb_dps_grandmaster1.Text.Equals(""))
            {
                parent.settings["grandmaster1"].dps = 0;
            }
            else
            {
                parent.settings["grandmaster1"].dps = Convert.ToInt32(tb_dps_grandmaster1.Text);
            }
        }

        private void tb_dps_grandmaster2_TextChanged(object sender, EventArgs e)
        {
            if (tb_dps_grandmaster2.Text.Equals(""))
            {
                parent.settings["grandmaster2"].dps = 0;
            }
            else
            {
                parent.settings["grandmaster2"].dps = Convert.ToInt32(tb_dps_grandmaster2.Text);
            }
        }

        private void tb_support_bronze1_TextChanged(object sender, EventArgs e)
        {
            if (tb_support_bronze1.Text.Equals(""))
            {
                parent.settings["bronze1"].support = 0;
            }
            else
            {
                parent.settings["bronze1"].support = Convert.ToInt32(tb_support_bronze1.Text);
            }
        }

        private void tb_support_bronze2_TextChanged(object sender, EventArgs e)
        {
            if (tb_support_bronze2.Text.Equals(""))
            {
                parent.settings["bronze2"].support = 0;
            }
            else
            {
                parent.settings["bronze2"].support = Convert.ToInt32(tb_support_bronze2.Text);
            }
        }

        private void tb_support_silver1_TextChanged(object sender, EventArgs e)
        {
            if (tb_support_silver1.Text.Equals(""))
            {
                parent.settings["silver1"].support = 0;
            }
            else
            {
                parent.settings["silver1"].support = Convert.ToInt32(tb_support_silver1.Text);
            }
        }

        private void tb_support_silver2_TextChanged(object sender, EventArgs e)
        {
            if (tb_support_silver2.Text.Equals(""))
            {
                parent.settings["silver2"].support = 0;
            }
            else
            {
                parent.settings["silver2"].support = Convert.ToInt32(tb_support_silver2.Text);
            }
        }

        private void tb_support_gold1_TextChanged(object sender, EventArgs e)
        {
            if (tb_support_gold1.Text.Equals(""))
            {
                parent.settings["gold1"].support = 0;
            }
            else
            {
                parent.settings["gold1"].support = Convert.ToInt32(tb_support_gold1.Text);
            }
        }

        private void tb_support_gold2_TextChanged(object sender, EventArgs e)
        {
            if (tb_support_gold2.Text.Equals(""))
            {
                parent.settings["gold2"].support = 0;
            }
            else
            {
                parent.settings["gold2"].support = Convert.ToInt32(tb_support_gold2.Text);
            }
        }

        private void tb_support_platinum1_TextChanged(object sender, EventArgs e)
        {
            if (tb_support_platinum1.Text.Equals(""))
            {
                parent.settings["platinum1"].support = 0;
            }
            else
            {
                parent.settings["platinum1"].support = Convert.ToInt32(tb_support_platinum1.Text);
            }
        }

        private void tb_support_platinum2_TextChanged(object sender, EventArgs e)
        {
            if (tb_support_platinum2.Text.Equals(""))
            {
                parent.settings["platinum2"].support = 0;
            }
            else
            {
                parent.settings["platinum2"].support = Convert.ToInt32(tb_support_platinum2.Text);
            }
        }

        private void tb_support_diamond1_TextChanged(object sender, EventArgs e)
        {
            if (tb_support_diamond1.Text.Equals(""))
            {
                parent.settings["diamond1"].support = 0;
            }
            else
            {
                parent.settings["diamond1"].support = Convert.ToInt32(tb_support_diamond1.Text);
            }
        }

        private void tb_support_diamond2_TextChanged(object sender, EventArgs e)
        {
            if (tb_support_diamond2.Text.Equals(""))
            {
                parent.settings["diamond2"].support = 0;
            }
            else
            {
                parent.settings["diamond2"].support = Convert.ToInt32(tb_support_diamond2.Text);
            }
        }

        private void tb_support_master1_TextChanged(object sender, EventArgs e)
        {
            if (tb_support_master1.Text.Equals(""))
            {
                parent.settings["master1"].support = 0;
            }
            else
            {
                parent.settings["master1"].support = Convert.ToInt32(tb_support_master1.Text);
            }
        }

        private void tb_support_master2_TextChanged(object sender, EventArgs e)
        {
            if (tb_support_master2.Text.Equals(""))
            {
                parent.settings["master2"].support = 0;
            }
            else
            {
                parent.settings["master2"].support = Convert.ToInt32(tb_support_master2.Text);
            }
        }

        private void tb_support_grandmaster1_TextChanged(object sender, EventArgs e)
        {
            if (tb_support_grandmaster1.Text.Equals(""))
            {
                parent.settings["grandmaster1"].support = 0;
            }
            else
            {
                parent.settings["grandmaster1"].support = Convert.ToInt32(tb_support_grandmaster1.Text);
            }
        }

        private void tb_support_grandmaster2_TextChanged(object sender, EventArgs e)
        {
            if (tb_support_grandmaster2.Text.Equals(""))
            {
                parent.settings["grandmaster2"].support = 0;
            }
            else
            {
                parent.settings["grandmaster2"].support = Convert.ToInt32(tb_support_grandmaster2.Text);
            }
        }
    }
}
