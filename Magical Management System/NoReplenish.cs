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
    public partial class NoReplenish : Form
    {
        public NoReplenish()
        {
            InitializeComponent();
            dtpStart.Value = DateTime.Today;
            dtpEnd.Value = DateTime.Today;
            lblDataListNum.Text = "";
            lblTotalPriceShow.Text = "";
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            SqlConnection CmsConnection = new SqlConnection("server=TCP:192.168.1.3;database=CMS;uid=sa;pwd=Magical9070");
            CmsConnection.Open();
            string Cmscomm = "";
            if (chkNoStopDate.Checked == true)
            {
                Cmscomm = "select custom.ano, custom.cno, custom.cust, custom.name, contract.price, contract.ps, contract.con_no," +
                    " custom.setdate, custom.startdate, custom.enddate, custom.stopdate, custom.memo from contract,custom where (custom." +
                    "enddate between '" + dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") + "' and '" + dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") +
                    "') and (custom.con_no=contract.con_no) and (custom.stopdate is null)";
            }
            else
            {
                Cmscomm = "select custom.ano, custom.cno, custom.cust, custom.name, contract.price, contract.ps, contract.con_no," +
                    " custom.setdate, custom.startdate, custom.enddate, custom.stopdate, custom.memo from contract,custom where (custom." +
                    "enddate between '" + dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") + "' and '" + dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") +
                    "') and (custom.con_no=contract.con_no)";
            }
            SqlCommand comm = new SqlCommand(Cmscomm, CmsConnection);
            SqlDataAdapter dataadapter = new SqlDataAdapter(Cmscomm, CmsConnection);
            DataTable dtTable = new DataTable();
            dtTable.Locale = System.Globalization.CultureInfo.InvariantCulture;
            dataadapter.Fill(dtTable);
            lblDataListNum.Text = "共" + dtTable.Rows.Count + "筆";
            dtTable.DefaultView.Sort = "enddate asc";
            if (dtTable.Rows.Count == 0)
            {
                MessageBox.Show("查詢的日期、條件，無符合用戶！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string PriceTotal = dtTable.Compute("Sum(price)", null).ToString();
                double PriceTotalNum = Convert.ToDouble(PriceTotal);
                lblTotalPriceShow.Text = PriceTotalNum.ToString("C0");
            }
            dgvShowData.Columns.Clear();
            dgvShowData.DataSource = dtTable;
            dgvShowData.Columns[0].HeaderText = "區碼";
            dgvShowData.Columns[1].HeaderText = "社區碼";
            dgvShowData.Columns[2].HeaderText = "用戶碼";
            dgvShowData.Columns[3].HeaderText = "姓名";
            dgvShowData.Columns[4].HeaderText = "金額";
            dgvShowData.Columns[5].HeaderText = "合約別";
            dgvShowData.Columns[6].HeaderText = "合約編號";
            dgvShowData.Columns[7].HeaderText = "裝機日";
            dgvShowData.Columns[8].HeaderText = "起算日";
            dgvShowData.Columns[9].HeaderText = "到期日";
            dgvShowData.Columns[10].HeaderText = "退租日";
            dgvShowData.Columns[11].HeaderText = "備註";
            dgvShowData.Columns[0].Width = 40;
            dgvShowData.Columns[1].Width = 70;
            dgvShowData.Columns[2].Width = 70;
            dgvShowData.Columns[3].Width = 80;
            dgvShowData.Columns[4].Width = 40;
            dgvShowData.Columns[5].Width = 70;
            dgvShowData.Columns[6].Width = 80;
            dgvShowData.Columns[7].Width = 80;
            dgvShowData.Columns[8].Width = 80;
            dgvShowData.Columns[9].Width = 80;
            dgvShowData.Columns[10].Width = 80;
            dgvShowData.Columns[11].Width = 350;
            CmsConnection.Close();
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
    }
}
