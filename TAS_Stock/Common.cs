using Microsoft.Reporting.WinForms;
using System;
using System.Configuration;

namespace TAS_Stock
{
    public class Common
    {
        public static string GetRandomString()
        {
            var guid = Guid.NewGuid().ToString();
            return guid.ToString();
        }
        public static void DynamicNameAndAddress(ReportViewer rpt)
        {
            try
            {
                string schoolName = ConfigurationManager.AppSettings["SchoolNAME"].ToString();
                string SchoolAddress = ConfigurationManager.AppSettings["SchoolAddress"].ToString();
                ReportParameter[] param = new ReportParameter[2];
                param[0] = new ReportParameter("SchoolName", schoolName);
                 param[1] = new ReportParameter("SchoolAddress", SchoolAddress);
                rpt.LocalReport.SetParameters(param);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
