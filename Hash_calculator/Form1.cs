using Hash_calculator.Classes;
using System.Security.Cryptography;

namespace Hash_calculator
{
    public partial class Form1 : Form
    {
        static FileSettings file = new FileSettings();

        private string[] hashes = { "", "", "", "", "" };
        public Form1()
        {
            InitializeComponent();
        }

        private void resetHashsumm()
        {
            md5_textBox.Text = "";
            sha1_box.Text = "";
            sha256_box.Text = "";
            sha384.Text = "";
            sha512.Text = "";
        }
        private void setfile(string filepath)
        {
            file = new FileSettings(filepath);
            if (file.success)
            {

                file_size_textBox.Text = file.size;
                file_size_textBox.Text = file.name;
                resetHashsumm();
            }
            else
                MessageBox.Show(file.message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog OFD = new OpenFileDialog())
            {
                OFD.InitialDirectory = "c:\\";
                OFD.Filter = "All files (*.*)|*.*";
                OFD.FilterIndex = 1;
                OFD.RestoreDirectory = true;
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    setfile(OFD.FileName);
                }
            }
        }

        private void sumcomp()
        {
            if (chech_hash_textBox.Text.Length > 0)
            {
                if (hashes.Contains(chech_hash_textBox.Text.ToLower()))
                {
                    chech_hash_textBox.BackColor = Color.DarkSeaGreen;
                }
                else
                {
                    chech_hash_textBox.BackColor = Color.IndianRed;
                }
            }
            else
            {
                chech_hash_textBox.BackColor = Color.White;
            }
        }

        private void chech_hash_textBox_TextChanged(object sender, EventArgs e)
        {
            sumcomp();
        }

        private void save_file_button_Click(object sender, EventArgs e)
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.DefaultExt = "*.txt";
            SFD.Filter = "Text files(*.txt)|*.txt";
            if (SFD.ShowDialog() == DialogResult.OK && SFD.FileName.Length > 0)
            {
                using (StreamWriter sw = new StreamWriter(SFD.FileName))
                {
                    sw.WriteLine($"filename - {file.name} \nmd5 - {hashes[0]} \nSHA1 - {hashes[1]} \nSHA256 - {hashes[2]} \nSHA384 {hashes[3]} \nSHA512 {hashes[4]} ");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void open_file_with_hash_button_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog OFD = new OpenFileDialog())
            {
                OFD.FilterIndex = 1;
                OFD.RestoreDirectory = false;
                OFD.DefaultExt = ".txt"; // Default file extension
                OFD.Filter = "Text documents (.txt)|*.txt";
                if (OFD.ShowDialog() == DialogResult.OK)
                {
                    inputHash.LoadFile(OFD.FileName, RichTextBoxStreamType.PlainText);

                }

            }
        }
    }
}