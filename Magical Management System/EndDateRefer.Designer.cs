namespace Magical_Management_System
{
    partial class EndDateRefer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndDateRefer));
            this.lblDays = new System.Windows.Forms.Label();
            this.cboDays = new System.Windows.Forms.ComboBox();
            this.dgvDataShow = new System.Windows.Forms.DataGridView();
            this.lblDataCount = new System.Windows.Forms.Label();
            this.lblDataCountResult = new System.Windows.Forms.Label();
            this.btnToExcel = new System.Windows.Forms.Button();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.rdoDays = new System.Windows.Forms.RadioButton();
            this.rdoDateInterval = new System.Windows.Forms.RadioButton();
            this.lblDateInterval = new System.Windows.Forms.Label();
            this.btnRefer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataShow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDays.Location = new System.Drawing.Point(23, 60);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(114, 19);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "要查詢的天數：";
            // 
            // cboDays
            // 
            this.cboDays.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboDays.FormattingEnabled = true;
            this.cboDays.Items.AddRange(new object[] {
            "5",
            "7",
            "10",
            "15",
            "20"});
            this.cboDays.Location = new System.Drawing.Point(129, 57);
            this.cboDays.Name = "cboDays";
            this.cboDays.Size = new System.Drawing.Size(60, 27);
            this.cboDays.TabIndex = 1;
            this.cboDays.SelectedIndexChanged += new System.EventHandler(this.cboDays_SelectedIndexChanged);
            // 
            // dgvDataShow
            // 
            this.dgvDataShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataShow.Location = new System.Drawing.Point(12, 149);
            this.dgvDataShow.Name = "dgvDataShow";
            this.dgvDataShow.RowTemplate.Height = 24;
            this.dgvDataShow.Size = new System.Drawing.Size(760, 400);
            this.dgvDataShow.TabIndex = 2;
            // 
            // lblDataCount
            // 
            this.lblDataCount.AutoSize = true;
            this.lblDataCount.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDataCount.Location = new System.Drawing.Point(12, 127);
            this.lblDataCount.Name = "lblDataCount";
            this.lblDataCount.Size = new System.Drawing.Size(129, 19);
            this.lblDataCount.TabIndex = 3;
            this.lblDataCount.Text = "符合天數的筆數：";
            // 
            // lblDataCountResult
            // 
            this.lblDataCountResult.AutoSize = true;
            this.lblDataCountResult.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDataCountResult.Location = new System.Drawing.Point(136, 127);
            this.lblDataCountResult.Name = "lblDataCountResult";
            this.lblDataCountResult.Size = new System.Drawing.Size(52, 19);
            this.lblDataCountResult.TabIndex = 4;
            this.lblDataCountResult.Text = "Result";
            // 
            // btnToExcel
            // 
            this.btnToExcel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnToExcel.Location = new System.Drawing.Point(365, 113);
            this.btnToExcel.Name = "btnToExcel";
            this.btnToExcel.Size = new System.Drawing.Size(90, 30);
            this.btnToExcel.TabIndex = 5;
            this.btnToExcel.Text = "滙出Excel";
            this.btnToExcel.UseVisualStyleBackColor = true;
            this.btnToExcel.Click += new System.EventHandler(this.btnToExcel_Click);
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CalendarFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpStartDate.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStartDate.Location = new System.Drawing.Point(365, 41);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(120, 27);
            this.dtpStartDate.TabIndex = 6;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.CalendarFont = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpEndDate.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEndDate.Location = new System.Drawing.Point(365, 74);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(120, 27);
            this.dtpEndDate.TabIndex = 7;
            // 
            // rdoDays
            // 
            this.rdoDays.AutoSize = true;
            this.rdoDays.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdoDays.Location = new System.Drawing.Point(27, 12);
            this.rdoDays.Name = "rdoDays";
            this.rdoDays.Size = new System.Drawing.Size(102, 23);
            this.rdoDays.TabIndex = 0;
            this.rdoDays.TabStop = true;
            this.rdoDays.Text = "以天數查詢";
            this.rdoDays.UseVisualStyleBackColor = true;
            this.rdoDays.CheckedChanged += new System.EventHandler(this.rdoDays_CheckedChanged);
            // 
            // rdoDateInterval
            // 
            this.rdoDateInterval.AutoSize = true;
            this.rdoDateInterval.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdoDateInterval.Location = new System.Drawing.Point(135, 12);
            this.rdoDateInterval.Name = "rdoDateInterval";
            this.rdoDateInterval.Size = new System.Drawing.Size(132, 23);
            this.rdoDateInterval.TabIndex = 9;
            this.rdoDateInterval.TabStop = true;
            this.rdoDateInterval.Text = "以日期區間查詢";
            this.rdoDateInterval.UseVisualStyleBackColor = true;
            this.rdoDateInterval.CheckedChanged += new System.EventHandler(this.rdoDateInterval_CheckedChanged);
            // 
            // lblDateInterval
            // 
            this.lblDateInterval.AutoSize = true;
            this.lblDateInterval.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDateInterval.Location = new System.Drawing.Point(225, 60);
            this.lblDateInterval.Name = "lblDateInterval";
            this.lblDateInterval.Size = new System.Drawing.Size(144, 19);
            this.lblDateInterval.TabIndex = 10;
            this.lblDateInterval.Text = "要查詢的日期區間：";
            // 
            // btnRefer
            // 
            this.btnRefer.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRefer.Location = new System.Drawing.Point(229, 113);
            this.btnRefer.Name = "btnRefer";
            this.btnRefer.Size = new System.Drawing.Size(90, 30);
            this.btnRefer.TabIndex = 11;
            this.btnRefer.Text = "查詢";
            this.btnRefer.UseVisualStyleBackColor = true;
            this.btnRefer.Click += new System.EventHandler(this.btnRefer_Click);
            // 
            // EndDateRefer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnRefer);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lblDateInterval);
            this.Controls.Add(this.rdoDateInterval);
            this.Controls.Add(this.rdoDays);
            this.Controls.Add(this.btnToExcel);
            this.Controls.Add(this.lblDataCountResult);
            this.Controls.Add(this.lblDataCount);
            this.Controls.Add(this.dgvDataShow);
            this.Controls.Add(this.cboDays);
            this.Controls.Add(this.lblDays);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EndDateRefer";
            this.Text = "快到期用戶查詢";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.ComboBox cboDays;
        private System.Windows.Forms.DataGridView dgvDataShow;
        private System.Windows.Forms.Label lblDataCount;
        private System.Windows.Forms.Label lblDataCountResult;
        private System.Windows.Forms.Button btnToExcel;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.RadioButton rdoDays;
        private System.Windows.Forms.RadioButton rdoDateInterval;
        private System.Windows.Forms.Label lblDateInterval;
        private System.Windows.Forms.Button btnRefer;
    }
}