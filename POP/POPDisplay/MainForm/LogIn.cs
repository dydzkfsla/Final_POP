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

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace POPDisplay.MainForm
{
    public partial class LogIn : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(LogIn));
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            lbl_ID.BackColor = Color.FromArgb(255, 221, 85);
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            EmployeeService service = new EmployeeService(log);
            bool result = service.LoginCheck(txt_ID.Text);

            if(result)
            {
                this.Hide();
                ProcessListForm frm = new ProcessListForm();
                if(frm.ShowDialog() == DialogResult.Cancel)
                {
                    this.Activate();
                }
            }
        }
    }
}
