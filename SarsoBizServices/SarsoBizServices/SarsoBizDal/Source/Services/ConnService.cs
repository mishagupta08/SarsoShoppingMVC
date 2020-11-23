//-----------------------------------------------------------------------
// <copyright file="ConnService.cs" company="SmartSoft">
//     Copyright (c) SmartSoft. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------
// ReSharper disable CheckNamespace

using System.Security.Cryptography;
using System.Text;

namespace SarsoBizDal
// ReSharper restore CheckNamespace
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;

    /// <summary>
    /// <c>User Service is a Class inherted by IUserService interface</c>
    /// </summary>
    public class ConnService : IConnService
    {
        #region Field(s)
        /// <summary>
        /// Store the key and connection string
        /// </summary>
        private readonly IDictionary<string, ObjectCache<SsConnection>> _ssconnections;

        /// <summary>
        /// Store the lock the object
        /// </summary>
        private readonly Object _sslock = new Object();
        #endregion Field(s)

        #region Constructor(s)

        /// <summary>
        /// Initializes a new instance of the <see>
        ///                                       <cref>ObjectCache</cref>
        ///                                   </see>
        ///     class.
        /// </summary>
        public ConnService()
        {
            _ssconnections = new Dictionary<string, ObjectCache<SsConnection>>();
        }
        #endregion Constructor(s)

        #region User Settings
        /// <summary>
        /// Get the client connection string
        /// </summary>
        /// <param name="environment"><c>environment is either dev, stag or prod</c></param>
        /// <returns><c>returns SsConnection object</c></returns>
        public SsConnection GetClientConnection(string environment)
        {
            string keyValue = string.Format("{0}",  environment);
            if (!(_ssconnections.ContainsKey(keyValue) && !_ssconnections[keyValue].IsExpired()))
            {
                lock (_sslock)
                {
                    if (!(_ssconnections.ContainsKey(keyValue) && !_ssconnections[keyValue].IsExpired()))
                    {
                        if (_ssconnections.ContainsKey(keyValue))
                        {
                            _ssconnections.Remove(keyValue);
                        }

                        _ssconnections.Add(keyValue, new ObjectCache<SsConnection>(new SsConnection(GetConnectionString(environment))));
                    }
                }
            }

            SsConnection result = _ssconnections[keyValue].ObjectItem;
            return result;
        }

        /// <summary>
        /// Get the connection string
        /// </summary>
        /// <returns>returns connection string</returns>
        //internal static string GetConString()
        //{
        //    string strConfigConnection = ConfigurationManager.AppSettings["ConfigConnection"];
        //    return strConfigConnection;
        //}

        /// <summary>
        /// Get the connection string based on environment
        /// </summary>
        /// <param name="environment"><c>environment is either dev, stag or prod</c></param>
        /// <returns>returns connection string</returns>
        protected string GetConnectionString(string environment)
        {
            string strConfigConnection= string.Empty;

            if (environment.ToUpper().Equals("DEV"))
            {
                strConfigConnection = Decrypt(ConfigurationManager.AppSettings["ConnectionStringDev"]);
            }
            else if (environment.ToUpper().Equals("STAG"))
            {
                strConfigConnection = Decrypt(ConfigurationManager.AppSettings["ConnectionStringStag"]);
            }
            else if (environment.ToUpper().Equals("PROD"))
            {
                strConfigConnection = Decrypt(ConfigurationManager.AppSettings["ConnectionStringProd"]);
            } 
            return strConfigConnection;
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
            catch (Exception ex)
            {
                return "";
            }
        }
        #endregion
    }
}
