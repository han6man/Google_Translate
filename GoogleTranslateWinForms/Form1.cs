using HtmlAgilityPack;
using MDH.Strings.Translation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
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
            //while(webControl1.IsLoading)
            {
                Application.DoEvents();
            }
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            button1.Enabled = true;
            isDomReady = false;
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
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                //WebClient webClient = new WebClient();
                //webClient.Encoding = System.Text.Encoding.UTF8;
                //string result = webClient.DownloadString(String.Format("https://translate.google.com/#view=home&op=translate&sl={0}&tl={1}&text={2}", "auto", "ru", textBox1.Text));
                //textBox2.Text = Parse(result);

                textBox2.Text = Translate(textBox1.Text, "en", "ru");
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
        private void Awesomium_Windows_Forms_WebControl_AddressChanged(object sender, Awesomium.Core.UrlEventArgs e)
        {
            if (!this.webControl1.IsLoading)
            {
                //webControl1.Source = webControl1.Source;
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
            string t = null;

            Uri url = new Uri(String.Format("https://translate.google.com/#view=home&op=translate&sl={0}&tl={1}&text={2}", fromLng, toLng, textToTranslate));
            webControl1.Source = url;
            //for refreshing webControl1.HTML
            webControl1.Source = webControl1.Source;

            //waiting for loding html
            while (!isDomReady)
            //while (webControl1.IsLoading)
            {
                Application.DoEvents();
            }

            //Clipboard.Clear();
            //webControl1.SelectAll();
            //webControl1.CopyHTML();
            //string HTML = Clipboard.GetText();

            //t = Parse(webControl1.HTML);
            t = Parse2(webControl1.HTML)?.TranslationText;
            isDomReady = false;

            while (t == null)
            {                
                webControl1.Source = url;
                webControl1.Source = webControl1.Source;
                while (!isDomReady)
                //while (webControl1.IsLoading)
                {
                    Application.DoEvents();
                }
                //t = Parse(webControl1.HTML);
                t = Parse2(webControl1.HTML)?.TranslationText;
                isDomReady = false;
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
            string t = null;

            Uri url = new Uri(String.Format("https://translate.google.com/#view=home&op=translate&sl={0}&tl={1}&text={2}", "auto", toLng, textToTranslate));
            webControl1.Source = url;
            //for refreshing webControl1.HTML
            webControl1.Source = webControl1.Source;

            //waiting for loding html
            //while (!isDomReady)
            while (webControl1.IsLoading)
            {
                Application.DoEvents();
            }

            //Clipboard.Clear();
            //webControl1.SelectAll();
            //webControl1.CopyHTML();
            //string HTML = Clipboard.GetText();            

            //t = Parse(webControl1.HTML);
            t = Parse2(webControl1.HTML)?.TranslationText;
            isDomReady = false;

            while (t == null)
            {
                webControl1.Source = url;
                webControl1.Source = webControl1.Source;
                while (!isDomReady)
                //while (webControl1.IsLoading)
                {
                    Application.DoEvents();
                }
                //t = Parse(webControl1.HTML);
                t = Parse2(webControl1.HTML)?.TranslationText;
                isDomReady = false;
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

        private Translation Parse2(string HTML)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(HTML);

            #region Translation Text
            HtmlNodeCollection _targetTextNodes = doc.DocumentNode.SelectNodes("//div[contains(@class, 'text-wrap tlid-copy-target')]");
            if (_targetTextNodes == null)
            {
                return null;
            }
            string translationText = _targetTextNodes?[0].GetElementsByClass("span", "tlid-translation translation").ToList()[0].InnerHtml;
            translationText = translationText.Replace("<br>", "\r\n");
            translationText = translationText.Replace("</span>", "");
            translationText = translationText.Replace("<span title=\"\">", "");
            #endregion
            #region Translation Language
            string tl = _targetTextNodes[0].GetElementsByClass("span", "tlid-translation translation").ToList()[0].GetAttributeValue("lang", "");
            Language translationLanguage = Language.Languages.Find(l => l.Code == tl);

            //Type language = typeof(Language);
            //PropertyInfo myPropInfo = language.GetProperty("Russian");
            //PropertyInfo[] l = language.GetProperties();
            //foreach (PropertyInfo prop in language.GetProperties())
            //{
            //    if (prop.GetType() != typeof(Language))
            //        continue;

            //    //object[] attributes = prop.GetCustomAttributes(typeof(MyAttribute), true);
            //    //if (attributes.Length == 1)
            //    //{
            //    //    //Property with my custom attribute
            //    //}
            //}
            #endregion
            #region Source Text
            HtmlNodeCollection _sourceTextNodes = doc.DocumentNode.SelectNodes("//div[contains(@class, 'text-dummy')]");
            string sourceText = _sourceTextNodes?[0].InnerHtml;
            //string sourceText = (_sourceTextNodes == null) ? null : _sourceTextNodes[0].InnerHtml;
            //string sourceText = _sourceTextNodes?[0].InnerHtml;
            #endregion
            #region Source Language
            //<div role="button"
            //<div class="lang-btn">
            Language sourcseLanguage = Language.Not_Specified;
            #endregion

            Translation translation = new Translation(sourceText, sourcseLanguage, translationText, translationLanguage);

            #region Translation Transliteration
            HtmlNodeCollection _targetTextTranslitNodes = doc.DocumentNode.SelectNodes("//div[contains(@class, 'tlid-result-transliteration-container result-transliteration-container transliteration-container')]");
            if (_targetTextTranslitNodes != null)
            {
                translation.Transliteration = _targetTextTranslitNodes[0].InnerHtml;
            }
            //string translit = _targetTextTranslitNodes?[0].InnerHtml;
            #endregion
            #region SimilarTranslations
            HtmlNodeCollection _targetTextTranslationsNodes = doc.DocumentNode.SelectNodes("//div[contains(@class, 'gt-cd gt-cd-mbd gt-cd-baf')]");
            if (_targetTextTranslationsNodes != null)
            {
                translation.SimilarTranslations = new List<SimilarTranslation>();
                string similarTranslation = null;
                List<string> translationsToSourceLanguage = null;
                PartOfSpeech PartOfSpeech = PartOfSpeech.Not_Specified;
                TranslationFrequency translationFrequency = TranslationFrequency.Not_Specified;

                IEnumerable<HtmlNode> trs = _targetTextTranslationsNodes[0].GetElementsByTagName("tr");
                foreach (HtmlNode tr in trs)
                {
                    List<HtmlNode> tds = tr.GetElementsByTagName("td").ToList();
                    if (tds.Count == 1)
                    {
                        PartOfSpeech = (PartOfSpeech)Enum.Parse(typeof(PartOfSpeech), tds[0].GetElementsByClass("span", "gt-cd-pos").ToList()[0].InnerHtml);
                    }
                    if (tds.Count == 3)
                    {
                        similarTranslation = tds[0].GetElementsByClass("span", "gt-baf-cell gt-baf-word-clickable").ToList()[0].InnerText;
                        translationsToSourceLanguage = new List<string>();
                        foreach (HtmlNode td in tds[1].GetElementsByClass("span", "gt-baf-back"))
                        {
                            translationsToSourceLanguage.Add(td.InnerText);
                        }
                        string tf = tds[2].GetElementsByClass("div", "gt-baf-cell gt-baf-entry-score").ToList()[0].GetAttributeValue("title", null);
                        translationFrequency = (TranslationFrequency)Enum.Parse(typeof(TranslationFrequency), tf.Replace(' ', '_'));
                    }

                    translation.SimilarTranslations.Add(new SimilarTranslation(PartOfSpeech, similarTranslation, translationsToSourceLanguage, translationFrequency));
                }

            }

            #endregion

            #region Source Translitiration
            //HtmlNodeCollection _sourceTranscriptionNodes = doc.DocumentNode.SelectNodes("//div[contains(@class, 'tlid-source-transliteration-container source-transliteration-container transliteration-container')]");
            //IEnumerable<HtmlNode> tt = _sourceTranscriptionNodes[0].GetElementsByClass("div", "tlid-transliteration-content transliteration-content full");

            HtmlNodeCollection _sourceTextWTranscriptionNodes = doc.DocumentNode.SelectNodes("//div[contains(@class, 'gt-cc-t')]");

            //Source text
            //var tst = _sourceTextWTranscriptionNodes[0].GetElementsByClass("span", "gt-ct-text").ToList()[0].InnerHtml;

            //Source translitiration
            translation.TranslationSource.Transliteration = _sourceTextWTranscriptionNodes?[0].GetElementsByClass("span", "gt-ct-translit")?.ToList()[0].InnerHtml;
            #endregion

            translation.TranslationSource.Definitions = GetSourceDefinitions(doc);
            translation.TranslationSource.Examples = GetSourceExamples(doc);
            translation.TranslationSource.Synonyms = GetSourceSynonyms(doc);
            translation.TranslationSource.SeeAlso = GetSourceSeeAlso(doc);
            
            //textBox3.Text = _sourceTextWTranscriptionNodes[0].InnerHtml;
            return translation;
        }

        private List<string> GetSourceSeeAlso(HtmlAgilityPack.HtmlDocument doc)
        {
            HtmlNodeCollection _sourceTextSeeAlsoNodes = doc.DocumentNode.SelectNodes("//div[contains(@class, 'gt-cd gt-cd-mrw')]");

            return new List<string>();
        }

        private List<Synonym> GetSourceSynonyms(HtmlAgilityPack.HtmlDocument doc)
        {
            HtmlNodeCollection _sourceTextSynonymsNodes = doc.DocumentNode.SelectNodes("//div[contains(@class, 'gt-cd gt-cd-mss')]");
            if (_sourceTextSynonymsNodes == null)
            {
                return null;
            }

            HtmlAgilityPack.HtmlDocument _sourceTextSynonymsNodesDoc = new HtmlAgilityPack.HtmlDocument();
            _sourceTextSynonymsNodesDoc.LoadHtml(_sourceTextSynonymsNodes[0].InnerHtml);

            HtmlNodeCollection x = _sourceTextSynonymsNodesDoc.DocumentNode.SelectNodes("//div [@class='gt-cd-pos']");
            HtmlNodeCollection y = _sourceTextSynonymsNodesDoc.DocumentNode.SelectNodes("//ul [@class='gt-syn-list']");

            if (x.Count != y.Count || x.Count < 1)
            {
                return null;
            }

            List<Synonym> synonyms = new List<Synonym>();

            for (int i = 0; i < x.Count; i++)
            {
                PartOfSpeech PartOfSpeech = (PartOfSpeech)Enum.Parse(typeof(PartOfSpeech), x[i].InnerHtml);

                HtmlAgilityPack.HtmlDocument synonymsDoc = new HtmlAgilityPack.HtmlDocument();
                synonymsDoc.LoadHtml(y[i].InnerHtml);

                HtmlNodeCollection synNodes = synonymsDoc.DocumentNode.SelectNodes("//span [@class='gt-cd-cl']");
                foreach (var synNode in synNodes)
                {
                    synonyms.Add(new Synonym(PartOfSpeech, synNode.InnerText.Trim()));
                }
            }

            return synonyms;
        }

        private List<string> GetSourceExamples(HtmlAgilityPack.HtmlDocument doc)
        {
            HtmlNodeCollection _sourceTextExamplesNodes = doc.DocumentNode.SelectNodes("//div[contains(@class, 'gt-cd gt-cd-mex')]");
            if (_sourceTextExamplesNodes == null)
            {
                return null;
            }

            HtmlAgilityPack.HtmlDocument _sourceTextExamplesNodesDoc = new HtmlAgilityPack.HtmlDocument();
            _sourceTextExamplesNodesDoc.LoadHtml(_sourceTextExamplesNodes[0].InnerHtml);

            HtmlNodeCollection ex = _sourceTextExamplesNodesDoc.DocumentNode.SelectNodes("//div[contains(@class, 'gt-ex-text')]");

            if ( ex == null || ex.Count < 1 )
            {
                return null;
            }

            List<string> examples = new List<string>();

            foreach (var item in ex)
            {
                examples.Add(item.InnerText.Trim());
            }

            return examples;
        }

        private static List<Definition> GetSourceDefinitions(HtmlAgilityPack.HtmlDocument doc)
        {
            HtmlNodeCollection _sourceTextDefinitionsNodes = doc.DocumentNode.SelectNodes("//div [@class='gt-cd gt-cd-mmd']");
            if (_sourceTextDefinitionsNodes == null)
            {
                return null;
            }

            HtmlAgilityPack.HtmlDocument _sourceTextDefinitionsNodesDoc = new HtmlAgilityPack.HtmlDocument();
            _sourceTextDefinitionsNodesDoc.LoadHtml(_sourceTextDefinitionsNodes[0].InnerHtml);

            //var x = _sourceTextDefinitionsNodes[0].SelectNodes("//div [contains(@class, 'gt-cd-pos')]");
            //var x = _sourceTextDefinitionsNodes[0].GetElementsByClass("div", "gt-cd-pos");
            //var x = _sourceTextDefinitionsNodes[0].SelectNodes("//div [@class='gt-cd-pos']");
            //var y = _sourceTextDefinitionsNodes[0].SelectNodes("//div [@class='gt-def-list']"); //style="direction: ltr;
            HtmlNodeCollection x = _sourceTextDefinitionsNodesDoc.DocumentNode.SelectNodes("//div [@class='gt-cd-pos']");
            HtmlNodeCollection y = _sourceTextDefinitionsNodesDoc.DocumentNode.SelectNodes("//div [@class='gt-def-list']");

            if (x.Count != y.Count || x.Count < 1)
            {
                return null;
            }

            List<Definition> definitions = new List<Definition>();

            for (int i = 0; i < x.Count; i++)
            {
                PartOfSpeech PartOfSpeech = (PartOfSpeech)Enum.Parse(typeof(PartOfSpeech), x[i].InnerHtml);

                HtmlAgilityPack.HtmlDocument defsDoc = new HtmlAgilityPack.HtmlDocument();
                defsDoc.LoadHtml(y[i].InnerHtml);

                HtmlNodeCollection defNodes = defsDoc.DocumentNode.SelectNodes("//div [@class='gt-def-info']");

                foreach (HtmlNode defNode in defNodes)
                {
                    Language defLang = Language.Languages.Find(l => l.Code == defNode.GetAttributeValue("lang", ""));

                    HtmlAgilityPack.HtmlDocument defDoc = new HtmlAgilityPack.HtmlDocument();
                    defDoc.LoadHtml(defNode.InnerHtml);

                    string gt_def_num = defDoc.DocumentNode.SelectNodes("//span [@class='gt-def-num']")[0]?.InnerText;
                    string gt_def_row = defDoc.DocumentNode.SelectNodes("//div [@class='gt-def-row']")[0].InnerText;
                    string gt_def_example = defDoc.DocumentNode.SelectNodes("//div [@class='gt-def-example']")[0].InnerText;

                    Definition def = new Definition(defLang, int.Parse(gt_def_num), PartOfSpeech, gt_def_row, gt_def_example);

                    HtmlNodeCollection syn = defDoc.DocumentNode.SelectNodes("//div [@class='gt-def-synonym']");

                    if (syn != null)
                    {
                        def.Synonyms = new List<Synonym>();

                        foreach (var s in syn[0].SelectNodes("//span [@class='gt-cd-cl']"))
                        {
                            def.Synonyms.Add(new Synonym(PartOfSpeech, s.InnerHtml.Trim()));
                        }
                    }
                    definitions.Add(def);
                }

            }

            return definitions;
        }
    }
}
