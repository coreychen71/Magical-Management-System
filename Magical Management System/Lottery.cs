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
            string SelectSales = "select meno, name from memb where dpna = '300' and meno <> '0201' and quidate is null order by meno asc";
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
            cboSalesName.DropDownStyle = ComboBoxStyle.DropDownList;
            lblSalesMeno.Text = "";
            con.Close();
            dataGridView1.ReadOnly = true;
            dataGridView2.ReadOnly = true;
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
            var comm = string.Empty;
            if (chkAllSales.Checked)
            {
                comm = "select paylist.ano+paylist.cno+paylist.cust 'customer', comm.cname, custom.name, paylist.price, custom.address, " +
                    "custom.tel, custom.cell, convert(char(10),custom.setdate,120) 'setdate', convert(char(10),custom.startdate,120) 'startdate', convert(char(10),paylist.p_date,120) 'p_date' from paylist,comm,custom where " +
                    "custom.ano=paylist.ano and paylist.ano=comm.ano and paylist.cno=comm.cno and paylist.cno=custom.cno and " +
                    "paylist.cust=custom.cust and paylist.p_date between '" + dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") +
                    "' and '" + dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") + "' and paylist.v_date is null and paylist.kind=3" +
                    " union " +
                    "select TSBank.ano+TSBank.cno+TSBank.cust 'customer', comm.cname, custom.name, TSBank.price, custom.address, custom.tel, " +
                    "custom.cell, convert(char(10),custom.setdate,120) 'setdate', convert(char(10),custom.startdate,120) 'startdate', convert(char(10),TSBank.p_date,120) 'p_date' from comm,custom,maintain,TSBank where " +
                    "TSBank.ano=comm.ano and TSBank.cno=comm.cno and TSBank.ano=maintain.ano and " +
                    "TSBank.cno=maintain.cno and TSBank.cust=maintain.cust and TSBank.ano=custom.ano and TSBank.cno=custom.cno and " +
                    "TSBank.cust=custom.cust and maintain.finishtime between '" + dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") +
                    "' and '" + dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") + "' and TSBank.p_date between '" +
                    dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") + "' and '" + dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") +
                    "' and TSBank.ps is null" +
                    " union " +
                    "select paylist.ano+paylist.cno+paylist.cust 'customer', comm.cname, custom.name, paylist.price, custom.address, " +
                    "custom.tel, custom.cell, convert(char(10),custom.setdate,120) 'setdate', convert(char(10),custom.startdate,120) 'startdate', convert(char(10),paylist.p_date,120) 'p_date' from paylist,comm,custom " +
                    "where custom.ano=paylist.ano and paylist.ano=comm.ano and paylist.cno=comm.cno and paylist.cno=custom.cno " +
                    "and paylist.cust=custom.cust and custom.setdate between '" + dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") +
                    "' and '" + dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") + "' order by p_date asc";
            }
            else
            {
                comm = "select paylist.ano+paylist.cno+paylist.cust 'customer', comm.cname, custom.name, paylist.price, custom.address, " +
                    "custom.tel, custom.cell, convert(char(10),custom.setdate,120) 'setdate', convert(char(10),custom.startdate,120) 'startdate', convert(char(10),paylist.p_date,120) 'p_date' from paylist,comm,custom where " +
                    "custom.ano=paylist.ano and paylist.ano=comm.ano and paylist.cno=comm.cno and paylist.cno=custom.cno and " +
                    "paylist.cust=custom.cust and paylist.p_date between '" + dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") +
                    "' and '" + dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") + "' and comm.meno='" + lblSalesMeno.Text +
                    "' and paylist.v_date is null and paylist.kind=3" +
                    " union " +
                    "select TSBank.ano+TSBank.cno+TSBank.cust 'customer', comm.cname, custom.name, TSBank.price, custom.address, custom.tel, " +
                    "custom.cell, convert(char(10),custom.setdate,120) 'setdate', convert(char(10),custom.startdate,120) 'startdate', convert(char(10),TSBank.p_date,120) 'p_date' from comm,custom,maintain,TSBank where " +
                    "TSBank.ano=comm.ano and TSBank.cno=comm.cno and comm.meno='" + lblSalesMeno.Text + "' and TSBank.ano=maintain.ano and " +
                    "TSBank.cno=maintain.cno and TSBank.cust=maintain.cust and TSBank.ano=custom.ano and TSBank.cno=custom.cno and " +
                    "TSBank.cust=custom.cust and maintain.finishtime between '" + dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") +
                    "' and '" + dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") + "' and TSBank.p_date between '" +
                    dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") + "' and '" + dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") +
                    "' and TSBank.ps is null" +
                    " union " +
                    "select paylist.ano+paylist.cno+paylist.cust 'customer', comm.cname, custom.name, paylist.price, custom.address, " +
                    "custom.tel, custom.cell, convert(char(10),custom.setdate,120) 'setdate', convert(char(10),custom.startdate,120) 'startdate', convert(char(10),paylist.p_date,120) 'p_date' from paylist,comm,custom " +
                    "where custom.ano=paylist.ano and paylist.ano=comm.ano and paylist.cno=comm.cno and paylist.cno=custom.cno " +
                    "and paylist.cust=custom.cust and custom.setdate between '" + dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") +
                    "' and '" + dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") + "' and comm.meno='" + lblSalesMeno.Text + "' " +
                    "order by p_date asc";
            }
            if (!chkAllSales.Checked & cboSalesName.SelectedIndex == 0)
            {
                MessageBox.Show("請選擇業務人員！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //第一部份先將符合條件的資料撈出，秀在DataGridView1上
                SqlConnection con = new SqlConnection("server=TCP:192.168.1.3;database=CMS;uid=sa;pwd=Magical9070");
                con.Open();
                //依指定的日期區間撈出指定業務人員在區間內的新申裝用戶資料並以繳費日期做正排序
                
                SqlDataAdapter selectdata = new SqlDataAdapter(comm, con);
                DataTable readall = new DataTable();
                readall.Locale = System.Globalization.CultureInfo.InvariantCulture;
                selectdata.Fill(readall);
                //將DataTable的筆數加總並傳至lblDataNum.Text
                lblDataNum.Text = "共" + readall.Rows.Count + "筆";
                dataGridView1.DataSource = readall;
                dataGridView1.Columns[0].HeaderText = "用戶編號";
                dataGridView1.Columns[1].HeaderText = "社區名稱";
                dataGridView1.Columns[2].HeaderText = "姓名";
                dataGridView1.Columns[3].HeaderText = "金額";
                dataGridView1.Columns[4].HeaderText = "地址";
                dataGridView1.Columns[5].HeaderText = "電話";
                dataGridView1.Columns[6].HeaderText = "手機";
                dataGridView1.Columns[7].HeaderText = "裝機日";
                dataGridView1.Columns[8].HeaderText = "起算日";
                dataGridView1.Columns[9].HeaderText = "繳費日";
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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
                    var srcData = (DataTable)dataGridView1.DataSource;
                    var result = srcData.Clone();
                    var aryNum = new int[Convert.ToInt32(txtNum.Text)];
                    var random = new Random();
                    for (int i = 0; i < Convert.ToInt32(txtNum.Text); i++)
                    {
                        Reload:
                        var num = random.Next(0, (srcData.Rows.Count - 1));
                        if (aryNum.Contains(num))
                        {
                            goto Reload;
                        }
                        else
                        {
                            aryNum[i] = num;
                            var copyRow = srcData.Rows[aryNum[i]];
                            DataRow row = result.NewRow();
                            for (int y = 0; y < result.Columns.Count; y++)
                            {
                                row[y] = copyRow[y];
                            }
                            result.Rows.Add(row);
                        }
                    }
                    result.Columns.Add("Item");
                    result.Columns["Item"].SetOrdinal(0);
                    for(int i = 0; i<result.Rows.Count; i++)
                    {
                        result.Rows[i]["Item"] = i + 1;
                    }
                    lblUser.Text = result.Rows.Count + "筆";
                    dataGridView2.DataSource = result;
                    dataGridView2.Columns[0].HeaderText="Item";
                    dataGridView2.Columns[1].HeaderText = "用戶編號";
                    dataGridView2.Columns[2].HeaderText = "社區名稱";
                    dataGridView2.Columns[3].HeaderText = "姓名";
                    dataGridView2.Columns[4].HeaderText = "金額";
                    dataGridView2.Columns[5].HeaderText = "地址";
                    dataGridView2.Columns[6].HeaderText = "電話";
                    dataGridView2.Columns[7].HeaderText = "手機";
                    dataGridView2.Columns[8].HeaderText = "裝機日";
                    dataGridView2.Columns[9].HeaderText = "起算日";
                    dataGridView2.Columns[10].HeaderText = "繳費日";
                    dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
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

        private void chkAllSales_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllSales.Checked)
            {
                cboSalesName.Enabled = false;
            }
            else
            {
                cboSalesName.Enabled = true;
            }
        }
    }
}
