namespace 오버워치팀매칭
{
    partial class UserAddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAddForm));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_addUser = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_tank = new System.Windows.Forms.TextBox();
            this.tb_dps = new System.Windows.Forms.TextBox();
            this.tb_support = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.0354F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.9646F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.btn_addUser, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb_name, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_tank, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_dps, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_support, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(187, 225);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 139);
            this.label4.Margin = new System.Windows.Forms.Padding(15, 13, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "지원";
            // 
            // btn_addUser
            // 
            this.btn_addUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_addUser.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_addUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btn_addUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_addUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addUser.Location = new System.Drawing.Point(78, 178);
            this.btn_addUser.Margin = new System.Windows.Forms.Padding(0, 10, 10, 5);
            this.btn_addUser.Name = "btn_addUser";
            this.btn_addUser.Size = new System.Drawing.Size(99, 42);
            this.btn_addUser.TabIndex = 3;
            this.btn_addUser.Text = "추가";
            this.btn_addUser.UseVisualStyleBackColor = true;
            this.btn_addUser.Click += new System.EventHandler(this.btn_addUser_Click);
            // 
            // tb_name
            // 
            this.tb_name.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tb_name.Font = new System.Drawing.Font("Arial", 10F);
            this.tb_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_name.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.tb_name.Location = new System.Drawing.Point(78, 6);
            this.tb_name.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tb_name.MaxLength = 10;
            this.tb_name.Name = "tb_name";
            this.tb_name.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_name.Size = new System.Drawing.Size(99, 30);
            this.tb_name.TabIndex = 7;
            this.tb_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(15, 13, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(15, 13, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "돌격";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(15, 13, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "공격";
            // 
            // tb_tank
            // 
            this.tb_tank.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tb_tank.Font = new System.Drawing.Font("Arial", 10F);
            this.tb_tank.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_tank.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.tb_tank.Location = new System.Drawing.Point(78, 48);
            this.tb_tank.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tb_tank.MaxLength = 4;
            this.tb_tank.Name = "tb_tank";
            this.tb_tank.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_tank.Size = new System.Drawing.Size(99, 30);
            this.tb_tank.TabIndex = 8;
            this.tb_tank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_tank.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_onlyDigit);
            // 
            // tb_dps
            // 
            this.tb_dps.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tb_dps.Font = new System.Drawing.Font("Arial", 10F);
            this.tb_dps.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_dps.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.tb_dps.Location = new System.Drawing.Point(78, 90);
            this.tb_dps.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tb_dps.MaxLength = 4;
            this.tb_dps.Name = "tb_dps";
            this.tb_dps.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_dps.Size = new System.Drawing.Size(99, 30);
            this.tb_dps.TabIndex = 9;
            this.tb_dps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_dps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_onlyDigit);
            // 
            // tb_support
            // 
            this.tb_support.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.tb_support.Font = new System.Drawing.Font("Arial", 10F);
            this.tb_support.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_support.ImeMode = System.Windows.Forms.ImeMode.Alpha;
            this.tb_support.Location = new System.Drawing.Point(78, 132);
            this.tb_support.Margin = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.tb_support.MaxLength = 4;
            this.tb_support.Name = "tb_support";
            this.tb_support.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tb_support.Size = new System.Drawing.Size(99, 30);
            this.tb_support.TabIndex = 10;
            this.tb_support.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_support.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_onlyDigit);
            // 
            // UserAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(187, 225);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserAddForm";
            this.Opacity = 0.95D;
            this.Text = "유저 추가";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_addUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_tank;
        private System.Windows.Forms.TextBox tb_dps;
        private System.Windows.Forms.TextBox tb_support;
    }
}