using DevExpress.XtraReports.UI;
using POPWareHouse.MainForm;
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

namespace POPWareHouse.MDI
{
    public partial class MDIForm : Form
    {
        List<View_WareHouseDetailVO> WareHouseDetail = null;
        public View_ContractVO selectVo { get; set; }
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

        private void btn_WareHouseIn_Click(object sender, EventArgs e)
        {
            WareHouseDetail open = new WareHouseDetail(WareHouseDetail);
            this.OpenCreateForm(open, true);
            open.Dock = DockStyle.Fill;
        }

        private async void MDIForm_Load(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            string UrlApi = Global.Global.APIAddress + "/WareHouse/detail/" + "WH_0301";
            HttpResponseMessage rm = await client.GetAsync(UrlApi);
            if (rm.IsSuccessStatusCode)
            {
                string result = await rm.Content.ReadAsStringAsync();
                JavaScriptSerializer jss = new JavaScriptSerializer();
                ApiMessage<List<View_WareHouseDetailVO>> apiMessage = jss.Deserialize<ApiMessage<List<View_WareHouseDetailVO>>>(result);

                if (apiMessage.ResultCode == "S")
                {
                    WareHouseDetail = apiMessage.Data;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrdersForm open = new OrdersForm();
            this.OpenCreateForm(open, true);
            open.Dock = DockStyle.Fill;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (selectVo == null)
                return;
            HttpClient client = new HttpClient();
            string UrlApi = Global.Global.APIAddress + "/Orders/GetOrder/Code/" + selectVo.Contract_Code.ToString();
            HttpResponseMessage rm = await client.GetAsync(UrlApi);

            if (rm.IsSuccessStatusCode)
            {
                string result = await rm.Content.ReadAsStringAsync();
                JavaScriptSerializer jss = new JavaScriptSerializer();
                ApiMessage<List<View_ContractVO>> apiMessage = jss.Deserialize<ApiMessage<List<View_ContractVO>>>(result);

                if (apiMessage.ResultCode == "S")
                {
                    XtraReport1 rpt = new XtraReport1();
                    rpt.DataSource = apiMessage.Data.ConvertToDataTable();

                    using (ReportPrintTool printTool = new ReportPrintTool(rpt))
                    {
                        printTool.ShowPreviewDialog();
                    }
                }
            }

           
        }
    }
}
