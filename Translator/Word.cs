namespace MDH.Strings.Translation
{
    /// <summary>
    /// 
    /// </summary>
    public class Word
    {
        /// <summary>
        /// 
        /// </summary>
        public string Text { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public Language Language { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public PartOfSpeech PartOfSpeech { get; private set; } = PartOfSpeech.Not_Specified;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="language"></param>
        public Word(string text, Language language, PartOfSpeech partOfSpeech)
        {
            this.PartOfSpeech = partOfSpeech;
            this.Text = text;
            this.Language = language;
        }
    }
}