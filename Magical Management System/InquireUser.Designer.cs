namespace Magical_Management_System
{
    partial class InquireUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InquireUser));
            this.lblUserNum = new System.Windows.Forms.Label();
            this.lblUserNumShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserNum
            // 
            this.lblUserNum.AutoSize = true;
            this.lblUserNum.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUserNum.Location = new System.Drawing.Point(12, 9);
            this.lblUserNum.Name = "lblUserNum";
            this.lblUserNum.Size = new System.Drawing.Size(54, 19);
            this.lblUserNum.TabIndex = 0;
            this.lblUserNum.Text = "編號：";
            // 
            // lblUserNumShow
            // 
            this.lblUserNumShow.AutoSize = true;
            this.lblUserNumShow.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUserNumShow.Location = new System.Drawing.Point(56, 9);
            this.lblUserNumShow.Name = "lblUserNumShow";
            this.lblUserNumShow.Size = new System.Drawing.Size(132, 19);
            this.lblUserNumShow.TabIndex = 1;
            this.lblUserNumShow.Text = "lblUserNumShow";
            // 
            // InquireUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.lblUserNumShow);
            this.Controls.Add(this.lblUserNum);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InquireUser";
            this.Text = "InquireUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserNum;
        private System.Windows.Forms.Label lblUserNumShow;
    }
}