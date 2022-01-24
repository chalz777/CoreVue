using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;


namespace Core.Global
{
    
    public class Globals
    {   
        public Globals()
        {        
        }

        public string MyCustomKey { get; set; }
        public string ServerUrl { get; set; }
        public string SecureServerUrl { get; set; }
        public string TempFolder { get; set; }
        public string WriteToLog { get; set; }
        public string LogPath { get; set; }
        public string LocalDomain { get; set; }
        public string AdminEmail { get; set; }
        public string EmailSendFrom { get; set; }
        public string ContactEmail { get; set; }

    //public static string gHelpDeskEmail = ConfigurationManager.AppSettings.Get("HelpDeskEmail");
    //public static string gHelpDeskPhoneNumber = ConfigurationManager.AppSettings.Get("HelpDeskPhoneNumber");
    //public static string gHelpDeskName = ConfigurationManager.AppSettings.Get("HelpDeskName");
    //public static string gServerUrl = ConfigurationManager.AppSettings.Get("ServerUrl");
    //public static string gSecureServerUrl = ConfigurationManager.AppSettings.Get("SecureServerUrl");

    //public static bool gUseDeveloperAuth = Convert.ToBoolean(ConfigurationManager.AppSettings.Get("UseDeveloperAuth"));
    //public static string gDeveloperEdipi = ConfigurationManager.AppSettings.Get("DeveloperEdipi");
    //public static string gMachineType = ConfigurationManager.AppSettings.Get("MachineType");

    //public static string gEmailService = ConfigurationManager.AppSettings.Get("EmailService");
    //public static string gTestEmailAddress = ConfigurationManager.AppSettings.Get("TestEmailAddress");

    //public static string gSMTPServer1 = ConfigurationManager.AppSettings.Get("SMTPServer1");
    //public static string gSMTPServer2 = ConfigurationManager.AppSettings.Get("SMTPServer2");
    //public static bool gSendMail = Convert.ToBoolean(ConfigurationManager.AppSettings.Get("SendMail"));
    //public static string gErrorEmail = ConfigurationManager.AppSettings.Get("ErrorEmail");

    //public static string gEnvEmailPrefix = ConfigurationManager.AppSettings.Get("EnvEmailPrefix");
    //public static string gEmailFrom = ConfigurationManager.AppSettings.Get("EmailFrom");
    //public static bool gSendCopy = Convert.ToBoolean(ConfigurationManager.AppSettings.Get("SendCopy"));
    //public static string gCopyAddress = ConfigurationManager.AppSettings.Get("CopyAddress");

    //// Email / Notification defaults
    ////public static bool gUseInternalMailServer = Convert.ToBoolean(ConfigurationManager.AppSettings.Get("UseInternalMailServer"));
    ////public static string gSMTPServerInternal = ConfigurationManager.AppSettings.Get("SMTPServerInternal");
    ////public static string gSMTPServerExternal = ConfigurationManager.AppSettings.Get("SMTPServerExternal");
    ////public static int gSMTPServerPort = Int32.Parse(ConfigurationManager.AppSettings.Get("SMTPServerPort"));
    ////public static string gSMTPServerUsername = ConfigurationManager.AppSettings.Get("SMTPServerUsername");
    ////public static string gSMTPServerPassword = ConfigurationManager.AppSettings.Get("SMTPServerPassword");      

    //// Other
    //public static bool gDebugMode = Convert.ToBoolean(ConfigurationManager.AppSettings.Get("DebugMode"));
    //public static bool gEmailEnabled = Convert.ToBoolean(ConfigurationManager.AppSettings.Get("EmailEnabled"));



    /// <summary>
    /// Format the uri into a root relative url
    /// </summary>
    //public static string gRootRelativeURL(string path)
    //{
    //    string rootRelativeUrl = "";

    //    try
    //    {
    //        rootRelativeUrl = gSiteUrl + path;
    //    }
    //    catch
    //    {
    //    }

    //    return rootRelativeUrl;
    //}

    ///// <summary>
    ///// Format the uri into a secure root relative url
    ///// </summary>
    //public static string gRootRelativeSecureURL(string path)
    //{
    //    string rootRelativeSecureUrl = "";

    //    try
    //    {
    //        rootRelativeSecureUrl = gSiteSecureUrl + path;
    //    }
    //    catch
    //    {
    //    }

    //    return rootRelativeSecureUrl;
    //}



}
}
