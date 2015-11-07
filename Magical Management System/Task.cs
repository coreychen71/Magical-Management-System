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
    public partial class Task : Form
    {
        int sec = 60;
        public Task()
        {
            InitializeComponent();
            lblEngNameShow.Text = "";
            lblSerNameShow.Text = "";
            lblOddNumShow.Text = "";
            lblFinishDateShow.Text = "";
            tmrTimeReciprocal.Enabled = true;
            string NowDate = DateTime.Today.ToString("yyyy-MM-dd 00:00:00");
            string LastDate = DateTime.Today.ToString("yyyy-MM-dd 23:59:59");
            SqlConnection cmsConn = new SqlConnection("server=TCP:192.168.1.3;database=CMS;uid=sa;pwd=Magical9070");
            cmsConn.Open();
            string SqlComm = "select maintain.ticket, maintain.gno, comm.cname, custom.ano, custom.cno, custom.cust, custom.name, "+
                "custom.tel, custom.cell, maintain.gotime, maintain.finishtime, maintain.probrem, maintain.solution, maintain.meno2, "+
                "maintain.meno1, maintain.kind from comm, custom, maintain where (comm.ano = custom.ano and custom.ano= maintain.ano and "+
                "comm.cno=custom.cno and custom.cno = maintain.cno and custom.cust=maintain.cust and maintain.gotime between '" +
                NowDate + "' AND '" + LastDate + "')"+
                " union "+
                "select ticket, gno, cname, ano, cno, cust, name, tel, cell, gotime, finishtime, probrem, solution, meno2, "+
                "meno1, kind from maintain where maintain.ano is null and maintain.gotime between '" + NowDate + "' AND '" + LastDate + "'";
            SqlDataAdapter ReadData = new SqlDataAdapter(SqlComm,cmsConn);
            DataTable ShowDataTable=new DataTable();
            ReadData.Fill(ShowDataTable);
            for (int i = 1; i < ShowDataTable.Rows.Count;i++)
            {
                if (ShowDataTable.Rows[i]["kind"].ToString() == "")
                {
                    i++;
                }
                else
                {
                    int a = Convert.ToInt32(ShowDataTable.Rows[i]["kind"]);
                    if(a==1)
                    {                        
                    }
                    else if(a==2)
                    {
                    }
                    else if(a==3)
                    {
                    }
                    else if(a==4)
                    {
                    }
                }
            }
            ShowDataTable.DefaultView.Sort = "gno,gotime asc";
            dgvShowData.DataSource = ShowDataTable;
            dgvShowData.Columns[0].Visible = false;
            dgvShowData.Columns[10].Visible = false;
            dgvShowData.Columns[13].Visible = false;
            dgvShowData.Columns[14].Visible = false;
            dgvShowData.Columns[0].HeaderText = "工單號";
            dgvShowData.Columns[1].HeaderText = "組別";
            dgvShowData.Columns[2].HeaderText = "社區名稱";
            dgvShowData.Columns[3].HeaderText = "區碼";
            dgvShowData.Columns[4].HeaderText = "社區碼";
            dgvShowData.Columns[5].HeaderText = "用戶碼";
            dgvShowData.Columns[6].HeaderText = "姓名";
            dgvShowData.Columns[7].HeaderText = "電話";
            dgvShowData.Columns[8].HeaderText = "手機";
            dgvShowData.Columns[9].HeaderText = "派工日期";
            dgvShowData.Columns[10].HeaderText = "結案日期";
            dgvShowData.Columns[11].HeaderText = "報修事項";
            dgvShowData.Columns[12].HeaderText = "處理事項";
            dgvShowData.Columns[13].HeaderText = "工程人員";
            dgvShowData.Columns[14].HeaderText = "客服人員";
            dgvShowData.Columns[0].Width = 70;
            dgvShowData.Columns[1].Width = 40;
            dgvShowData.Columns[2].Width = 120;
            dgvShowData.Columns[3].Width = 60;
            dgvShowData.Columns[4].Width = 70;
            dgvShowData.Columns[5].Width = 70;
            dgvShowData.Columns[6].Width = 90;
            dgvShowData.Columns[7].Width = 80;
            dgvShowData.Columns[8].Width = 80;
            dgvShowData.Columns[9].Width = 120;
            dgvShowData.Columns[10].Width = 120;
            dgvShowData.Columns[11].Width = 350;
            dgvShowData.Columns[12].Width = 350;
            dgvShowData.Columns[13].Width = 100;
            dgvShowData.Columns[14].Width = 100;
            cmsConn.Close();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblEngNameShow.Text = "";
            lblSerNameShow.Text = "";
            lblOddNumShow.Text = "";
            lblFinishDateShow.Text = "";
            string NowDate = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd 00:00:00");
            string LastDate = monthCalendar1.SelectionEnd.ToString("yyyy-MM-dd 23:59:59");
            SqlConnection cmsConn = new SqlConnection("server=TCP:192.168.1.3;database=CMS;uid=sa;pwd=Magical9070");
            cmsConn.Open();
            string SqlComm = "select maintain.ticket, maintain.gno, comm.cname, custom.ano, custom.cno, custom.cust, custom.name, " +
                "custom.tel, custom.cell, maintain.gotime, maintain.finishtime, maintain.probrem, maintain.solution, maintain.meno2, " +
                "maintain.meno1, maintain.kind from comm, custom, maintain where (comm.ano = custom.ano and custom.ano= maintain.ano and " +
                "comm.cno=custom.cno and custom.cno = maintain.cno and custom.cust=maintain.cust and maintain.gotime between '" +
                NowDate + "' AND '" + LastDate + "')" +
                " union " +
                "select ticket, gno, cname, ano, cno, cust, name, tel, cell, gotime, finishtime, probrem, solution, meno2, " +
                "meno1, maintain.kind from maintain where maintain.ano is null and maintain.gotime between '" + NowDate + "' AND '" + LastDate + "'";
            SqlDataAdapter ReadData = new SqlDataAdapter(SqlComm, cmsConn);
            DataTable ShowDataTable = new DataTable();
            ReadData.Fill(ShowDataTable);
            ShowDataTable.DefaultView.Sort = "gno asc";
            dgvShowData.DataSource = ShowDataTable;
            dgvShowData.Columns[0].Visible = false;
            dgvShowData.Columns[10].Visible = false;
            dgvShowData.Columns[13].Visible = false;
            dgvShowData.Columns[14].Visible = false;
            dgvShowData.Columns[0].HeaderText = "工單號";
            dgvShowData.Columns[1].HeaderText = "組別";
            dgvShowData.Columns[2].HeaderText = "社區名稱";
            dgvShowData.Columns[3].HeaderText = "區碼";
            dgvShowData.Columns[4].HeaderText = "社區碼";
            dgvShowData.Columns[5].HeaderText = "用戶碼";
            dgvShowData.Columns[6].HeaderText = "姓名";
            dgvShowData.Columns[7].HeaderText = "電話";
            dgvShowData.Columns[8].HeaderText = "手機";
            dgvShowData.Columns[9].HeaderText = "派工日期";
            dgvShowData.Columns[10].HeaderText = "結案日期";
            dgvShowData.Columns[11].HeaderText = "報修事項";
            dgvShowData.Columns[12].HeaderText = "處理事項";
            dgvShowData.Columns[13].HeaderText = "工程人員";
            dgvShowData.Columns[14].HeaderText = "客服人員";
            dgvShowData.Columns[0].Width = 70;
            dgvShowData.Columns[1].Width = 40;
            dgvShowData.Columns[2].Width = 120;
            dgvShowData.Columns[3].Width = 60;
            dgvShowData.Columns[4].Width = 70;
            dgvShowData.Columns[5].Width = 70;
            dgvShowData.Columns[6].Width = 90;
            dgvShowData.Columns[7].Width = 80;
            dgvShowData.Columns[8].Width = 80;
            dgvShowData.Columns[9].Width = 120;
            dgvShowData.Columns[10].Width = 120;
            dgvShowData.Columns[11].Width = 350;
            dgvShowData.Columns[12].Width = 350;
            dgvShowData.Columns[13].Width = 100;
            dgvShowData.Columns[14].Width = 100;
            cmsConn.Close();
            sec = 60;
        }

        private void dgvShowData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //取出DataGridView第0欄位的值
            lblOddNumShow.Text = dgvShowData.CurrentRow.Cells[0].Value.ToString();
            //透過用DataGridView隱藏起來的工號欄位來查詢員工姓名，再秀在對應的Label
            SqlConnection CmsConnection = new SqlConnection("server=TCP:192.168.1.3;database=CMS;uid=sa;pwd=Magical9070");
            CmsConnection.Open();
            //判斷是否有押工程師工號，若沒押，lblEngNameShow秀"未指派"
            if (dgvShowData.CurrentRow.Cells[13].Value.ToString().Trim() == "")
            {
                lblEngNameShow.Text = "未指派";
                string SqlComm = "select name from memb where meno='" + dgvShowData.CurrentRow.Cells[14].Value.ToString() + "'";
                SqlDataAdapter ReadSerNameComm = new SqlDataAdapter(SqlComm, CmsConnection);
                DataSet ReadName = new DataSet();
                ReadSerNameComm.Fill(ReadName, "SerName");
                lblSerNameShow.Text = ReadName.Tables["SerName"].Rows[0]["name"].ToString();
                ReadName.Clear();
                CmsConnection.Close();
                //將DataGridView第10欄位的日期值指定給字串變數Finishdate，另一個目的是不能直接將DataGridView欄位去字串
                string FinishDate = dgvShowData.CurrentRow.Cells[10].Value.ToString();
                //判斷FinishDate的值是否為空
                if (FinishDate == "")
                {
                    lblFinishDateShow.Text = "尚未結案";
                }
                else
                {
                    //去掉日期格式XXXX/XX/XX後方字串，再指定給lblFinishDateShow
                    lblFinishDateShow.Text = FinishDate.Remove(FinishDate.Length - 12);
                }
            }
            else
            {
                string SqlComm = "select name from memb where meno='" + dgvShowData.CurrentRow.Cells[13].Value.ToString() + "'";
                SqlDataAdapter ReadEngNameComm = new SqlDataAdapter(SqlComm, CmsConnection);
                DataSet ReadName = new DataSet();
                ReadEngNameComm.Fill(ReadName, "EngName");
                lblEngNameShow.Text = ReadName.Tables["EngName"].Rows[0]["name"].ToString();
                SqlComm = "select name from memb where meno='" + dgvShowData.CurrentRow.Cells[14].Value.ToString() + "'";
                SqlDataAdapter ReadSerNameComm = new SqlDataAdapter(SqlComm, CmsConnection);
                ReadSerNameComm.Fill(ReadName, "SerName");
                lblSerNameShow.Text = ReadName.Tables["SerName"].Rows[0]["name"].ToString();
                ReadName.Clear();
                CmsConnection.Close();
                //將DataGridView第10欄位的日期值指定給字串變數Finishdate
                string FinishDate = dgvShowData.CurrentRow.Cells[10].Value.ToString();
                //判斷FinishDate的值是否為空
                if (FinishDate == "")
                {
                    lblFinishDateShow.Text = "尚未結案";
                }
                else
                {
                    //去掉日期格式XXXX/XX/XX後方字串，再指定給lblFinishDateShow
                    lblFinishDateShow.Text = FinishDate.Remove(FinishDate.Length - 12);
                }
            }
        }

        private void tmrDataShow_Tick(object sender, EventArgs e)
        {
            sec--;
            label1.Text = "" + sec;
            if (sec == 0)
            {
                string NowDate = monthCalendar1.SelectionStart.ToString("yyyy-MM-dd 00:00:00");
                string LastDate = monthCalendar1.SelectionEnd.ToString("yyyy-MM-dd 23:59:59");
                SqlConnection cmsConn = new SqlConnection("server=TCP:192.168.1.3;database=CMS;uid=sa;pwd=Magical9070");
                cmsConn.Open();
                string SqlComm = "select maintain.ticket, maintain.gno, comm.cname, custom.ano, custom.cno, custom.cust, custom.name, " +
                    "custom.tel, custom.cell, maintain.gotime, maintain.finishtime, maintain.probrem, maintain.solution, maintain.meno2, " +
                    "maintain.meno1, maintain.kind from comm, custom, maintain where (comm.ano = custom.ano and custom.ano= maintain.ano and " +
                    "comm.cno=custom.cno and custom.cno = maintain.cno and custom.cust=maintain.cust and maintain.gotime between '" +
                    NowDate + "' AND '" + LastDate + "')" +
                    " union " +
                    "select ticket, gno, cname, ano, cno, cust, name, tel, cell, gotime, finishtime, probrem, solution, meno2, " +
                    "meno1, kind from maintain where maintain.ano is null and maintain.gotime between '" + NowDate + "' AND '" + LastDate + "'";
                SqlDataAdapter ReadData = new SqlDataAdapter(SqlComm, cmsConn);
                DataTable ShowDataTable = new DataTable();
                ReadData.Fill(ShowDataTable);
                ShowDataTable.DefaultView.Sort = "gno asc";
                dgvShowData.DataSource = ShowDataTable;
                dgvShowData.Columns[0].Visible = false;
                dgvShowData.Columns[10].Visible = false;
                dgvShowData.Columns[13].Visible = false;
                dgvShowData.Columns[14].Visible = false;
                dgvShowData.Columns[0].HeaderText = "工單號";
                dgvShowData.Columns[1].HeaderText = "組別";
                dgvShowData.Columns[2].HeaderText = "社區名稱";
                dgvShowData.Columns[3].HeaderText = "區碼";
                dgvShowData.Columns[4].HeaderText = "社區碼";
                dgvShowData.Columns[5].HeaderText = "用戶碼";
                dgvShowData.Columns[6].HeaderText = "姓名";
                dgvShowData.Columns[7].HeaderText = "電話";
                dgvShowData.Columns[8].HeaderText = "手機";
                dgvShowData.Columns[9].HeaderText = "派工日期";
                dgvShowData.Columns[10].HeaderText = "結案日期";
                dgvShowData.Columns[11].HeaderText = "報修事項";
                dgvShowData.Columns[12].HeaderText = "處理事項";
                dgvShowData.Columns[13].HeaderText = "工程人員";
                dgvShowData.Columns[14].HeaderText = "客服人員";
                dgvShowData.Columns[0].Width = 70;
                dgvShowData.Columns[1].Width = 40;
                dgvShowData.Columns[2].Width = 120;
                dgvShowData.Columns[3].Width = 60;
                dgvShowData.Columns[4].Width = 70;
                dgvShowData.Columns[5].Width = 70;
                dgvShowData.Columns[6].Width = 90;
                dgvShowData.Columns[7].Width = 80;
                dgvShowData.Columns[8].Width = 80;
                dgvShowData.Columns[9].Width = 120;
                dgvShowData.Columns[10].Width = 120;
                dgvShowData.Columns[11].Width = 350;
                dgvShowData.Columns[12].Width = 350;
                dgvShowData.Columns[13].Width = 100;
                dgvShowData.Columns[14].Width = 100;
                cmsConn.Close();
                sec = 60;
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            SelectTask selecttask = new SelectTask();
            selecttask.Show();
        }
    }
}
