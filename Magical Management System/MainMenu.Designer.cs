namespace Magical_Management_System
{
    partial class MainMenu
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系統ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.結束程式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.派工ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查詢ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.用戶資料查詢ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.派工單退租戶查詢ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.續約戶查詢ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.未續約查詢ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.復機戶查詢ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退租戶查詢ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.快到期用戶查詢ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用戶抽獎ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tslblLoginUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblNowDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslblDateTimeShow = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrNowDateTime = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系統ToolStripMenuItem,
            this.新增ToolStripMenuItem,
            this.查詢ToolStripMenuItem1,
            this.工具ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 27);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系統ToolStripMenuItem
            // 
            this.系統ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.結束程式ToolStripMenuItem});
            this.系統ToolStripMenuItem.Name = "系統ToolStripMenuItem";
            this.系統ToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.系統ToolStripMenuItem.Text = "系統";
            // 
            // 結束程式ToolStripMenuItem
            // 
            this.結束程式ToolStripMenuItem.Name = "結束程式ToolStripMenuItem";
            this.結束程式ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.結束程式ToolStripMenuItem.Text = "結束程式";
            this.結束程式ToolStripMenuItem.Click += new System.EventHandler(this.結束程式ToolStripMenuItem_Click);
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.派工ToolStripMenuItem});
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.新增ToolStripMenuItem.Text = "新增";
            // 
            // 派工ToolStripMenuItem
            // 
            this.派工ToolStripMenuItem.Name = "派工ToolStripMenuItem";
            this.派工ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.派工ToolStripMenuItem.Text = "派工";
            this.派工ToolStripMenuItem.Click += new System.EventHandler(this.派工ToolStripMenuItem_Click);
            // 
            // 查詢ToolStripMenuItem1
            // 
            this.查詢ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用戶資料查詢ToolStripMenuItem,
            this.派工單退租戶查詢ToolStripMenuItem,
            this.續約戶查詢ToolStripMenuItem,
            this.未續約查詢ToolStripMenuItem,
            this.復機戶查詢ToolStripMenuItem,
            this.退租戶查詢ToolStripMenuItem,
            this.快到期用戶查詢ToolStripMenuItem});
            this.查詢ToolStripMenuItem1.Name = "查詢ToolStripMenuItem1";
            this.查詢ToolStripMenuItem1.Size = new System.Drawing.Size(51, 23);
            this.查詢ToolStripMenuItem1.Text = "查詢";
            // 
            // 用戶資料查詢ToolStripMenuItem
            // 
            this.用戶資料查詢ToolStripMenuItem.Enabled = false;
            this.用戶資料查詢ToolStripMenuItem.Name = "用戶資料查詢ToolStripMenuItem";
            this.用戶資料查詢ToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.用戶資料查詢ToolStripMenuItem.Text = "用戶資料查詢";
            this.用戶資料查詢ToolStripMenuItem.Click += new System.EventHandler(this.用戶資料查詢ToolStripMenuItem_Click);
            // 
            // 派工單退租戶查詢ToolStripMenuItem
            // 
            this.派工單退租戶查詢ToolStripMenuItem.Name = "派工單退租戶查詢ToolStripMenuItem";
            this.派工單退租戶查詢ToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.派工單退租戶查詢ToolStripMenuItem.Text = "派工單查詢";
            this.派工單退租戶查詢ToolStripMenuItem.Click += new System.EventHandler(this.派工單查詢ToolStripMenuItem_Click);
            // 
            // 續約戶查詢ToolStripMenuItem
            // 
            this.續約戶查詢ToolStripMenuItem.Name = "續約戶查詢ToolStripMenuItem";
            this.續約戶查詢ToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.續約戶查詢ToolStripMenuItem.Text = "續約戶查詢";
            this.續約戶查詢ToolStripMenuItem.Click += new System.EventHandler(this.續約戶查詢ToolStripMenuItem_Click);
            // 
            // 未續約查詢ToolStripMenuItem
            // 
            this.未續約查詢ToolStripMenuItem.Name = "未續約查詢ToolStripMenuItem";
            this.未續約查詢ToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.未續約查詢ToolStripMenuItem.Text = "未續約戶查詢";
            this.未續約查詢ToolStripMenuItem.Click += new System.EventHandler(this.未續約戶查詢ToolStripMenuItem_Click);
            // 
            // 復機戶查詢ToolStripMenuItem
            // 
            this.復機戶查詢ToolStripMenuItem.Name = "復機戶查詢ToolStripMenuItem";
            this.復機戶查詢ToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.復機戶查詢ToolStripMenuItem.Text = "復機戶查詢";
            this.復機戶查詢ToolStripMenuItem.Click += new System.EventHandler(this.復機戶查詢ToolStripMenuItem_Click);
            // 
            // 退租戶查詢ToolStripMenuItem
            // 
            this.退租戶查詢ToolStripMenuItem.Name = "退租戶查詢ToolStripMenuItem";
            this.退租戶查詢ToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.退租戶查詢ToolStripMenuItem.Text = "退租戶查詢";
            this.退租戶查詢ToolStripMenuItem.Click += new System.EventHandler(this.退租戶查詢ToolStripMenuItem_Click);
            // 
            // 快到期用戶查詢ToolStripMenuItem
            // 
            this.快到期用戶查詢ToolStripMenuItem.Name = "快到期用戶查詢ToolStripMenuItem";
            this.快到期用戶查詢ToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.快到期用戶查詢ToolStripMenuItem.Text = "快到期用戶查詢";
            this.快到期用戶查詢ToolStripMenuItem.Click += new System.EventHandler(this.快到期用戶查詢ToolStripMenuItem_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用戶抽獎ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
            this.工具ToolStripMenuItem.Text = "工具";
            // 
            // 用戶抽獎ToolStripMenuItem
            // 
            this.用戶抽獎ToolStripMenuItem.Name = "用戶抽獎ToolStripMenuItem";
            this.用戶抽獎ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.用戶抽獎ToolStripMenuItem.Text = "用戶抽獎";
            this.用戶抽獎ToolStripMenuItem.Click += new System.EventHandler(this.用戶抽獎ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslblLoginUser,
            this.tslblUserName,
            this.tslblNowDateTime,
            this.tslblDateTimeShow,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 538);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 24);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tslblLoginUser
            // 
            this.tslblLoginUser.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tslblLoginUser.Name = "tslblLoginUser";
            this.tslblLoginUser.Size = new System.Drawing.Size(69, 19);
            this.tslblLoginUser.Text = "登入者：";
            // 
            // tslblUserName
            // 
            this.tslblUserName.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tslblUserName.Name = "tslblUserName";
            this.tslblUserName.Size = new System.Drawing.Size(51, 19);
            this.tslblUserName.Text = "Name";
            // 
            // tslblNowDateTime
            // 
            this.tslblNowDateTime.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tslblNowDateTime.Margin = new System.Windows.Forms.Padding(50, 3, 0, 2);
            this.tslblNowDateTime.Name = "tslblNowDateTime";
            this.tslblNowDateTime.Size = new System.Drawing.Size(114, 19);
            this.tslblNowDateTime.Text = "目前系統時間：";
            // 
            // tslblDateTimeShow
            // 
            this.tslblDateTimeShow.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tslblDateTimeShow.Name = "tslblDateTimeShow";
            this.tslblDateTimeShow.Size = new System.Drawing.Size(114, 19);
            this.tslblDateTimeShow.Text = "DateTimeShow";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.toolStripStatusLabel1.Margin = new System.Windows.Forms.Padding(50, 3, 0, 2);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(79, 19);
            this.toolStripStatusLabel1.Text = "版本號 2.0";
            // 
            // tmrNowDateTime
            // 
            this.tmrNowDateTime.Tick += new System.EventHandler(this.tmrNowDateTime_Tick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Magical Management System Rev 2.1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系統ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 結束程式ToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tslblLoginUser;
        public System.Windows.Forms.ToolStripStatusLabel tslblUserName;
        private System.Windows.Forms.ToolStripStatusLabel tslblNowDateTime;
        private System.Windows.Forms.ToolStripStatusLabel tslblDateTimeShow;
        private System.Windows.Forms.Timer tmrNowDateTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem 查詢ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 派工單退租戶查詢ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用戶資料查詢ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 續約戶查詢ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 未續約查詢ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 退租戶查詢ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 復機戶查詢ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 用戶抽獎ToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem 派工ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 快到期用戶查詢ToolStripMenuItem;
    }
}

