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
    public class TargetTextDescription
    {
        /// <summary>
        /// 
        /// </summary>
        public string SourceText { get; private set; } = "";
        /// <summary>
        /// 
        /// </summary>
        public Language SourceLanguage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Translation { get; private set; } = "";
        /// <summary>
        /// 
        /// </summary>
        public Language TargetLanguage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<OptionalTranslation> OptionalTranslations { get; private set; } = new List<OptionalTranslation>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sourceText"></param>
        /// <param name="translation"></param>
        /// <param name="optionalTranslations"></param>
        public TargetTextDescription(string sourceText, string translation, List<OptionalTranslation> optionalTranslations)
        {
            this.SourceText = sourceText;
            this.Translation = translation;
            this.OptionalTranslations = optionalTranslations;
        }
    }
}
