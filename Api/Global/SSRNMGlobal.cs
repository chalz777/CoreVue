using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace SSRNM.Global
{
    public class SSRNMGlobal
    {
        public string FileFolder { get; set; }
        public string Report { get; set; }
        public string Unclassified { get; set; }
        public string SecuredXml { get; set; }
        public string Pmo { get; set; }
        public string Excel { get; set; }
        public string Pdf { get; set; }

        //public static string file_folder = Configuration["FileFolder"].ToString();
        //public static string report = Configuration["Report"].ToString();
        //public static string unclassified = System.Configuration. ConfigurationManager.AppSettings["Unclassified"].ToString();
        //public static string securedXml = Configuration["SecuredXML"].ToString();
        //public static string pmo = Configuration["PMO"].ToString();
        //public static string excel = Configuration["Excel"].ToString();
        //public static string pdf = Configuration["Pdf"].ToString();

    }
}