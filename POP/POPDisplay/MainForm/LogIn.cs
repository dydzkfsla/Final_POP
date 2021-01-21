using DAC;
using log4net;
using POPDisplay.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POPDisplay.MainForm
{
    public partial class LogIn : Form
    {
        bool thisMax = false;
        Size fstSize;
        ILog log = log4net.LogManager.GetLogger(typeof(LogIn));

        public LogIn()
        {
            InitializeComponent();
        }

        private void pic_MinSizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pic_MaxSizeBtn_Click(object sender, EventArgs e)
        {
            if (!thisMax)
            {
                fstSize = this.Size;
                this.WindowState = FormWindowState.Maximized;
                thisMax = true;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.Size = fstSize;
                thisMax = false;
            }
        }

        private void pic_CancleBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 폼옮기기및 사이즈조절
        protected override void WndProc(ref Message m)
        {
            const int RESIZE_HANDLE_SIZE = 10;
            switch (m.Msg)
            {
                case 0x0084/*NCHITTEST*/ :
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x01/*HTCLIENT*/)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = this.PointToClient(screenPoint);
                        if (clientPoint.Y <= RESIZE_HANDLE_SIZE)
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)13/*HTTOPLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)12/*HTTOP*/ ;
                            else
                                m.Result = (IntPtr)14/*HTTOPRIGHT*/ ;
                        }
                        else if (clientPoint.Y <= (Size.Height - RESIZE_HANDLE_SIZE))
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)10/*HTLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)2/*HTCAPTION*/ ;
                            else
                                m.Result = (IntPtr)11/*HTRIGHT*/ ;
                        }
                        else
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)16/*HTBOTTOMLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)15/*HTBOTTOM*/ ;
                            else
                                m.Result = (IntPtr)17/*HTBOTTOMRIGHT*/ ;
                        }
                    }
                    return;
            }
            base.WndProc(ref m);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- use 0x20000
                return cp;
            }
        }

        #endregion

        private void LogIn_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 221, 85);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            EmployeeService service = new EmployeeService(log);
            bool result = service.LoginCheck(txt_ID.Text);

            if(result)
            {
                MainMenu main = new MainMenu();
                main.Show();
            }
            else
            {
                MessageBox.Show("로그인실패");
            }

        }
    }
}
