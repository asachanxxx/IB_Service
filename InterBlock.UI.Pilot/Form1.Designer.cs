namespace InterBlock.UI.Pilot
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_key1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_output = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_key2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_filedisplay = new System.Windows.Forms.RichTextBox();
            this.btn_decryption = new System.Windows.Forms.Button();
            this.btn_entryption = new System.Windows.Forms.Button();
            this.btn_browsedestination = new System.Windows.Forms.Button();
            this.txt_destinationfile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_browsesource = new System.Windows.Forms.Button();
            this.txt_sourcefile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txt_filedisplayEncry = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "EncyptText";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(166, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "DecryptText";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txt_key1
            // 
            this.txt_key1.Location = new System.Drawing.Point(85, 9);
            this.txt_key1.Name = "txt_key1";
            this.txt_key1.Size = new System.Drawing.Size(328, 20);
            this.txt_key1.TabIndex = 2;
            this.txt_key1.Text = "b14ca5898a4e4133bbce2ea2315a1916";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Symmetric Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Output";
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(85, 64);
            this.txt_output.Name = "txt_output";
            this.txt_output.Size = new System.Drawing.Size(414, 20);
            this.txt_output.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Symmetric Key";
            // 
            // txt_key2
            // 
            this.txt_key2.Location = new System.Drawing.Point(85, 3);
            this.txt_key2.Name = "txt_key2";
            this.txt_key2.Size = new System.Drawing.Size(328, 20);
            this.txt_key2.TabIndex = 6;
            this.txt_key2.Text = "b14ca5898a4e4133bbce2ea2315a1916";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_key1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt_output);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 95);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_filedisplayEncry);
            this.panel2.Controls.Add(this.txt_filedisplay);
            this.panel2.Controls.Add(this.btn_decryption);
            this.panel2.Controls.Add(this.btn_entryption);
            this.panel2.Controls.Add(this.btn_browsedestination);
            this.panel2.Controls.Add(this.txt_destinationfile);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btn_browsesource);
            this.panel2.Controls.Add(this.txt_sourcefile);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_key2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 474);
            this.panel2.TabIndex = 9;
            // 
            // txt_filedisplay
            // 
            this.txt_filedisplay.BackColor = System.Drawing.Color.Black;
            this.txt_filedisplay.Font = new System.Drawing.Font("Consolas", 8.25F);
            this.txt_filedisplay.ForeColor = System.Drawing.Color.White;
            this.txt_filedisplay.Location = new System.Drawing.Point(9, 112);
            this.txt_filedisplay.Name = "txt_filedisplay";
            this.txt_filedisplay.Size = new System.Drawing.Size(404, 350);
            this.txt_filedisplay.TabIndex = 16;
            this.txt_filedisplay.Text = "";
            // 
            // btn_decryption
            // 
            this.btn_decryption.Location = new System.Drawing.Point(166, 83);
            this.btn_decryption.Name = "btn_decryption";
            this.btn_decryption.Size = new System.Drawing.Size(75, 23);
            this.btn_decryption.TabIndex = 15;
            this.btn_decryption.Text = "Decrypt File";
            this.btn_decryption.UseVisualStyleBackColor = true;
            this.btn_decryption.Click += new System.EventHandler(this.btn_decryption_Click);
            // 
            // btn_entryption
            // 
            this.btn_entryption.Location = new System.Drawing.Point(85, 83);
            this.btn_entryption.Name = "btn_entryption";
            this.btn_entryption.Size = new System.Drawing.Size(75, 23);
            this.btn_entryption.TabIndex = 14;
            this.btn_entryption.Text = "Encypt File";
            this.btn_entryption.UseVisualStyleBackColor = true;
            this.btn_entryption.Click += new System.EventHandler(this.btn_entryption_Click);
            // 
            // btn_browsedestination
            // 
            this.btn_browsedestination.Location = new System.Drawing.Point(569, 55);
            this.btn_browsedestination.Name = "btn_browsedestination";
            this.btn_browsedestination.Size = new System.Drawing.Size(75, 23);
            this.btn_browsedestination.TabIndex = 13;
            this.btn_browsedestination.Text = "Browse";
            this.btn_browsedestination.UseVisualStyleBackColor = true;
            this.btn_browsedestination.Click += new System.EventHandler(this.btn_browsedestination_Click);
            // 
            // txt_destinationfile
            // 
            this.txt_destinationfile.Location = new System.Drawing.Point(85, 57);
            this.txt_destinationfile.Name = "txt_destinationfile";
            this.txt_destinationfile.Size = new System.Drawing.Size(478, 20);
            this.txt_destinationfile.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Destination File";
            // 
            // btn_browsesource
            // 
            this.btn_browsesource.Location = new System.Drawing.Point(569, 27);
            this.btn_browsesource.Name = "btn_browsesource";
            this.btn_browsesource.Size = new System.Drawing.Size(75, 23);
            this.btn_browsesource.TabIndex = 10;
            this.btn_browsesource.Text = "Browse";
            this.btn_browsesource.UseVisualStyleBackColor = true;
            this.btn_browsesource.Click += new System.EventHandler(this.btn_browsesource_Click);
            // 
            // txt_sourcefile
            // 
            this.txt_sourcefile.Location = new System.Drawing.Point(85, 29);
            this.txt_sourcefile.Name = "txt_sourcefile";
            this.txt_sourcefile.Size = new System.Drawing.Size(478, 20);
            this.txt_sourcefile.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Source File";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txt_filedisplayEncry
            // 
            this.txt_filedisplayEncry.BackColor = System.Drawing.Color.Black;
            this.txt_filedisplayEncry.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_filedisplayEncry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_filedisplayEncry.Location = new System.Drawing.Point(419, 112);
            this.txt_filedisplayEncry.Name = "txt_filedisplayEncry";
            this.txt_filedisplayEncry.Size = new System.Drawing.Size(406, 350);
            this.txt_filedisplayEncry.TabIndex = 17;
            this.txt_filedisplayEncry.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 599);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "AES Functions";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_key1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_output;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_key2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox txt_filedisplay;
        private System.Windows.Forms.Button btn_decryption;
        private System.Windows.Forms.Button btn_entryption;
        private System.Windows.Forms.Button btn_browsedestination;
        private System.Windows.Forms.TextBox txt_destinationfile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_browsesource;
        private System.Windows.Forms.TextBox txt_sourcefile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.RichTextBox txt_filedisplayEncry;
    }
}

