namespace Magical_Management_System
{
    partial class Task
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Task));
            this.dgvShowData = new System.Windows.Forms.DataGridView();
            this.tmrTimeReciprocal = new System.Windows.Forms.Timer(this.components);
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lblFinishDateShow = new System.Windows.Forms.Label();
            this.lblOddNumShow = new System.Windows.Forms.Label();
            this.lblSerNameShow = new System.Windows.Forms.Label();
            this.lblEngNameShow = new System.Windows.Forms.Label();
            this.lblEngName = new System.Windows.Forms.Label();
            this.lblOddNum = new System.Windows.Forms.Label();
            this.lblSerName = new System.Windows.Forms.Label();
            this.lblFinishDate = new System.Windows.Forms.Label();
            this.grpShowMessage = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).BeginInit();
            this.grpShowMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvShowData
            // 
            this.dgvShowData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowData.Location = new System.Drawing.Point(12, 185);
            this.dgvShowData.Name = "dgvShowData";
            this.dgvShowData.RowTemplate.Height = 24;
            this.dgvShowData.Size = new System.Drawing.Size(760, 365);
            this.dgvShowData.TabIndex = 0;
            this.dgvShowData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowData_CellContentClick);
            // 
            // tmrTimeReciprocal
            // 
            this.tmrTimeReciprocal.Interval = 1000;
            this.tmrTimeReciprocal.Tick += new System.EventHandler(this.tmrDataShow_Tick);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.monthCalendar1.Location = new System.Drawing.Point(552, 2);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // lblFinishDateShow
            // 
            this.lblFinishDateShow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFinishDateShow.AutoSize = true;
            this.lblFinishDateShow.Location = new System.Drawing.Point(350, 15);
            this.lblFinishDateShow.Name = "lblFinishDateShow";
            this.lblFinishDateShow.Size = new System.Drawing.Size(51, 19);
            this.lblFinishDateShow.TabIndex = 7;
            this.lblFinishDateShow.Text = "label1";
            // 
            // lblOddNumShow
            // 
            this.lblOddNumShow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblOddNumShow.AutoSize = true;
            this.lblOddNumShow.Location = new System.Drawing.Point(170, 15);
            this.lblOddNumShow.Name = "lblOddNumShow";
            this.lblOddNumShow.Size = new System.Drawing.Size(51, 19);
            this.lblOddNumShow.TabIndex = 5;
            this.lblOddNumShow.Text = "label1";
            // 
            // lblSerNameShow
            // 
            this.lblSerNameShow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSerNameShow.AutoSize = true;
            this.lblSerNameShow.Location = new System.Drawing.Point(350, 47);
            this.lblSerNameShow.Name = "lblSerNameShow";
            this.lblSerNameShow.Size = new System.Drawing.Size(51, 19);
            this.lblSerNameShow.TabIndex = 3;
            this.lblSerNameShow.Text = "label1";
            // 
            // lblEngNameShow
            // 
            this.lblEngNameShow.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEngNameShow.AutoSize = true;
            this.lblEngNameShow.Location = new System.Drawing.Point(170, 46);
            this.lblEngNameShow.Name = "lblEngNameShow";
            this.lblEngNameShow.Size = new System.Drawing.Size(51, 19);
            this.lblEngNameShow.TabIndex = 1;
            this.lblEngNameShow.Text = "label1";
            // 
            // lblEngName
            // 
            this.lblEngName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblEngName.AutoSize = true;
            this.lblEngName.Location = new System.Drawing.Point(97, 46);
            this.lblEngName.Name = "lblEngName";
            this.lblEngName.Size = new System.Drawing.Size(84, 19);
            this.lblEngName.TabIndex = 0;
            this.lblEngName.Text = "工程人員：";
            // 
            // lblOddNum
            // 
            this.lblOddNum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblOddNum.AutoSize = true;
            this.lblOddNum.Location = new System.Drawing.Point(97, 15);
            this.lblOddNum.Name = "lblOddNum";
            this.lblOddNum.Size = new System.Drawing.Size(84, 19);
            this.lblOddNum.TabIndex = 4;
            this.lblOddNum.Text = "單據號碼：";
            // 
            // lblSerName
            // 
            this.lblSerName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSerName.AutoSize = true;
            this.lblSerName.Location = new System.Drawing.Point(275, 46);
            this.lblSerName.Name = "lblSerName";
            this.lblSerName.Size = new System.Drawing.Size(84, 19);
            this.lblSerName.TabIndex = 2;
            this.lblSerName.Text = "客服人員：";
            // 
            // lblFinishDate
            // 
            this.lblFinishDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFinishDate.AutoSize = true;
            this.lblFinishDate.Location = new System.Drawing.Point(275, 15);
            this.lblFinishDate.Name = "lblFinishDate";
            this.lblFinishDate.Size = new System.Drawing.Size(84, 19);
            this.lblFinishDate.TabIndex = 6;
            this.lblFinishDate.Text = "結案日期：";
            // 
            // grpShowMessage
            // 
            this.grpShowMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpShowMessage.Controls.Add(this.lblFinishDateShow);
            this.grpShowMessage.Controls.Add(this.lblOddNumShow);
            this.grpShowMessage.Controls.Add(this.lblSerNameShow);
            this.grpShowMessage.Controls.Add(this.lblEngNameShow);
            this.grpShowMessage.Controls.Add(this.lblEngName);
            this.grpShowMessage.Controls.Add(this.lblOddNum);
            this.grpShowMessage.Controls.Add(this.lblSerName);
            this.grpShowMessage.Controls.Add(this.lblFinishDate);
            this.grpShowMessage.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.grpShowMessage.Location = new System.Drawing.Point(12, 99);
            this.grpShowMessage.Name = "grpShowMessage";
            this.grpShowMessage.Size = new System.Drawing.Size(498, 80);
            this.grpShowMessage.TabIndex = 20;
            this.grpShowMessage.TabStop = false;
            this.grpShowMessage.Text = "相關訊息";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(516, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "label1";
            // 
            // btnNew
            // 
            this.btnNew.Enabled = false;
            this.btnNew.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNew.Location = new System.Drawing.Point(430, 12);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(80, 33);
            this.btnNew.TabIndex = 22;
            this.btnNew.Text = "派工";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // Task
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpShowMessage);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.dgvShowData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Task";
            this.Text = "派工作業";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).EndInit();
            this.grpShowMessage.ResumeLayout(false);
            this.grpShowMessage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowData;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lblFinishDateShow;
        private System.Windows.Forms.Label lblOddNumShow;
        private System.Windows.Forms.Label lblSerNameShow;
        private System.Windows.Forms.Label lblEngNameShow;
        private System.Windows.Forms.Label lblEngName;
        private System.Windows.Forms.Label lblOddNum;
        private System.Windows.Forms.Label lblSerName;
        private System.Windows.Forms.Label lblFinishDate;
        private System.Windows.Forms.GroupBox grpShowMessage;
        public System.Windows.Forms.Timer tmrTimeReciprocal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
    }
}