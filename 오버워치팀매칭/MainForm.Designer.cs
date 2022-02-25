namespace 오버워치팀매칭
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tableLayoutPanelLeftContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.listViewUser = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tank = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dps = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.support = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanelContainer = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelRightContainer = new System.Windows.Forms.TableLayoutPanel();
            this.listViewResult = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.tableLayoutPanelLeftContainer.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanelContainer.SuspendLayout();
            this.tableLayoutPanelRightContainer.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelLeftContainer
            // 
            this.tableLayoutPanelLeftContainer.ColumnCount = 1;
            this.tableLayoutPanelLeftContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0316F));
            this.tableLayoutPanelLeftContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.96839F));
            this.tableLayoutPanelLeftContainer.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanelLeftContainer.Controls.Add(this.listViewUser, 0, 0);
            this.tableLayoutPanelLeftContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelLeftContainer.Location = new System.Drawing.Point(4, 3);
            this.tableLayoutPanelLeftContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanelLeftContainer.Name = "tableLayoutPanelLeftContainer";
            this.tableLayoutPanelLeftContainer.RowCount = 2;
            this.tableLayoutPanelLeftContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.94212F));
            this.tableLayoutPanelLeftContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.05788F));
            this.tableLayoutPanelLeftContainer.Size = new System.Drawing.Size(371, 554);
            this.tableLayoutPanelLeftContainer.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnAddUser, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnDeleteUser, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 490);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(363, 61);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.White;
            this.btnAddUser.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAddUser.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnAddUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnAddUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnAddUser.Location = new System.Drawing.Point(0, 0);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(101, 61);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "추가";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.White;
            this.btnDeleteUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnDeleteUser.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDeleteUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnDeleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDeleteUser.Location = new System.Drawing.Point(257, 0);
            this.btnDeleteUser.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(106, 61);
            this.btnDeleteUser.TabIndex = 2;
            this.btnDeleteUser.Text = "삭제";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // listViewUser
            // 
            this.listViewUser.BackColor = System.Drawing.Color.White;
            this.listViewUser.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.tank,
            this.dps,
            this.support});
            this.listViewUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewUser.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listViewUser.FullRowSelect = true;
            this.listViewUser.HideSelection = false;
            this.listViewUser.Location = new System.Drawing.Point(4, 3);
            this.listViewUser.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listViewUser.Name = "listViewUser";
            this.listViewUser.Size = new System.Drawing.Size(363, 481);
            this.listViewUser.TabIndex = 0;
            this.listViewUser.UseCompatibleStateImageBehavior = false;
            this.listViewUser.View = System.Windows.Forms.View.Details;
            // 
            // name
            // 
            this.name.Text = "이름";
            this.name.Width = 67;
            // 
            // tank
            // 
            this.tank.Text = "돌격";
            this.tank.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dps
            // 
            this.dps.Text = "공격";
            this.dps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // support
            // 
            this.support.Text = "지원";
            this.support.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanelContainer
            // 
            this.tableLayoutPanelContainer.ColumnCount = 2;
            this.tableLayoutPanelContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.26525F));
            this.tableLayoutPanelContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.73475F));
            this.tableLayoutPanelContainer.Controls.Add(this.tableLayoutPanelLeftContainer, 0, 0);
            this.tableLayoutPanelContainer.Controls.Add(this.tableLayoutPanelRightContainer, 1, 0);
            this.tableLayoutPanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelContainer.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanelContainer.Name = "tableLayoutPanelContainer";
            this.tableLayoutPanelContainer.RowCount = 1;
            this.tableLayoutPanelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelContainer.Size = new System.Drawing.Size(754, 560);
            this.tableLayoutPanelContainer.TabIndex = 1;
            // 
            // tableLayoutPanelRightContainer
            // 
            this.tableLayoutPanelRightContainer.ColumnCount = 1;
            this.tableLayoutPanelRightContainer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelRightContainer.Controls.Add(this.listViewResult, 0, 1);
            this.tableLayoutPanelRightContainer.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanelRightContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelRightContainer.Location = new System.Drawing.Point(383, 3);
            this.tableLayoutPanelRightContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanelRightContainer.Name = "tableLayoutPanelRightContainer";
            this.tableLayoutPanelRightContainer.Padding = new System.Windows.Forms.Padding(0, 3, 4, 3);
            this.tableLayoutPanelRightContainer.RowCount = 2;
            this.tableLayoutPanelRightContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.77372F));
            this.tableLayoutPanelRightContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.22628F));
            this.tableLayoutPanelRightContainer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelRightContainer.Size = new System.Drawing.Size(367, 554);
            this.tableLayoutPanelRightContainer.TabIndex = 1;
            // 
            // listViewResult
            // 
            this.listViewResult.BackColor = System.Drawing.Color.White;
            this.listViewResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewResult.Font = new System.Drawing.Font("돋움", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listViewResult.FullRowSelect = true;
            this.listViewResult.HideSelection = false;
            this.listViewResult.Location = new System.Drawing.Point(4, 92);
            this.listViewResult.Margin = new System.Windows.Forms.Padding(4, 20, 4, 3);
            this.listViewResult.Name = "listViewResult";
            this.listViewResult.Size = new System.Drawing.Size(355, 456);
            this.listViewResult.TabIndex = 5;
            this.listViewResult.UseCompatibleStateImageBehavior = false;
            this.listViewResult.View = System.Windows.Forms.View.Details;
            this.listViewResult.DoubleClick += new System.EventHandler(this.listViewResult_DoubleClicked);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "번호";
            this.columnHeader1.Width = 45;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "A팀 평균점수";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "B팀 평균점수";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 90;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.btnSetting, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnStart, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 6);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(355, 63);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // btnSetting
            // 
            this.btnSetting.BackColor = System.Drawing.Color.White;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSetting.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnSetting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSetting.Location = new System.Drawing.Point(254, 0);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(0);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(101, 63);
            this.btnSetting.TabIndex = 7;
            this.btnSetting.Text = "설정";
            this.btnSetting.UseVisualStyleBackColor = false;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.White;
            this.btnStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Cyan;
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnStart.Location = new System.Drawing.Point(0, 0);
            this.btnStart.Margin = new System.Windows.Forms.Padding(0);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(131, 63);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "매칭 시작";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(754, 560);
            this.Controls.Add(this.tableLayoutPanelContainer);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "오버워치 팀 매칭";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tableLayoutPanelLeftContainer.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanelContainer.ResumeLayout(false);
            this.tableLayoutPanelRightContainer.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelLeftContainer;
        private System.Windows.Forms.ListView listViewUser;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelRightContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.ColumnHeader tank;
        private System.Windows.Forms.ColumnHeader dps;
        private System.Windows.Forms.ColumnHeader support;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.ListView listViewResult;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}

