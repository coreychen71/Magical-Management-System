using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Magical_Management_System
{
    public partial class EndDateRefer : Form
    {
        string cmsCon = "server=TCP:192.168.1.3;database=CMS;uid=sa;pwd=Magical9070";
        int days = 0;
        DateTime nowDay = DateTime.Now;
        DateTime endDay;
        public EndDateRefer()
        {
            InitializeComponent();
            cboDays.SelectedIndex = -1;
            cboDays.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private DataTable ReloadData(string startDate,string endDate)
        {
            DataTable result = new DataTable();
            string strComm = "select ano+cno+cust as '客戶編號',name as '姓名',area+'-'+tel as '市話',cell as '手機1'," +
                "cell2 as '手機2',startdate as '起算日',enddate as '到期日' from custom where enddate between '" +
                startDate + "' and '" + endDate + "'";
            using (SqlConnection sqlcon = new SqlConnection(cmsCon))
            {
                using (SqlCommand sqlcomm = new SqlCommand(strComm, sqlcon))
                {
                    try
                    {
                        sqlcon.Open();
                        SqlDataReader read = sqlcomm.ExecuteReader();
                        result.Load(read);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            return result;
        }

        private void cboDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDays.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                days = Convert.ToInt32(cboDays.Text);
                endDay = nowDay.AddDays(days);
                dgvDataShow.DataSource = ReloadData(nowDay.ToString("yyyy-MM-dd"), endDay.ToString("yyyy-MM-dd"));
                lblDataCountResult.Text = dgvDataShow.Rows.Count - 1 + "筆";
            }
        }

        private void btnToExcel_Click(object sender, EventArgs e)
        {
            Excel.Application excel = null;
            try
            {
                //DataGridView沒有資料就不執行
                if (dgvDataShow.Rows.Count <= 1)
                {
                    MessageBox.Show("沒有可滙出的資料！", "訊息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //設定滙出後的存檔路徑(儲存在桌面)
                string SaveFilePath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) +
                    @"\即將到期用戶名單" + ".xls";
                //new 出一個Excel
                excel = new Microsoft.Office.Interop.Excel.Application();
                //看的到Excel在工作
                excel.Visible = false;
                //新增加一工作簿
                excel.Application.Workbooks.Add(true);

                PGB pgb = new PGB();
                pgb.progressBar1.Value = 0;
                pgb.progressBar1.Minimum = 0;
                pgb.progressBar1.Maximum = dgvDataShow.Rows.Count - 1;
                pgb.progressBar1.Step = 1;
                pgb.Show();

                //寫入欄位名稱
                for (int i = 0; i < dgvDataShow.Columns.Count; i++)
                {
                    excel.Cells[1, i + 1] = dgvDataShow.Columns[i].HeaderText;
                }
                //把DataGridView資料寫到Excel
                for (int i = 0; i < dgvDataShow.Rows.Count - 1; i++)
                {
                    pgb.progressBar1.Value++;
                    Application.DoEvents();
                    for (int j = 0; j < dgvDataShow.Columns.Count; j++)
                    {
                        if (dgvDataShow[j, i].ValueType == typeof(string))
                        {
                            excel.Cells[i + 2, j + 1] = "'" + dgvDataShow[j, i].Value.ToString();
                        }
                        else
                        {
                            excel.Cells[i + 2, j + 1] = dgvDataShow[j, i].Value.ToString();
                        }
                    }
                }

                //設定滙出後，欄位寛度自動配合資料調整
                excel.Cells.EntireRow.AutoFit();
                //自動調整列高
                excel.Cells.EntireColumn.AutoFit();
                //設置禁止彈出覆蓋或儲存的彈跳視窗
                excel.DisplayAlerts = false;
                excel.AlertBeforeOverwriting = false;
                //將檔案儲存到SaveFile指定的位置
                excel.ActiveWorkbook.SaveCopyAs(SaveFilePath);
                if (excel.Application.Version == "11.0")//Office 2007 up
                {
                    excel.ActiveWorkbook.SaveAs(SaveFilePath);
                }
                else
                {
                    //Office 2003 Up，FileFormat: Excel.XlFileFormat.xlExcel8=>指定Excel 2003 xls格式
                    excel.ActiveWorkbook.SaveAs(SaveFilePath, FileFormat: Excel.XlFileFormat.xlExcel8);
                }
                pgb.Dispose();
                MessageBox.Show("已成功滙出Excel檔！" + Environment.NewLine + "檔案儲存在您電腦的桌面，檔名：即將到期用戶名單" +
                    ".xls", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //關閉工作簿和結束Excel程式
            excel.Workbooks.Close();
            excel.Quit();
            //釋放資源
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
            excel = null;
            GC.Collect();
        }
    }
}
