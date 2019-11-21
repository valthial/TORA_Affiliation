using System;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace TORA_Affiliation.Controllers
{
    class Crypto
    {
        /// <summary>
        /// 
        /// </summary>
        static readonly byte[] Entropy = Encoding.Unicode.GetBytes("fI9YLGy7Wk2dPeZ3fDRL8qZyp4edGJeEMgH01eqJ");

        /// <summary>
        /// Encrypt a SecureString to a non secure string.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string EncryptString(SecureString input)
        {
            byte[] encryptedData = ProtectedData.Protect(Encoding.Unicode.GetBytes(ToInsecureString(input)),
                                                         Entropy,
                                                         DataProtectionScope.CurrentUser);
            return Convert.ToBase64String(encryptedData);
        }

        /// <summary>
        /// Decrypt a non secure string to a SecureString.
        /// </summary>
        /// <param name="encryptedData"></param>
        /// <returns></returns>
        public static SecureString DecryptString(string encryptedData)
        {

            try
            {
                byte[] decryptedData = ProtectedData.Unprotect(Convert.FromBase64String(encryptedData),
                                                               Entropy,
                                                               DataProtectionScope.CurrentUser);
                return ToSecureString(Encoding.Unicode.GetString(decryptedData));
            }
            catch
            {
                return new SecureString();
            }

        }

        /// <summary>
        /// Change a non secure string to a SecureString.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static SecureString ToSecureString(string input)
        {
            var secure = new SecureString();

            foreach (var c in input)
            {
                secure.AppendChar(c);
            }

            secure.MakeReadOnly();

            return secure;
        }

        /// <summary>
        /// Change a SecureString to a non secure string.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string ToInsecureString(SecureString input)
        {
            string returnValue;
            var ptr = System.Runtime.InteropServices.Marshal.SecureStringToBSTR(input);

            try
            {
                returnValue = System.Runtime.InteropServices.Marshal.PtrToStringBSTR(ptr);
            }
            finally
            {
                System.Runtime.InteropServices.Marshal.ZeroFreeBSTR(ptr);
            }

            return returnValue;
        }
    }
}
