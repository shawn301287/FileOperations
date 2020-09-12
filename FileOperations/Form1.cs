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

namespace FileOperations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_filename_findReplace_browse_Click(object sender, EventArgs e)
        {
            folderBrowser_filename_findReplace.ShowDialog();
            textBox_folderPath.Text = folderBrowser_filename_findReplace.SelectedPath;
        }

        private void folderBrowser_filename_findReplace_HelpRequest(object sender, EventArgs e)
        {
            
        }

        private void button_replace_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(folderBrowser_filename_findReplace.SelectedPath, "*.*", SearchOption.AllDirectories);

            foreach (var item in files)
            {
                FileInfo file = new FileInfo(item);

                string newName = item;
                newName = newName.Replace(textBox_original.Text, textBox_modified.Text);

                File.Move(item, newName);

                listBox_filenames.Items.Add(newName);
            }
            
        }

        private void button_readDirectory_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(folderBrowser_filename_findReplace.SelectedPath, "*.*", SearchOption.AllDirectories);

            foreach (var item in files)
            {
                FileInfo file = new FileInfo(item);

                listBox_filenames.Items.Add(file.Name);
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_folderPath.Text = textBox_original.Text = textBox_appendtxt.Text = textBox_prependtxt.Text = textBox_modified.Text = "";
            
            listBox_filenames.Items.Clear();

            folderBrowser_filename_findReplace.SelectedPath = null;
        }

        private void button_append_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(folderBrowser_filename_findReplace.SelectedPath, "*.*", SearchOption.AllDirectories);

            foreach (var item in files)
            {
                FileInfo file = new FileInfo(item);

                string newName = file.DirectoryName + "/" + file.Name.Replace(file.Extension, "") + textBox_appendtxt.Text + file.Extension;
                //newName = newName.Replace(textBox_original.Text, textBox_modified.Text);

                File.Move(item, newName);

                listBox_filenames.Items.Add(newName);
            }
        }

        private void button_prepend_Click(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(folderBrowser_filename_findReplace.SelectedPath, "*.*", SearchOption.AllDirectories);

            foreach (var item in files)
            {
                FileInfo file = new FileInfo(item);

                string newName = file.DirectoryName + "/" + textBox_prependtxt.Text + file.Name.Replace(file.Extension, "") + file.Extension;
                //newName = newName.Replace(textBox_original.Text, textBox_modified.Text);

                File.Move(item, newName);

                listBox_filenames.Items.Add(newName);
            }
        }
    }
}
