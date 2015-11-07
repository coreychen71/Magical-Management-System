namespace Magical_Management_System
{
    partial class NewTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTask));
            this.txtUserNum = new System.Windows.Forms.TextBox();
            this.lblCommunity = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.txtCommunity = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblCell = new System.Windows.Forms.Label();
            this.txtCell = new System.Windows.Forms.TextBox();
            this.txtExt = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblGotimeDate = new System.Windows.Forms.Label();
            this.dtpGotimeDate = new System.Windows.Forms.DateTimePicker();
            this.lblGotimeTime = new System.Windows.Forms.Label();
            this.dtpGotimeTime = new System.Windows.Forms.DateTimePicker();
            this.lblGno = new System.Windows.Forms.Label();
            this.txtGno = new System.Windows.Forms.TextBox();
            this.lblProbrem = new System.Windows.Forms.Label();
            this.txtProbrem = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblMeno2 = new System.Windows.Forms.Label();
            this.cboMeno2 = new System.Windows.Forms.ComboBox();
            this.rdoDetect = new System.Windows.Forms.RadioButton();
            this.rdoDemolition = new System.Windows.Forms.RadioButton();
            this.rdoRestore = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtUserNum
            // 
            this.txtUserNum.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtUserNum.Location = new System.Drawing.Point(372, 12);
            this.txtUserNum.MaxLength = 8;
            this.txtUserNum.Name = "txtUserNum";
            this.txtUserNum.Size = new System.Drawing.Size(100, 27);
            this.txtUserNum.TabIndex = 0;
            this.txtUserNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_keyPress);
            // 
            // lblCommunity
            // 
            this.lblCommunity.AutoSize = true;
            this.lblCommunity.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCommunity.Location = new System.Drawing.Point(12, 63);
            this.lblCommunity.Name = "lblCommunity";
            this.lblCommunity.Size = new System.Drawing.Size(89, 20);
            this.lblCommunity.TabIndex = 1;
            this.lblCommunity.Text = "社區名稱：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblName.Location = new System.Drawing.Point(47, 97);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(54, 19);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "姓名：";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConfirm.Location = new System.Drawing.Point(492, 8);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(80, 33);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "查詢";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMessage.Location = new System.Drawing.Point(295, 15);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(84, 19);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "客戶編號：";
            // 
            // txtCommunity
            // 
            this.txtCommunity.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCommunity.Location = new System.Drawing.Point(92, 61);
            this.txtCommunity.Name = "txtCommunity";
            this.txtCommunity.ReadOnly = true;
            this.txtCommunity.Size = new System.Drawing.Size(150, 27);
            this.txtCommunity.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(92, 94);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(120, 27);
            this.txtName.TabIndex = 8;
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTel.Location = new System.Drawing.Point(148, 127);
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(120, 27);
            this.txtTel.TabIndex = 9;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTel.Location = new System.Drawing.Point(47, 130);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(54, 19);
            this.lblTel.TabIndex = 10;
            this.lblTel.Text = "電話：";
            // 
            // lblCell
            // 
            this.lblCell.AutoSize = true;
            this.lblCell.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCell.Location = new System.Drawing.Point(47, 163);
            this.lblCell.Name = "lblCell";
            this.lblCell.Size = new System.Drawing.Size(54, 19);
            this.lblCell.TabIndex = 11;
            this.lblCell.Text = "手機：";
            // 
            // txtCell
            // 
            this.txtCell.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCell.Location = new System.Drawing.Point(92, 160);
            this.txtCell.Name = "txtCell";
            this.txtCell.ReadOnly = true;
            this.txtCell.Size = new System.Drawing.Size(120, 27);
            this.txtCell.TabIndex = 12;
            // 
            // txtExt
            // 
            this.txtExt.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtExt.Location = new System.Drawing.Point(92, 127);
            this.txtExt.Name = "txtExt";
            this.txtExt.ReadOnly = true;
            this.txtExt.Size = new System.Drawing.Size(50, 27);
            this.txtExt.TabIndex = 14;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAddress.Location = new System.Drawing.Point(47, 196);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(54, 19);
            this.lblAddress.TabIndex = 15;
            this.lblAddress.Text = "地址：";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtAddress.Location = new System.Drawing.Point(92, 193);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(350, 27);
            this.txtAddress.TabIndex = 16;
            // 
            // lblGotimeDate
            // 
            this.lblGotimeDate.AutoSize = true;
            this.lblGotimeDate.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblGotimeDate.Location = new System.Drawing.Point(295, 64);
            this.lblGotimeDate.Name = "lblGotimeDate";
            this.lblGotimeDate.Size = new System.Drawing.Size(84, 19);
            this.lblGotimeDate.TabIndex = 17;
            this.lblGotimeDate.Text = "派工日期：";
            // 
            // dtpGotimeDate
            // 
            this.dtpGotimeDate.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpGotimeDate.Location = new System.Drawing.Point(372, 58);
            this.dtpGotimeDate.Name = "dtpGotimeDate";
            this.dtpGotimeDate.Size = new System.Drawing.Size(200, 27);
            this.dtpGotimeDate.TabIndex = 18;
            // 
            // lblGotimeTime
            // 
            this.lblGotimeTime.AutoSize = true;
            this.lblGotimeTime.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblGotimeTime.Location = new System.Drawing.Point(295, 97);
            this.lblGotimeTime.Name = "lblGotimeTime";
            this.lblGotimeTime.Size = new System.Drawing.Size(84, 19);
            this.lblGotimeTime.TabIndex = 19;
            this.lblGotimeTime.Text = "派工時間：";
            // 
            // dtpGotimeTime
            // 
            this.dtpGotimeTime.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dtpGotimeTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpGotimeTime.Location = new System.Drawing.Point(372, 91);
            this.dtpGotimeTime.Name = "dtpGotimeTime";
            this.dtpGotimeTime.ShowUpDown = true;
            this.dtpGotimeTime.Size = new System.Drawing.Size(200, 27);
            this.dtpGotimeTime.TabIndex = 20;
            // 
            // lblGno
            // 
            this.lblGno.AutoSize = true;
            this.lblGno.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblGno.Location = new System.Drawing.Point(325, 157);
            this.lblGno.Name = "lblGno";
            this.lblGno.Size = new System.Drawing.Size(54, 19);
            this.lblGno.TabIndex = 21;
            this.lblGno.Text = "組別：";
            // 
            // txtGno
            // 
            this.txtGno.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtGno.Location = new System.Drawing.Point(372, 154);
            this.txtGno.MaxLength = 1;
            this.txtGno.Name = "txtGno";
            this.txtGno.Size = new System.Drawing.Size(40, 27);
            this.txtGno.TabIndex = 22;
            this.txtGno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNum_keyPress);
            // 
            // lblProbrem
            // 
            this.lblProbrem.AutoSize = true;
            this.lblProbrem.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblProbrem.Location = new System.Drawing.Point(17, 229);
            this.lblProbrem.Name = "lblProbrem";
            this.lblProbrem.Size = new System.Drawing.Size(84, 19);
            this.lblProbrem.TabIndex = 23;
            this.lblProbrem.Text = "報修事項：";
            // 
            // txtProbrem
            // 
            this.txtProbrem.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtProbrem.Location = new System.Drawing.Point(92, 226);
            this.txtProbrem.Multiline = true;
            this.txtProbrem.Name = "txtProbrem";
            this.txtProbrem.Size = new System.Drawing.Size(480, 150);
            this.txtProbrem.TabIndex = 24;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSend.Location = new System.Drawing.Point(406, 382);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(80, 33);
            this.btnSend.TabIndex = 25;
            this.btnSend.Text = "送出";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCancel.Location = new System.Drawing.Point(492, 382);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 33);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "放棄";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblMeno2
            // 
            this.lblMeno2.AutoSize = true;
            this.lblMeno2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblMeno2.Location = new System.Drawing.Point(295, 127);
            this.lblMeno2.Name = "lblMeno2";
            this.lblMeno2.Size = new System.Drawing.Size(84, 19);
            this.lblMeno2.TabIndex = 27;
            this.lblMeno2.Text = "工程人員：";
            // 
            // cboMeno2
            // 
            this.cboMeno2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cboMeno2.FormattingEnabled = true;
            this.cboMeno2.Location = new System.Drawing.Point(372, 124);
            this.cboMeno2.Name = "cboMeno2";
            this.cboMeno2.Size = new System.Drawing.Size(121, 27);
            this.cboMeno2.TabIndex = 28;
            // 
            // rdoDetect
            // 
            this.rdoDetect.AutoSize = true;
            this.rdoDetect.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdoDetect.Location = new System.Drawing.Point(85, 13);
            this.rdoDetect.Name = "rdoDetect";
            this.rdoDetect.Size = new System.Drawing.Size(57, 23);
            this.rdoDetect.TabIndex = 29;
            this.rdoDetect.TabStop = true;
            this.rdoDetect.Text = "檢測";
            this.rdoDetect.UseVisualStyleBackColor = true;
            // 
            // rdoDemolition
            // 
            this.rdoDemolition.AutoSize = true;
            this.rdoDemolition.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdoDemolition.Location = new System.Drawing.Point(148, 13);
            this.rdoDemolition.Name = "rdoDemolition";
            this.rdoDemolition.Size = new System.Drawing.Size(57, 23);
            this.rdoDemolition.TabIndex = 30;
            this.rdoDemolition.TabStop = true;
            this.rdoDemolition.Text = "拆機";
            this.rdoDemolition.UseVisualStyleBackColor = true;
            // 
            // rdoRestore
            // 
            this.rdoRestore.AutoSize = true;
            this.rdoRestore.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rdoRestore.Location = new System.Drawing.Point(211, 13);
            this.rdoRestore.Name = "rdoRestore";
            this.rdoRestore.Size = new System.Drawing.Size(57, 23);
            this.rdoRestore.TabIndex = 31;
            this.rdoRestore.TabStop = true;
            this.rdoRestore.Text = "復機";
            this.rdoRestore.UseVisualStyleBackColor = true;
            // 
            // NewTask
            // 
            this.AcceptButton = this.btnConfirm;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 422);
            this.Controls.Add(this.rdoRestore);
            this.Controls.Add(this.rdoDemolition);
            this.Controls.Add(this.rdoDetect);
            this.Controls.Add(this.cboMeno2);
            this.Controls.Add(this.lblMeno2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtProbrem);
            this.Controls.Add(this.lblProbrem);
            this.Controls.Add(this.txtGno);
            this.Controls.Add(this.lblGno);
            this.Controls.Add(this.dtpGotimeTime);
            this.Controls.Add(this.lblGotimeTime);
            this.Controls.Add(this.dtpGotimeDate);
            this.Controls.Add(this.lblGotimeDate);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtExt);
            this.Controls.Add(this.txtCell);
            this.Controls.Add(this.lblCell);
            this.Controls.Add(this.txtUserNum);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCommunity);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblCommunity);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewTask";
            this.Text = "NewTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserNum;
        private System.Windows.Forms.Label lblCommunity;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtCommunity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblCell;
        private System.Windows.Forms.TextBox txtCell;
        private System.Windows.Forms.TextBox txtExt;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblGotimeDate;
        private System.Windows.Forms.DateTimePicker dtpGotimeDate;
        private System.Windows.Forms.Label lblGotimeTime;
        private System.Windows.Forms.DateTimePicker dtpGotimeTime;
        private System.Windows.Forms.Label lblGno;
        private System.Windows.Forms.TextBox txtGno;
        private System.Windows.Forms.Label lblProbrem;
        private System.Windows.Forms.TextBox txtProbrem;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblMeno2;
        private System.Windows.Forms.ComboBox cboMeno2;
        private System.Windows.Forms.RadioButton rdoDetect;
        private System.Windows.Forms.RadioButton rdoDemolition;
        private System.Windows.Forms.RadioButton rdoRestore;
    }
}