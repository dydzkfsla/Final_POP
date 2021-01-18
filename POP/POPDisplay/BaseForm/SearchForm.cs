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
    public partial class SearchForm : POPDisplay.BaseForm.BaseForm
    {
        public SearchForm()
        {
            InitializeComponent();
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            rbn_Asc.Checkevent += RadioClick;
            rbn_Desc.Checkevent += RadioClick;
        }

        private void RadioClick(object sender, EventArgs e)
        {
            RadioBtn rb = (RadioBtn)sender;

            if(rb.thisCheck)
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
    }
}
