using log4net;
using POPDisplay.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using VO;

namespace POPDisplay.MainForm
{
    public partial class LogIn : Form
    {
        HttpClient client;
        private static readonly ILog log = LogManager.GetLogger(typeof(LogIn));
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            lbl_ID.BackColor = Color.FromArgb(255, 221, 85);
        }

        private async void btn_Login_Click(object sender, EventArgs e)
        {
            client = new HttpClient();
            string UrlApi = Global.Global.APIAddress + "Employees/" + txt_ID.Text;
            HttpResponseMessage rm = await client.GetAsync(UrlApi);
            if (rm.IsSuccessStatusCode)
            {
                string result = await rm.Content.ReadAsStringAsync();
                JavaScriptSerializer jss = new JavaScriptSerializer();
                ApiMessage<EmployeesVO> apiMessage = jss.Deserialize<ApiMessage<EmployeesVO>>(result);

                if(apiMessage.ResultCode == "S")
                {
                    ProcessListForm frm = new ProcessListForm();
                    if (frm.ShowDialog() == DialogResult.Cancel)
                    {
                        this.Activate();
                    }
                }
            }
        }
    }
}
