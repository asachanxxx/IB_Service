using InterBlock.Helpers.CyperEngine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterBlock.UI.Pilot
{
    public partial class Form1 : Form
    {
        string key = "b14ca5898a4e4133bbce2ea2315a1916";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_browsesource_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_sourcefile.Text = openFileDialog1.FileName;

                Random rand = new Random(2);
                txt_destinationfile.Text = Path.Combine(Path.GetDirectoryName(txt_sourcefile.Text), Path.GetFileNameWithoutExtension(txt_sourcefile.Text) + rand.Next(1000, 20000) + ".encry");

                txt_filedisplay.Text = string.Empty;
                txt_filedisplayEncry.Text = string.Empty;
            }
        }

        private void btn_browsedestination_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                txt_destinationfile.Text = folderBrowserDialog1.SelectedPath;

                txt_filedisplay.Text = string.Empty;
                txt_filedisplayEncry.Text = string.Empty;
            }
        }

        private void btn_entryption_Click(object sender, EventArgs e)
        {

            var str = Console.ReadLine();
            
            string _sourceFileContent = LoadFileContent(txt_sourcefile.Text);

            txt_filedisplay.Text = _sourceFileContent;

            var encryptedString = AESEngine.EncryptString(key, _sourceFileContent);

            WriteToFile(encryptedString, txt_destinationfile.Text);

            txt_filedisplayEncry.Text = encryptedString;

            
        }

        private void WriteToFile(string encryptedString, string p)
        {
            if (File.Exists(p))
            {
                using (StreamWriter sr = new StreamWriter(p))
                {
                    sr.Write(encryptedString);
                }
            }
            else
            {
                FileStream fs = new FileStream(p, FileMode.CreateNew);
                fs.Close();
                using (StreamWriter sr = new StreamWriter(p))
                {
                    sr.Write(encryptedString);
                }
            }
        }

     

        private string LoadFileContent(string p)
        {
            string readtext = string.Empty;
            string finalout = string.Empty;
            if (File.Exists(p))
            {
                using (StreamReader sr = new StreamReader(p))
                {
                    while ((readtext = sr.ReadLine()) != null)
                    {
                        finalout += readtext;
                    }

                }

                return finalout;

            }
            else
            {
                throw new FileNotFoundException();
            }
        }

        private void btn_decryption_Click(object sender, EventArgs e)
        {
            string _sourceFileContent = LoadFileContent(txt_sourcefile.Text);
            txt_filedisplayEncry.Text = _sourceFileContent;


            var decryptedString = AESEngine.DecryptString(key, _sourceFileContent);

            txt_filedisplay.Text = decryptedString;
 

        }


    }
}
