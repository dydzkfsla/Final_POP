using log4net;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using VO;
using WebAPI.Global;

namespace WebAPI.DAC
{
    public class ViewDAC
    {
        ILog log = null;

        public ViewDAC() { }

        public List<TeamInfoVO> GetTeamFormEmp(string EmpCode)
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = new SqlConnection(ConnString.strConn);
                    cmd.CommandText = "select Team_Code, Team_Name, Team_Chief, Team_Part from View_EmpForTeam where Emp_Code = @Emp_Code";
                    cmd.Parameters.AddWithValue("@Emp_Code", EmpCode);
                    cmd.Connection.Open();
                    List<TeamInfoVO> list = Helper.DataReaderMapToList<TeamInfoVO>(cmd.ExecuteReader());
                    cmd.Connection.Close();

                    return list;
                }
            }
            catch (Exception err)
            {
                Debug.WriteLine(err.Message);
                return null;
            }
        }
    }
}