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
    public class LanguageFamily
    {
        /// <summary>
        /// ISO 639-5: three-letter Language Family code
        /// </summary>
        public string ISO_639_5_code { get; } = string.Empty;
        /// <summary>
        /// ISO 639-2: three-letter codes, for the same languages as 639-1
        /// </summary>
        public string ISO_639_2_code { get; } = string.Empty;
        /// <summary>
        /// Language collection name
        /// </summary>
        public string Name { get; } = string.Empty;
        /// <summary>
        /// Language Family Notes
        /// </summary>
        public string Notes { get; } = string.Empty;
        /// <summary>
        /// List of lenguages in group
        /// </summary>
        public List<Language> Languages { get; } = new List<Language>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ISO_639_5_code"></param>
        /// <param name="ISO_639_2_code"></param>
        /// <param name="Name"></param>
        /// <param name="Notes"></param>
        /// <param name="Languages"></param>
        public LanguageFamily(string ISO_639_5_code, string ISO_639_2_code, string Name, string Notes, List<Language> Languages)
        {
            this.ISO_639_5_code = ISO_639_5_code;
            this.ISO_639_2_code = ISO_639_2_code;
            this.Name = Name;
            this.Notes = Notes;
            this.Languages = Languages;
        }

        #region LanguageGroups
        /// <summary>
        /// Austro_Asiatic LanguageFamily
        /// </summary>
        public static LanguageFamily Austro_Asiatic = new LanguageFamily("aav", "", "Austro-Asiatic languages", "South-Asiatic languages, not related to Australian languages", new List<Language>());
        /// <summary>
        /// Afro_Asiatic LanguageFamily
        /// </summary>
        public static LanguageFamily Afro_Asiatic = new LanguageFamily("afa", "afa", "Afro-Asiatic languages", "", new List<Language>());
        /// <summary>
        /// Algonquian LanguageFamily
        /// </summary>
        public static LanguageFamily Algonquian = new LanguageFamily("alg", "alg", "Algonquian languages", "", new List<Language>());
        /// <summary>
        /// Atlantic_Congo LanguageFamily
        /// </summary>
        public static LanguageFamily Atlantic_Congo = new LanguageFamily("alv", "", "Atlantic-Congo languages", "", new List<Language>());
        /// <summary>
        /// Apache LanguageFamily
        /// </summary>
        public static LanguageFamily Apache = new LanguageFamily("apa", "apa", "Apache languages", "", new List<Language>());
        /// <summary>
        /// Alacalufan LanguageFamily
        /// </summary>
        public static LanguageFamily Alacalufan = new LanguageFamily("aqa", "", "Alacalufan languages", "", new List<Language>());
        /// <summary>
        /// Algic LanguageFamily
        /// </summary>
        public static LanguageFamily Algic = new LanguageFamily("aql", "", "Algic languages", "", new List<Language>());
        /// <summary>
        /// Artificial LanguageFamily
        /// </summary>
        public static LanguageFamily Artificial = new LanguageFamily("art", "art", "Artificial languages", "", new List<Language>());
        /// <summary>
        /// Athapascan LanguageFamily
        /// </summary>
        public static LanguageFamily Athapascan = new LanguageFamily("ath", "ath", "Athapascan languages", "", new List<Language>());
        /// <summary>
        /// Arauan LanguageFamily
        /// </summary>
        public static LanguageFamily Arauan = new LanguageFamily("auf", "", "Arauan languages", "", new List<Language>());
        /// <summary>
        /// Australian LanguageFamily
        /// </summary>
        public static LanguageFamily Australian = new LanguageFamily("aus", "aus", "Australian languages", "", new List<Language>());
        /// <summary>
        /// Arawakan LanguageFamily
        /// </summary>
        public static LanguageFamily Arawakan = new LanguageFamily("awd", "", "Arawakan languages", "", new List<Language>());
        /// <summary>
        /// Uto_Aztecan LanguageFamily
        /// </summary>
        public static LanguageFamily Uto_Aztecan = new LanguageFamily("azc", "", "Uto-Aztecan languages", "", new List<Language>());
        /// <summary>
        /// Banda LanguageFamily
        /// </summary>
        public static LanguageFamily Banda = new LanguageFamily("bad", "bad", "Banda languages", "", new List<Language>());
        /// <summary>
        /// Bamileke LanguageFamily
        /// </summary>
        public static LanguageFamily Bamileke = new LanguageFamily("bai", "bai", "Bamileke languages", "", new List<Language>());
        /// <summary>
        /// Baltic LanguageFamily
        /// </summary>
        public static LanguageFamily Baltic = new LanguageFamily("bat", "bat", "Baltic languages", "", new List<Language>());
        /// <summary>
        /// Berber LanguageFamily
        /// </summary>
        public static LanguageFamily Berber = new LanguageFamily("ber", "ber", "Berber languages", "", new List<Language>());
        /// <summary>
        /// Bihari LanguageFamily
        /// </summary>
        public static LanguageFamily Bihari = new LanguageFamily("bih", "bih", "Bihari languages", "", new List<Language>());
        /// <summary>
        /// Bantu LanguageFamily
        /// </summary>
        public static LanguageFamily Bantu = new LanguageFamily("bnt", "bnt", "Bantu languages", "", new List<Language>());
        /// <summary>
        /// Batak LanguageFamily
        /// </summary>
        public static LanguageFamily Batak = new LanguageFamily("btk", "btk", "Batak languages", "", new List<Language>());
        /// <summary>
        /// Central_American_Indian LanguageFamily
        /// </summary>
        public static LanguageFamily Central_American_Indian = new LanguageFamily("cai", "cai", "Central American Indian languages", "", new List<Language>());
        /// <summary>
        /// Caucasian LanguageFamily
        /// </summary>
        public static LanguageFamily Caucasian = new LanguageFamily("cau", "cau", "Caucasian languages", "", new List<Language>());
        /// <summary>
        /// Chibchan LanguageFamily
        /// </summary>
        public static LanguageFamily Chibchan = new LanguageFamily("cba", "", "Chibchan languages", "", new List<Language>());
        /// <summary>
        /// North_Caucasian LanguageFamily
        /// </summary>
        public static LanguageFamily North_Caucasian = new LanguageFamily("ccn", "", "North Caucasian languages", "", new List<Language>());
        /// <summary>
        /// South_Caucasian LanguageFamily
        /// </summary>
        public static LanguageFamily South_Caucasian = new LanguageFamily("ccs", "", "South Caucasian languages", "", new List<Language>());
        /// <summary>
        /// Chadic LanguageFamily
        /// </summary>
        public static LanguageFamily Chadic = new LanguageFamily("cdc", "", "Chadic languages", "", new List<Language>());
        /// <summary>
        /// Caddoan LanguageFamily
        /// </summary>
        public static LanguageFamily Caddoan = new LanguageFamily("cdd", "", "Caddoan languages", "", new List<Language>());
        /// <summary>
        /// Celtic LanguageFamily
        /// </summary>
        public static LanguageFamily Celtic = new LanguageFamily("cel", "cel", "Celtic languages", "", new List<Language>());
        /// <summary>
        /// Chamic LanguageFamily
        /// </summary>
        public static LanguageFamily Chamic = new LanguageFamily("cmc", "cmc", "Chamic languages", "", new List<Language>());
        /// <summary>
        /// Creoles_and_pidgins_English_based LanguageFamily
        /// </summary>
        public static LanguageFamily Creoles_and_pidgins_English_based = new LanguageFamily("cpe", "cpe", "creoles and pidgins, English-based", "", new List<Language>());
        /// <summary>
        /// Creoles_and_pidgins_French_based LanguageFamily
        /// </summary>
        public static LanguageFamily Creoles_and_pidgins_French_based = new LanguageFamily("cpf", "cpf", "creoles and pidgins, French-based", "", new List<Language>());
        /// <summary>
        /// Creoles_and_pidgins_Portuguese_based LanguageFamily
        /// </summary>
        public static LanguageFamily Creoles_and_pidgins_Portuguese_based = new LanguageFamily("cpp", "cpp", "creoles and pidgins, Portuguese-based", "", new List<Language>());
        /// <summary>
        /// Creolesand_pidgins LanguageFamily
        /// </summary>
        public static LanguageFamily Creolesand_pidgins = new LanguageFamily("crp", "crp", "creoles and pidgins", "", new List<Language>());
        /// <summary>
        /// Central_Sudanic LanguageFamily
        /// </summary>
        public static LanguageFamily Central_Sudanic = new LanguageFamily("csu", "", "Central Sudanic languages", "", new List<Language>());
        /// <summary>
        /// Cushitic LanguageFamily
        /// </summary>
        public static LanguageFamily Cushitic = new LanguageFamily("cus", "cus", "Cushitic languages", "", new List<Language>());
        /// <summary>
        /// Land_Dayak LanguageFamily
        /// </summary>
        public static LanguageFamily Land_Dayak = new LanguageFamily("day", "day", "Land Dayak languages", "not to be confused with Dayak languages, which is a larger group", new List<Language>());
        /// <summary>
        /// Mande LanguageFamily
        /// </summary>
        public static LanguageFamily Mande = new LanguageFamily("dmn", "", "Mande languages", "", new List<Language>());
        /// <summary>
        /// Dravidian LanguageFamily
        /// </summary>
        public static LanguageFamily Dravidian = new LanguageFamily("dra", "dra", "Dravidian languages", "", new List<Language>());
        /// <summary>
        /// Egyptian LanguageFamily
        /// </summary>
        public static LanguageFamily Egyptian = new LanguageFamily("egx", "", "Egyptian languages", "", new List<Language>());
        /// <summary>
        /// Eskimo_Aleut LanguageFamily
        /// </summary>
        public static LanguageFamily Eskimo_Aleut = new LanguageFamily("esx", "", "Eskimo-Aleut languages", "", new List<Language>());
        /// <summary>
        /// Basque LanguageFamily
        /// </summary>
        public static LanguageFamily Basque = new LanguageFamily("euq", "", "Basque (family)", "Basque (eu/eus/baq) is an individual language covered by this collection code", new List<Language>());
        /// <summary>
        /// Finno_Ugrian LanguageFamily
        /// </summary>
        public static LanguageFamily Finno_Ugrian = new LanguageFamily("fiu", "fiu", "Finno-Ugrian languages", "", new List<Language>());
        /// <summary>
        /// Formosan LanguageFamily
        /// </summary>
        public static LanguageFamily Formosan = new LanguageFamily("fox", "", "Formosan languages", "", new List<Language>());
        /// <summary>
        /// Germanic LanguageFamily
        /// </summary>
        public static LanguageFamily Germanic = new LanguageFamily("gem", "gem", "Germanic languages", "", new List<Language>());
        /// <summary>
        /// East_Germanic LanguageFamily
        /// </summary>
        public static LanguageFamily East_Germanic = new LanguageFamily("gme", "", "East Germanic languages", "", new List<Language>());
        /// <summary>
        /// North_Germanic LanguageFamily
        /// </summary>
        public static LanguageFamily North_Germanic = new LanguageFamily("gmq", "", "North Germanic languages", "", new List<Language>());
        /// <summary>
        /// West_Germanic LanguageFamily
        /// </summary>
        public static LanguageFamily West_Germanic = new LanguageFamily("gmw", "", "West Germanic languages", "", new List<Language>());
        /// <summary>
        /// Greek LanguageFamily
        /// </summary>
        public static LanguageFamily Greek = new LanguageFamily("grk", "", "Greek languages", "", new List<Language>());
        /// <summary>
        /// Hmong_Mien LanguageFamily
        /// </summary>
        public static LanguageFamily Hmong_Mien = new LanguageFamily("hmx", "", "Hmong-Mien languages", "", new List<Language>());
        /// <summary>
        /// Hokan LanguageFamily
        /// </summary>
        public static LanguageFamily Hokan = new LanguageFamily("hok", "", "Hokan languages", "", new List<Language>());
        /// <summary>
        /// Armenian LanguageFamily
        /// </summary>
        public static LanguageFamily Armenian = new LanguageFamily("hyx", "", "Armenian (family)", "Armenian (hy/hye/arm) is an individual language covered by this collection code", new List<Language>());
        /// <summary>
        /// Indo_Iranian LanguageFamily
        /// </summary>
        public static LanguageFamily Indo_Iranian = new LanguageFamily("iir", "", "Indo-Iranian languages", "", new List<Language>());
        /// <summary>
        /// Ijo LanguageFamily
        /// </summary>
        public static LanguageFamily Ijo = new LanguageFamily("ijo", "ijo", "Ijo languages", "", new List<Language>());
        /// <summary>
        /// Indic LanguageFamily
        /// </summary>
        public static LanguageFamily Indic = new LanguageFamily("inc", "inc", "Indic languages", "", new List<Language>());
        /// <summary>
        /// Indo_European LanguageFamily
        /// </summary>
        public static LanguageFamily Indo_European = new LanguageFamily("ine", "ine", "Indo-European languages", "", new List<Language>());
        /// <summary>
        /// Iranian LanguageFamily
        /// </summary>
        public static LanguageFamily Iranian = new LanguageFamily("ira", "ira", "Iranian languages", "", new List<Language>());
        /// <summary>
        /// Iroquoian LanguageFamily
        /// </summary>
        public static LanguageFamily Iroquoian = new LanguageFamily("iro", "iro", "Iroquoian languages", "", new List<Language>());
        /// <summary>
        /// Italic LanguageFamily
        /// </summary>
        public static LanguageFamily Italic = new LanguageFamily("itc", "", "Italic languages", "", new List<Language>());
        /// <summary>
        /// Japanese LanguageFamily
        /// </summary>
        public static LanguageFamily Japanese = new LanguageFamily("jpx", "", "Japanese (family)", "Japanese (ja/jpn) is an individual language covered by this collection code", new List<Language>());
        /// <summary>
        /// Karen LanguageFamily
        /// </summary>
        public static LanguageFamily Karen = new LanguageFamily("kar", "kar", "Karen languages", "", new List<Language>());
        /// <summary>
        /// Kordofanian LanguageFamily
        /// </summary>
        public static LanguageFamily Kordofanian = new LanguageFamily("kdo", "", "Kordofanian languages", "", new List<Language>());
        /// <summary>
        /// Khoisan LanguageFamily
        /// </summary>
        public static LanguageFamily Khoisan = new LanguageFamily("khi", "khi", "Khoisan languages", "", new List<Language>());
        /// <summary>
        /// Kru LanguageFamily
        /// </summary>
        public static LanguageFamily Kru = new LanguageFamily("kro", "kro", "Kru languages", "", new List<Language>());
        /// <summary>
        /// Austronesian LanguageFamily
        /// </summary>
        public static LanguageFamily Austronesian = new LanguageFamily("map", "map", "Austronesian languages", "", new List<Language>());
        /// <summary>
        /// Mon_Khmer LanguageFamily
        /// </summary>
        public static LanguageFamily Mon_Khmer = new LanguageFamily("mkh", "mkh", "Mon-Khmer languages", "", new List<Language>());
        /// <summary>
        /// Manobo LanguageFamily
        /// </summary>
        public static LanguageFamily Manobo = new LanguageFamily("mno", "mno", "Manobo languages", "", new List<Language>());
        /// <summary>
        /// Munda LanguageFamily
        /// </summary>
        public static LanguageFamily Munda = new LanguageFamily("mun", "mun", "Munda languages", "", new List<Language>());
        /// <summary>
        /// Mayan LanguageFamily
        /// </summary>
        public static LanguageFamily Mayan = new LanguageFamily("myn", "myn", "Mayan languages", "", new List<Language>());
        /// <summary>
        /// Nahuatl LanguageFamily
        /// </summary>
        public static LanguageFamily Nahuatl = new LanguageFamily("nah", "nah", "Nahuatl languages", "", new List<Language>());
        /// <summary>
        /// North_American_Indian LanguageFamily
        /// </summary>
        public static LanguageFamily North_American_Indian = new LanguageFamily("nai", "nai", "North American Indian languages", "", new List<Language>());
        /// <summary>
        /// Trans_New_Guinea LanguageFamily
        /// </summary>
        public static LanguageFamily Trans_New_Guinea = new LanguageFamily("ngf", "", "Trans-New Guinea languages", "", new List<Language>());
        /// <summary>
        /// Niger_Kordofanian LanguageFamily
        /// </summary>
        public static LanguageFamily Niger_Kordofanian = new LanguageFamily("nic", "nic", "Niger-Kordofanian languages", "", new List<Language>());
        /// <summary>
        /// Nubian LanguageFamily
        /// </summary>
        public static LanguageFamily Nubian = new LanguageFamily("nub", "nub", "Nubian languages", "", new List<Language>());
        /// <summary>
        /// Oto_Manguean LanguageFamily
        /// </summary>
        public static LanguageFamily Oto_Manguean = new LanguageFamily("omq", "", "Oto-Manguean languages", "", new List<Language>());
        /// <summary>
        /// Omotic LanguageFamily
        /// </summary>
        public static LanguageFamily Omotic = new LanguageFamily("omv", "", "Omotic languages", "", new List<Language>());
        /// <summary>
        /// Otomian LanguageFamily
        /// </summary>
        public static LanguageFamily Otomian = new LanguageFamily("oto", "oto", "Otomian languages", "", new List<Language>());
        /// <summary>
        /// Papuan LanguageFamily
        /// </summary>
        public static LanguageFamily Papuan = new LanguageFamily("paa", "paa", "Papuan languages", "", new List<Language>());
        /// <summary>
        /// Philippine LanguageFamily
        /// </summary>
        public static LanguageFamily Philippine = new LanguageFamily("phi", "phi", "Philippine languages", "", new List<Language>());
        /// <summary>
        /// Central_Malayo_Polynesian LanguageFamily
        /// </summary>
        public static LanguageFamily Central_Malayo_Polynesian = new LanguageFamily("plf", "", "Central Malayo-Polynesian languages", "", new List<Language>());
        /// <summary>
        /// Malayo_Polynesian LanguageFamily
        /// </summary>
        public static LanguageFamily Malayo_Polynesian = new LanguageFamily("poz", "", "Malayo-Polynesian languages", "", new List<Language>());
        /// <summary>
        /// Eastern_Malayo_Polynesian LanguageFamily
        /// </summary>
        public static LanguageFamily Eastern_Malayo_Polynesian = new LanguageFamily("pqe", "", "Eastern Malayo-Polynesian languages", "", new List<Language>());
        /// <summary>
        /// Western_Malayo_Polynesian LanguageFamily
        /// </summary>
        public static LanguageFamily Western_Malayo_Polynesian = new LanguageFamily("pqw", "", "Western Malayo-Polynesian languages", "", new List<Language>());
        /// <summary>
        /// Prakrit LanguageFamily
        /// </summary>
        public static LanguageFamily Prakrit = new LanguageFamily("pra", "pra", "Prakrit languages", "", new List<Language>());
        /// <summary>
        /// Quechuan LanguageFamily
        /// </summary>
        public static LanguageFamily Quechuan = new LanguageFamily("qwe", "", "Quechuan (family)", "Quechua (qu/que) is a macrolanguage covered by this collection code", new List<Language>());
        /// <summary>
        /// Romance LanguageFamily
        /// </summary>
        public static LanguageFamily Romance = new LanguageFamily("roa", "roa", "Romance languages", "", new List<Language>());
        /// <summary>
        /// South_American_Indian LanguageFamily
        /// </summary>
        public static LanguageFamily South_American_Indian = new LanguageFamily("sai", "sai", "South American Indian languages", "", new List<Language>());
        /// <summary>
        /// Salishan LanguageFamily
        /// </summary>
        public static LanguageFamily Salishan = new LanguageFamily("sal", "sal", "Salishan languages", "", new List<Language>());
        /// <summary>
        /// Eastern_Sudanic LanguageFamily
        /// </summary>
        public static LanguageFamily Eastern_Sudanic = new LanguageFamily("sdv", "", "Eastern Sudanic languages", "", new List<Language>());
        /// <summary>
        /// Semitic LanguageFamily
        /// </summary>
        public static LanguageFamily Semitic = new LanguageFamily("sem", "sem", "Semitic languages", "", new List<Language>());
        /// <summary>
        /// sign LanguageFamily
        /// </summary>
        public static LanguageFamily sign = new LanguageFamily("sgn", "sgn", "sign languages", "", new List<Language>());
        /// <summary>
        /// Siouan LanguageFamily
        /// </summary>
        public static LanguageFamily Siouan = new LanguageFamily("sio", "sio", "Siouan languages", "", new List<Language>());
        /// <summary>
        /// Sino_Tibetan LanguageFamily
        /// </summary>
        public static LanguageFamily Sino_Tibetan = new LanguageFamily("sit", "sit", "Sino-Tibetan languages", "", new List<Language>());
        /// <summary>
        /// Slavic LanguageFamily
        /// </summary>
        public static LanguageFamily Slavic = new LanguageFamily("sla", "sla", "Slavic languages", "", new List<Language>());
        /// <summary>
        /// Sami LanguageFamily
        /// </summary>
        public static LanguageFamily Sami = new LanguageFamily("smi", "smi", "Sami languages", "", new List<Language>());
        /// <summary>
        /// Songhai LanguageFamily
        /// </summary>
        public static LanguageFamily Songhai = new LanguageFamily("son", "son", "Songhai languages", "", new List<Language>());
        /// <summary>
        /// Albanian LanguageFamily
        /// </summary>
        public static LanguageFamily Albanian = new LanguageFamily("sqj", "", "Albanian languages", "Albanian (sq/sqi/alb) is a macrolanguage covered by this collection code", new List<Language>());
        /// <summary>
        /// Nilo_Saharan LanguageFamily
        /// </summary>
        public static LanguageFamily Nilo_Saharan = new LanguageFamily("ssa", "ssa", "Nilo-Saharan languages", "", new List<Language>());
        /// <summary>
        /// Samoyedic LanguageFamily
        /// </summary>
        public static LanguageFamily Samoyedic = new LanguageFamily("syd", "", "Samoyedic languages", "", new List<Language>());
        /// <summary>
        /// Tai LanguageFamily
        /// </summary>
        public static LanguageFamily Tai = new LanguageFamily("tai", "tai", "Tai languages", "Thai (th/tha) is an individual language covered by this collection code", new List<Language>());
        /// <summary>
        /// Tibeto_Burman LanguageFamily
        /// </summary>
        public static LanguageFamily Tibeto_Burman = new LanguageFamily("tbq", "", "Tibeto-Burman languages", "", new List<Language>());
        /// <summary>
        /// Turkic LanguageFamily
        /// </summary>
        public static LanguageFamily Turkic = new LanguageFamily("trk", "", "Turkic languages", "Turkish (tr/tur) is an individual language covered by this collection code", new List<Language>());
        /// <summary>
        /// Tupi LanguageFamily
        /// </summary>
        public static LanguageFamily Tupi = new LanguageFamily("tup", "tup", "Tupi languages", "", new List<Language>());
        /// <summary>
        /// Altaic LanguageFamily
        /// </summary>
        public static LanguageFamily Altaic = new LanguageFamily("tut", "tut", "Altaic languages", "", new List<Language>());
        /// <summary>
        /// Tungus LanguageFamily
        /// </summary>
        public static LanguageFamily Tungus = new LanguageFamily("tuw", "", "Tungus languages", "", new List<Language>());
        /// <summary>
        /// Uralic LanguageFamily
        /// </summary>
        public static LanguageFamily Uralic = new LanguageFamily("urj", "", "Uralic languages", "", new List<Language>());
        /// <summary>
        /// Wakashan LanguageFamily
        /// </summary>
        public static LanguageFamily Wakashan = new LanguageFamily("wak", "wak", "Wakashan languages", "", new List<Language>());
        /// <summary>
        /// Sorbian LanguageFamily
        /// </summary>
        public static LanguageFamily Sorbian = new LanguageFamily("wen", "wen", "Sorbian languages", "", new List<Language>());
        /// <summary>
        /// Mongolian LanguageFamily
        /// </summary>
        public static LanguageFamily Mongolian = new LanguageFamily("xgn", "", "Mongolian languages", "Mongolian (mn/mon) is a macrolanguage covered by this collection code", new List<Language>());
        /// <summary>
        /// Na_Dene LanguageFamily
        /// </summary>
        public static LanguageFamily Na_Dene = new LanguageFamily("xnd", "", "Na-Dene languages", "", new List<Language>());
        /// <summary>
        /// Yupik LanguageFamily
        /// </summary>
        public static LanguageFamily Yupik = new LanguageFamily("ypk", "ypk", "Yupik languages", "", new List<Language>());
        /// <summary>
        /// Chinese LanguageFamily
        /// </summary>
        public static LanguageFamily Chinese = new LanguageFamily("zhx", "", "Chinese (family)", "Chinese (zh/zho/chi) is a macrolanguage covered by this collection code", new List<Language>());
        /// <summary>
        /// East_Slavic LanguageFamily
        /// </summary>
        public static LanguageFamily East_Slavic = new LanguageFamily("zle", "", "East Slavic languages", "", new List<Language>());
        /// <summary>
        /// South_Slavic LanguageFamily
        /// </summary>
        public static LanguageFamily South_Slavic = new LanguageFamily("zls", "", "South Slavic languages", "", new List<Language>());
        /// <summary>
        /// West_Slavic LanguageFamily
        /// </summary>
        public static LanguageFamily West_Slavic = new LanguageFamily("zlw", "", "West Slavic languages", "", new List<Language>());
        /// <summary>
        /// Zande LanguageFamily
        /// </summary>
        public static LanguageFamily Zande = new LanguageFamily("znd", "znd", "Zande languages", "Zande (individual language) (zne) is an individual language covered by this collection code", new List<Language>());
        #endregion
    }
}
