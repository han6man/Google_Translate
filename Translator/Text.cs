namespace MDH.Strings.Translation
{
    /// <summary>
    /// 
    /// </summary>
    public class Text
    {
        /// <summary>
        /// 
        /// </summary>
        public string _Text { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public Language Language { get; private set; }
        /// <summary>
        /// 
        /// </summary>
        public PartOfSpeech PartOfSpeech { get; private set; } = PartOfSpeech.Article;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <param name="language"></param>
        public Text(string text, Language language)
        {
            this._Text = text;
            this.Language = language;
        }
    }
}