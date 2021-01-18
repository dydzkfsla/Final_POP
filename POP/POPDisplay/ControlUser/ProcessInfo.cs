using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POPDisplay.ControlUser
{
    public partial class ProcessInfo : UserControl
    {
        double TotTactTime = 0;
        Color _back = new Color(); // 폼의 백그라운드컬러
        public PictureBox PcsPic { get { return pic_PcsImg; } }
        public string PcsName { get { return lbl_PcsName.Text; } set { lbl_PcsName.Text = value; } }
        public string PcsCode { get { return lbl_PcsName.Tag.ToString(); } set { lbl_PcsName.Tag = value; } }
        public double PcsPer { get { return TotTactTime; } set { TotTactTime = value; } }
        public Color FrmBack { get { return _back; } set { _back = value; } }


        public ProcessInfo()
        {
            InitializeComponent();
        }

        private void ProcessInfo_Load(object sender, EventArgs e)
        {
            _back = this.BackColor;
        }

        private void tmr_TactTime_Tick(object sender, EventArgs e)
        {

        }
    }
}
