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
            if (textBox1.Text!=string.Empty && textBox1.Text!=null)
            {
                textBox2.Text = Translate(textBox1.Text, "ru");
            }
            
        }

        #region Translating
        private void Awesomium_Windows_Forms_WebControl_LoadingFrameComplete(object sender, Awesomium.Core.FrameEventArgs e)
        {
            isMainFrame = e.IsMainFrame;

            //Loding 3 frames
            //frame 2 Is MainFrame
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
            string t = null;

            Uri url = new Uri(String.Format("https://translate.google.com/#view=home&op=translate&sl={0}&tl={1}&text={2}", fromLng, toLng, textToTranslate));
            webControl1.Source = url;
            //for refreshing webControl1.HTML
            webControl1.Source = webControl1.Source;

            //waiting for loding html
            while (!isDomReady)
            {
                Application.DoEvents();
            }

            //Clipboard.Clear();
            //webControl1.SelectAll();
            //webControl1.CopyHTML();
            //string HTML = Clipboard.GetText();

            t = Parse(webControl1.HTML);

            while (t == null)
            {
                isDomReady = false;
                webControl1.Source = url;
                webControl1.Source = webControl1.Source;
                while (!isDomReady)
                {
                    Application.DoEvents();
                }
                t = Parse(webControl1.HTML);
            }

            if (t == null)
            {
                return "null";
            }
            return t;
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
            string t = null;

            Uri url = new Uri(String.Format("https://translate.google.com/#view=home&op=translate&sl={0}&tl={1}&text={2}", "auto", toLng, textToTranslate));
            webControl1.Source = url;
            //for refreshing webControl1.HTML
            webControl1.Source = webControl1.Source;

            //waiting for loding html
            while (!isDomReady)
            {
                Application.DoEvents();
            }

            //Clipboard.Clear();
            //webControl1.SelectAll();
            //webControl1.CopyHTML();
            //string HTML = Clipboard.GetText();

            t = Parse(webControl1.HTML);

            while (t == null)
            {
                isDomReady = false;
                webControl1.Source = url;
                webControl1.Source = webControl1.Source;
                while (!isDomReady)
                {
                    Application.DoEvents();
                }
                t = Parse(webControl1.HTML);
            }

            if (t == null)
            {
                return "null";
            }
            return t;
        }

        private string Parse(string HTML)
        {
            int substringIndex = HTML.IndexOf("<span title=\"\">");
            if (substringIndex == -1)
            {
                return null;
            }
            HTML = HTML.Substring(substringIndex + 15);

            substringIndex = HTML.IndexOf("</span></span>");
            if (substringIndex == -1)
            {
                return null;
            }
            HTML = HTML.Remove(substringIndex);

            HTML = HTML.Replace("<br>", "\r\n");
            HTML = HTML.Replace("</span>", "");
            HTML = HTML.Replace("<span title=\"\">", "");

            return HTML;
        }
        #endregion
    }
}
