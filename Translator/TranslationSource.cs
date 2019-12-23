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
    public class TranslationSource
    {
        /// <summary>
        /// 
        /// </summary>
        public string SourceText { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public Language SourceLanguage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Transliteration { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Definition> Definitions { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> Examples { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Synonym> Synonyms { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<string> SeeAlso { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sourceText"></param>
        public TranslationSource(string sourceText)
        {
            this.SourceText = sourceText;
            this.SourceLanguage = Language.Auto_Detect;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sourceText"></param>
        /// <param name="sourceLanguage"></param>
        public TranslationSource(string sourceText, Language sourceLanguage)
        {
            this.SourceText = sourceText;
            this.SourceLanguage = sourceLanguage;
        }
    }
}
