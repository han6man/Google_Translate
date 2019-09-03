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
    public class Language
    {
        /// <summary>
        /// Google Language Code
        /// </summary>
        public string Code { get; } = string.Empty;
        /// <summary>
        /// Google Language English Name
        /// </summary>
        public string EnglishName { get; } = string.Empty;
        /// <summary>
        /// Google Language Native Name
        /// </summary>
        public string NativeName { get; } = string.Empty;
        /// <summary>
        /// ISO 639 is a standardized nomenclature used to classify languages. Each language is assigned a two-letter (639-1),
        /// lowercase abbreviation, amended in later versions of the nomenclature.
        /// ISO 639-1: two-letter codes, one per language for ISO 639 macrolanguage
        /// </summary>
        public string ISO_639_1_code { get; } = string.Empty;
        /// <summary>
        /// ISO 639-2/T: three-letter codes, for the same languages as 639-1
        /// </summary>
        public string ISO_639_2T_code { get; } = string.Empty;
        /// <summary>
        /// ISO 639-2/B: three-letter codes, mostly the same as 639-2/T, but with some codes derived from English names rather than native names of languages
        /// (in the following table, these differing codes are highlighted in boldface)
        /// </summary>
        public string ISO_639_2B_code { get; } = string.Empty;
        /// <summary>
        /// ISO 639-3: three-letter codes, the same as 639-2/T for languages, but with distinct codes for each variety of an ISO 639 macrolanguage
        /// </summary>
        public string ISO_639_3_code { get; } = string.Empty;
        /// <summary>
        /// ISO 639-5: three-letter Language Family code
        /// </summary>
        public string ISO_639_5_code { get; } = string.Empty;

        #region Constractor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Code"></param>
        /// <param name="EnglishName"></param>
        private Language(string Code, string EnglishName)
        {
            this.Code = Code;
            this.EnglishName = EnglishName;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="Code">Google code for language</param>
        /// <param name="EnglishName"></param>
        /// <param name="NativeName"></param>
        /// <param name="ISO_639_1_code"></param>
        /// <param name="ISO_639_2T_code"></param>
        /// <param name="ISO_639_2B_code"></param>
        /// <param name="ISO_639_3_code"></param>
        /// <param name="ISO_639_5_code"></param>
        private Language(string Code, string EnglishName, string NativeName, string ISO_639_1_code, string ISO_639_2T_code, string ISO_639_2B_code, string ISO_639_3_code, string ISO_639_5_code)
        {
            this.Code = Code;
            this.EnglishName = EnglishName;
            this.NativeName = NativeName;
            this.ISO_639_1_code = ISO_639_1_code;
            this.ISO_639_2T_code = ISO_639_2T_code;
            this.ISO_639_2B_code = ISO_639_2B_code;
            this.ISO_639_3_code = ISO_639_3_code;
            this.ISO_639_5_code = ISO_639_5_code;
        }
        #endregion

        #region Languages
        /// <summary>
        /// Language Auto Detect
        /// </summary>
        public static Language Not_Specified = new Language("", "", "", "", "", "", "", "");
        /// <summary>
        /// Language Auto Detect
        /// </summary>
        public static Language Auto_Detect = new Language("auto", "Auto Detect", "", "", "", "", "", "");
        /// <summary>
        /// Language Afrikaans
        /// </summary>
        public static Language Afrikaans = new Language("af", "Afrikaans", "", "", "", "", "", "");
        /// <summary>
        /// Language Albanian
        /// </summary>
        public static Language Albanian = new Language("sq", "Albanian", "", "", "", "", "", "");
        /// <summary>
        /// Language Amharic
        /// </summary>
        public static Language Amharic = new Language("am", "Amharic", "", "", "", "", "", "");
        /// <summary>
        /// Language Arabic
        /// </summary>
        public static Language Arabic = new Language("ar", "Arabic", "", "", "", "", "", "");
        /// <summary>
        /// Language Armenian
        /// </summary>
        public static Language Armenian = new Language("hy", "Armenian", "", "", "", "", "", "");
        /// <summary>
        /// Language Azerbaijani
        /// </summary>
        public static Language Azerbaijani = new Language("az", "Azerbaijani", "", "", "", "", "", "");
        /// <summary>
        /// Language Basque
        /// </summary>
        public static Language Basque = new Language("eu", "Basque", "", "", "", "", "", "");
        /// <summary>
        /// Language Belarusian
        /// </summary>
        public static Language Belarusian = new Language("be", "Belarusian", "", "", "", "", "", "");
        /// <summary>
        /// Language Bengali
        /// </summary>
        public static Language Bengali = new Language("bn", "Bengali", "", "", "", "", "", "");
        /// <summary>
        /// Language Bosnian
        /// </summary>
        public static Language Bosnian = new Language("bs", "Bosnian", "", "", "", "", "", "");
        /// <summary>
        /// Language Bulgarian
        /// </summary>
        public static Language Bulgarian = new Language("bg", "Bulgarian", "", "", "", "", "", "");
        /// <summary>
        /// Language Catalan
        /// </summary>
        public static Language Catalan = new Language("ca", "Catalan", "", "", "", "", "", "");
        /// <summary>
        /// Language Cebuano
        /// </summary>
        public static Language Cebuano = new Language("ceb", "Cebuano", "", "", "", "", "", "");
        /// <summary>
        /// Language Chichewa
        /// </summary>
        public static Language Chichewa = new Language("ny", "Chichewa", "", "", "", "", "", "");
        /// <summary>
        /// Language Chinese
        /// </summary>
        public static Language Chinese = new Language("zh-CN", "Chinese", "", "", "", "", "", "");
        /// <summary>
        /// Language Corsican
        /// </summary>
        public static Language Corsican = new Language("co", "Corsican", "", "", "", "", "", "");
        /// <summary>
        /// Language Croatian
        /// </summary>
        public static Language Croatian = new Language("hr", "Croatian", "", "", "", "", "", "");
        /// <summary>
        /// Language Czech
        /// </summary>
        public static Language Czech = new Language("cs", "Czech", "", "", "", "", "", "");
        /// <summary>
        /// Language Danish
        /// </summary>
        public static Language Danish = new Language("da", "Danish", "", "", "", "", "", "");
        /// <summary>
        /// Language Dutch
        /// </summary>
        public static Language Dutch = new Language("nl", "Dutch", "", "", "", "", "", "");
        /// <summary>
        /// Language English
        /// </summary>
        public static Language English = new Language("en", "English", "", "", "", "", "", "");
        /// <summary>
        /// Language Esperanto
        /// </summary>
        public static Language Esperanto = new Language("eo", "Esperanto", "", "", "", "", "", "");
        /// <summary>
        /// Language Estonian
        /// </summary>
        public static Language Estonian = new Language("et", "Estonian", "", "", "", "", "", "");
        /// <summary>
        /// Language Filipino
        /// </summary>
        public static Language Filipino = new Language("tl", "Filipino", "", "", "", "", "", "");
        /// <summary>
        /// Language Finnish
        /// </summary>
        public static Language Finnish = new Language("fi", "Finnish", "", "", "", "", "", "");
        /// <summary>
        /// Language French
        /// </summary>
        public static Language French = new Language("fr", "French", "", "", "", "", "", "");
        /// <summary>
        /// Language Frisian
        /// </summary>
        public static Language Frisian = new Language("fy", "Frisian", "", "", "", "", "", "");
        /// <summary>
        /// Language Galician
        /// </summary>
        public static Language Galician = new Language("gl", "Galician", "", "", "", "", "", "");
        /// <summary>
        /// Language Georgian
        /// </summary>
        public static Language Georgian = new Language("ka", "Georgian", "", "", "", "", "", "");
        /// <summary>
        /// Language German
        /// </summary>
        public static Language German = new Language("de", "German", "", "", "", "", "", "");
        /// <summary>
        /// Language Greek
        /// </summary>
        public static Language Greek = new Language("el", "Greek", "", "", "", "", "", "");
        /// <summary>
        /// Language Gujarati
        /// </summary>
        public static Language Gujarati = new Language("gu", "Gujarati", "", "", "", "", "", "");
        /// <summary>
        /// Language Haitian Creole
        /// </summary>
        public static Language Haitian_Creole = new Language("ht", "Haitian Creole", "", "", "", "", "", "");
        /// <summary>
        /// Language Hausa
        /// </summary>
        public static Language Hausa = new Language("ha", "Hausa", "", "", "", "", "", "");
        /// <summary>
        /// Language Hawaiian
        /// </summary>
        public static Language Hawaiian = new Language("haw", "Hawaiian", "", "", "", "", "", "");
        /// <summary>
        /// Language Hebrew
        /// </summary>
        public static Language Hebrew = new Language("iw", "Hebrew", "", "", "", "", "", "");
        /// <summary>
        /// Language Hindi
        /// </summary>
        public static Language Hindi = new Language("hi", "Hindi", "", "", "", "", "", "");
        /// <summary>
        /// Language Hmong
        /// </summary>
        public static Language Hmong = new Language("hmn", "Hmong", "", "", "", "", "", "");
        /// <summary>
        /// Language Hungarian
        /// </summary>
        public static Language Hungarian = new Language("hu", "Hungarian", "", "", "", "", "", "");
        /// <summary>
        /// Language Icelandic
        /// </summary>
        public static Language Icelandic = new Language("is", "Icelandic", "", "", "", "", "", "");
        /// <summary>
        /// Language Igbo
        /// </summary>
        public static Language Igbo = new Language("ig", "Igbo", "", "", "", "", "", "");
        /// <summary>
        /// Language Indonesian
        /// </summary>
        public static Language Indonesian = new Language("id", "Indonesian", "", "", "", "", "", "");
        /// <summary>
        /// Language Irish
        /// </summary>
        public static Language Irish = new Language("ga", "Irish", "", "", "", "", "", "");
        /// <summary>
        /// Language Italian
        /// </summary>
        public static Language Italian = new Language("it", "Italian", "", "", "", "", "", "");
        /// <summary>
        /// Language Japanese
        /// </summary>
        public static Language Japanese = new Language("ja", "Japanese", "", "", "", "", "", "");
        /// <summary>
        /// Language Javanese
        /// </summary>
        public static Language Javanese = new Language("jw", "Javanese", "", "", "", "", "", "");
        /// <summary>
        /// Language Kannada
        /// </summary>
        public static Language Kannada = new Language("kn", "Kannada", "", "", "", "", "", "");
        /// <summary>
        /// Language Kazakh
        /// </summary>
        public static Language Kazakh = new Language("kk", "Kazakh", "", "", "", "", "", "");
        /// <summary>
        /// Language Khmer
        /// </summary>
        public static Language Khmer = new Language("km", "Khmer", "", "", "", "", "", "");
        /// <summary>
        /// Language Korean
        /// </summary>
        public static Language Korean = new Language("ko", "Korean", "", "", "", "", "", "");
        /// <summary>
        /// Language Kurdish
        /// </summary>
        public static Language Kurdish = new Language("ku", "Kurdish", "", "", "", "", "", "");
        /// <summary>
        /// Language Kurmanji
        /// </summary>
        public static Language Kurmanji = new Language("ku", "Kurmanji", "", "", "", "", "", "");
        /// <summary>
        /// Language Kyrgyz
        /// </summary>
        public static Language Kyrgyz = new Language("ky", "Kyrgyz", "", "", "", "", "", "");
        /// <summary>
        /// Language Lao
        /// </summary>
        public static Language Lao = new Language("lo", "Lao", "", "", "", "", "", "");
        /// <summary>
        /// Language Latin
        /// </summary>
        public static Language Latin = new Language("la", "Latin", "", "", "", "", "", "");
        /// <summary>
        /// Language Latvian
        /// </summary>
        public static Language Latvian = new Language("lv", "Latvian", "", "", "", "", "", "");
        /// <summary>
        /// Language Lithuanian
        /// </summary>
        public static Language Lithuanian = new Language("lt", "Lithuanian", "", "", "", "", "", "");
        /// <summary>
        /// Language Luxembourgish
        /// </summary>
        public static Language Luxembourgish = new Language("lb", "Luxembourgish", "", "", "", "", "", "");
        /// <summary>
        /// Language Macedonian
        /// </summary>
        public static Language Macedonian = new Language("mk", "Macedonian", "", "", "", "", "", "");
        /// <summary>
        /// Language Malagasy
        /// </summary>
        public static Language Malagasy = new Language("mg", "Malagasy", "", "", "", "", "", "");
        /// <summary>
        /// Language Malay
        /// </summary>
        public static Language Malay = new Language("ms", "Malay", "", "", "", "", "", "");
        /// <summary>
        /// Language Malayalam
        /// </summary>
        public static Language Malayalam = new Language("ml", "Malayalam", "", "", "", "", "", "");
        /// <summary>
        /// Language Maltese
        /// </summary>
        public static Language Maltese = new Language("mt", "Maltese", "", "", "", "", "", "");
        /// <summary>
        /// Language Maori
        /// </summary>
        public static Language Maori = new Language("mi", "Maori", "", "", "", "", "", "");
        /// <summary>
        /// Language Marathi
        /// </summary>
        public static Language Marathi = new Language("mr", "Marathi", "", "", "", "", "", "");
        /// <summary>
        /// Language Mongolian
        /// </summary>
        public static Language Mongolian = new Language("mn", "Mongolian", "", "", "", "", "", "");
        /// <summary>
        /// Language Myanmar
        /// </summary>
        public static Language Myanmar = new Language("my", "Myanmar", "", "", "", "", "", "");
        /// <summary>
        /// Language Burmese
        /// </summary>
        public static Language Burmese = new Language("my", "Burmese", "", "", "", "", "", "");
        /// <summary>
        /// Language Nepali
        /// </summary>
        public static Language Nepali = new Language("ne", "Nepali", "", "", "", "", "", "");
        /// <summary>
        /// Language Norwegian
        /// </summary>
        public static Language Norwegian = new Language("no", "Norwegian", "", "", "", "", "", "");
        /// <summary>
        /// Language Pashto
        /// </summary>
        public static Language Pashto = new Language("ps", "Pashto", "", "", "", "", "", "");
        /// <summary>
        /// Language Persian
        /// </summary>
        public static Language Persian = new Language("fa", "Persian", "", "", "", "", "", "");
        /// <summary>
        /// Language Polish
        /// </summary>
        public static Language Polish = new Language("pl", "Polish", "", "", "", "", "", "");
        /// <summary>
        /// Language Portuguese
        /// </summary>
        public static Language Portuguese = new Language("pt", "Portuguese", "", "", "", "", "", "");
        /// <summary>
        /// Language Punjabi
        /// </summary>
        public static Language Punjabi = new Language("pa", "Punjabi", "", "", "", "", "", "");
        /// <summary>
        /// Language Romanian
        /// </summary>
        public static Language Romanian = new Language("ro", "Romanian", "", "", "", "", "", "");
        /// <summary>
        /// Language Russian
        /// </summary>
        public static Language Russian = new Language("ru", "Russian", "", "", "", "", "", "");
        /// <summary>
        /// Language Samoan
        /// </summary>
        public static Language Samoan = new Language("sm", "Samoan", "", "", "", "", "", "");
        /// <summary>
        /// Language Scots Gaelic
        /// </summary>
        public static Language Scots_Gaelic = new Language("gd", "Scots Gaelic", "", "", "", "", "", "");
        /// <summary>
        /// Language Serbian
        /// </summary>
        public static Language Serbian = new Language("sr", "Serbian", "", "", "", "", "", "");
        /// <summary>
        /// Language Sesotho
        /// </summary>
        public static Language Sesotho = new Language("st", "Sesotho", "", "", "", "", "", "");
        /// <summary>
        /// Language Shona
        /// </summary>
        public static Language Shona = new Language("sn", "Shona", "", "", "", "", "", "");
        /// <summary>
        /// Language Sindhi
        /// </summary>
        public static Language Sindhi = new Language("sd", "Sindhi", "", "", "", "", "", "");
        /// <summary>
        /// Language Sinhala
        /// </summary>
        public static Language Sinhala = new Language("si", "Sinhala", "", "", "", "", "", "");
        /// <summary>
        /// Language Slovak
        /// </summary>
        public static Language Slovak = new Language("sk", "Slovak", "", "", "", "", "", "");
        /// <summary>
        /// Language Slovenian
        /// </summary>
        public static Language Slovenian = new Language("sl", "Slovenian", "", "", "", "", "", "");
        /// <summary>
        /// Language Somali
        /// </summary>
        public static Language Somali = new Language("so", "Somali", "", "", "", "", "", "");
        /// <summary>
        /// Language Spanish
        /// </summary>
        public static Language Spanish = new Language("es", "Spanish", "", "", "", "", "", "");
        /// <summary>
        /// Language Sundanese
        /// </summary>
        public static Language Sundanese = new Language("su", "Sundanese", "", "", "", "", "", "");
        /// <summary>
        /// Language Swahili
        /// </summary>
        public static Language Swahili = new Language("sw", "Swahili", "", "", "", "", "", "");
        /// <summary>
        /// Language Swedish
        /// </summary>
        public static Language Swedish = new Language("sv", "Swedish", "", "", "", "", "", "");
        /// <summary>
        /// Language Tajik
        /// </summary>
        public static Language Tajik = new Language("tg", "Tajik", "", "", "", "", "", "");
        /// <summary>
        /// Language Tamil
        /// </summary>
        public static Language Tamil = new Language("ta", "Tamil", "", "", "", "", "", "");
        /// <summary>
        /// Language Telugu
        /// </summary>
        public static Language Telugu = new Language("te", "Telugu", "", "", "", "", "", "");
        /// <summary>
        /// Language Thai
        /// </summary>
        public static Language Thai = new Language("th", "Thai", "", "", "", "", "", "");
        /// <summary>
        /// Language Turkish
        /// </summary>
        public static Language Turkish = new Language("tr", "Turkish", "", "", "", "", "", "");
        /// <summary>
        /// Language Ukrainian
        /// </summary>
        public static Language Ukrainian = new Language("uk", "Ukrainian", "", "", "", "", "", "");
        /// <summary>
        /// Language Urdu
        /// </summary>
        public static Language Urdu = new Language("ur", "Urdu", "", "", "", "", "", "");
        /// <summary>
        /// Language Uzbek
        /// </summary>
        public static Language Uzbek = new Language("uz", "Uzbek", "", "", "", "", "", "");
        /// <summary>
        /// Language Vietnamese
        /// </summary>
        public static Language Vietnamese = new Language("vi", "Vietnamese", "", "", "", "", "", "");
        /// <summary>
        /// Language Welsh
        /// </summary>
        public static Language Welsh = new Language("cy", "Welsh", "", "", "", "", "", "");
        /// <summary>
        /// Language Xhosa
        /// </summary>
        public static Language Xhosa = new Language("xh", "Xhosa", "", "", "", "", "", "");
        /// <summary>
        /// Language Yiddish
        /// </summary>
        public static Language Yiddish = new Language("yi", "Yiddish", "", "", "", "", "", "");
        /// <summary>
        /// Language Yoruba
        /// </summary>
        public static Language Yoruba = new Language("yo", "Yoruba", "", "", "", "", "", "");
        /// <summary>
        /// Language Zulu
        /// </summary>
        public static Language Zulu = new Language("zu", "Zulu", "", "", "", "", "", "");
        #endregion
    }
}
