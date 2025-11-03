using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace SignUpForm
{
    class RSAHelper
    {
        private RSACryptoServiceProvider rsa;

       

        public RSAHelper(int KetSize = 2048)
        {
            rsa = new RSACryptoServiceProvider(KetSize);

            
        }

        public string GetPublicKeyXml()
        {
            return rsa.ToXmlString(false);

        }

        public string GetPrivateKeyXml()
        {
            return rsa.ToXmlString(true);
        }

        public void LoadKeyFromXml(string xmlKey)
        {
            rsa.FromXmlString(xmlKey);
        }

        //public void LoadPrivateKey(string privateKey)
       // {
        //    rsa.FromXmlString(privateKey);
      //  }


        public string Encrypt(string plainText)
        {
            var data = Encoding.UTF8.GetBytes(plainText);

            var encrypted = rsa.Encrypt(data, true);

            return Convert.ToBase64String(encrypted);
        }

        public string Decrypt(string base64Cipher)
        {
            var cipher = Convert.FromBase64String(base64Cipher);

            var decrypted = rsa.Decrypt(cipher, true);

            return Encoding.UTF8.GetString(decrypted);
        }
  

    }
}
