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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection cmsConn = new SqlConnection("server=TCP:192.168.1.3;database=CMS;uid=sa;pwd=Magical9070");
            cmsConn.Open();
            SqlCommand cmsSqlComm = new SqlCommand();
            cmsSqlComm.CommandText = "select * from memb where meno='" + txtUserName.Text + "'";
            cmsSqlComm.Connection = cmsConn;
            SqlDataReader meno = cmsSqlComm.ExecuteReader();
            if (meno.HasRows)
            {
                meno.Close();
                cmsSqlComm.CommandText = "select * from memb where meno='"+txtUserName.Text+"' and p='" + txtPassword.Text + "'";
                SqlDataReader p = cmsSqlComm.ExecuteReader();
                if (p.HasRows)
                {
                    p.Read();
                    //判斷登入用戶是否有被壓上離職日期
                    if (p["quidate"].ToString() != "")
                    {
                        MessageBox.Show("您已無登入權限！" + Environment.NewLine + "若有疑問，請洽人事。", "注意", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        p.Close();
                        cmsConn.Close();
                        txtUserName.Text = "";
                        txtPassword.Text = "";
                        return;
                    }
                    else
                    {
                        this.Hide();
                        MainMenu MM = new MainMenu();
                        MM.tslblUserName.Text = p["name"].ToString();
                        p.Close();
                        string SqlComm = "select dpna from memb where name='" + MM.tslblUserName.Text + "'";
                        SqlCommand CommGo = new SqlCommand(SqlComm, cmsConn);
                        SqlDataAdapter ReadAcc = new SqlDataAdapter(CommGo);
                        DataTable DataTable = new DataTable();
                        ReadAcc.Fill(DataTable);
                        string dpna =Convert.ToString(DataTable.Rows[0][0].ToString());
                        string A = "200";
                        string B = "400";
                        if (dpna == A)
                        {
                            MM.派工ToolStripMenuItem.Enabled = true;
                            MM.續約戶查詢ToolStripMenuItem.Enabled = true;
                            MM.未續約查詢ToolStripMenuItem.Enabled = true;
                            MM.復機戶查詢ToolStripMenuItem.Enabled = true;
                            MM.退租戶查詢ToolStripMenuItem.Enabled = true;
                            MM.用戶抽獎ToolStripMenuItem.Enabled = true;
                        }
                        else if(dpna==B)
                        {
                            MM.派工ToolStripMenuItem.Enabled = true;
                            MM.續約戶查詢ToolStripMenuItem.Enabled = true;
                            MM.未續約查詢ToolStripMenuItem.Enabled = true;
                            MM.復機戶查詢ToolStripMenuItem.Enabled = true;
                            MM.退租戶查詢ToolStripMenuItem.Enabled = true;
                            MM.用戶抽獎ToolStripMenuItem.Enabled = false;
                        }
                        else
                        {
                            MM.派工ToolStripMenuItem.Enabled = false;
                            MM.續約戶查詢ToolStripMenuItem.Enabled = false;
                            MM.未續約查詢ToolStripMenuItem.Enabled = false;
                            MM.復機戶查詢ToolStripMenuItem.Enabled = false;
                            MM.退租戶查詢ToolStripMenuItem.Enabled = false;
                            MM.用戶抽獎ToolStripMenuItem.Enabled = false;
                        }
                        cmsConn.Close();
                        if (MM.ShowDialog() == DialogResult.Cancel)
                        {
                            Application.Exit();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("密碼不正確！" + Environment.NewLine + "請確認.....", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    txtPassword.Text = "";
                    cmsConn.Close();
                }
            }
            else
            {
                MessageBox.Show("查無此帳號！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUserName.Text = "";
                cmsConn.Close();
            }
        }
    }
}
