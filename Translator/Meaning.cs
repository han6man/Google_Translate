using System.Collections.Generic;

namespace MDH.Strings.Translation
{
    /// <summary>
    /// 
    /// </summary>
    public class Meaning
    {
        /// <summary>
        /// 
        /// </summary>
        public string Word { get; private set; } = "";
        /// <summary>
        /// In traditional grammar, a part of speech (abbreviated form: PoS or POS) is a category of words (or, more generally, of lexical items) that have similar grammatical properties.
        /// Words that are assigned to the same part of speech generally display similar synactic behavior—they play similar roles within the grammatical structure of sentences—and sometimes similar morphology in that they undergo inflection for similar properties.
        /// </summary>
        public PartOfSpeech PartOfSpeech { get; private set; } = PartOfSpeech.Not_Specified;
        /// <summary>
        /// 
        /// </summary>
        public string Description { get; private set; } = "";
        /// <summary>
        /// 
        /// </summary>
        public string Example { get; private set; } = "";
        /// <summary>
        /// 
        /// </summary>
        public List<Synonym> Synonyms { get; private set; } = new List<Synonym>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="word"></param>
        /// <param name="partOfSpeech"></param>
        /// <param name="value"></param>
        /// <param name="example"></param>
        /// <param name="synonyms"></param>
        public Meaning(string word, PartOfSpeech partOfSpeech, string value, string example, List<Synonym> synonyms)
        {
            this.Word = word;
            this.PartOfSpeech = partOfSpeech;
            this.Description = value;
            this.Example = example;
            this.Synonyms = synonyms;
        }
    }
}