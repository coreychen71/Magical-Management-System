namespace Magical_Management_System
{
    partial class Replenish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Replenish));
            this.dgvShowData = new System.Windows.Forms.DataGridView();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.btnInquiry = new System.Windows.Forms.Button();
            this.lblDataListNum = new System.Windows.Forms.Label();
            this.lblSelectData = new System.Windows.Forms.Label();
            this.btnToExcel = new System.Windows.Forms.Button();
            this.chkPauseUser = new System.Windows.Forms.CheckBox();
            this.chkStopUser = new System.Windows.Forms.CheckBox();
            this.lblTotalPriceShow = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).BeginInit();
            this.SuspendLayout();
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
            this.dgvShowData.TabIndex = 0;
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSelectDate.Location = new System.Drawing.Point(474, 29);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(84, 19);
            this.lblSelectDate.TabIndex = 13;
            this.lblSelectDate.Text = "日期區間：";
            // 
            // lblEndDate
            // 
            this.lblEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblEndDate.Location = new System.Drawing.Point(553, 48);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(54, 19);
            this.lblEndDate.TabIndex = 12;
            this.lblEndDate.Text = "結束日";
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStartDate.Location = new System.Drawing.Point(553, 17);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(54, 19);
            this.lblStartDate.TabIndex = 11;
            this.lblStartDate.Text = "起始日";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpEnd.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpEnd.Location = new System.Drawing.Point(612, 42);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(160, 27);
            this.dtpEnd.TabIndex = 10;
            this.dtpEnd.Value = new System.DateTime(2015, 6, 19, 0, 0, 0, 0);
            // 
            // dtpStart
            // 
            this.dtpStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpStart.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpStart.Location = new System.Drawing.Point(612, 11);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(160, 27);
            this.dtpStart.TabIndex = 9;
            this.dtpStart.Value = new System.DateTime(2015, 6, 19, 0, 0, 0, 0);
            // 
            // btnInquiry
            // 
            this.btnInquiry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInquiry.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInquiry.Location = new System.Drawing.Point(697, 85);
            this.btnInquiry.Name = "btnInquiry";
            this.btnInquiry.Size = new System.Drawing.Size(75, 33);
            this.btnInquiry.TabIndex = 14;
            this.btnInquiry.Text = "查詢";
            this.btnInquiry.UseVisualStyleBackColor = true;
            this.btnInquiry.Click += new System.EventHandler(this.btnInquiry_Click);
            // 
            // lblDataListNum
            // 
            this.lblDataListNum.AutoSize = true;
            this.lblDataListNum.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDataListNum.Location = new System.Drawing.Point(132, 118);
            this.lblDataListNum.Name = "lblDataListNum";
            this.lblDataListNum.Size = new System.Drawing.Size(51, 19);
            this.lblDataListNum.TabIndex = 19;
            this.lblDataListNum.Text = "label1";
            // 
            // lblSelectData
            // 
            this.lblSelectData.AutoSize = true;
            this.lblSelectData.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblSelectData.Location = new System.Drawing.Point(12, 118);
            this.lblSelectData.Name = "lblSelectData";
            this.lblSelectData.Size = new System.Drawing.Size(129, 19);
            this.lblSelectData.TabIndex = 18;
            this.lblSelectData.Text = "符合條件的筆數：";
            // 
            // btnToExcel
            // 
            this.btnToExcel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToExcel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnToExcel.Location = new System.Drawing.Point(591, 85);
            this.btnToExcel.Name = "btnToExcel";
            this.btnToExcel.Size = new System.Drawing.Size(100, 33);
            this.btnToExcel.TabIndex = 21;
            this.btnToExcel.Text = "滙出至Excel";
            this.btnToExcel.UseVisualStyleBackColor = true;
            this.btnToExcel.Click += new System.EventHandler(this.btnToExcel_Click_1);
            // 
            // chkPauseUser
            // 
            this.chkPauseUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkPauseUser.AutoSize = true;
            this.chkPauseUser.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkPauseUser.Location = new System.Drawing.Point(399, 91);
            this.chkPauseUser.Name = "chkPauseUser";
            this.chkPauseUser.Size = new System.Drawing.Size(73, 23);
            this.chkPauseUser.TabIndex = 22;
            this.chkPauseUser.Text = "暫停中";
            this.chkPauseUser.UseVisualStyleBackColor = true;
            // 
            // chkStopUser
            // 
            this.chkStopUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkStopUser.AutoSize = true;
            this.chkStopUser.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkStopUser.Location = new System.Drawing.Point(478, 91);
            this.chkStopUser.Name = "chkStopUser";
            this.chkStopUser.Size = new System.Drawing.Size(73, 23);
            this.chkStopUser.TabIndex = 23;
            this.chkStopUser.Text = "已退租";
            this.chkStopUser.UseVisualStyleBackColor = true;
            // 
            // lblTotalPriceShow
            // 
            this.lblTotalPriceShow.AutoSize = true;
            this.lblTotalPriceShow.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalPriceShow.Location = new System.Drawing.Point(78, 85);
            this.lblTotalPriceShow.Name = "lblTotalPriceShow";
            this.lblTotalPriceShow.Size = new System.Drawing.Size(51, 19);
            this.lblTotalPriceShow.TabIndex = 37;
            this.lblTotalPriceShow.Text = "label1";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTotalPrice.Location = new System.Drawing.Point(12, 85);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(69, 19);
            this.lblTotalPrice.TabIndex = 36;
            this.lblTotalPrice.Text = "總金額：";
            // 
            // Replenish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 602);
            this.Controls.Add(this.lblTotalPriceShow);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.chkStopUser);
            this.Controls.Add(this.chkPauseUser);
            this.Controls.Add(this.btnToExcel);
            this.Controls.Add(this.lblDataListNum);
            this.Controls.Add(this.lblSelectData);
            this.Controls.Add(this.btnInquiry);
            this.Controls.Add(this.lblSelectDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.dgvShowData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Replenish";
            this.Text = "續約查詢";
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowData;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Button btnInquiry;
        private System.Windows.Forms.Label lblDataListNum;
        private System.Windows.Forms.Label lblSelectData;
        private System.Windows.Forms.Button btnToExcel;
        private System.Windows.Forms.CheckBox chkPauseUser;
        private System.Windows.Forms.CheckBox chkStopUser;
        private System.Windows.Forms.Label lblTotalPriceShow;
        private System.Windows.Forms.Label lblTotalPrice;
    }
}