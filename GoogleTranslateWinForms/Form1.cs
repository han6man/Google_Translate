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
        private int framesLoaded = 1;
        private bool isDomReady = false;
        private bool isMainFrame = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            while (!isDomReady)
            {
                Application.DoEvents();
            }
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            button1.Enabled = true;
            textBox1.Focus();
        }

        private void Awesomium_Windows_Forms_WebControl_LoadingFrameComplete(object sender, Awesomium.Core.FrameEventArgs e)
        {
            isMainFrame = e.IsMainFrame;

            if (framesLoaded < 3)
            {
                framesLoaded++;
                isDomReady = false;
            }
            else
            {
                framesLoaded = 1;
                isDomReady = true;
            }
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
            textBox2.Text = Translate(textBox1.Text, "ru");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="textToTranslate"></param>
        /// <param name="fromLng"></param>
        /// <param name="toLng"></param>
        /// <returns></returns>
        private string Translate(string textToTranslate, string fromLng, string toLng)
        {
            isDomReady = false;
            string s = null;

            Uri url = new Uri(String.Format("https://translate.google.com/#view=home&op=translate&sl={0}&tl={1}&text={2}", fromLng, toLng, textToTranslate));
            webControl1.Source = url;
            //for refreshing HTML
            webControl1.Source = webControl1.Source;

            s = Parse();

            //while (s == null)
            //{
            //    webControl1.Source = url;
            //    webControl1.Source = url;
            //    s = Parse();
            //}

            if (s == null)
            {
                return "null";
            }
            return s;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="textToTranslate"></param>
        /// <param name="toLng"></param>
        /// <returns></returns>
        private string Translate(string textToTranslate, string toLng)
        {
            isDomReady = false;
            string s = null;

            Uri url = new Uri(String.Format("https://translate.google.com/#view=home&op=translate&sl={0}&tl={1}&text={2}", "auto", toLng, textToTranslate));
            webControl1.Source = url;
            //for refreshing HTML
            webControl1.Source = webControl1.Source;

            s = Parse();

            //while (s == null)
            //{
            //    webControl1.Source = url;
            //    webControl1.Source = url;
            //    s = Parse();
            //}

            if (s == null)
            {
                return "null";
            }
            return s;
        }

        private string Parse()
        {
            while (!isDomReady)
            {
                Application.DoEvents();
            }

            //Clipboard.Clear();
            //webControl1.SelectAll();
            //webControl1.CopyHTML();
            //s = Clipboard.GetText();

            string s = webControl1.HTML;

            int substringIndex = s.IndexOf("<span title=\"\">");
            if (substringIndex == -1)
            {
                return null;
            }
            s = s.Substring(substringIndex + 15);

            substringIndex = s.IndexOf("</span></span>");
            if (substringIndex == -1)
            {
                return null;
            }
            s = s.Remove(substringIndex);

            s = s.Replace("<br>", "\r\n");
            s = s.Replace("</span>", "");
            s = s.Replace("<span title=\"\">", "");

            return s;
        }

    }
}
