using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileOperations
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void findReplaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            Form1 form1 = new Form1();
            form1.MdiParent = this;
            form1.WindowState = FormWindowState.Maximized;
            form1.ShowIcon = false;
            form1.ShowInTaskbar = false;
            form1.Show();

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
