using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magical_Management_System
{
    public partial class SelectTask : Form
    {
        public SelectTask()
        {
            InitializeComponent();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            if(rdoTask.Checked==true | rdoNonCommission.Checked==true)
            {
                NewTask newtask = new NewTask();
                newtask.Show();
                newtask.Visible = false;
                this.Hide();
                if(newtask.ShowDialog()==DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
