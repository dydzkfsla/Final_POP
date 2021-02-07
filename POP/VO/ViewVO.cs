using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VO
{
    public class SP_WorkOrderSherchTeamVO
    {
        public string WO_Code { get; set; }
        public string WO_CodeName { get; set; }
        public string Prod_Name { get; set; }
        public string Team_Name { get; set; }
        public string WO_WorkTimeName { get; set; }
        public int WO_EstimatedQuantity { get; set; }
        public int WO_OrderQuantity { get; set; }
        public int WO_TactTime { get; set; }
        public DateTime WO_EstimatedEnd { get; set; }
        public int WO_Priority { get; set; }
        public string WO_WorkTime { get; set; }
        public string WO_State { get; set; }
        public string Prod_Code { get; set; }
        public string Fac_Code { get; set; }
        public string Team_Code { get; set; }
    }

    public class View_ProcessForProductVO
    {
        public string Pcs_Name { get; set; }
        public string PcsD_Code { get; set; }
        public string PcsD_Name { get; set; }
    }
}
