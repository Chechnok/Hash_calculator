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
            sha1_textBox.Text = "";
            sha256_textBox.Text = "";
            sha384_textBox.Text = "";
            sha512_textBox.Text = "";
        }
        private void setfile(string filepath)
        {
            file = new FileSettings(filepath);
            if (file.success)
            {

                file_size_textBox.Text = file.size;
                file_name_textBox.Text = file.name;
                resetHashsumm();
            }
            else
                MessageBox.Show(file.message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private string computing(string algc)
        {
            string checkhash;
            try
            {
                using (var str = File.OpenRead(file.path))
                {
                    checkhash = Hash_sum.compute(str, algc)[0];
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                checkhash = "IO Read error";
            }
            return checkhash;
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

        private void VisualCompute(int stageNum, CheckBox algoCheck, string algoCode, int hashIndex, ref TextBox hashsumBox)
        {
            if (algoCheck.Checked)
            {
                hashes[hashIndex] = computing(algoCode); hashsumBox.Text = hashes[hashIndex];
            }
        }

        private void calculate_button_Click(object sender, EventArgs e)
        {
            resetHashsumm();
            VisualCompute(1, md5_check, "md5", 0, ref md5_textBox);
            VisualCompute(2, sha1_check, "sha1", 1, ref sha1_textBox);
            VisualCompute(3, sha256_check, "sha256", 2, ref sha256_textBox);
            VisualCompute(4, sha384_check, "sha384", 3, ref sha384_textBox);
            VisualCompute(5, sha512_check, "sha512", 4, ref sha512_textBox);
            calculate_button.Text = "Calculate";
        }
        private void fileBox_DragEnter(object sender, DragEventArgs e)
        {
            string[] filepaths = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            if (filepaths.Length > 0)
            {
                setfile(filepaths[0]);
            }
        }
        private void fileBox_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
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
                    input.LoadFile(OFD.FileName, RichTextBoxStreamType.PlainText);

                }

            }
        }

        private void file_size_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void file_name_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}