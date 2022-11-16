namespace Hash_calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.md5_textBox = new System.Windows.Forms.TextBox();
            this.sha1_box = new System.Windows.Forms.TextBox();
            this.sha256_box = new System.Windows.Forms.TextBox();
            this.sha384 = new System.Windows.Forms.TextBox();
            this.sha512 = new System.Windows.Forms.TextBox();
            this.md5_label = new System.Windows.Forms.Label();
            this.SHA1_label = new System.Windows.Forms.Label();
            this.SHA256_label = new System.Windows.Forms.Label();
            this.SHA384_label = new System.Windows.Forms.Label();
            this.SHA512_label = new System.Windows.Forms.Label();
            this.file_size_textBox = new System.Windows.Forms.TextBox();
            this.file_size_label = new System.Windows.Forms.Label();
            this.file_name_textBox = new System.Windows.Forms.TextBox();
            this.fiile_name_label = new System.Windows.Forms.Label();
            this.chech_hash_textBox = new System.Windows.Forms.TextBox();
            this.Check_hash_label = new System.Windows.Forms.Label();
            this.save_file_button = new System.Windows.Forms.Button();
            this.input = new System.Windows.Forms.RichTextBox();
            this.calculate_button = new System.Windows.Forms.Button();
            this.md5_check = new System.Windows.Forms.RadioButton();
            this.sha1_check = new System.Windows.Forms.RadioButton();
            this.sha256_check = new System.Windows.Forms.RadioButton();
            this.sha384_check = new System.Windows.Forms.RadioButton();
            this.sha512_check = new System.Windows.Forms.RadioButton();
            this.open_file_with_hash_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "Choose file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // md5_textBox
            // 
            this.md5_textBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.md5_textBox.Location = new System.Drawing.Point(23, 164);
            this.md5_textBox.Name = "md5_textBox";
            this.md5_textBox.Size = new System.Drawing.Size(534, 23);
            this.md5_textBox.TabIndex = 1;
            // 
            // sha1_box
            // 
            this.sha1_box.BackColor = System.Drawing.SystemColors.MenuBar;
            this.sha1_box.Location = new System.Drawing.Point(23, 215);
            this.sha1_box.Name = "sha1_box";
            this.sha1_box.Size = new System.Drawing.Size(534, 23);
            this.sha1_box.TabIndex = 2;
            // 
            // sha256_box
            // 
            this.sha256_box.BackColor = System.Drawing.SystemColors.MenuBar;
            this.sha256_box.Location = new System.Drawing.Point(23, 270);
            this.sha256_box.Name = "sha256_box";
            this.sha256_box.Size = new System.Drawing.Size(534, 23);
            this.sha256_box.TabIndex = 3;
            // 
            // sha384
            // 
            this.sha384.BackColor = System.Drawing.SystemColors.MenuBar;
            this.sha384.Location = new System.Drawing.Point(23, 326);
            this.sha384.Name = "sha384";
            this.sha384.Size = new System.Drawing.Size(534, 23);
            this.sha384.TabIndex = 4;
            // 
            // sha512
            // 
            this.sha512.BackColor = System.Drawing.SystemColors.MenuBar;
            this.sha512.Location = new System.Drawing.Point(23, 383);
            this.sha512.Name = "sha512";
            this.sha512.Size = new System.Drawing.Size(534, 23);
            this.sha512.TabIndex = 5;
            // 
            // md5_label
            // 
            this.md5_label.AutoSize = true;
            this.md5_label.Location = new System.Drawing.Point(23, 146);
            this.md5_label.Name = "md5_label";
            this.md5_label.Size = new System.Drawing.Size(32, 15);
            this.md5_label.TabIndex = 6;
            this.md5_label.Text = "MD5";
            // 
            // SHA1_label
            // 
            this.SHA1_label.AutoSize = true;
            this.SHA1_label.Location = new System.Drawing.Point(23, 197);
            this.SHA1_label.Name = "SHA1_label";
            this.SHA1_label.Size = new System.Drawing.Size(36, 15);
            this.SHA1_label.TabIndex = 7;
            this.SHA1_label.Text = "SHA1";
            // 
            // SHA256_label
            // 
            this.SHA256_label.AutoSize = true;
            this.SHA256_label.Location = new System.Drawing.Point(23, 252);
            this.SHA256_label.Name = "SHA256_label";
            this.SHA256_label.Size = new System.Drawing.Size(53, 15);
            this.SHA256_label.TabIndex = 8;
            this.SHA256_label.Text = "SHA_256";
            // 
            // SHA384_label
            // 
            this.SHA384_label.AutoSize = true;
            this.SHA384_label.Location = new System.Drawing.Point(23, 308);
            this.SHA384_label.Name = "SHA384_label";
            this.SHA384_label.Size = new System.Drawing.Size(48, 15);
            this.SHA384_label.TabIndex = 9;
            this.SHA384_label.Text = "SHA384";
            // 
            // SHA512_label
            // 
            this.SHA512_label.AutoSize = true;
            this.SHA512_label.Location = new System.Drawing.Point(23, 365);
            this.SHA512_label.Name = "SHA512_label";
            this.SHA512_label.Size = new System.Drawing.Size(48, 15);
            this.SHA512_label.TabIndex = 10;
            this.SHA512_label.Text = "SHA512";
            // 
            // file_size_textBox
            // 
            this.file_size_textBox.Location = new System.Drawing.Point(299, 42);
            this.file_size_textBox.Name = "file_size_textBox";
            this.file_size_textBox.Size = new System.Drawing.Size(100, 23);
            this.file_size_textBox.TabIndex = 11;
            // 
            // file_size_label
            // 
            this.file_size_label.AutoSize = true;
            this.file_size_label.Location = new System.Drawing.Point(299, 24);
            this.file_size_label.Name = "file_size_label";
            this.file_size_label.Size = new System.Drawing.Size(47, 15);
            this.file_size_label.TabIndex = 12;
            this.file_size_label.Text = "File size";
            // 
            // file_name_textBox
            // 
            this.file_name_textBox.Location = new System.Drawing.Point(157, 42);
            this.file_name_textBox.Name = "file_name_textBox";
            this.file_name_textBox.Size = new System.Drawing.Size(100, 23);
            this.file_name_textBox.TabIndex = 13;
            // 
            // fiile_name_label
            // 
            this.fiile_name_label.AutoSize = true;
            this.fiile_name_label.Location = new System.Drawing.Point(157, 24);
            this.fiile_name_label.Name = "fiile_name_label";
            this.fiile_name_label.Size = new System.Drawing.Size(58, 15);
            this.fiile_name_label.TabIndex = 14;
            this.fiile_name_label.Text = "File name";
            // 
            // chech_hash_textBox
            // 
            this.chech_hash_textBox.Location = new System.Drawing.Point(23, 86);
            this.chech_hash_textBox.Name = "chech_hash_textBox";
            this.chech_hash_textBox.Size = new System.Drawing.Size(366, 23);
            this.chech_hash_textBox.TabIndex = 15;
            this.chech_hash_textBox.TextChanged += new System.EventHandler(this.chech_hash_textBox_TextChanged);
            // 
            // Check_hash_label
            // 
            this.Check_hash_label.AutoSize = true;
            this.Check_hash_label.Location = new System.Drawing.Point(23, 68);
            this.Check_hash_label.Name = "Check_hash_label";
            this.Check_hash_label.Size = new System.Drawing.Size(132, 15);
            this.Check_hash_label.TabIndex = 16;
            this.Check_hash_label.Text = "Check hash to compare";
            // 
            // save_file_button
            // 
            this.save_file_button.Location = new System.Drawing.Point(436, 35);
            this.save_file_button.Name = "save_file_button";
            this.save_file_button.Size = new System.Drawing.Size(86, 30);
            this.save_file_button.TabIndex = 17;
            this.save_file_button.Text = "Save file";
            this.save_file_button.UseVisualStyleBackColor = true;
            this.save_file_button.Click += new System.EventHandler(this.save_file_button_Click);
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(585, 86);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(364, 320);
            this.input.TabIndex = 18;
            this.input.Text = "";
            // 
            // calculate_button
            // 
            this.calculate_button.Location = new System.Drawing.Point(23, 120);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(75, 23);
            this.calculate_button.TabIndex = 19;
            this.calculate_button.Text = "Calculate";
            this.calculate_button.UseVisualStyleBackColor = true;
            // 
            // md5_check
            // 
            this.md5_check.AutoSize = true;
            this.md5_check.Location = new System.Drawing.Point(104, 124);
            this.md5_check.Name = "md5_check";
            this.md5_check.Size = new System.Drawing.Size(50, 19);
            this.md5_check.TabIndex = 20;
            this.md5_check.TabStop = true;
            this.md5_check.Text = "MD5";
            this.md5_check.UseVisualStyleBackColor = true;
            // 
            // sha1_check
            // 
            this.sha1_check.AutoSize = true;
            this.sha1_check.Location = new System.Drawing.Point(160, 124);
            this.sha1_check.Name = "sha1_check";
            this.sha1_check.Size = new System.Drawing.Size(54, 19);
            this.sha1_check.TabIndex = 21;
            this.sha1_check.TabStop = true;
            this.sha1_check.Text = "SHA1";
            this.sha1_check.UseVisualStyleBackColor = true;
            // 
            // sha256_check
            // 
            this.sha256_check.AutoSize = true;
            this.sha256_check.Location = new System.Drawing.Point(220, 124);
            this.sha256_check.Name = "sha256_check";
            this.sha256_check.Size = new System.Drawing.Size(66, 19);
            this.sha256_check.TabIndex = 22;
            this.sha256_check.TabStop = true;
            this.sha256_check.Text = "SHA256";
            this.sha256_check.UseVisualStyleBackColor = true;
            // 
            // sha384_check
            // 
            this.sha384_check.AutoSize = true;
            this.sha384_check.Location = new System.Drawing.Point(292, 124);
            this.sha384_check.Name = "sha384_check";
            this.sha384_check.Size = new System.Drawing.Size(66, 19);
            this.sha384_check.TabIndex = 23;
            this.sha384_check.TabStop = true;
            this.sha384_check.Text = "SHA384";
            this.sha384_check.UseVisualStyleBackColor = true;
            // 
            // sha512_check
            // 
            this.sha512_check.AutoSize = true;
            this.sha512_check.Location = new System.Drawing.Point(364, 124);
            this.sha512_check.Name = "sha512_check";
            this.sha512_check.Size = new System.Drawing.Size(66, 19);
            this.sha512_check.TabIndex = 24;
            this.sha512_check.TabStop = true;
            this.sha512_check.Text = "SHA512";
            this.sha512_check.UseVisualStyleBackColor = true;
            // 
            // open_file_with_hash_button
            // 
            this.open_file_with_hash_button.Location = new System.Drawing.Point(642, 34);
            this.open_file_with_hash_button.Name = "open_file_with_hash_button";
            this.open_file_with_hash_button.Size = new System.Drawing.Size(183, 31);
            this.open_file_with_hash_button.TabIndex = 25;
            this.open_file_with_hash_button.Text = "Open file with hash";
            this.open_file_with_hash_button.UseVisualStyleBackColor = true;
            this.open_file_with_hash_button.Click += new System.EventHandler(this.open_file_with_hash_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 469);
            this.Controls.Add(this.open_file_with_hash_button);
            this.Controls.Add(this.sha512_check);
            this.Controls.Add(this.sha384_check);
            this.Controls.Add(this.sha256_check);
            this.Controls.Add(this.sha1_check);
            this.Controls.Add(this.md5_check);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.input);
            this.Controls.Add(this.save_file_button);
            this.Controls.Add(this.Check_hash_label);
            this.Controls.Add(this.chech_hash_textBox);
            this.Controls.Add(this.fiile_name_label);
            this.Controls.Add(this.file_name_textBox);
            this.Controls.Add(this.file_size_label);
            this.Controls.Add(this.file_size_textBox);
            this.Controls.Add(this.SHA512_label);
            this.Controls.Add(this.SHA384_label);
            this.Controls.Add(this.SHA256_label);
            this.Controls.Add(this.SHA1_label);
            this.Controls.Add(this.md5_label);
            this.Controls.Add(this.sha512);
            this.Controls.Add(this.sha384);
            this.Controls.Add(this.sha256_box);
            this.Controls.Add(this.sha1_box);
            this.Controls.Add(this.md5_textBox);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Hash sum calc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox md5_textBox;
        private TextBox sha1_box;
        private TextBox sha256_box;
        private TextBox sha384;
        private TextBox sha512;
        private Label md5_label;
        private Label SHA1_label;
        private Label SHA256_label;
        private Label SHA384_label;
        private Label SHA512_label;
        private TextBox file_size_textBox;
        private Label file_size_label;
        private TextBox file_name_textBox;
        private Label fiile_name_label;
        private TextBox chech_hash_textBox;
        private Label Check_hash_label;
        private Button save_file_button;
        private RichTextBox input;
        private Button calculate_button;
        private RadioButton md5_check;
        private RadioButton sha1_check;
        private RadioButton sha256_check;
        private RadioButton sha384_check;
        private RadioButton sha512_check;
        private Button open_file_with_hash_button;
    }
}