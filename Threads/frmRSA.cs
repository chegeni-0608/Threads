using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Threads
{
    public partial class frmRSA : Form
    {
        public frmRSA()
        {
            InitializeComponent();
        }

        private void btnGenerateRSAKey_Click(object sender, EventArgs e)
        {
            GenerateRSAKey();
            txtPublicKey.Text = publicKey;
            txtPrivateKey.Text = privateKey;
        }

        static string publicKey = "";
        static string privateKey = "";

        public static void GenerateRSAKey()
        {
          using(var rsa = new RSACryptoServiceProvider(1024))
          {
                publicKey = rsa.ToXmlString(false); // do something with the key
                privateKey = rsa.ToXmlString(true); // do somthing with the key
          }
        }

        public static string Encryption(string strText)
        {
            var testData = Encoding.UTF8.GetBytes(strText);
            using(var rsa = new RSACryptoServiceProvider(1024))
            {
                // client encryption data with public key issue by server
                rsa.FromXmlString(publicKey);

                var encryptedData = rsa.Encrypt(testData, true);
                var base64Encrypted = Convert.ToBase64String(encryptedData);
                return base64Encrypted;
            }
        }

        public static string Decryption(string strText)
        {
            var testData = Encoding.UTF8.GetBytes(strText);
            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                // client encryption data with public key issue by server
                rsa.FromXmlString(privateKey);

                var decryptedData = rsa.Decrypt(testData, true);
                var base64Decrypted = Convert.ToBase64String(decryptedData);
                return base64Decrypted;
            }
        }


    }
}
