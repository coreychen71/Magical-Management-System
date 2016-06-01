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
    public partial class InquiryTools : Form
    {
        SqlConnection CmsConnection = new SqlConnection("server=TCP:192.168.1.3;database=CMS;uid=sa;pwd=Magical9070");

        public InquiryTools()
        {
            InitializeComponent();
            //讓DateTimePick一起始就取得當天日期
            dtpStart.Value = DateTime.Today;
            dtpEnd.Value = DateTime.Today;
            lblEngNameShow.Text = "";
            lblSerNameShow.Text = "";
            lblOddNumShow.Text = "";
            lblFinishDateShow.Text = "";
            lblDataListNum.Text = "";
        }

        //限制txtAreaNum,txtCommunityNum,txtEngNum,txtSerNum只能輸入數字
        private void txtNum_keyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //開始依條件進行查詢
        private void btnStart_Click(object sender, EventArgs e)
        {
            CmsConnection.Open();
            lblOddNumShow.Text = "";
            lblSerNameShow.Text = "";
            lblEngNameShow.Text = "";
            lblFinishDateShow.Text = "";
            if (chkCommunity.Checked == false & chkEngNum.Checked == false & chkSerNum.Checked == false)
            {
                string Cmscomm = "select maintain.ticket as '派工單號', maintain.gno as '組別', comm.cname as '社區名稱', custom.ano as '區碼', custom.cno as " +
                        "'社區碼', custom.cust as '用戶碼', custom.name as '姓名', custom.tel as '電話', custom.cell as '手機', " +
                        "maintain.gotime as '派工日期', maintain.finishtime as '結案日期', maintain.probrem as '報修事項', maintain.solution as '處理事項'," +
                        " maintain.meno2 as '工程', maintain.meno1 as '客服' from comm, custom, maintain where (comm.ano = custom.ano" +
                        " and custom.ano= maintain.ano and comm.cno=custom.cno and custom.cno = maintain.cno and custom.cust = " +
                        "maintain.cust and maintain.gotime between '" + dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") + "' AND '" +
                        dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") + "') union select ticket as '派工單號', gno as '組別', cname as " +
                        "'社區名稱', ano as '區域碼', cno as '社區碼', cust as '用戶碼', name as '姓名', tel as '電話', cell as '手機'" +
                        ", gotime as '派工日期', finishtime as '結案日期', probrem as '報修事項', solution as '處理事項', meno2 as '工程', meno1 as '客服' from maintain where" +
                        " maintain.ano is null and maintain.gotime between '" + dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") +
                        "' AND '" + dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") + "'";
                SqlCommand comm = new SqlCommand(Cmscomm, CmsConnection);
                SqlDataAdapter dataadapter = new SqlDataAdapter(Cmscomm, CmsConnection);
                DataTable dtTable = new DataTable();
                dtTable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataadapter.Fill(dtTable);
                lblDataListNum.Text = "共" + dtTable.Rows.Count + "筆";
                //判斷查詢的日期若為同一天就用組別就排序，若不是同一天，則以派工日期做排序
                if (dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") == dtpEnd.Value.ToString("yyyy-MM-dd 00:00:00"))
                {
                    //依組別欄位做正向排序
                    dtTable.DefaultView.Sort = "組別,社區名稱,派工日期 asc";
                    //先清空DataGridView內資料與格式
                    dgvShowData.Columns.Clear();
                    dgvShowData.DataSource = dtTable;
                    //將欄位0,10,13,14隱藏起來
                    dgvShowData.Columns[0].Visible = false;
                    dgvShowData.Columns[10].Visible = false;
                    dgvShowData.Columns[13].Visible = false;
                    dgvShowData.Columns[14].Visible = false;
                    //dgvShowData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvShowData.Columns[1].Width = 40;
                    dgvShowData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvShowData.Columns[3].Width = 60;
                    dgvShowData.Columns[4].Width = 70;
                    dgvShowData.Columns[5].Width = 70;
                    dgvShowData.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvShowData.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvShowData.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvShowData.Columns[9].Width = 120;
                    dgvShowData.Columns[10].Width = 80;
                    dgvShowData.Columns[11].Width = 350;
                    dgvShowData.Columns[12].Width = 350;
                    //dgvShowData.Columns[13].Width = 70;
                    //dgvShowData.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    CmsConnection.Close();
                    //dtTable.Dispose();
                }
                else
                {
                    dtTable.DefaultView.Sort = "派工日期 asc";
                    dgvShowData.Columns.Clear();
                    dgvShowData.DataSource = dtTable;
                    //將欄位0,10,13,14隱藏起來
                    dgvShowData.Columns[0].Visible = false;
                    dgvShowData.Columns[10].Visible = false;
                    dgvShowData.Columns[13].Visible = false;
                    dgvShowData.Columns[14].Visible = false;
                    //dgvShowData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvShowData.Columns[1].Width = 40;
                    dgvShowData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvShowData.Columns[3].Width = 60;
                    dgvShowData.Columns[4].Width = 70;
                    dgvShowData.Columns[5].Width = 70;
                    dgvShowData.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvShowData.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvShowData.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    dgvShowData.Columns[9].Width = 120;
                    dgvShowData.Columns[10].Width = 80;
                    dgvShowData.Columns[11].Width = 350;
                    dgvShowData.Columns[12].Width = 350;
                    //dgvShowData.Columns[13].Width = 70;
                    //dgvShowData.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    CmsConnection.Close();
                    //dtTable.Dispose();
                }
            }
            else if (chkCommunity.Checked == true & chkEngNum.Checked == false & chkSerNum.Checked == false)
            {
                if ((txtAreaNum.Text == "") | (txtCommunityNum.Text == ""))
                {
                    MessageBox.Show("未輸入區碼或社區碼！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if ((txtAreaNum.Text.Length < 2) | (txtCommunityNum.Text.Length < 3))
                {
                    MessageBox.Show("區碼或社區碼輸入不完整！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string Cmscomm = "select cname from comm where ano='" + txtAreaNum.Text + "' and cno='" + txtCommunityNum.Text + "'";
                    SqlCommand cname = new SqlCommand(Cmscomm, CmsConnection);
                    SqlDataAdapter ReadCname = new SqlDataAdapter(Cmscomm, CmsConnection);
                    DataTable CnameTable = new DataTable();
                    ReadCname.Fill(CnameTable);
                    if (CnameTable.Rows.Count == 0)
                    {
                        MessageBox.Show("無此社區！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Cmscomm = "select maintain.ticket as '派工單號', maintain.gno as '組別', comm.cname as '社區名稱', custom.ano as '區碼', custom.cno as " +
                                "'社區碼', custom.cust as '用戶碼', custom.name as '姓名', custom.tel as '電話', custom.cell as '手機', " +
                                "maintain.gotime as '派工日期', maintain.finishtime as '結案日期', maintain.probrem as '報修事項', maintain.solution as '處理事項'," +
                                " maintain.meno2 as '工程', maintain.meno1 as '客服' from comm, custom, maintain where (comm.ano = custom.ano" +
                                " and custom.ano= maintain.ano and comm.cno=custom.cno and custom.cno = maintain.cno and custom.cust = " +
                                "maintain.cust and maintain.ano='" + txtAreaNum.Text + "' and maintain.cno='" + txtCommunityNum.Text + "'" +
                                " and maintain.gotime between '" + dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") + "' AND '" +
                                dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") + "') union select ticket as '派工單號', gno as '組別',cname as '社區名稱'," +
                                " ano as '區碼', cno as '社區碼', cust as '用戶碼', name as '姓名', tel as '電話', cell as '手機', " +
                                "gotime as '派工日期', finishtime as '結案日期', probrem as '報修事項', solution as '處理事項', meno2 as '工程', meno1 as '客服' from " +
                                "maintain where (maintain.cname='" + CnameTable.Rows[0]["cname"].ToString() + "') and (gotime between '" +
                                dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") + "' AND '" + dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") + "')";
                        SqlCommand comm = new SqlCommand(Cmscomm, CmsConnection);
                        SqlDataAdapter dataadapter = new SqlDataAdapter(Cmscomm, CmsConnection);
                        DataTable dtTable = new DataTable();
                        dtTable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                        dataadapter.Fill(dtTable);
                        lblDataListNum.Text = "共" + dtTable.Rows.Count + "筆";
                        //判斷查詢的日期若為同一天就用組別就排序，若不是同一天，則以派工日期做排序
                        if (dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") == dtpEnd.Value.ToString("yyyy-MM-dd 00:00:00"))
                        {
                            //依組別欄位做正向排序
                            dtTable.DefaultView.Sort = "組別 asc";
                            //先清空DataGridView內資料與格式
                            dgvShowData.Columns.Clear();
                            dgvShowData.DataSource = dtTable;
                            //將欄位0,10,13,14隱藏起來
                            dgvShowData.Columns[0].Visible = false;
                            dgvShowData.Columns[10].Visible = false;
                            dgvShowData.Columns[13].Visible = false;
                            dgvShowData.Columns[14].Visible = false;
                            //dgvShowData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            dgvShowData.Columns[1].Width = 40;
                            dgvShowData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            dgvShowData.Columns[3].Width = 60;
                            dgvShowData.Columns[4].Width = 70;
                            dgvShowData.Columns[5].Width = 70;
                            dgvShowData.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            dgvShowData.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            dgvShowData.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            dgvShowData.Columns[9].Width = 120;
                            dgvShowData.Columns[10].Width = 80;
                            dgvShowData.Columns[11].Width = 350;
                            dgvShowData.Columns[12].Width = 350;
                            //dgvShowData.Columns[13].Width = 70;
                            //dgvShowData.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            CmsConnection.Close();
                            //dtTable.Dispose();
                        }
                        else
                        {
                            dtTable.DefaultView.Sort = "派工日期 asc";
                            dgvShowData.Columns.Clear();
                            dgvShowData.DataSource = dtTable;
                            //將欄位0,10,13,14隱藏起來
                            dgvShowData.Columns[0].Visible = false;
                            dgvShowData.Columns[10].Visible = false;
                            dgvShowData.Columns[13].Visible = false;
                            dgvShowData.Columns[14].Visible = false;
                            //dgvShowData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            dgvShowData.Columns[1].Width = 40;
                            dgvShowData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            dgvShowData.Columns[3].Width = 60;
                            dgvShowData.Columns[4].Width = 70;
                            dgvShowData.Columns[5].Width = 70;
                            dgvShowData.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            dgvShowData.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            dgvShowData.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            dgvShowData.Columns[9].Width = 120;
                            dgvShowData.Columns[10].Width = 80;
                            dgvShowData.Columns[11].Width = 350;
                            dgvShowData.Columns[12].Width = 350;
                            //dgvShowData.Columns[13].Width = 70;
                            //dgvShowData.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            CmsConnection.Close();
                            //dtTable.Dispose();
                        }
                    }
                }
            }
            else if (chkCommunity.Checked == false & chkEngNum.Checked == true & chkSerNum.Checked == false)
            {
                if (txtEngNum.Text == "")
                {
                    MessageBox.Show("未輸入工程人員工號！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtEngNum.Text.Length < 4)
                {
                    MessageBox.Show("工程人員工號輸入不完整！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string Cmscomm = "select maintain.ticket as '派工單號', maintain.gno as '組別', comm.cname as '社區名稱', custom.ano as '區碼', custom.cno as " +
                             "'社區碼', custom.cust as '用戶碼', custom.name as '姓名', custom.tel as '電話', custom.cell as '手機', " +
                             "maintain.gotime as '派工日期', maintain.finishtime as '結案日期', maintain.probrem as '報修事項', maintain.solution as '處理事項'," +
                             " maintain.meno2 as '工程', maintain.meno1 as '客服' from comm, custom, maintain where (comm.ano = custom.ano" +
                             " and custom.ano= maintain.ano and comm.cno=custom.cno and custom.cno = maintain.cno and custom.cust = " +
                             "maintain.cust and maintain.meno2='" + txtEngNum.Text + "' and maintain.gotime between '" +
                             dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") + "' AND '" + dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") + "')";
                    SqlCommand comm = new SqlCommand(Cmscomm, CmsConnection);
                    SqlDataAdapter dataadapter = new SqlDataAdapter(Cmscomm, CmsConnection);
                    DataTable dtTable = new DataTable();
                    dtTable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    dataadapter.Fill(dtTable);
                    lblDataListNum.Text = "共" + dtTable.Rows.Count + "筆";
                    //判斷查詢的日期若為同一天就用組別就排序，若不是同一天，則以派工日期做排序
                    if (dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") == dtpEnd.Value.ToString("yyyy-MM-dd 00:00:00"))
                    {
                        //依組別欄位做正向排序
                        dtTable.DefaultView.Sort = "組別 asc";
                        //先清空DataGridView內資料與格式
                        dgvShowData.Columns.Clear();
                        dgvShowData.DataSource = dtTable;
                        //將欄位0,10,14隱藏起來
                        dgvShowData.Columns[0].Visible = false;
                        dgvShowData.Columns[10].Visible = false;
                        //dgvShowData.Columns[13].Visible = false;
                        dgvShowData.Columns[14].Visible = false;
                        //dgvShowData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvShowData.Columns[1].Width = 40;
                        dgvShowData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvShowData.Columns[3].Width = 60;
                        dgvShowData.Columns[4].Width = 70;
                        dgvShowData.Columns[5].Width = 70;
                        dgvShowData.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvShowData.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvShowData.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvShowData.Columns[9].Width = 120;
                        dgvShowData.Columns[10].Width = 80;
                        dgvShowData.Columns[11].Width = 350;
                        dgvShowData.Columns[12].Width = 350;
                        dgvShowData.Columns[13].Width = 70;
                        //dgvShowData.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        CmsConnection.Close();
                        //dtTable.Dispose();
                    }
                    else
                    {
                        dtTable.DefaultView.Sort = "派工日期 asc";
                        dgvShowData.Columns.Clear();
                        dgvShowData.DataSource = dtTable;
                        //將欄位0,10,14隱藏起來
                        dgvShowData.Columns[0].Visible = false;
                        dgvShowData.Columns[10].Visible = false;
                        //dgvShowData.Columns[13].Visible = false;
                        dgvShowData.Columns[14].Visible = false;
                        //dgvShowData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvShowData.Columns[1].Width = 40;
                        dgvShowData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvShowData.Columns[3].Width = 60;
                        dgvShowData.Columns[4].Width = 70;
                        dgvShowData.Columns[5].Width = 70;
                        dgvShowData.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvShowData.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvShowData.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvShowData.Columns[9].Width = 120;
                        dgvShowData.Columns[10].Width = 80;
                        dgvShowData.Columns[11].Width = 350;
                        dgvShowData.Columns[12].Width = 350;
                        dgvShowData.Columns[13].Width = 70;
                        //dgvShowData.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        CmsConnection.Close();
                        //dtTable.Dispose();
                    }
                }
            }
            else if (chkCommunity.Checked == false & chkEngNum.Checked == false & chkSerNum.Checked == true)
            {
                if (txtSerNum.Text == "")
                {
                    MessageBox.Show("未輸入客服人員工號！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtSerNum.Text.Length < 4)
                {
                    MessageBox.Show("客服人員工號輸入不完整！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string Cmscomm = "select maintain.ticket as '派工單號', maintain.gno as '組別', comm.cname as '社區名稱', custom.ano as '區碼', custom.cno as " +
                             "'社區碼', custom.cust as '用戶碼', custom.name as '姓名', custom.tel as '電話', custom.cell as '手機', " +
                             "maintain.gotime as '派工日期', maintain.finishtime as '結案日期', maintain.probrem as '報修事項', maintain.solution as '處理事項'," +
                             " maintain.meno2 as '工程', maintain.meno1 as '客服' from comm, custom, maintain where (comm.ano = custom.ano" +
                             " and custom.ano= maintain.ano and comm.cno=custom.cno and custom.cno = maintain.cno and custom.cust = " +
                             "maintain.cust and maintain.meno1='" + txtSerNum.Text + "' and maintain.gotime between '" +
                             dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") + "' AND '" + dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") + "')";
                    SqlCommand comm = new SqlCommand(Cmscomm, CmsConnection);
                    SqlDataAdapter dataadapter = new SqlDataAdapter(Cmscomm, CmsConnection);
                    DataTable dtTable = new DataTable();
                    dtTable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                    dataadapter.Fill(dtTable);
                    lblDataListNum.Text = "共" + dtTable.Rows.Count + "筆";
                    //判斷查詢的日期若為同一天就用組別就排序，若不是同一天，則以派工日期做排序
                    if (dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") == dtpEnd.Value.ToString("yyyy-MM-dd 00:00:00"))
                    {
                        //依組別欄位做正向排序
                        dtTable.DefaultView.Sort = "組別 asc";
                        //先清空DataGridView內資料與格式
                        dgvShowData.Columns.Clear();
                        dgvShowData.DataSource = dtTable;
                        //將欄位0,10,13隱藏起來
                        dgvShowData.Columns[0].Visible = false;
                        dgvShowData.Columns[10].Visible = false;
                        dgvShowData.Columns[13].Visible = false;
                        //dgvShowData.Columns[14].Visible = false;
                        //dgvShowData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvShowData.Columns[1].Width = 40;
                        dgvShowData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvShowData.Columns[3].Width = 60;
                        dgvShowData.Columns[4].Width = 70;
                        dgvShowData.Columns[5].Width = 70;
                        dgvShowData.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvShowData.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvShowData.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvShowData.Columns[9].Width = 120;
                        dgvShowData.Columns[10].Width = 80;
                        dgvShowData.Columns[11].Width = 350;
                        dgvShowData.Columns[12].Width = 350;
                        //dgvShowData.Columns[13].Width = 70;
                        dgvShowData.Columns[14].Width = 70;
                        CmsConnection.Close();
                        //dtTable.Dispose();
                    }
                    else
                    {
                        dtTable.DefaultView.Sort = "派工日期 asc";
                        dgvShowData.Columns.Clear();
                        dgvShowData.DataSource = dtTable;
                        //將欄位0,10,13隱藏起來
                        dgvShowData.Columns[0].Visible = false;
                        dgvShowData.Columns[10].Visible = false;
                        dgvShowData.Columns[13].Visible = false;
                        //dgvShowData.Columns[14].Visible = false;
                        //dgvShowData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvShowData.Columns[1].Width = 40;
                        dgvShowData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvShowData.Columns[3].Width = 60;
                        dgvShowData.Columns[4].Width = 70;
                        dgvShowData.Columns[5].Width = 70;
                        dgvShowData.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvShowData.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvShowData.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        dgvShowData.Columns[9].Width = 120;
                        dgvShowData.Columns[10].Width = 80;
                        dgvShowData.Columns[11].Width = 350;
                        dgvShowData.Columns[12].Width = 350;
                        //dgvShowData.Columns[13].Width = 70;
                        dgvShowData.Columns[14].Width = 70;
                        CmsConnection.Close();
                        //dtTable.Dispose();
                    }
                }
            }
            else if (chkCommunity.Checked == true & chkEngNum.Checked == true & chkSerNum.Checked == false)
            {
                if ((txtAreaNum.Text == "") | (txtCommunityNum.Text == "") | (txtEngNum.Text == ""))
                {
                    MessageBox.Show("區碼、社區碼、工程人員工號未輸入！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if ((txtAreaNum.Text.Length < 2) | (txtCommunityNum.Text.Length < 3) | (txtEngNum.Text.Length < 4))
                {
                    MessageBox.Show("區碼、社區碼、工程人員工號輸入不完整！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string Cmscomm = "select cname from comm where ano='" + txtAreaNum.Text + "' and cno='" + txtCommunityNum.Text + "'";
                    SqlCommand cname = new SqlCommand(Cmscomm, CmsConnection);
                    SqlDataAdapter ReadCname = new SqlDataAdapter(Cmscomm, CmsConnection);
                    DataTable CnameTable = new DataTable();
                    ReadCname.Fill(CnameTable);
                    if (CnameTable.Rows.Count == 0)
                    {
                        MessageBox.Show("無此社區！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Cmscomm = "select maintain.ticket as '派工單號', maintain.gno as '組別', comm.cname as '社區名稱', custom.ano as '區碼', custom.cno as " +
                                    "'社區碼', custom.cust as '用戶碼', custom.name as '姓名', custom.tel as '電話', custom.cell as '手機', " +
                                    "maintain.gotime as '派工日期', maintain.finishtime as '結案日期', maintain.probrem as '報修事項', maintain.solution as '處理事項'," +
                                    " maintain.meno2 as '工程', maintain.meno1 as '客服' from comm, custom, maintain where (comm.ano = custom.ano" +
                                    " and custom.ano= maintain.ano and comm.cno=custom.cno and custom.cno = maintain.cno and custom.cust = " +
                                    "maintain.cust and maintain.ano='" + txtAreaNum.Text + "' and maintain.cno='" + txtCommunityNum.Text + "'" +
                                    " and maintain.meno2='" + txtEngNum.Text + "' and maintain.gotime between '" + dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") + "' AND '" +
                                    dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") + "') union select ticket as '派工單號', gno as '組別',cname as '社區名稱'," +
                                    " ano as '區碼', cno as '社區碼', cust as '用戶碼', name as '姓名', tel as '電話', cell as '手機', " +
                                    "gotime as '派工日期', finishtime as '結案日期', probrem as '報修事項', solution as '處理事項', meno2 as '工程', meno1 as '客服' from " +
                                    "maintain where (maintain.cname='" + CnameTable.Rows[0]["cname"].ToString() + "') and (meno2='" + txtEngNum.Text + "') and (gotime between '" +
                                    dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") + "' AND '" + dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") + "')";
                        SqlCommand comm = new SqlCommand(Cmscomm, CmsConnection);
                        SqlDataAdapter dataadapter = new SqlDataAdapter(Cmscomm, CmsConnection);
                        DataTable dtTable = new DataTable();
                        dtTable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                        dataadapter.Fill(dtTable);
                        lblDataListNum.Text = "共" + dtTable.Rows.Count + "筆";
                        //判斷查詢的日期若為同一天就用組別就排序，若不是同一天，則以派工日期做排序
                        if (dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") == dtpEnd.Value.ToString("yyyy-MM-dd 00:00:00"))
                        {
                            //依組別欄位做正向排序
                            dtTable.DefaultView.Sort = "組別 asc";
                            //先清空DataGridView內資料與格式
                            dgvShowData.Columns.Clear();
                            dgvShowData.DataSource = dtTable;
                            //將欄位0,10,14隱藏起來
                            dgvShowData.Columns[0].Visible = false;
                            dgvShowData.Columns[10].Visible = false;
                            //dgvShowData.Columns[13].Visible = false;
                            dgvShowData.Columns[14].Visible = false;
                            //dgvShowData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            dgvShowData.Columns[1].Width = 40;
                            dgvShowData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            dgvShowData.Columns[3].Width = 60;
                            dgvShowData.Columns[4].Width = 70;
                            dgvShowData.Columns[5].Width = 70;
                            dgvShowData.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            dgvShowData.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            dgvShowData.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            dgvShowData.Columns[9].Width = 120;
                            dgvShowData.Columns[10].Width = 80;
                            dgvShowData.Columns[11].Width = 350;
                            dgvShowData.Columns[12].Width = 350;
                            dgvShowData.Columns[13].Width = 70;
                            //dgvShowData.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            CmsConnection.Close();
                            //dtTable.Dispose();
                        }
                        else
                        {
                            dtTable.DefaultView.Sort = "派工日期 asc";
                            dgvShowData.Columns.Clear();
                            dgvShowData.DataSource = dtTable;
                            //將欄位0,10,14隱藏起來
                            dgvShowData.Columns[0].Visible = false;
                            dgvShowData.Columns[10].Visible = false;
                            //dgvShowData.Columns[13].Visible = false;
                            dgvShowData.Columns[14].Visible = false;
                            //dgvShowData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            dgvShowData.Columns[1].Width = 40;
                            dgvShowData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            dgvShowData.Columns[3].Width = 60;
                            dgvShowData.Columns[4].Width = 70;
                            dgvShowData.Columns[5].Width = 70;
                            dgvShowData.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            dgvShowData.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            dgvShowData.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            dgvShowData.Columns[9].Width = 120;
                            dgvShowData.Columns[10].Width = 80;
                            dgvShowData.Columns[11].Width = 350;
                            dgvShowData.Columns[12].Width = 350;
                            dgvShowData.Columns[13].Width = 70;
                            //dgvShowData.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            CmsConnection.Close();
                            //dtTable.Dispose();
                        }
                    }
                }
            }
            else if (chkCommunity.Checked == true & chkEngNum.Checked == false & chkSerNum.Checked == true)
            {
                if ((txtAreaNum.Text == "") | (txtCommunityNum.Text == "") | (txtSerNum.Text == ""))
                {
                    MessageBox.Show("區碼、社區碼、客服人員工號未輸入！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if ((txtAreaNum.Text.Length < 2) | (txtCommunityNum.Text.Length < 3) | (txtSerNum.Text.Length < 4))
                {
                    MessageBox.Show("區碼、社區碼、客服人員工號輸入不完整！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    string Cmscomm = "select cname from comm where ano='" + txtAreaNum.Text + "' and cno='" + txtCommunityNum.Text + "'";
                    SqlCommand cname = new SqlCommand(Cmscomm, CmsConnection);
                    SqlDataAdapter ReadCname = new SqlDataAdapter(Cmscomm, CmsConnection);
                    DataTable CnameTable = new DataTable();
                    ReadCname.Fill(CnameTable);
                    if (CnameTable.Rows.Count == 0)
                    {
                        MessageBox.Show("無此社區！", "注意", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        Cmscomm = "select maintain.ticket as '派工單號', maintain.gno as '組別', comm.cname as '社區名稱', custom.ano as '區碼', custom.cno as " +
                                    "'社區碼', custom.cust as '用戶碼', custom.name as '姓名', custom.tel as '電話', custom.cell as '手機', " +
                                    "maintain.gotime as '派工日期', maintain.finishtime as '結案日期', maintain.probrem as '報修事項', maintain.solution as '處理事項'," +
                                    " maintain.meno2 as '工程', maintain.meno1 as '客服' from comm, custom, maintain where (comm.ano = custom.ano" +
                                    " and custom.ano= maintain.ano and comm.cno=custom.cno and custom.cno = maintain.cno and custom.cust = " +
                                    "maintain.cust and maintain.ano='" + txtAreaNum.Text + "' and maintain.cno='" + txtCommunityNum.Text + "'" +
                                    " and maintain.meno1='" + txtSerNum.Text + "' and maintain.gotime between '" + dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") + "' AND '" +
                                    dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") + "') union select ticket as '派工單號', gno as '組別',cname as '社區名稱'," +
                                    " ano as '區碼', cno as '社區碼', cust as '用戶碼', name as '姓名', tel as '電話', cell as '手機', " +
                                    "gotime as '派工日期', finishtime, probrem as '報修事項', solution as '處理事項', meno2 as '工程', meno1 as '客服' from " +
                                    "maintain where (maintain.cname='" + CnameTable.Rows[0]["cname"].ToString() + "') and (meno1='" + txtSerNum.Text + "') and (gotime between '" +
                                    dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") + "' AND '" + dtpEnd.Value.ToString("yyyy-MM-dd 23:59:59") + "')";
                        SqlCommand comm = new SqlCommand(Cmscomm, CmsConnection);
                        SqlDataAdapter dataadapter = new SqlDataAdapter(Cmscomm, CmsConnection);
                        DataTable dtTable = new DataTable();
                        dtTable.Locale = System.Globalization.CultureInfo.InvariantCulture;
                        dataadapter.Fill(dtTable);
                        lblDataListNum.Text = "共" + dtTable.Rows.Count + "筆";
                        //判斷查詢的日期若為同一天就用組別就排序，若不是同一天，則以派工日期做排序
                        if (dtpStart.Value.ToString("yyyy-MM-dd 00:00:00") == dtpEnd.Value.ToString("yyyy-MM-dd 00:00:00"))
                        {
                            //依組別欄位做正向排序
                            dtTable.DefaultView.Sort = "組別 asc";
                            //先清空DataGridView內資料與格式
                            dgvShowData.Columns.Clear();
                            dgvShowData.DataSource = dtTable;
                            //將欄位0,10,13隱藏起來
                            dgvShowData.Columns[0].Visible = false;
                            dgvShowData.Columns[10].Visible = false;
                            dgvShowData.Columns[13].Visible = false;
                            //dgvShowData.Columns[14].Visible = false;
                            //dgvShowData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            dgvShowData.Columns[1].Width = 40;
                            dgvShowData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            dgvShowData.Columns[3].Width = 60;
                            dgvShowData.Columns[4].Width = 70;
                            dgvShowData.Columns[5].Width = 70;
                            dgvShowData.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            dgvShowData.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            dgvShowData.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            dgvShowData.Columns[9].Width = 120;
                            dgvShowData.Columns[10].Width = 80;
                            dgvShowData.Columns[11].Width = 350;
                            dgvShowData.Columns[12].Width = 350;
                            //dgvShowData.Columns[13].Width = 70;
                            dgvShowData.Columns[14].Width = 70;
                            CmsConnection.Close();
                            //dtTable.Dispose();
                        }
                        else
                        {
                            dtTable.DefaultView.Sort = "派工日期 asc";
                            dgvShowData.Columns.Clear();
                            dgvShowData.DataSource = dtTable;
                            //將欄位0,10,13隱藏起來
                            dgvShowData.Columns[0].Visible = false;
                            dgvShowData.Columns[10].Visible = false;
                            dgvShowData.Columns[13].Visible = false;
                            //dgvShowData.Columns[14].Visible = false;
                            //dgvShowData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            dgvShowData.Columns[1].Width = 40;
                            dgvShowData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            dgvShowData.Columns[3].Width = 60;
                            dgvShowData.Columns[4].Width = 70;
                            dgvShowData.Columns[5].Width = 70;
                            dgvShowData.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            dgvShowData.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            dgvShowData.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                            dgvShowData.Columns[9].Width = 120;
                            dgvShowData.Columns[10].Width = 80;
                            dgvShowData.Columns[11].Width = 350;
                            dgvShowData.Columns[12].Width = 350;
                            //dgvShowData.Columns[13].Width = 70;
                            dgvShowData.Columns[14].Width = 70;
                            CmsConnection.Close();
                            //dtTable.Dispose();
                        }
                    }
                }
            }
            else if (chkCommunity.Checked == true & chkEngNum.Checked == true & chkSerNum.Checked == true)
            {
                MessageBox.Show("不可同時以三個為條件！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chkCommunity.Checked = false;
                chkEngNum.Checked = false;
                chkSerNum.Checked = false;
                txtAreaNum.Text = "";
                txtCommunityNum.Text = "";
                txtEngNum.Text = "";
                txtSerNum.Text = "";
            }
            else if (chkCommunity.Checked == false & chkEngNum.Checked == true & chkSerNum.Checked == true)
            {
                MessageBox.Show("不可同時以工程人員和客服人員為條件！", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                chkCommunity.Checked = false;
                chkEngNum.Checked = false;
                chkSerNum.Checked = false;
                txtAreaNum.Text = "";
                txtCommunityNum.Text = "";
                txtEngNum.Text = "";
                txtSerNum.Text = "";
            }
        }

        //當點選DataGridView資料列時，秀出該筆資料列的相關資訊
        private void dgvShowData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //取出DataGridView第0欄位的值
            lblOddNumShow.Text = dgvShowData.CurrentRow.Cells[0].Value.ToString();
            //透過用DataGridView隱藏起來的工號欄位來查詢員工姓名，再秀在對應的Label
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

        //將DataGridView滙出至Excel
        private void btnToExcel_Click(object sender, EventArgs e)
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
