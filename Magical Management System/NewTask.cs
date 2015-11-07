using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Magical_Management_System
{
    public partial class NewTask : Form
    {
        SqlConnection cmsConn = new SqlConnection("server=TCP:192.168.1.3;database=CMS;uid=sa;pwd=Magical9070");
        string SqlComm = "";
        public NewTask()
        {
            InitializeComponent();
            txtGno.Enabled = false;
            txtProbrem.Enabled = false;
            dtpGotimeDate.Value = DateTime.Today;
            dtpGotimeTime.Value = DateTime.Now;
            dtpGotimeDate.Enabled = false;
            dtpGotimeTime.Enabled = false;
            cboMeno2.Enabled = false;
            btnSend.Enabled = false;
            rdoDemolition.Enabled = false;
            rdoDetect.Enabled = false;
            rdoRestore.Enabled = false;
        }

        private void txtNum_keyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            cmsConn.Open();
            string ano = txtUserNum.Text.Substring(0, 2);
            string cno = txtUserNum.Text.Substring(2, 3);
            string cust = txtUserNum.Text.Substring(5);
            SqlComm = "select comm.cname, custom.name, custom.tel, custom.ext, custom.cell, custom.address from comm,custom "+
                "where comm.ano=custom.ano and comm.cno=custom.cno and custom.ano='" + ano + "' and custom.cno='" + cno +
                "' and custom.cust='" + cust + "'";
            SqlDataAdapter Read = new SqlDataAdapter(SqlComm, cmsConn);
            DataTable table = new DataTable();
            Read.Fill(table);
            if (table.Rows.Count == 0)
            {
                MessageBox.Show("查無該筆客編！" + Environment.NewLine + "請重新輸入！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cmsConn.Close();
            }
            else
            {
                btnSend.Enabled = true;
                btnConfirm.Enabled = false;
                txtGno.Enabled = true;
                txtProbrem.Enabled = true;
                dtpGotimeDate.Enabled = true;
                dtpGotimeTime.Enabled = true;
                cboMeno2.Enabled = true;
                btnConfirm.Enabled = false;
                rdoDemolition.Enabled = true;
                rdoDetect.Enabled = true;
                rdoRestore.Enabled = true;
                txtCommunity.Text = table.Rows[0]["cname"].ToString().Trim();
                txtName.Text = table.Rows[0]["name"].ToString().Trim();
                txtTel.Text = table.Rows[0]["tel"].ToString();
                txtExt.Text = table.Rows[0]["ext"].ToString();
                txtCell.Text = table.Rows[0]["cell"].ToString();
                txtAddress.Text = table.Rows[0]["address"].ToString();
                cmsConn.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtCommunity.Text = "";
            txtName.Text = "";
            txtTel.Text = "";
            txtExt.Text = "";
            txtCell.Text = "";
            txtGno.Text = "";
            txtAddress.Text = "";
            txtProbrem.Text = "";
            txtGno.Enabled = false;
            txtProbrem.Enabled = false;
            btnSend.Enabled = false;
            btnConfirm.Enabled = true;
            dtpGotimeDate.Enabled = false;
            dtpGotimeTime.Enabled = false;
            rdoDemolition.Enabled = false;
            rdoDetect.Enabled = false;
            rdoRestore.Enabled = false;
            rdoDemolition.Checked = false;
            rdoDetect.Checked = false;
            rdoRestore.Checked = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if(rdoDetect.Checked==false & rdoDemolition.Checked==false & rdoRestore.Checked==false)
            {
                MessageBox.Show("未選擇工單別！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if(rdoDetect.Checked==true)
            {
                
            }
        }
    }
}
