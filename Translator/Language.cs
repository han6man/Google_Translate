using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google_Translate
{
    public class Language
    {
        //public string ISO_639_1_code { get; } = string.Empty;
        //public string ISO_639_2T_code { get; } = string.Empty;
        //public string ISO_639_2B_code { get; } = string.Empty;
        //public string ISO_639_3_code { get; } = string.Empty;
        
        public string Code { get; } = string.Empty;
        public string EnglishName { get; } = string.Empty;
        public string NativeName { get; } = string.Empty;

        #region Constractor
        //private Language(string Code)
        //{
        //    this.Code = Code;
        //}
        private Language(string Code, string EnglishName)
        {
            this.Code = Code;
            this.EnglishName = EnglishName;
        }
        //private Language(string Code, string EnglishName, string NativeName)
        //{
        //    this.Code = Code;
        //    this.EnglishName = EnglishName;
        //    this.NativeName = NativeName;
        //}

        //private Language(string ISO_639_1_code)
        //{
        //    this.ISO_639_1_code = ISO_639_1_code;
        //}

        //public Language(string ISO_639_1_code, string ISO_639_2T_code, string ISO_639_2B_code, string ISO_639_3_code, string ISO_639_5_code)
        //private Language(string ISO_639_1_code, string ISO_639_2T_code, string ISO_639_2B_code, string ISO_639_3_code)
        //{
        //    this.ISO_639_1_code = ISO_639_1_code;
        //    this.ISO_639_2T_code = ISO_639_2T_code;
        //    this.ISO_639_2B_code = ISO_639_2B_code;
        //    this.ISO_639_3_code = ISO_639_3_code;
        //    //this.ISO_639_5_code = ISO_639_5_code;
        //}
        #endregion

        #region Languages
        public static Language Auto_Detect = new Language("auto", "Auto Detect");
        public static Language Afrikaans = new Language("af", "Afrikaans");
        public static Language Albanian = new Language("sq", "Albanian");
        public static Language Amharic = new Language("am", "Amharic");
        public static Language Arabic = new Language("ar", "Arabic");
        public static Language Armenian = new Language("hy", "Armenian");
        public static Language Azerbaijani = new Language("az", "Azerbaijani");
        public static Language Basque = new Language("eu", "Basque");
        public static Language Belarusian = new Language("be", "Belarusian");
        public static Language Bengali = new Language("bn", "Bengali");
        public static Language Bosnian = new Language("bs", "Bosnian");
        public static Language Bulgarian = new Language("bg", "Bulgarian");
        public static Language Catalan = new Language("ca", "Catalan");
        public static Language Cebuano = new Language("ceb", "Cebuano");
        public static Language Chichewa = new Language("ny", "Chichewa");
        public static Language Chinese = new Language("zh-CN", "Chinese");
        public static Language Corsican = new Language("co", "Corsican");
        public static Language Croatian = new Language("hr", "Croatian");
        public static Language Czech = new Language("cs", "Czech");
        public static Language Danish = new Language("da", "Danish");
        public static Language Dutch = new Language("nl", "Dutch");
        public static Language English = new Language("en", "English");
        public static Language Esperanto = new Language("eo", "Esperanto");
        public static Language Estonian = new Language("et", "Estonian");
        public static Language Filipino = new Language("tl", "Filipino");
        public static Language Finnish = new Language("fi", "Finnish");
        public static Language French = new Language("fr", "French");
        public static Language Frisian = new Language("fy", "Frisian");
        public static Language Galician = new Language("gl", "Galician");
        public static Language Georgian = new Language("ka", "Georgian");
        public static Language German = new Language("de", "German");
        public static Language Greek = new Language("el", "Greek");
        public static Language Gujarati = new Language("gu", "Gujarati");
        public static Language Haitian_Creole = new Language("ht", "Haitian Creole");
        public static Language Hausa = new Language("ha", "Hausa");
        public static Language Hawaiian = new Language("haw", "Hawaiian");
        public static Language Hebrew = new Language("iw", "Hebrew");
        public static Language Hindi = new Language("hi", "Hindi");
        public static Language Hmong = new Language("hmn", "Hmong");
        public static Language Hungarian = new Language("hu", "Hungarian");
        public static Language Icelandic = new Language("is", "Icelandic");
        public static Language Igbo = new Language("ig", "Igbo");
        public static Language Indonesian = new Language("id", "Indonesian");
        public static Language Irish = new Language("ga", "Irish");
        public static Language Italian = new Language("it", "Italian");
        public static Language Japanese = new Language("ja", "Japanese");
        public static Language Javanese = new Language("jw", "Javanese");
        public static Language Kannada = new Language("kn", "Kannada");
        public static Language Kazakh = new Language("kk", "Kazakh");
        public static Language Khmer = new Language("km", "Khmer");
        public static Language Korean = new Language("ko", "Korean");
        public static Language Kurdish = new Language("ku", "Kurdish");
        public static Language Kurmanji = new Language("ku", "Kurmanji");
        public static Language Kyrgyz = new Language("ky", "Kyrgyz");
        public static Language Lao = new Language("lo", "Lao");
        public static Language Latin = new Language("la", "Latin");
        public static Language Latvian = new Language("lv", "Latvian");
        public static Language Lithuanian = new Language("lt", "Lithuanian");
        public static Language Luxembourgish = new Language("lb", "Luxembourgish");
        public static Language Macedonian = new Language("mk", "Macedonian");
        public static Language Malagasy = new Language("mg", "Malagasy");
        public static Language Malay = new Language("ms", "Malay");
        public static Language Malayalam = new Language("ml", "Malayalam");
        public static Language Maltese = new Language("mt", "Maltese");
        public static Language Maori = new Language("mi", "Maori");
        public static Language Marathi = new Language("mr", "Marathi");
        public static Language Mongolian = new Language("mn", "Mongolian");
        public static Language Myanmar = new Language("my", "Myanmar");
        public static Language Burmese = new Language("my", "Burmese");
        public static Language Nepali = new Language("ne", "Nepali");
        public static Language Norwegian = new Language("no", "Norwegian");
        public static Language Pashto = new Language("ps", "Pashto");
        public static Language Persian = new Language("fa", "Persian");
        public static Language Polish = new Language("pl", "Polish");
        public static Language Portuguese = new Language("pt", "Portuguese");
        public static Language Punjabi = new Language("pa", "Punjabi");
        public static Language Romanian = new Language("ro", "Romanian");
        public static Language Russian = new Language("ru", "Russian");
        public static Language Samoan = new Language("sm", "Samoan");
        public static Language Scots_Gaelic = new Language("gd", "Scots Gaelic");
        public static Language Serbian = new Language("sr", "Serbian");
        public static Language Sesotho = new Language("st", "Sesotho");
        public static Language Shona = new Language("sn", "Shona");
        public static Language Sindhi = new Language("sd", "Sindhi");
        public static Language Sinhala = new Language("si", "Sinhala");
        public static Language Slovak = new Language("sk", "Slovak");
        public static Language Slovenian = new Language("sl", "Slovenian");
        public static Language Somali = new Language("so", "Somali");
        public static Language Spanish = new Language("es", "Spanish");
        public static Language Sundanese = new Language("su", "Sundanese");
        public static Language Swahili = new Language("sw", "Swahili");
        public static Language Swedish = new Language("sv", "Swedish");
        public static Language Tajik = new Language("tg", "Tajik");
        public static Language Tamil = new Language("ta", "Tamil");
        public static Language Telugu = new Language("te", "Telugu");
        public static Language Thai = new Language("th", "Thai");
        public static Language Turkish = new Language("tr", "Turkish");
        public static Language Ukrainian = new Language("uk", "Ukrainian");
        public static Language Urdu = new Language("ur", "Urdu");
        public static Language Uzbek = new Language("uz", "Uzbek");
        public static Language Vietnamese = new Language("vi", "Vietnamese");
        public static Language Welsh = new Language("cy", "Welsh");
        public static Language Xhosa = new Language("xh", "Xhosa");
        public static Language Yiddish = new Language("yi", "Yiddish");
        public static Language Yoruba = new Language("yo", "Yoruba");
        public static Language Zulu = new Language("zu", "Zulu");
        #endregion
    }
}
