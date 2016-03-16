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
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataShow)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDays.Location = new System.Drawing.Point(12, 23);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(144, 19);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "要查詢的剩餘天數：";
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
            this.cboDays.Location = new System.Drawing.Point(151, 20);
            this.cboDays.Name = "cboDays";
            this.cboDays.Size = new System.Drawing.Size(60, 27);
            this.cboDays.TabIndex = 1;
            this.cboDays.SelectedIndexChanged += new System.EventHandler(this.cboDays_SelectedIndexChanged);
            // 
            // dgvDataShow
            // 
            this.dgvDataShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataShow.Location = new System.Drawing.Point(12, 90);
            this.dgvDataShow.Name = "dgvDataShow";
            this.dgvDataShow.RowTemplate.Height = 24;
            this.dgvDataShow.Size = new System.Drawing.Size(760, 459);
            this.dgvDataShow.TabIndex = 2;
            // 
            // lblDataCount
            // 
            this.lblDataCount.AutoSize = true;
            this.lblDataCount.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDataCount.Location = new System.Drawing.Point(12, 68);
            this.lblDataCount.Name = "lblDataCount";
            this.lblDataCount.Size = new System.Drawing.Size(129, 19);
            this.lblDataCount.TabIndex = 3;
            this.lblDataCount.Text = "符合天數的筆數：";
            // 
            // lblDataCountResult
            // 
            this.lblDataCountResult.AutoSize = true;
            this.lblDataCountResult.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDataCountResult.Location = new System.Drawing.Point(136, 68);
            this.lblDataCountResult.Name = "lblDataCountResult";
            this.lblDataCountResult.Size = new System.Drawing.Size(52, 19);
            this.lblDataCountResult.TabIndex = 4;
            this.lblDataCountResult.Text = "Result";
            // 
            // btnToExcel
            // 
            this.btnToExcel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnToExcel.Location = new System.Drawing.Point(253, 54);
            this.btnToExcel.Name = "btnToExcel";
            this.btnToExcel.Size = new System.Drawing.Size(90, 30);
            this.btnToExcel.TabIndex = 5;
            this.btnToExcel.Text = "滙出Excel";
            this.btnToExcel.UseVisualStyleBackColor = true;
            this.btnToExcel.Click += new System.EventHandler(this.btnToExcel_Click);
            // 
            // EndDateRefer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
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
    }
}