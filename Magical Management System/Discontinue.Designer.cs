namespace Magical_Management_System
{
    partial class Discontinue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Discontinue));
            this.btnToExcel = new System.Windows.Forms.Button();
            this.lblDataListNum = new System.Windows.Forms.Label();
            this.lblSelectData = new System.Windows.Forms.Label();
            this.btnInquiry = new System.Windows.Forms.Button();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dgvShowData = new System.Windows.Forms.DataGridView();
            this.chkSales = new System.Windows.Forms.CheckBox();
            this.rdoNoStopDate = new System.Windows.Forms.RadioButton();
            this.rdoKinkNoStop = new System.Windows.Forms.RadioButton();
            this.cboSales = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.chkDataToSales = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).BeginInit();
            this.SuspendLayout();
            // 
            // btnToExcel
            // 
            this.btnToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToExcel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnToExcel.Location = new System.Drawing.Point(591, 90);
            this.btnToExcel.Name = "btnToExcel";
            this.btnToExcel.Size = new System.Drawing.Size(100, 33);
            this.btnToExcel.TabIndex = 55;
            this.btnToExcel.Text = "滙出至Excel";
            this.btnToExcel.UseVisualStyleBackColor = true;
            this.btnToExcel.Click += new System.EventHandler(this.btnToExcel_Click_1);
            // 
            // lblDataListNum
            // 
            this.lblDataListNum.AutoSize = true;
            this.lblDataListNum.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDataListNum.Location = new System.Drawing.Point(128, 118);
            this.lblDataListNum.Name = "lblDataListNum";
            this.lblDataListNum.Size = new System.Drawing.Size(51, 19);
            this.lblDataListNum.TabIndex = 54;
            this.lblDataListNum.Text = "label1";
            // 
            // lblSelectData
            // 
            this.lblSelectData.AutoSize = true;
            this.lblSelectData.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSelectData.Location = new System.Drawing.Point(8, 118);
            this.lblSelectData.Name = "lblSelectData";
            this.lblSelectData.Size = new System.Drawing.Size(129, 19);
            this.lblSelectData.TabIndex = 53;
            this.lblSelectData.Text = "符合條件的筆數：";
            // 
            // btnInquiry
            // 
            this.btnInquiry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInquiry.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInquiry.Location = new System.Drawing.Point(697, 90);
            this.btnInquiry.Name = "btnInquiry";
            this.btnInquiry.Size = new System.Drawing.Size(75, 33);
            this.btnInquiry.TabIndex = 52;
            this.btnInquiry.Text = "查詢";
            this.btnInquiry.UseVisualStyleBackColor = true;
            this.btnInquiry.Click += new System.EventHandler(this.btnInquiry_Click);
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSelectDate.Location = new System.Drawing.Point(474, 34);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(84, 19);
            this.lblSelectDate.TabIndex = 51;
            this.lblSelectDate.Text = "日期區間：";
            // 
            // lblEndDate
            // 
            this.lblEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEndDate.Location = new System.Drawing.Point(553, 53);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(54, 19);
            this.lblEndDate.TabIndex = 50;
            this.lblEndDate.Text = "結束日";
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStartDate.Location = new System.Drawing.Point(553, 22);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(54, 19);
            this.lblStartDate.TabIndex = 49;
            this.lblStartDate.Text = "起始日";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEnd.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpEnd.Location = new System.Drawing.Point(612, 47);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(160, 27);
            this.dtpEnd.TabIndex = 48;
            this.dtpEnd.Value = new System.DateTime(2015, 6, 19, 0, 0, 0, 0);
            // 
            // dtpStart
            // 
            this.dtpStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStart.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpStart.Location = new System.Drawing.Point(612, 16);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(160, 27);
            this.dtpStart.TabIndex = 47;
            this.dtpStart.Value = new System.DateTime(2015, 6, 19, 0, 0, 0, 0);
            // 
            // dgvShowData
            // 
            this.dgvShowData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvShowData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowData.Location = new System.Drawing.Point(12, 140);
            this.dgvShowData.Name = "dgvShowData";
            this.dgvShowData.RowTemplate.Height = 24;
            this.dgvShowData.Size = new System.Drawing.Size(760, 450);
            this.dgvShowData.TabIndex = 56;
            // 
            // chkSales
            // 
            this.chkSales.AutoSize = true;
            this.chkSales.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkSales.Location = new System.Drawing.Point(247, 7);
            this.chkSales.Name = "chkSales";
            this.chkSales.Size = new System.Drawing.Size(103, 23);
            this.chkSales.TabIndex = 59;
            this.chkSales.Text = "以業務查詢";
            this.chkSales.UseVisualStyleBackColor = true;
            this.chkSales.CheckedChanged += new System.EventHandler(this.chkSales_CheckedChanged);
            // 
            // rdoNoStopDate
            // 
            this.rdoNoStopDate.AutoSize = true;
            this.rdoNoStopDate.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdoNoStopDate.Location = new System.Drawing.Point(247, 90);
            this.rdoNoStopDate.Name = "rdoNoStopDate";
            this.rdoNoStopDate.Size = new System.Drawing.Size(102, 23);
            this.rdoNoStopDate.TabIndex = 60;
            this.rdoNoStopDate.TabStop = true;
            this.rdoNoStopDate.Text = "未押退租日";
            this.rdoNoStopDate.UseVisualStyleBackColor = true;
            // 
            // rdoKinkNoStop
            // 
            this.rdoKinkNoStop.AutoSize = true;
            this.rdoKinkNoStop.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdoKinkNoStop.Location = new System.Drawing.Point(247, 64);
            this.rdoKinkNoStop.Name = "rdoKinkNoStop";
            this.rdoKinkNoStop.Size = new System.Drawing.Size(222, 23);
            this.rdoKinkNoStop.TabIndex = 61;
            this.rdoKinkNoStop.TabStop = true;
            this.rdoKinkNoStop.Text = "符合到期日，但尚未押已斷線";
            this.rdoKinkNoStop.UseVisualStyleBackColor = true;
            // 
            // cboSales
            // 
            this.cboSales.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboSales.FormattingEnabled = true;
            this.cboSales.Location = new System.Drawing.Point(247, 31);
            this.cboSales.Name = "cboSales";
            this.cboSales.Size = new System.Drawing.Size(121, 27);
            this.cboSales.TabIndex = 62;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClear.Location = new System.Drawing.Point(389, 90);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 33);
            this.btnClear.TabIndex = 63;
            this.btnClear.Text = "清除選項";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // chkDataToSales
            // 
            this.chkDataToSales.AutoSize = true;
            this.chkDataToSales.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkDataToSales.Location = new System.Drawing.Point(347, 7);
            this.chkDataToSales.Name = "chkDataToSales";
            this.chkDataToSales.Size = new System.Drawing.Size(103, 23);
            this.chkDataToSales.TabIndex = 64;
            this.chkDataToSales.Text = "業務用報表";
            this.chkDataToSales.UseVisualStyleBackColor = true;
            // 
            // Discontinue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 602);
            this.Controls.Add(this.chkDataToSales);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.cboSales);
            this.Controls.Add(this.rdoKinkNoStop);
            this.Controls.Add(this.rdoNoStopDate);
            this.Controls.Add(this.chkSales);
            this.Controls.Add(this.dgvShowData);
            this.Controls.Add(this.btnToExcel);
            this.Controls.Add(this.lblDataListNum);
            this.Controls.Add(this.lblSelectData);
            this.Controls.Add(this.btnInquiry);
            this.Controls.Add(this.lblSelectDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Discontinue";
            this.Text = "退租戶查詢";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToExcel;
        private System.Windows.Forms.Label lblDataListNum;
        private System.Windows.Forms.Label lblSelectData;
        private System.Windows.Forms.Button btnInquiry;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DataGridView dgvShowData;
        private System.Windows.Forms.CheckBox chkSales;
        private System.Windows.Forms.RadioButton rdoNoStopDate;
        private System.Windows.Forms.RadioButton rdoKinkNoStop;
        private System.Windows.Forms.ComboBox cboSales;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.CheckBox chkDataToSales;
    }
}