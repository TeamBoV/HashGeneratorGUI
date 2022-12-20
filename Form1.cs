using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace HashGeneratorGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Set up the event handler for the button's Click event
            button1.Click += new EventHandler(Button1_Click);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Show the OpenFileDialog to select a file
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file path
                string filePath = openFileDialog1.FileName;

                // Check if the file exists
                if (!File.Exists(filePath))
                {
                    MessageBox.Show("The file does not exist.");
                    return;
                }

                // Calculate the MD5 hash
                string md5Hash = CalculateHash(filePath, new MD5CryptoServiceProvider());

                // Calculate the SHA1 hash
                string sha1Hash = CalculateHash(filePath, new SHA1CryptoServiceProvider());

                // Calculate the SHA256 hash
                string sha256Hash = CalculateHash(filePath, new SHA256CryptoServiceProvider());

                // Display the hash values in the textbox
                textBox1.Text = Environment.NewLine
                              + "MD5 hash: " + md5Hash + Environment.NewLine + Environment.NewLine
                              + "SHA1 hash: " + sha1Hash + Environment.NewLine + Environment.NewLine
                              + "SHA256 hash: " + sha256Hash + Environment.NewLine;
            }
        }

        static string CalculateHash(string filePath, HashAlgorithm hashAlgorithm)
        {
            // Open the file
            using (FileStream stream = File.OpenRead(filePath))
            {
                // Calculate the hash
                byte[] hash = hashAlgorithm.ComputeHash(stream);

                // Convert the hash to a hexadecimal string
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("X2"));
                }
                return sb.ToString();
            }
        }
    }
}
