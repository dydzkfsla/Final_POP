using POPDisplay.PopUp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POPDisplay.MainForm
{
    public partial class WorkOrderList : POPDisplay.BaseForm.BaseForm
    {
        public WorkOrderList()
        {
            InitializeComponent();
        }

        private void btn_PcsStart_Click(object sender, EventArgs e)
        {
            PcsStateForm frm = new PcsStateForm();
            frm.Show();
        }
    }
}
