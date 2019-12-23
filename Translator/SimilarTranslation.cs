using System.Collections.Generic;

namespace MDH.Strings.Translation
{
    /// <summary>
    /// 
    /// </summary>
    public class SimilarTranslation
    {
        /// <summary>
        /// 
        /// </summary>
        public PartOfSpeech PartOfSpeech { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public string Translation { get; private set; }
        
        /// <summary>
        /// 
        /// </summary>
        public List<string> TranslationsToSourceLanguage { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        public TranslationFrequency TranslationFrequency;

        /// <summary>
        /// 
        /// </summary>
        public SimilarTranslation()
        {
            this.PartOfSpeech = PartOfSpeech.Not_Specified;
            this.Translation = null;
            //this.SourceText = null;
            this.TranslationsToSourceLanguage = null;// new List<string>();
            this.TranslationFrequency = TranslationFrequency.Not_Specified;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="partOfSpeech"></param>
        /// <param name="translation"></param>
        /// <param name="translationsToSourceLanguage"></param>
        /// <param name="translationFrequency"></param>
        public SimilarTranslation(PartOfSpeech partOfSpeech, string translation, List<string> translationsToSourceLanguage, TranslationFrequency translationFrequency)
        {
            this.PartOfSpeech = partOfSpeech;
            this.Translation = translation;
            this.TranslationsToSourceLanguage = translationsToSourceLanguage;
        }
    }
}