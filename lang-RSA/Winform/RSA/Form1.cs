/*
 * https://github.com/geon-jeong/Language-Examples.git
 */

using System;
using System.Collections.Generic;
using System.Security.Cryptography; 
using System.Text;
using System.Windows.Forms;

namespace RSA
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_str"></param>
        /// <param name="_keys"></param>
        public void rsa_keygen(String _str, out Dictionary<string, string> _keys)
        {
            _keys = new Dictionary<string, string>();

            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            RSAParameters key_private = System.Security.Cryptography.RSA.Create().ExportParameters(true);
            rsa.ImportParameters(key_private);
            string txt_key_private = rsa.ToXmlString(true);

            RSAParameters key_public = new RSAParameters();
            key_public.Modulus = key_private.Modulus;
            key_public.Exponent = key_private.Exponent;
            rsa.ImportParameters(key_public);

            string txt_key_public = Encryption(_str, rsa.ToXmlString(false));     

            _keys.Add("public_key", txt_key_public);
            _keys.Add("private_key", txt_key_private);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_seed"></param>
        /// <param name="_key_public"></param>
        /// <returns></returns>
        public string Encryption(string _seed, string _key_public)
        {
            var tmp = Encoding.UTF8.GetBytes(_seed);

            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                try
                {
                    rsa.FromXmlString(_key_public);
                    return Convert.ToBase64String(rsa.Encrypt(tmp, true));
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_seed"></param>
        /// <param name="_key_private"></param>
        /// <returns></returns>
        public string Decryption(string _key_public, string _key_private)
        {
            var tmp = Encoding.UTF8.GetBytes(_key_public);

            using (var rsa = new RSACryptoServiceProvider(1024))
            {
                try
                {
                    rsa.FromXmlString(_key_private);
                    return Encoding.UTF8.GetString(rsa.Decrypt(Convert.FromBase64String(_key_public), true)).ToString();
                }
                finally
                {
                    rsa.PersistKeyInCsp = false;
                }
            }
        }

        /*----------------------------------------------------------------------------------------------------------
         * GUI
         * ----------------------------------------------------------------------------------------------------------*/

        Dictionary<string, string> rsa_keys;
        public Form1()
        {
            InitializeComponent();

        }

        private void Button_keygen_Click(object sender, EventArgs e)
        {
            rsa_keygen(textBox_key.Text.Trim(), out rsa_keys);
            richTextBox_PrivateKey.Text = rsa_keys["private_key"];
            richTextBox_PublicKey.Text = rsa_keys["public_key"];
            richTextBox_Decryption.Clear();
        }

        private void Button_Decryption_Click(object sender, EventArgs e)
        {
            richTextBox_Decryption.Text = Decryption(richTextBox_PublicKey.Text, richTextBox_PrivateKey.Text);            
        }
    }
}
