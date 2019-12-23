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
    public class SourceTextDescription
    {
        /// <summary>
        /// 
        /// </summary>
        public string Word { get; private set; } = "";
        /// <summary>
        /// 
        /// </summary>
        public List<Definition> Definition { get; private set; } = new List<Definition>();
        /// <summary>
        /// 
        /// </summary>
        public List<Synonym> Synonyms { get; private set; } = new List<Synonym>();
        /// <summary>
        /// 
        /// </summary>
        public List<string> ExamplesOfUsing { get; private set; } = new List<string>();
        /// <summary>
        /// 
        /// </summary>
        public List<string> SimilarWords { get; private set; } = new List<string>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="word"></param>
        /// <param name="definition"></param>
        /// <param name="synonyms"></param>
        /// <param name="examplesOfUsing"></param>
        /// <param name="similarWords"></param>
        public SourceTextDescription(string word, List<Definition> definition, List<Synonym> synonyms, List<string> examplesOfUsing, List<string> similarWords)
        {
            this.Word = word;
            this.Definition = definition;
            this.Synonyms = synonyms;
            this.ExamplesOfUsing = examplesOfUsing;
            this.SimilarWords = similarWords;
        }
    }
}
