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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            tmrNowDateTime.Enabled = true;
        }

        //判斷傳入的視窗名稱(WindowName)是否已存在於[MdiChildren]陣列中
        //若已存在則表示已開啟，將該子視窗帶到到最上層，並傳回false，否則傳回true
        private bool CheckOpenWindow(String windowName)
        {
            bool result = true;
            for (int i = 0; i < MdiChildren.Length; i++)
            {
                if (MdiChildren[i].Name == windowName)
                {
                    MdiChildren[i].BringToFront();
                    result = false;
                }
            }
            return result;
        }

        private void 結束程式ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tmrNowDateTime_Tick(object sender, EventArgs e)
        {
            DateTime DT_now = DateTime.Now;
            tslblDateTimeShow.Text = DT_now.ToString("yyyy-MM-dd (ddd) tt hh:mm:ss");
        }

        private void 用戶抽獎ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckOpenWindow("Lottery"))
            {
                Lottery lottery = new Lottery();
                lottery.Name = "Lottery";
                lottery.MdiParent = this;
                lottery.Show();
            }
        }

        private void 派工單查詢ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckOpenWindow("InquiryTools"))
            {
                InquiryTools inquirytools = new InquiryTools();
                inquirytools.Name = "InquiryTools";
                inquirytools.MdiParent = this;
                inquirytools.Show();
            }
        }

        private void 續約戶查詢ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckOpenWindow("Replenish"))
            {
                Replenish replenish = new Replenish();
                replenish.Name = "Replenish";
                replenish.MdiParent = this;
                replenish.Show();
            }
        }

        private void 未續約戶查詢ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CheckOpenWindow("NoReplenish"))
            {
                NoReplenish noreplenish = new NoReplenish();
                noreplenish.Name = "NoReplenish";
                noreplenish.MdiParent = this;
                noreplenish.Show();
            }
        }

        private void 退租戶查詢ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(CheckOpenWindow("Discontinue"))
            {
                Discontinue discontinue = new Discontinue();
                discontinue.Name = "Discontinue";
                discontinue.MdiParent = this;
                discontinue.Show();
            }
        }

        private void 復機戶查詢ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(CheckOpenWindow("Repeat"))
            {
                Repeat repeat = new Repeat();
                repeat.Name = "Repeat";
                repeat.MdiParent = this;
                repeat.Show();
            }
        }

        private void 用戶資料查詢ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(CheckOpenWindow("InquireUser"))
            {
                InquireUser inquireuser = new InquireUser();
                inquireuser.Name = "InquireUser";
                inquireuser.MdiParent = this;
                inquireuser.Show();
            }
        }

        private void 派工ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(CheckOpenWindow("Task"))
            {
                Task task = new Task();
                task.Name = "Task";
                task.MdiParent = this;
                task.Show();
            }
        }

        private void 快到期用戶查詢ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(CheckOpenWindow("EndDateRefer"))
            {
                EndDateRefer edr = new EndDateRefer();
                edr.Name = "EndDateRefer";
                edr.MdiParent = this;
                edr.Show();
            }
        }
    }
}
