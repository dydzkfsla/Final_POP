using POPDisplay.ControlUser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POPDisplay.BaseForm
{
    public partial class ShowListForm : POPDisplay.BaseForm.BaseForm
    {
        public ShowListForm()
        {
            InitializeComponent();
        }

        private void panel2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void ShowListForm_Load(object sender, EventArgs e)
        {
            rbn_Asc.Checkevent += RadioClick;
            rbn_Desc.Checkevent += RadioClick;
        }

        private void RadioClick(object sender, EventArgs e)
        {
            RadioBtn rb = (RadioBtn)sender;

            if (rb.thisCheck)
            {
                rb.thisPic.Image = Properties.Resources.NoneCheck;
                rb.thisCheck = false;
            }
            else
            {
                rb.thisPic.Image = Properties.Resources.CheckBtn;
                rb.thisCheck = true;

                CommonUtil.ControlAction<Panel, RadioBtn>(pnl_Sort, (item) =>
                {
                    if (item != rb)
                    {
                        item.thisCheck = false;
                        item.thisPic.Image = Properties.Resources.NoneCheck;
                    }
                });
            }
        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
