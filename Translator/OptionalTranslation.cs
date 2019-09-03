using System.Collections.Generic;

namespace MDH.Strings.Translation
{
    /// <summary>
    /// 
    /// </summary>
    public class OptionalTranslation
    {
        /// <summary>
        /// 
        /// </summary>
        public PartOfSpeech PartOfSpeech { get; private set; } = PartOfSpeech.Not_Specified;
        /// <summary>
        /// 
        /// </summary>
        public string Translation { get; private set; } = "";
        /// <summary>
        /// 
        /// </summary>
        public string SourceText { get; private set; } = "";
        /// <summary>
        /// 
        /// </summary>
        public List<Synonym> SourceSynonyms { get; private set; } = new List<Synonym>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="partOfSpeech"></param>
        /// <param name="translation"></param>
        /// <param name="sourceText"></param>
        /// <param name="sorces"></param>
        public OptionalTranslation(PartOfSpeech partOfSpeech, string translation, string sourceText, List<Synonym> sorces)
        {
            this.PartOfSpeech = partOfSpeech;
            this.Translation = translation;
            this.SourceText = sourceText;
            this.SourceSynonyms = sorces;
        }
    }
}