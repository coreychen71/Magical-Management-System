using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace Magical_Management_System
{
    public partial class Lottery : Form
    {
        public Lottery()
        {
            InitializeComponent();
            dtpStart.Value = DateTime.Today;
            dtpEnd.Value = DateTime.Today;
            groupBox1.ForeColor = Color.Blue;
            lbl8.ForeColor = Color.Blue;
            lblUser.ForeColor = Color.Blue;
            lblDataNum.Text = "";
            lblUser.Text = "";
            SqlConnection con = new SqlConnection("server=TCP:192.168.1.3;database=CMS;uid=sa;pwd=Magical9070");
            con.Open();
            //找出仍在職業務人員工號與姓名
            string SelectSales = "select meno, name from memb where (meno like '03%') and (dpna='300') and (quidate is null);";
            SqlDataAdapter readname = new SqlDataAdapter(SelectSales, con);
            DataSet sn = new DataSet();
            readname.Fill(sn, "name");
            //在讀出的DataSet Tables中，插入一筆meno=0300,name=請選擇
            sn.Tables["name"].Rows.Add("0300", "請選擇");
            //將sn.Tables裡的資料依工號做正向排序
            sn.Tables[0].DefaultView.Sort="meno asc";
            //指定cboSalesName的資料來源為sn裡的name Tables
            cboSalesName.DataSource = sn.Tables["name"];
            //指定將sn裡的name Tables的姓名欄位為cboSalesName選單資料
            cboSalesName.DisplayMember = "name";
            lblSalesMeno.Text = "";
            con.Close();
        }

        //設定txtNum只能輸入數字
        private void txtNum_keyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public void btnStart_Click(object sender, EventArgs e)
        {
            if (cboSalesName.SelectedIndex == 0)
            {
                MessageBox.Show("請選擇業務人員！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //第一部份先將符合條件的資料撈出，秀在DataGridView1上
                SqlConnection con = new SqlConnection("server=TCP:192.168.1.3;database=CMS;uid=sa;pwd=Magical9070");
                con.Open();
                //依指定的日期區間撈出指定業務人員在區間內的新申裝用戶資料並以繳費日期做正排序
                string comm = "select paylist.ano, paylist.cno, paylist.cust, comm.cname, custom.name, paylist.price, custom.address, " +
                    "custom.tel, custom.cell, custom.setdate, custom.startdate, paylist.p_date from paylist,comm,custom where " +
                    "custom.ano=paylist.ano and paylist.ano=comm.ano and paylist.cno=comm.cno and paylist.cno=custom.cno and " +
                    "paylist.cust=custom.cust and paylist.p_date between '" + dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") +
                    "' and '" + dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") + "' and comm.meno='" + lblSalesMeno.Text +
                    "' and paylist.v_date is null and paylist.kind=3" +
                    " union " +
                    "select TSBank.ano, TSBank.cno, TSBank.cust, comm.cname, custom.name, TSBank.price, custom.address, custom.tel, " +
                    "custom.cell, custom.setdate, custom.startdate, TSBank.p_date from comm,custom,maintain,TSBank where " +
                    "TSBank.ano=comm.ano and TSBank.cno=comm.cno and comm.meno='" + lblSalesMeno.Text + "' and TSBank.ano=maintain.ano and " +
                    "TSBank.cno=maintain.cno and TSBank.cust=maintain.cust and TSBank.ano=custom.ano and TSBank.cno=custom.cno and " +
                    "TSBank.cust=custom.cust and maintain.finishtime between '" + dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") +
                    "' and '" + dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") + "' and TSBank.p_date between '" +
                    dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") + "' and '" + dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") +
                    "' and TSBank.ps is null" +
                    " union " +
                    "select paylist.ano, paylist.cno, paylist.cust, comm.cname, custom.name, paylist.price, custom.address, " +
                    "custom.tel, custom.cell, custom.setdate, custom.startdate, paylist.p_date from paylist,comm,custom " +
                    "where custom.ano=paylist.ano and paylist.ano=comm.ano and paylist.cno=comm.cno and paylist.cno=custom.cno " +
                    "and paylist.cust=custom.cust and custom.setdate between '" + dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") +
                    "' and '" + dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") + "' and comm.meno='" + lblSalesMeno.Text + "' " +
                    "order by p_date asc";
                SqlDataAdapter selectdata = new SqlDataAdapter(comm, con);
                DataTable readall = new DataTable();
                readall.Locale = System.Globalization.CultureInfo.InvariantCulture;
                selectdata.Fill(readall);
                //將DataTable的筆數加總並傳至lblDataNum.Text
                lblDataNum.Text = "共" + readall.Rows.Count + "筆";
                dataGridView1.DataSource = readall;
                dataGridView1.Columns[0].HeaderText = "區碼";
                dataGridView1.Columns[1].HeaderText = "社區碼";
                dataGridView1.Columns[2].HeaderText = "用戶碼";
                dataGridView1.Columns[3].HeaderText = "社區名稱";
                dataGridView1.Columns[4].HeaderText = "姓名";
                dataGridView1.Columns[5].HeaderText = "金額";
                dataGridView1.Columns[6].HeaderText = "地址";
                dataGridView1.Columns[7].HeaderText = "電話";
                dataGridView1.Columns[8].HeaderText = "手機";
                dataGridView1.Columns[9].HeaderText = "裝機日";
                dataGridView1.Columns[10].HeaderText = "起算日";
                dataGridView1.Columns[11].HeaderText = "繳費日";
                //指定dataGridView1的欄位寬
                dataGridView1.Columns[0].Width = 60;
                dataGridView1.Columns[1].Width = 70;
                dataGridView1.Columns[2].Width = 70;
                dataGridView1.Columns[3].Width = 120;
                dataGridView1.Columns[4].Width = 100;
                dataGridView1.Columns[5].Width = 60;
                dataGridView1.Columns[6].Width = 250;
                dataGridView1.Columns[7].Width = 70;
                dataGridView1.Columns[8].Width = 70;
                dataGridView1.Columns[9].Width = 70;
                dataGridView1.Columns[10].Width = 70;
                dataGridView1.Columns[11].Width = 70;
            }
        }

        //當cboSalesName的選項變動時，連帶撈出該名業務人員的工號並秀在lblSalesMeno
        private void cboSalesName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //先將業務人員姓名帶入lblSalesMeno
            lblSalesMeno.Text = cboSalesName.Text;
            //在杳詢前，先檢查cboSalesName的SelectdIndex值是否大於0
            if (cboSalesName.SelectedIndex > 0)
            {
                lblSalesMeno.Text = cboSalesName.Text;
                SqlConnection con = new SqlConnection("server=TCP:192.168.1.3;database=CMS;uid=sa;pwd=Magical9070");
                con.Open();
                //用業務人員姓名去查詢工號
                string sqcom = "select meno from memb where name='" + lblSalesMeno.Text + "'";
                SqlCommand cmd = new SqlCommand(sqcom, con);
                SqlDataAdapter readmeno = new SqlDataAdapter(sqcom, con);
                DataSet meno = new DataSet();
                //將資料撈出並暫存於meno DataSet
                readmeno.Fill(meno);
                //將存入DataSet的資料轉成字串
                lblSalesMeno.Text = meno.Tables[0].Rows[0]["meno"].ToString();
                con.Close();
            }
        }

        private void btnShootOut_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count <= 1)
            {
                MessageBox.Show("無符合條件之查詢資料！"+Environment.NewLine+"無法抽出用戶！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (txtNum.Text == "")
                {
                    MessageBox.Show("請輸入要隨機抽出的筆數！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    //透過SQL指令亂數排序後，再隨機抽出txtNum指定的資料筆數並秀於DataGridView2
                    SqlConnection con = new SqlConnection("server=TCP:192.168.1.3;database=CMS;uid=sa;pwd=Magical9070");
                    con.Open();
                    string comm = "select paylist.ano, paylist.cno, paylist.cust, comm.cname, custom.name, paylist.price, custom.address, " +
                        "custom.tel, custom.cell, custom.setdate, custom.startdate, paylist.p_date into #TT from paylist,comm,custom where " +
                        "custom.ano=paylist.ano and paylist.ano=comm.ano and paylist.cno=comm.cno and paylist.cno=custom.cno and " +
                        "paylist.cust=custom.cust and paylist.p_date between '" + dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") +
                        "' and '" + dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") + "' and comm.meno='" + lblSalesMeno.Text +
                        "' and paylist.v_date is null and paylist.kind=3" +
                        " union " +
                        "select TSBank.ano, TSBank.cno, TSBank.cust, comm.cname, custom.name, TSBank.price, custom.address, custom.tel, " +
                        "custom.cell, custom.setdate, custom.startdate, TSBank.p_date from comm,custom,maintain,TSBank where " +
                        "TSBank.ano=comm.ano and TSBank.cno=comm.cno and comm.meno='" + lblSalesMeno.Text + "' and TSBank.ano=maintain.ano and " +
                        "TSBank.cno=maintain.cno and TSBank.cust=maintain.cust and TSBank.ano=custom.ano and TSBank.cno=custom.cno and " +
                        "TSBank.cust=custom.cust and maintain.finishtime between '" + dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") +
                        "' and '" + dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") + "' and TSBank.p_date between '" +
                        dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") + "' and '" + dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") +
                        "' and TSBank.ps is null"+
                        " union " +
                        "select paylist.ano, paylist.cno, paylist.cust, comm.cname, custom.name, paylist.price, custom.address, " +
                        "custom.tel, custom.cell, custom.setdate, custom.startdate, paylist.p_date from paylist,comm,custom " +
                        "where custom.ano=paylist.ano and paylist.ano=comm.ano and paylist.cno=comm.cno and paylist.cno=custom.cno " +
                        "and paylist.cust=custom.cust and custom.setdate between '" + dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") +
                        "' and '" + dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") + "' and comm.meno='" + lblSalesMeno.Text + "' " +
                        "order by p_date asc "+
                        "select top " + txtNum.Text + " IDENTITY(int,1,1) as id, ano, cno, cust, cname, name, price, address, tel, cell, " +
                        "setdate, startdate, p_date into #DD from #TT order by NewID() " +
                        "select * from #DD";
                    SqlDataAdapter RandomUser = new SqlDataAdapter(comm, con);
                    DataTable ReadUser = new DataTable();
                    ReadUser.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    RandomUser.Fill(ReadUser);
                    lblUser.Text = ReadUser.Rows.Count + "筆";
                    dataGridView2.DataSource = ReadUser;
                    dataGridView2.Columns[0].HeaderText="ID";
                    dataGridView2.Columns[1].HeaderText = "區碼";
                    dataGridView2.Columns[2].HeaderText = "社區碼";
                    dataGridView2.Columns[3].HeaderText = "用戶碼";
                    dataGridView2.Columns[4].HeaderText = "社區名稱";
                    dataGridView2.Columns[5].HeaderText = "姓名";
                    dataGridView2.Columns[6].HeaderText = "金額";
                    dataGridView2.Columns[7].HeaderText = "地址";
                    dataGridView2.Columns[8].HeaderText = "電話";
                    dataGridView2.Columns[9].HeaderText = "手機";
                    dataGridView2.Columns[10].HeaderText = "裝機日";
                    dataGridView2.Columns[11].HeaderText = "起算日";
                    dataGridView2.Columns[12].HeaderText = "繳費日";
                    dataGridView2.Columns[0].Width = 30;
                    dataGridView2.Columns[1].Width = 60;
                    dataGridView2.Columns[2].Width = 70;
                    dataGridView2.Columns[3].Width = 70;
                    dataGridView2.Columns[4].Width = 120;
                    dataGridView2.Columns[5].Width = 100;
                    dataGridView2.Columns[6].Width = 60;
                    dataGridView2.Columns[7].Width = 250;
                    dataGridView2.Columns[8].Width = 70;
                    dataGridView2.Columns[9].Width = 70;
                    dataGridView2.Columns[10].Width = 70;
                    dataGridView2.Columns[11].Width = 70;
                    dataGridView2.Columns[12].Width = 70;
                    con.Close();
                }
            }
        }

        private void btnToExcel_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = null;
            try
            {
                //DataGridView沒有資料就不執行
                if (this.dataGridView2.Rows.Count <= 1)
                {
                    MessageBox.Show("沒有可滙出的資料！", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
                //new 出一個Excel
                excel = new Microsoft.Office.Interop.Excel.Application();
                //看的到Excel在工作
                excel.Visible = true;
                //新增加一工作簿
                excel.Application.Workbooks.Add(true);

                //寫入欄位名稱
                for (int i = 0; i < dataGridView2.Columns.Count; i++)
                {
                    excel.Cells[1, i + 1] = dataGridView2.Columns[i].HeaderText;
                }
                //把DataGridView資料寫到Excel
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView2.Columns.Count; j++)
                    {
                        if (dataGridView2[j, i].ValueType == typeof(string))
                        {
                            excel.Cells[i + 2, j + 1] = "'" + dataGridView2[j, i].Value.ToString();
                        }
                        else
                        {
                            excel.Cells[i + 2, j + 1] = dataGridView2[j, i].Value.ToString();
                        }
                    }
                }
                //設定滙出後，欄位寛度自動配合資料調整
                excel.Cells.EntireRow.AutoFit(); //自動調整列高
                excel.Cells.EntireColumn.AutoFit();
                excel.Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignTop;
                excel.get_Range("A1").Font.Color = Color.White;
                excel.get_Range("A1").Interior.Color = Color.DodgerBlue;
                excel.get_Range("B1").Font.Color = Color.White;
                excel.get_Range("B1").Interior.Color = Color.DodgerBlue;
                excel.get_Range("C1").Font.Color = Color.White;
                excel.get_Range("C1").Interior.Color = Color.DodgerBlue;
                excel.get_Range("D1").Font.Color = Color.White;
                excel.get_Range("D1").Interior.Color = Color.DodgerBlue;
                excel.get_Range("E1").Font.Color = Color.White;
                excel.get_Range("E1").Interior.Color = Color.DodgerBlue;
                excel.get_Range("F1").Font.Color = Color.White;
                excel.get_Range("F1").Interior.Color = Color.DodgerBlue;
                excel.get_Range("G1").Font.Color = Color.White;
                excel.get_Range("G1").Interior.Color = Color.DodgerBlue;
                excel.get_Range("H1").Font.Color = Color.White;
                excel.get_Range("H1").Interior.Color = Color.DodgerBlue;
                excel.get_Range("I1").Font.Color = Color.White;
                excel.get_Range("I1").Interior.Color = Color.DodgerBlue;
                excel.get_Range("J1").Font.Color = Color.White;
                excel.get_Range("J1").Interior.Color = Color.DodgerBlue;
                excel.get_Range("K1").Font.Color = Color.White;
                excel.get_Range("K1").Interior.Color = Color.DodgerBlue;
                excel.get_Range("L1").Font.Color = Color.White;
                excel.get_Range("L1").Interior.Color = Color.DodgerBlue;
                excel.get_Range("M1").Font.Color = Color.White;
                excel.get_Range("M1").Interior.Color = Color.DodgerBlue;
                //excel.get_Range("N1").Font.Color = Color.White;
                //excel.get_Range("N1").Interior.Color = Color.DodgerBlue;
                //excel.get_Range("O1").Font.Color = Color.White;
                //excel.get_Range("O1").Interior.Color = Color.DodgerBlue;

                //設置禁止彈出覆蓋或儲存的彈跳視窗
                excel.DisplayAlerts = false;
                excel.AlertBeforeOverwriting = false;
                MessageBox.Show("已成功滙出至Excel！", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (dataGridView2.Rows.Count <= 1)
                {
                    excel = null;
                    GC.Collect();
                }
                else
                {
                    //釋放資源
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
                    excel = null;
                    GC.Collect();
                }
            }
        }
    }
}
