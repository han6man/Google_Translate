using Awesomium.Core;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Google_Translate
{
    public class GoogleTranslator
    {
        private int framesLoaded = 1;
        private bool isDomReady = false;
        private bool isMainFrame = false;
        private WebView webView;
        private WebSession webSession;

        public string SourceText { get; private set; }
        public string TargetText { get; private set; }

        public Language SourceLanguage { get; set; } = Language.Auto_Detect;
        public Language TargetLanguage { get; set; } = Language.English;
        
        #region Constractors
        /// <summary>
        /// 
        /// </summary>
        public GoogleTranslator()
        {
            this.SourceLanguage = Language.Auto_Detect;
            this.TargetLanguage = Language.English;

            InitializeBrowser();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="toLng"></param>
        public GoogleTranslator(Language TargetLanguage)
        {
            this.SourceLanguage = Language.Auto_Detect;
            this.TargetLanguage = TargetLanguage;

            InitializeBrowser();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fromLng"></param>
        /// <param name="toLng"></param>
        public GoogleTranslator(Language SourceLanguage, Language TargetLanguage)
        {
            this.SourceLanguage = SourceLanguage;
            this.TargetLanguage = TargetLanguage;

            InitializeBrowser();
        }

        private void InitializeBrowser()
        {
            WebConfig webConfig = WebConfig.Default;
            if (!WebCore.IsInitialized)
            {
                WebCore.Initialize(webConfig, true);
            }

            WebPreferences webPreferences = WebPreferences.Default;
            //webPreferences.ProxyConfig = "198.1.99.26:3128";
            //webPreferences.CustomCSS = "body { overflow:hidden; }";
            //webPreferences.WebSecurity = false;
            webPreferences.DefaultEncoding = "UTF-8";

            webSession = WebCore.CreateWebSession(webPreferences);

            webView = WebCore.CreateWebView(1366, 768, webSession, WebViewType.Offscreen);
            webView.LoadingFrameComplete += WebView_LoadingFrameComplete;

            // Load a URL.
            webView.Source = new Uri("https://translate.google.com/");

            while (!isDomReady)
            {
                Thread.Sleep(100);
                // A Console application does not have a synchronization
                // context, thus auto-update won't be enabled on WebCore.
                // We need to manually call Update here.
                WebCore.Update();
            }
            //BitmapSurface surface = (BitmapSurface)webView.Surface;
            //surface.SaveToPNG("result.png", true);
            //System.Diagnostics.Process.Start("result.png");
        }
        #endregion

        #region Translating
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WebView_LoadingFrameComplete(object sender, Awesomium.Core.FrameEventArgs e)
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
        /// <returns></returns>
        private string GetHTML()
        {
            isDomReady = false;

            Uri url = new Uri($"https://translate.google.com/#view=home&op=translate&sl={this.SourceLanguage.Code}&tl={this.TargetLanguage.Code}&text={HttpUtility.UrlEncode(this.SourceText)}");
            webView.Source = url;
            //for refreshing webView.HTML
            webView.Source = webView.Source;

            //waiting for loding html
            while (!isDomReady)
            {
                Thread.Sleep(100);
                // A Console application does not have a synchronization
                // context, thus auto-update won't be enabled on WebCore.
                // We need to manually call Update here.
                WebCore.Update();
            }

            return webView.HTML;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="HTML"></param>
        /// <returns></returns>
        private string Parse(string HTML)
        {
            if (string.IsNullOrEmpty(HTML))
            {
                //HTML = null;
                //throw new Exception("string HTML null or empty");
                return HTML;
            }

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
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private string Translate()
        {
            if (string.IsNullOrEmpty(this.SourceText))
            {
                this.TargetText = this.SourceText;
                return this.TargetText;
            }
            if (this.SourceLanguage == null)
            {
                this.SourceLanguage = Language.Auto_Detect;
            }
            if (this.TargetLanguage == Language.Auto_Detect || this.TargetLanguage == null)
            {
                this.TargetLanguage = Language.English;
            }

            this.TargetText = null;

            this.TargetText = Parse(GetHTML());

            while (this.TargetText == null)
            {
                this.TargetText = Parse(GetHTML());
            }

            return this.TargetText;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="SourceText"></param>
        /// <param name="SourceLanguage"></param>
        /// <param name="TargetLanguage"></param>
        /// <returns></returns>
        public string Translate(string SourceText, Language SourceLanguage, Language TargetLanguage)
        {
            this.SourceText = SourceText;
            
            this.SourceLanguage = SourceLanguage;
            this.TargetLanguage = TargetLanguage;

            return Translate();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="SourceText"></param>
        /// <param name="TargetLanguage"></param>
        /// <returns></returns>
        public string Translate(string SourceText, Language TargetLanguage)
        {
            this.SourceText = SourceText;
            
            this.SourceLanguage = Language.Auto_Detect;
            this.TargetLanguage = TargetLanguage;

            return Translate();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="SourceText"></param>
        /// <returns></returns>
        public string Translate(string SourceText)
        {
            this.SourceText = SourceText;            

            return Translate();
        }
        #endregion
    }
}