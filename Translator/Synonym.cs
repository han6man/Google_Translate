namespace MDH.Strings.Translation
{
    /// <summary>
    /// 
    /// </summary>
    public class Synonym
    {
        /// <summary>
        /// 
        /// </summary>
        public PartOfSpeech PartOfSpeech { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public string Text { get; private set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        public Synonym(string text)
        {
            this.PartOfSpeech = PartOfSpeech.Not_Specified;
            this.Text = text;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="partOfSpeech"></param>
        /// <param name="text"></param>
        public Synonym(PartOfSpeech partOfSpeech, string text)
        {
            this.PartOfSpeech = partOfSpeech;
            this.Text = text;
        }
    }
}