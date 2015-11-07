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
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace Magical_Management_System
{
    public partial class Discontinue : Form
    {
        SqlConnection CmsConnection = new SqlConnection("server=TCP:192.168.1.3;database=CMS;uid=sa;pwd=Magical9070");
        string Cmscomm = "";
        public Discontinue()
        {
            InitializeComponent();
            dtpStart.Value = DateTime.Today;
            dtpEnd.Value = DateTime.Today;
            lblDataListNum.Text = "";
            rdoKinkNoStop.Checked = false;
            rdoNoStopDate.Checked = false;
            cboSales.Enabled = false;
            chkDataToSales.Enabled = false;
            string SelectSales = "select meno, name from memb where (meno like '03%') and (dpna='300') and (quidate is null);";
            SqlDataAdapter readname = new SqlDataAdapter(SelectSales,CmsConnection);
            DataSet sn = new DataSet();
            readname.Fill(sn, "name");
            //在讀出的DataSet Tables中，插入一筆meno=0300,name=請選擇
            sn.Tables["name"].Rows.Add("0300", "請選擇");
            //將sn.Tables裡的資料依工號做正向排序
            sn.Tables[0].DefaultView.Sort = "meno asc";
            //指定cboSalesName的資料來源為sn裡的name Tables
            cboSales.DataSource = sn.Tables["name"];
            //指定將sn裡的name Tables的姓名欄位為cboSalesName選單資料
            cboSales.DisplayMember = "name";
            cboSales.DropDownStyle = ComboBoxStyle.DropDownList;
            CmsConnection.Close();
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            if(chkSales.Checked==true & rdoKinkNoStop.Checked==false & rdoNoStopDate.Checked==false)
            {
                if (cboSales.SelectedIndex == 0)
                {
                    MessageBox.Show("未選擇業務人員！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    CmsConnection.Open();
                    Cmscomm = "select meno from memb where name='" + cboSales.Text.Trim() + "'";
                    SqlDataAdapter SelectSalesMeno = new SqlDataAdapter(Cmscomm, CmsConnection);
                    DataTable salesmeno = new DataTable();
                    SelectSalesMeno.Fill(salesmeno);
                    if (chkDataToSales.Checked == false)
                    {
                        Cmscomm = "select custom.ano, custom.cno, custom.cust, comm.cname, custom.name, custom.tel, custom.cell, " +
                            "Convert(char(10),custom.setdate,20) as setdate, Convert(char(10),custom.startdate,20) as startdate, " +
                            "Convert(char(10),custom.enddate,20) as enddate, Convert(char(10),custom.stopdate,20) as stopdate, " +
                            "contract.price, custom.memo from comm, contract,custom,memb where (custom.ano= comm.ano AND custom.cno = " +
                            "comm.cno AND custom.con_no = contract.con_no) and (custom.stopdate between '" + dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") +
                            "' and '" + dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") + "') and (custom.use_kind=6) and (comm.meno=memb.meno) " +
                            "and (memb.meno='"+salesmeno.Rows[0]["meno"].ToString().Trim()+"')" +
                            " union " +
                            "select custom.ano, custom.cno, custom.cust, comm.cname, custom.name, custom.tel, custom.cell, " +
                            "Convert(char(10),custom.setdate,20) as setdate, Convert(char(10),custom.startdate,20) as startdate, " +
                            "Convert(char(10),custom.enddate,20) as enddate, Convert(char(10),custom.stopdate,20) as stopdate, " +
                            "contract.price, custom.memo from comm, contract,custom,memb where (custom.ano= comm.ano AND custom.cno = " +
                            "comm.cno AND custom.con_no = contract.con_no) and (custom.enddate between '" + dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") +
                            "' and '" + dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") + "') and (custom.use_kind=6) and (comm.meno=memb.meno) " +
                            "and (memb.meno='" + salesmeno.Rows[0]["meno"].ToString().Trim() + "')";
                    }
                    else
                    {
                        Cmscomm = "select custom.ano, custom.cno, custom.cust, comm.cname, custom.name,Convert(char(10),custom.enddate,20) as enddate, "+
                            "Convert(char(10),custom.stopdate,20) as stopdate, contract.price, custom.memo from comm, contract,custom,memb where "+
                            "(custom.ano= comm.ano AND custom.cno = comm.cno AND custom.con_no = contract.con_no) and (custom.stopdate between '" + 
                            dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") + "' and '" + dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") + "') and "+
                            "(custom.use_kind=6) and (comm.meno=memb.meno) and (memb.meno='" + salesmeno.Rows[0]["meno"].ToString().Trim() + "')" +
                            " union " +
                            "select custom.ano, custom.cno, custom.cust, comm.cname, custom.name,Convert(char(10),custom.enddate,20) as enddate, "+
                            "Convert(char(10),custom.stopdate,20) as stopdate, contract.price, custom.memo from comm, contract,custom,memb where "+
                            "(custom.ano= comm.ano AND custom.cno = comm.cno AND custom.con_no = contract.con_no) and (custom.enddate between '" + 
                            dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") + "' and '" + dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") + "') and "+
                            "(custom.use_kind=6) and (comm.meno=memb.meno) and (memb.meno='" + salesmeno.Rows[0]["meno"].ToString().Trim() + "')";
                    }
                }
            }
            else if((chkSales.Checked==true) & (rdoKinkNoStop.Checked==true | rdoNoStopDate.Checked==true))
            {
                MessageBox.Show("不可同時選擇二個條件！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else if(rdoNoStopDate.Checked==true)
            {
                Cmscomm = "SELECT custom.ano, custom.cno, custom.cust, comm.cname, custom.name, custom.tel, custom.cell, "+
                    "Convert(char(10),custom.setdate,20) as setdate, Convert(char(10),custom.startdate,20) as startdate, " +
                    "Convert(char(10),custom.enddate,20) as enddate, Convert(char(10),custom.stopdate,20) as stopdate, "+
                    "contract.price, custom.memo from comm, contract, custom where (custom.ano = comm.ano AND custom.cno = "+
                    "comm.cno and custom.con_no = contract.con_no) and (custom.enddate between '" + dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") + 
                    "' and '" + dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") + "') and (custom.use_kind=6) and (custom.stopdate is null)";
            }
            else if(rdoKinkNoStop.Checked==true)
            {
                Cmscomm = "SELECT custom.ano, custom.cno, custom.cust, comm.cname, custom.name, custom.tel, custom.cell, "+
                    "Convert(char(10),custom.setdate,20) as setdate, Convert(char(10),custom.startdate,20) as startdate, " +
                    "Convert(char(10),custom.enddate,20) as enddate, Convert(char(10),custom.stopdate,20) as stopdate, "+
                    "contract.price, custom.memo from comm, contract, custom where (custom.ano = comm.ano AND custom.cno = "+
                    "comm.cno AND custom.con_no = contract.con_no) and (custom.enddate between '" + dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") + 
                    "' and '" + dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") + "') and (custom.use_kind=7)";
            }
            else
            {
                Cmscomm = "SELECT custom.ano, custom.cno, custom.cust, comm.cname, custom.name, custom.tel, custom.cell, "+
                    "Convert(char(10),custom.setdate,20) as setdate, Convert(char(10),custom.startdate,20) as startdate, "+
                    "Convert(char(10),custom.enddate,20) as enddate, Convert(char(10),custom.stopdate,20) as stopdate, "+
                    "contract.price, custom.memo from comm, contract, custom where (custom.ano= comm.ano AND custom.cno = "+
                    "comm.cno AND custom.con_no = contract.con_no) and (custom.stopdate between '" + dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") + 
                    "' and '" + dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") + "') and (custom.use_kind=6)" +
                    " union " +
                    "SELECT custom.ano, custom.cno, custom.cust, comm.cname, custom.name, custom.tel, custom.cell, "+
                    "Convert(char(10),custom.setdate,20) as setdate, Convert(char(10),custom.startdate,20) as startdate, "+
                    "Convert(char(10),custom.enddate,20) as enddate, Convert(char(10),custom.stopdate,20) as stopdate, "+
                    "contract.price, custom.memo from comm, contract, custom where (custom.ano= comm.ano AND custom.cno = "+
                    "comm.cno AND custom.con_no = contract.con_no) and (custom.enddate between '" + dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") + 
                    "' and '" + dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") + "') and (custom.use_kind=6)";
            }
            if (chkSales.Checked == true & chkDataToSales.Checked==true)
            {
                SqlCommand comm = new SqlCommand(Cmscomm, CmsConnection);
                SqlDataAdapter dataadapter = new SqlDataAdapter(Cmscomm, CmsConnection);
                DataTable dtTable = new DataTable();
                dtTable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataadapter.Fill(dtTable);
                lblDataListNum.Text = "共" + dtTable.Rows.Count + "筆";
                dtTable.DefaultView.Sort = "enddate asc";
                dgvShowData.Columns.Clear();
                dgvShowData.DataSource = dtTable;
                dgvShowData.Columns[0].HeaderText = "區碼";
                dgvShowData.Columns[1].HeaderText = "社區碼";
                dgvShowData.Columns[2].HeaderText = "用戶碼";
                dgvShowData.Columns[3].HeaderText = "社區名稱";
                dgvShowData.Columns[4].HeaderText = "姓名";
                dgvShowData.Columns[5].HeaderText = "到期日";
                dgvShowData.Columns[6].HeaderText = "退租日";
                dgvShowData.Columns[7].HeaderText = "金額";
                dgvShowData.Columns[8].HeaderText = "備註";
                dgvShowData.Columns[0].Width = 40;
                dgvShowData.Columns[1].Width = 70;
                dgvShowData.Columns[2].Width = 70;
                dgvShowData.Columns[3].Width = 120;
                dgvShowData.Columns[4].Width = 100;
                dgvShowData.Columns[5].Width = 80;
                dgvShowData.Columns[6].Width = 80;
                dgvShowData.Columns[7].Width = 70;
                dgvShowData.Columns[8].Width = 350;
                CmsConnection.Close();
            }
            else
            {
                SqlCommand comm = new SqlCommand(Cmscomm, CmsConnection);
                SqlDataAdapter dataadapter = new SqlDataAdapter(Cmscomm, CmsConnection);
                DataTable dtTable = new DataTable();
                dtTable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataadapter.Fill(dtTable);
                lblDataListNum.Text = "共" + dtTable.Rows.Count + "筆";
                dtTable.DefaultView.Sort = "enddate asc";
                dgvShowData.Columns.Clear();
                dgvShowData.DataSource = dtTable;
                dgvShowData.Columns[0].HeaderText = "區碼";
                dgvShowData.Columns[1].HeaderText = "社區碼";
                dgvShowData.Columns[2].HeaderText = "用戶碼";
                dgvShowData.Columns[3].HeaderText = "社區名稱";
                dgvShowData.Columns[4].HeaderText = "姓名";
                dgvShowData.Columns[5].HeaderText = "電話";
                dgvShowData.Columns[6].HeaderText = "手機";
                dgvShowData.Columns[7].HeaderText = "裝機日";
                dgvShowData.Columns[8].HeaderText = "起算日";
                dgvShowData.Columns[9].HeaderText = "到期日";
                dgvShowData.Columns[10].HeaderText = "退租日";
                dgvShowData.Columns[11].HeaderText = "金額";
                dgvShowData.Columns[12].HeaderText = "備註";
                dgvShowData.Columns[0].Width = 40;
                dgvShowData.Columns[1].Width = 70;
                dgvShowData.Columns[2].Width = 70;
                dgvShowData.Columns[3].Width = 120;
                dgvShowData.Columns[4].Width = 100;
                dgvShowData.Columns[5].Width = 70;
                dgvShowData.Columns[6].Width = 90;
                dgvShowData.Columns[7].Width = 80;
                dgvShowData.Columns[8].Width = 80;
                dgvShowData.Columns[9].Width = 80;
                dgvShowData.Columns[10].Width = 80;
                dgvShowData.Columns[11].Width = 70;
                dgvShowData.Columns[12].Width = 350;
                CmsConnection.Close();
            }
        }

        private void btnToExcel_Click_1(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excel = null;
            try
            {
                //DataGridView沒有資料就不執行
                if (this.dgvShowData.Rows.Count <= 1)
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
                for (int i = 0; i < dgvShowData.Columns.Count; i++)
                {
                    excel.Cells[1, i + 1] = dgvShowData.Columns[i].HeaderText;
                }
                //把DataGridView資料寫到Excel
                for (int i = 0; i < dgvShowData.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvShowData.Columns.Count; j++)
                    {
                        if (dgvShowData[j, i].ValueType == typeof(string))
                        {
                            excel.Cells[i + 2, j + 1] = "'" + dgvShowData[j, i].Value.ToString();
                        }
                        else
                        {
                            excel.Cells[i + 2, j + 1] = dgvShowData[j, i].Value.ToString();
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
                excel.get_Range("N1").Font.Color = Color.White;
                excel.get_Range("N1").Interior.Color = Color.DodgerBlue;
                excel.get_Range("O1").Font.Color = Color.White;
                excel.get_Range("O1").Interior.Color = Color.DodgerBlue;

                //設置禁止彈出覆蓋或儲存的彈跳視窗
                excel.DisplayAlerts = false;
                excel.AlertBeforeOverwriting = false;
                MessageBox.Show("已成功輸出至Excel！", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //釋放資源
                System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
                excel = null;
                GC.Collect();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            chkSales.Checked = false;
            chkDataToSales.Checked = false;
            rdoKinkNoStop.Checked = false;
            rdoNoStopDate.Checked = false;
        }

        private void chkSales_CheckedChanged(object sender, EventArgs e)
        {
            if(chkSales.Checked==true)
            {
                cboSales.Enabled = true;
                chkDataToSales.Enabled = true;
            }
            else
            {
                cboSales.SelectedIndex = 0;
                cboSales.Enabled = false;
                chkDataToSales.Enabled = false;
            }
        }

    }
}
