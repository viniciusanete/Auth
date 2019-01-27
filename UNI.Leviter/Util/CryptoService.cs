using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace UNI.Leviter.Util
{
    public class CryptoService
    {
        public static string CryptoPassword(string text)
        {
            try
            {
                byte[] buffer = Encoding.Default.GetBytes(text);
                System.Security.Cryptography.SHA1CryptoServiceProvider cryptoTransformSHA1 = new System.Security.Cryptography.SHA1CryptoServiceProvider();
                string hash = BitConverter.ToString(cryptoTransformSHA1.ComputeHash(buffer)).Replace("-", "");
                return hash;
            }
            catch (Exception x)
            {
                throw new Exception(x.Message);
            }
        }
    }
}