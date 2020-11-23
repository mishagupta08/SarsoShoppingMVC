using System;
using System.Configuration;
using System.Globalization;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Text;

namespace SarsoBizServices
{
    // NOTE: If you change the class name "Utilities" here, you must also update the reference to "Utilities" in Web.config.
    public class Utilities : IUtilities
    {
        public string AutoGenerateId()
        {
            var rand = new Random((int)DateTime.Now.Ticks);
            int randomNum = rand.Next(999);
            string acctnum = randomNum.ToString(CultureInfo.InvariantCulture);
            if (acctnum.Length < 3)
            {
                acctnum = acctnum.PadLeft(3, '0');
            }
            return acctnum;
        }

        public string MoneyinWords(decimal v)
        {
            if (v == 0) return "zero";
            var units = "|one|two|three|four|five|six|seven|eight|nine".Split('|');
            var teens = "|eleven|twelve|thir#|four#|fif#|six#|seven#|eigh#|nine#".Replace("#", "teen").Split('|');
            var tens = "|ten|twenty|thirty|forty|fifty|sixty|seventy|eighty|ninety".Split('|');
            var thou = "|thousand|m#|b#|tr#|quadr#|quint#|sex#|sept#|oct#".Replace("#", "illion").Split('|');
            var g = (v < 0) ? "minus " : "";
            var w = "";
            var p = 0;
            v = Math.Abs(v);
            while (v > 0)
            {
                var b = (int)(v % 1000);
                if (b > 0)
                {
                    var h = (b / 100);
                    var t = (b - h * 100) / 10;
                    var u = (b - h * 100 - t * 10);
                    var s = ((h > 0) ? units[h] + " hundred" + ((t > 0 | u > 0) ? " and " : "") : "") + ((t > 0) ? (t == 1 && u > 0) ? teens[u] : tens[t] + ((u > 0) ? "-" : "") : "") + ((t != 1) ? units[u] : ""); s = (((v > 1000) && (h == 0) && (p == 0)) ? " and " : (v > 1000) ? ", " : "") + s; w = s + " " + thou[p] + w;
                } v = v / 1000; p++;
            }
            return g + w;
        }

        public string Encrypt(string toEncrypt)
        {
            byte[] keyArray;
            byte[] toEncryptArray = Encoding.UTF8.GetBytes(toEncrypt);
            var settingsReader = new AppSettingsReader();
            var key = (string)settingsReader.GetValue("SarsoBiz", typeof(String));
            {
                var hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(key));
                hashmd5.Clear();
            }
            var tdes = new TripleDESCryptoServiceProvider
                {
                    Key = keyArray,
                    Mode = CipherMode.ECB,
                    Padding = PaddingMode.PKCS7
                };
            var cTransform = tdes.CreateEncryptor();
            byte[] resultArray =
              cTransform.TransformFinalBlock(toEncryptArray, 0, toEncryptArray.Length);
            tdes.Clear();
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }
        public string Decrypt(string cipherString)
        {
            try
            {
                cipherString = cipherString.Replace(' ', '+');
                byte[] keyArray;
                byte[] toEncryptArray = Convert.FromBase64String(cipherString);
                var settingsReader = new AppSettingsReader();
                var key = (string)settingsReader.GetValue("SarsoBiz", typeof(String));
                {
                    var hashmd5 = new MD5CryptoServiceProvider();
                    keyArray = hashmd5.ComputeHash(Encoding.UTF8.GetBytes(key));
                    hashmd5.Clear();
                }
                var tdes = new TripleDESCryptoServiceProvider
                    {
                        Key = keyArray,
                        Mode = CipherMode.ECB,
                        Padding = PaddingMode.PKCS7
                    };
                var cTransform = tdes.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(
                    toEncryptArray, 0, toEncryptArray.Length);
                tdes.Clear();
                return Encoding.UTF8.GetString(resultArray);
            }
            catch (Exception )
            {
                return "";
            }
        }
        public void SendErrorMail(string subject, string strBody)
        {
           
        }
       
        public void SendMail(String strMailTo, string subject, string strBody)
        {
            
        }
        public static string CreatedUrl;
        public static string OzSurl;
        public static string Username;
        public static string Password;
        public static string Type;
        public static string Dlr;
        public static string To;
        public static string Source;
        public static string Sender;
        public static string Unicodes;
        public static string versions;
        public static string OzCdmasender;
        public int SmsThroughGateWay(string mobiles, string message)
        {
            try
            {
                // Mobiles = "91" + Mobiles;
                //we creating the necessary URL string:
                OzSurl = "http://mysms.versatileitsolution.com/submitsms.jsp?"; //where Ozeki NG SMS Gateway is running
                //string ozSPort = "9501"; //port number where Ozeki NG SMS Gateway is listening
                Username = "SarsoTrn"; //username for successful login
                Password = "ce41381891XX";
                Sender = "SARSOB";
                To = mobiles;
                Unicodes = "1";
                CreatedUrl = OzSurl +
                             "user=" + Username +
                             "&key=" + Password +
                             "&senderid=" + Sender +
                             "&mobile=" + To +
                             "&message=" + message +
                             "&accusage=" + Unicodes;                           

                //Create the request and send data to SMS Gateway Server by HTTP connection
                var myReq = (HttpWebRequest)WebRequest.Create(CreatedUrl);

                ////Get response from Ozeki NG SMS Gateway Server and read the answer
                var myResp = (HttpWebResponse)myReq.GetResponse();
                var respStreamReader = new System.IO.StreamReader(myResp.GetResponseStream());
                // var responseString = respStreamReader.ReadToEnd();
                respStreamReader.Close();
                myResp.Close();
                return 1;
            }
            catch (Exception)
            {

                return 0;
            }

        }
    }
}
