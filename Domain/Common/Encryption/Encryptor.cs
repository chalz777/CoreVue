namespace Web.Security.Encryption
{
    using Microsoft.AspNetCore.DataProtection;
    using System;
    using System.Text;
    using System.Web;

    public class Encryptor
    {
        private static IDataProtector _dataProtector;

        public Encryptor(IDataProtector dataProtector)
        {
            _dataProtector = dataProtector.CreateProtector("some-key"); // todo: revise the key.
        }

        public static string Protect(string txt, bool urlEncode = true)
        {
            if (string.IsNullOrEmpty(txt))
            {
                return txt;
            }
            else
            {
               
                byte[] stream = Encoding.UTF8.GetBytes(txt);
                return urlEncode ? HttpUtility.UrlEncode(_dataProtector.Protect(stream))
                    : Convert.ToBase64String(_dataProtector.Protect(stream));
            }
        }

        public static string Unprotect(string txt, bool urlEncoded = true)
        {
            if (string.IsNullOrEmpty(txt))
            {
                return txt;
            }
            else
            {
                byte[] stream = urlEncoded ? HttpUtility.UrlDecodeToBytes(txt) : Convert.FromBase64String(txt);
                return Encoding.UTF8.GetString(_dataProtector.Unprotect(stream));
            }
        }

        public static byte[] UnprotectAsBytes(string txt)
        {
            if (string.IsNullOrEmpty(txt))
            {
                return new byte[0];
            }
            else
            {
                return _dataProtector.Unprotect(Convert.FromBase64String(txt));
            }
        }

        public static byte[] Protect(byte[] bytes)
        {
            return _dataProtector.Protect(bytes);
        }

        public static string Unprotect(byte[] bytes)
        {
            return Encoding.UTF8.GetString(_dataProtector.Unprotect(bytes));
        }
    }
}
