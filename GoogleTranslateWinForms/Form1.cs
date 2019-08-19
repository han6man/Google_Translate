using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoogleTranslateWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton_Back_Click(object sender, EventArgs e)
        {
            this.webControl1.GoBack();
        }

        private void toolStripButton_Forward_Click(object sender, EventArgs e)
        {
            this.webControl1.GoForward();
        }

        private void toolStripButton_Reload_Click(object sender, EventArgs e)
        {
            this.webControl1.Reload(false);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
