using DAC;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POPDisplay.Service
{
    class EmployeeService
    {
        ILog log = null;

        public EmployeeService(ILog log)
        {
            this.log = log;
        }

        internal bool LoginCheck(string text)
        {
            EmployeeDAC dac = new EmployeeDAC(log);
            bool result = dac.LoginCheck(text);
            dac.Dispose();
            return result;
        }
    }
}
