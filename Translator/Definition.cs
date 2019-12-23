using System.Collections.Generic;

namespace MDH.Strings.Translation
{
    /// <summary>
    /// 
    /// </summary>
    public class Definition
    {
        /// <summary>
        /// 
        /// </summary>
        public Language DefinitionLanguage { get; private set; }
        /// <summary>
        /// In traditional grammar, a part of speech (abbreviated form: PoS or POS) is a category of words (or, more generally, of lexical items) that have similar grammatical properties.
        /// Words that are assigned to the same part of speech generally display similar synactic behavior—they play similar roles within the grammatical structure of sentences—and sometimes similar morphology in that they undergo inflection for similar properties.
        /// </summary>
        public PartOfSpeech PartOfSpeech { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public int DefinitionNumber { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public string DescriptionText { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public string Example { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public List<Synonym> Synonyms { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="definitionLanguage"></param>
        /// <param name="definitionNumber"></param>
        /// <param name="partOfSpeech"></param>
        /// <param name="value"></param>
        /// <param name="example"></param>
        public Definition(Language definitionLanguage, int definitionNumber, PartOfSpeech partOfSpeech, string value, string example)
        {
            this.DefinitionLanguage = definitionLanguage;
            this.DefinitionNumber = definitionNumber;
            this.PartOfSpeech = partOfSpeech;
            this.DescriptionText = value;
            this.Example = example;
            Synonyms = null;
        }
    }
}