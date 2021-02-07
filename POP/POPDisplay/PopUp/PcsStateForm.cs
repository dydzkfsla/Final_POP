using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace POPDisplay.PopUp
{
    public partial class PcsStateForm : POPDisplay.POPUpBase.POPBaseForm
    {
        bool detailShow = false;

        public PcsStateForm()
        {
            InitializeComponent();
        }

        private void btn_ShowDetail_Click(object sender, EventArgs e)
        {
            if(detailShow)
            {
                detailShow = false;
                this.Size = new Size(1035, 1021);
                panel1.Size = new Size(994, 908);

            }else
            {
                detailShow = true;
                this.Size = new Size(1705, 1021);
                panel1.Size = new Size(1667, 908);
            }
        }
    }
}
