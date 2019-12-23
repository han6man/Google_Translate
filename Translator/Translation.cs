using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MDH.Strings.Translation
{
    /// <summary>
    /// 
    /// </summary>
    public class Translation
    {
        /// <summary>
        /// 
        /// </summary>
        public TranslationSource TranslationSource { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string TranslationText { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public Language TranslationLanguage { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public string Transliteration { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<SimilarTranslation> SimilarTranslations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sourceText"></param>
        /// <param name="sourceLanguage"></param>
        /// <param name="translationText"></param>
        /// <param name="translationLanguage"></param>
        public Translation(string sourceText, Language sourceLanguage, string translationText, Language translationLanguage)
        {
            this.TranslationSource = new TranslationSource(sourceText, sourceLanguage);
            this.TranslationText = translationText;
            this.TranslationLanguage = translationLanguage;
            this.Transliteration = null;
            this.SimilarTranslations = null;
        }
    }
}
