using POPDisplay.MainForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VO;

namespace POPWareHouse.MDI
{
    public partial class MDIForm : Form
    {

        public MDIForm()
        {
            InitializeComponent();
        }


        #region 닫기버튼
        private void pcb_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region 닫는중 로그인 폼 띄워줌
        private void MDIForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
        #endregion

        #region 최소화
        private void pcb_Minmax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion
    }
}
