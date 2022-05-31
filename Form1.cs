using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string md5_hash(byte[] tmpSource)
        {
          
            //Compute hash based on source data
            byte[] tmpHash = new MD5CryptoServiceProvider().ComputeHash(tmpSource);
            string result = BitConverter.ToString(tmpHash);
            result = result.Replace("-", "").ToLowerInvariant();
            return result;
        }
        string sha1_hash(byte[] tmpSource)
        {

            //Compute hash based on source data
            byte[] tmpHash = new SHA1CryptoServiceProvider().ComputeHash(tmpSource);
            string result = BitConverter.ToString(tmpHash);
            result = result.Replace("-", "").ToLowerInvariant();
            return result;
        }
        string sha2_hash(byte[] tmpSource, int num)
        {
          
            byte[] tmpHash;

            string result = "";
            switch (num)
            {
                case 256:
                    //Compute hash based on source data
                    tmpHash = new SHA256CryptoServiceProvider().ComputeHash(tmpSource);


                    result = BitConverter.ToString(tmpHash); ;
                    break;
                case 384:
                    //Compute hash based on source data
                    tmpHash = new SHA384CryptoServiceProvider().ComputeHash(tmpSource);
                    result = BitConverter.ToString(tmpHash); ;
                    break;
                case 512:
                    //Compute hash based on source data
                    tmpHash = new SHA512CryptoServiceProvider().ComputeHash(tmpSource);
                    result = BitConverter.ToString(tmpHash); ;
                    break;
                default:
                    break;
            }
            result = result.Replace("-", "").ToLowerInvariant();

            return result;
        }
        string sha3_hash(byte[] tmpSource)
        {
            string sSourceData;
            byte[] tmpHash;
            var hashAlgorithm = new Org.BouncyCastle.Crypto.Digests.Sha3Digest(512);

            // Choose correct encoding based on your usecase

            hashAlgorithm.BlockUpdate(tmpSource, 0, tmpSource.Length);

            byte[] result = new byte[64]; // 512 / 8 = 64
            hashAlgorithm.DoFinal(result, 0);

            string hashString = BitConverter.ToString(result);
            string hash3text = hashString.Replace("-", "").ToLowerInvariant();
            return hash3text;
        }
        public static byte[] StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MD5text.Text = "";
            SHA1text.Text = "";
            SHA256text.Text = "";
            SHA384text.Text = "";
            SHA512text.Text = "";
            SHA3512text.Text = "";
            string tire = ListBoxtire.GetItemText(ListBoxtire.SelectedItem);
            if (tire == "TEXT String")
            {
                byte[] text_utf8_byte = Encoding.UTF8.GetBytes(InPuttext.Text);
                if (InPuttext.Text != string.Empty)
                {
                    MD5text.Text = md5_hash(text_utf8_byte);
                    SHA1text.Text = sha1_hash(text_utf8_byte);
                    SHA256text.Text = sha2_hash(text_utf8_byte, 256);
                    SHA384text.Text = sha2_hash(text_utf8_byte, 384);
                    SHA512text.Text = sha2_hash(text_utf8_byte, 512);
                    SHA3512text.Text = sha3_hash(text_utf8_byte);
                }
                else
                {
                    MessageBox.Show("Lỗi lòi le bạn ơi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (tire == "HEX String")
                    {
                byte[] text_hex_utf8_byte = StringToByteArray(InPuttext.Text);
                if (InPuttext.Text.ToString() != string.Empty)
                {
                    MD5text.Text = md5_hash(text_hex_utf8_byte);
                    SHA1text.Text = sha1_hash(text_hex_utf8_byte);
                    SHA256text.Text = sha2_hash(text_hex_utf8_byte, 256);
                    SHA384text.Text = sha2_hash(text_hex_utf8_byte, 384);
                    SHA512text.Text = sha2_hash(text_hex_utf8_byte, 512);
                    SHA3512text.Text = sha3_hash(text_hex_utf8_byte);
                }
                else
                {
                    MessageBox.Show("Lỗi lòi le bạn ơi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (tire =="FILE")
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                InPuttext.Text = ofd.FileName.ToString();
                byte[] file_text_byte = File.ReadAllBytes(ofd.FileName.ToString());
                
                if (InPuttext.Text.ToString() != string.Empty)
                {
                    MD5text.Text = md5_hash(file_text_byte);
                    SHA1text.Text = sha1_hash(file_text_byte);
                    SHA256text.Text = sha2_hash(file_text_byte, 256);
                    SHA384text.Text = sha2_hash(file_text_byte, 384);
                    SHA512text.Text = sha2_hash(file_text_byte, 512);
                    SHA3512text.Text = sha3_hash(file_text_byte);
                }
                else
                {
                    MessageBox.Show("Lỗi lòi le bạn ơi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }    


        }
    }
}
