using Awesomium.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Google_Translate
{
    public class GoogleTranslator
    {
        private int framesLoaded = 1;
        private bool isDomReady = false;
        private bool isMainFrame = false;
        private WebView webView;
        private WebSession webSession;

        public string ToLng { get; set; }
        public string FromLng { get; set; } = "auto";

        #region Constractors
        /// <summary>
        /// 
        /// </summary>
        public GoogleTranslator()
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="toLng"></param>
        public GoogleTranslator(string toLng)
        {
            ToLng = toLng;
            FromLng = "auto";

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fromLng"></param>
        /// <param name="toLng"></param>
        public GoogleTranslator(string fromLng, string toLng)
        {
            ToLng = toLng;
            FromLng = fromLng;

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
        /// <param name="textToTranslate"></param>
        /// <param name="fromLng"></param>
        /// <param name="toLng"></param>
        /// <returns></returns>
        public string Translate(string textToTranslate, string fromLng, string toLng)
        {
            ToLng = toLng;
            FromLng = fromLng;

            isDomReady = false;
            string t = null;

            Uri url = new Uri(String.Format("https://translate.google.com/#view=home&op=translate&sl={0}&tl={1}&text={2}", fromLng, toLng, textToTranslate));
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
            
            t = Parse(webView.HTML);

            while (t == null)
            {
                isDomReady = false;
                webView.Source = url;
                webView.Source = webView.Source;

                while (!isDomReady)
                {
                    Thread.Sleep(100);
                    // A Console application does not have a synchronization
                    // context, thus auto-update won't be enabled on WebCore.
                    // We need to manually call Update here.
                    WebCore.Update();
                }
                t = Parse(webView.HTML);
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
        public string Translate(string textToTranslate, string toLng)
        {
            ToLng = toLng;
            FromLng = "auto";

            isDomReady = false;
            string t = null;

            Uri url = new Uri(String.Format("https://translate.google.com/#view=home&op=translate&sl={0}&tl={1}&text={2}", "auto", toLng, textToTranslate));
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

            t = Parse(webView.HTML);

            while (t == null)
            {
                isDomReady = false;
                webView.Source = url;
                webView.Source = webView.Source;

                while (!isDomReady)
                {
                    Thread.Sleep(100);
                    // A Console application does not have a synchronization
                    // context, thus auto-update won't be enabled on WebCore.
                    // We need to manually call Update here.
                    WebCore.Update();
                }
                t = Parse(webView.HTML);
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
        /// <returns></returns>
        public string Translate(string textToTranslate)
        {
            isDomReady = false;
            string t = null;

            Uri url = new Uri(String.Format("https://translate.google.com/#view=home&op=translate&sl={0}&tl={1}&text={2}", FromLng, ToLng, textToTranslate));
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

            t = Parse(webView.HTML);

            while (t == null)
            {
                isDomReady = false;
                webView.Source = url;
                webView.Source = webView.Source;

                while (!isDomReady)
                {
                    Thread.Sleep(100);
                    // A Console application does not have a synchronization
                    // context, thus auto-update won't be enabled on WebCore.
                    // We need to manually call Update here.
                    WebCore.Update();
                }
                t = Parse(webView.HTML);
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
