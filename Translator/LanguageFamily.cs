using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Google_Translate
{
    public class LanguageFamily
    {
        public string ISO_639_5_code { get; } = string.Empty;
        public string ISO_639_2_code { get; } = string.Empty;
        public string Name { get; } = string.Empty;
        public string Notes { get; } = string.Empty;

        public List<Language> Languages { get; } = new List<Language>();

        public LanguageFamily(string ISO_639_5_code, string ISO_639_2_code, string Name, string Notes, List<Language> Languages)
        {
            this.ISO_639_5_code = ISO_639_5_code;
            this.ISO_639_2_code = ISO_639_2_code;
            this.Name = Name;
            this.Notes = Notes;
            this.Languages = Languages;
        }

        #region LanguageGroups
        public static LanguageFamily Austro_Asiatic = new LanguageFamily("aav", "", "Austro-Asiatic languages", "South-Asiatic languages, not related to Australian languages", null);
        public static LanguageFamily Afro_Asiatic = new LanguageFamily("afa", "afa", "Afro-Asiatic languages", "", null);
        public static LanguageFamily Algonquian = new LanguageFamily("alg", "alg", "Algonquian languages", "", null);
        public static LanguageFamily Atlantic_Congo = new LanguageFamily("alv", "", "Atlantic-Congo languages", "", null);
        public static LanguageFamily Apache = new LanguageFamily("apa", "apa", "Apache languages", "", null);
        public static LanguageFamily Alacalufan = new LanguageFamily("aqa", "", "Alacalufan languages", "", null);
        public static LanguageFamily Algic = new LanguageFamily("aql", "", "Algic languages", "", null);
        public static LanguageFamily Artificial = new LanguageFamily("art", "art", "Artificial languages", "", null);
        public static LanguageFamily Athapascan = new LanguageFamily("ath", "ath", "Athapascan languages", "", null);
        public static LanguageFamily Arauan = new LanguageFamily("auf", "", "Arauan languages", "", null);
        public static LanguageFamily Australian = new LanguageFamily("aus", "aus", "Australian languages", "", null);
        public static LanguageFamily Arawakan = new LanguageFamily("awd", "", "Arawakan languages", "", null);
        public static LanguageFamily Uto_Aztecan = new LanguageFamily("azc", "", "Uto-Aztecan languages", "", null);
        public static LanguageFamily Banda = new LanguageFamily("bad", "bad", "Banda languages", "", null);
        public static LanguageFamily Bamileke = new LanguageFamily("bai", "bai", "Bamileke languages", "", null);
        public static LanguageFamily Baltic = new LanguageFamily("bat", "bat", "Baltic languages", "", null);
        public static LanguageFamily Berber = new LanguageFamily("ber", "ber", "Berber languages", "", null);
        public static LanguageFamily Bihari = new LanguageFamily("bih", "bih", "Bihari languages", "", null);
        public static LanguageFamily Bantu = new LanguageFamily("bnt", "bnt", "Bantu languages", "", null);
        public static LanguageFamily Batak = new LanguageFamily("btk", "btk", "Batak languages", "", null);
        public static LanguageFamily Central_American_Indian = new LanguageFamily("cai", "cai", "Central American Indian languages", "", null);
        public static LanguageFamily Caucasian = new LanguageFamily("cau", "cau", "Caucasian languages", "", null);
        public static LanguageFamily Chibchan = new LanguageFamily("cba", "", "Chibchan languages", "", null);
        public static LanguageFamily North_Caucasian = new LanguageFamily("ccn", "", "North Caucasian languages", "", null);
        public static LanguageFamily South_Caucasian = new LanguageFamily("ccs", "", "South Caucasian languages", "", null);
        public static LanguageFamily Chadic = new LanguageFamily("cdc", "", "Chadic languages", "", null);
        public static LanguageFamily Caddoan = new LanguageFamily("cdd", "", "Caddoan languages", "", null);
        public static LanguageFamily Celtic = new LanguageFamily("cel", "cel", "Celtic languages", "", null);
        public static LanguageFamily Chamic = new LanguageFamily("cmc", "cmc", "Chamic languages", "", null);
        public static LanguageFamily Creoles_and_pidgins_English_based = new LanguageFamily("cpe", "cpe", "creoles and pidgins, English-based", "", null);
        public static LanguageFamily Creoles_and_pidgins_French_based = new LanguageFamily("cpf", "cpf", "creoles and pidgins, French-based", "", null);
        public static LanguageFamily Creoles_and_pidgins_Portuguese_based = new LanguageFamily("cpp", "cpp", "creoles and pidgins, Portuguese-based", "", null);
        public static LanguageFamily Creolesand_pidgins = new LanguageFamily("crp", "crp", "creoles and pidgins", "", null);
        public static LanguageFamily Central_Sudanic = new LanguageFamily("csu", "", "Central Sudanic languages", "", null);
        public static LanguageFamily Cushitic = new LanguageFamily("cus", "cus", "Cushitic languages", "", null);
        public static LanguageFamily Land_Dayak = new LanguageFamily("day", "day", "Land Dayak languages", "not to be confused with Dayak languages, which is a larger group", null);
        public static LanguageFamily Mande = new LanguageFamily("dmn", "", "Mande languages", "", null);
        public static LanguageFamily Dravidian = new LanguageFamily("dra", "dra", "Dravidian languages", "", null);
        public static LanguageFamily Egyptian = new LanguageFamily("egx", "", "Egyptian languages", "", null);
        public static LanguageFamily Eskimo_Aleut = new LanguageFamily("esx", "", "Eskimo-Aleut languages", "", null);
        public static LanguageFamily Basque = new LanguageFamily("euq", "", "Basque (family)", "Basque (eu/eus/baq) is an individual language covered by this collection code", null);
        public static LanguageFamily Finno_Ugrian = new LanguageFamily("fiu", "fiu", "Finno-Ugrian languages", "", null);
        public static LanguageFamily Formosan = new LanguageFamily("fox", "", "Formosan languages", "", null);
        public static LanguageFamily Germanic = new LanguageFamily("gem", "gem", "Germanic languages", "", null);
        public static LanguageFamily East_Germanic = new LanguageFamily("gme", "", "East Germanic languages", "", null);
        public static LanguageFamily North_Germanic = new LanguageFamily("gmq", "", "North Germanic languages", "", null);
        public static LanguageFamily West_Germanic = new LanguageFamily("gmw", "", "West Germanic languages", "", null);
        public static LanguageFamily Greek = new LanguageFamily("grk", "", "Greek languages", "", null);
        public static LanguageFamily Hmong_Mien = new LanguageFamily("hmx", "", "Hmong-Mien languages", "", null);
        public static LanguageFamily Hokan = new LanguageFamily("hok", "", "Hokan languages", "", null);
        public static LanguageFamily Armenian = new LanguageFamily("hyx", "", "Armenian (family)", "Armenian (hy/hye/arm) is an individual language covered by this collection code", null);
        public static LanguageFamily Indo_Iranian = new LanguageFamily("iir", "", "Indo-Iranian languages", "", null);
        public static LanguageFamily Ijo = new LanguageFamily("ijo", "ijo", "Ijo languages", "", null);
        public static LanguageFamily Indic = new LanguageFamily("inc", "inc", "Indic languages", "", null);
        public static LanguageFamily Indo_European = new LanguageFamily("ine", "ine", "Indo-European languages", "", null);
        public static LanguageFamily Iranian = new LanguageFamily("ira", "ira", "Iranian languages", "", null);
        public static LanguageFamily Iroquoian = new LanguageFamily("iro", "iro", "Iroquoian languages", "", null);
        public static LanguageFamily Italic = new LanguageFamily("itc", "", "Italic languages", "", null);
        public static LanguageFamily Japanese = new LanguageFamily("jpx", "", "Japanese (family)", "Japanese (ja/jpn) is an individual language covered by this collection code", null);
        public static LanguageFamily Karen = new LanguageFamily("kar", "kar", "Karen languages", "", null);
        public static LanguageFamily Kordofanian = new LanguageFamily("kdo", "", "Kordofanian languages", "", null);
        public static LanguageFamily Khoisan = new LanguageFamily("khi", "khi", "Khoisan languages", "", null);
        public static LanguageFamily Kru = new LanguageFamily("kro", "kro", "Kru languages", "", null);
        public static LanguageFamily Austronesian = new LanguageFamily("map", "map", "Austronesian languages", "", null);
        public static LanguageFamily Mon_Khmer = new LanguageFamily("mkh", "mkh", "Mon-Khmer languages", "", null);
        public static LanguageFamily Manobo = new LanguageFamily("mno", "mno", "Manobo languages", "", null);
        public static LanguageFamily Munda = new LanguageFamily("mun", "mun", "Munda languages", "", null);
        public static LanguageFamily Mayan = new LanguageFamily("myn", "myn", "Mayan languages", "", null);
        public static LanguageFamily Nahuatl = new LanguageFamily("nah", "nah", "Nahuatl languages", "", null);
        public static LanguageFamily North_American_Indian = new LanguageFamily("nai", "nai", "North American Indian languages", "", null);
        public static LanguageFamily Trans_New_Guinea = new LanguageFamily("ngf", "", "Trans-New Guinea languages", "", null);
        public static LanguageFamily Niger_Kordofanian = new LanguageFamily("nic", "nic", "Niger-Kordofanian languages", "", null);
        public static LanguageFamily Nubian = new LanguageFamily("nub", "nub", "Nubian languages", "", null);
        public static LanguageFamily Oto_Manguean = new LanguageFamily("omq", "", "Oto-Manguean languages", "", null);
        public static LanguageFamily Omotic = new LanguageFamily("omv", "", "Omotic languages", "", null);
        public static LanguageFamily Otomian = new LanguageFamily("oto", "oto", "Otomian languages", "", null);
        public static LanguageFamily Papuan = new LanguageFamily("paa", "paa", "Papuan languages", "", null);
        public static LanguageFamily Philippine = new LanguageFamily("phi", "phi", "Philippine languages", "", null);
        public static LanguageFamily Central_Malayo_Polynesian = new LanguageFamily("plf", "", "Central Malayo-Polynesian languages", "", null);
        public static LanguageFamily Malayo_Polynesian = new LanguageFamily("poz", "", "Malayo-Polynesian languages", "", null);
        public static LanguageFamily Eastern_Malayo_Polynesian = new LanguageFamily("pqe", "", "Eastern Malayo-Polynesian languages", "", null);
        public static LanguageFamily Western_Malayo_Polynesian = new LanguageFamily("pqw", "", "Western Malayo-Polynesian languages", "", null);
        public static LanguageFamily Prakrit = new LanguageFamily("pra", "pra", "Prakrit languages", "", null);
        public static LanguageFamily Quechuan = new LanguageFamily("qwe", "", "Quechuan (family)", "Quechua (qu/que) is a macrolanguage covered by this collection code", null);
        public static LanguageFamily Romance = new LanguageFamily("roa", "roa", "Romance languages", "", null);
        public static LanguageFamily South_American_Indian = new LanguageFamily("sai", "sai", "South American Indian languages", "", null);
        public static LanguageFamily Salishan = new LanguageFamily("sal", "sal", "Salishan languages", "", null);
        public static LanguageFamily Eastern_Sudanic = new LanguageFamily("sdv", "", "Eastern Sudanic languages", "", null);
        public static LanguageFamily Semitic = new LanguageFamily("sem", "sem", "Semitic languages", "", null);
        public static LanguageFamily sign = new LanguageFamily("sgn", "sgn", "sign languages", "", null);
        public static LanguageFamily Siouan = new LanguageFamily("sio", "sio", "Siouan languages", "", null);
        public static LanguageFamily Sino_Tibetan = new LanguageFamily("sit", "sit", "Sino-Tibetan languages", "", null);
        public static LanguageFamily Slavic = new LanguageFamily("sla", "sla", "Slavic languages", "", null);
        public static LanguageFamily Sami = new LanguageFamily("smi", "smi", "Sami languages", "", null);
        public static LanguageFamily Songhai = new LanguageFamily("son", "son", "Songhai languages", "", null);
        public static LanguageFamily Albanian = new LanguageFamily("sqj", "", "Albanian languages", "Albanian (sq/sqi/alb) is a macrolanguage covered by this collection code", null);
        public static LanguageFamily Nilo_Saharan = new LanguageFamily("ssa", "ssa", "Nilo-Saharan languages", "", null);
        public static LanguageFamily Samoyedic = new LanguageFamily("syd", "", "Samoyedic languages", "", null);
        public static LanguageFamily Tai = new LanguageFamily("tai", "tai", "Tai languages", "Thai (th/tha) is an individual language covered by this collection code", null);
        public static LanguageFamily Tibeto_Burman = new LanguageFamily("tbq", "", "Tibeto-Burman languages", "", null);
        public static LanguageFamily Turkic = new LanguageFamily("trk", "", "Turkic languages", "Turkish (tr/tur) is an individual language covered by this collection code", null);
        public static LanguageFamily Tupi = new LanguageFamily("tup", "tup", "Tupi languages", "", null);
        public static LanguageFamily Altaic = new LanguageFamily("tut", "tut", "Altaic languages", "", null);
        public static LanguageFamily Tungus = new LanguageFamily("tuw", "", "Tungus languages", "", null);
        public static LanguageFamily Uralic = new LanguageFamily("urj", "", "Uralic languages", "", null);
        public static LanguageFamily Wakashan = new LanguageFamily("wak", "wak", "Wakashan languages", "", null);
        public static LanguageFamily Sorbian = new LanguageFamily("wen", "wen", "Sorbian languages", "", null);
        public static LanguageFamily Mongolian = new LanguageFamily("xgn", "", "Mongolian languages", "Mongolian (mn/mon) is a macrolanguage covered by this collection code", null);
        public static LanguageFamily Na_Dene = new LanguageFamily("xnd", "", "Na-Dene languages", "", null);
        public static LanguageFamily Yupik = new LanguageFamily("ypk", "ypk", "Yupik languages", "", null);
        public static LanguageFamily Chinese = new LanguageFamily("zhx", "", "Chinese (family)", "Chinese (zh/zho/chi) is a macrolanguage covered by this collection code", null);
        public static LanguageFamily East_Slavic = new LanguageFamily("zle", "", "East Slavic languages", "", null);
        public static LanguageFamily South_Slavic = new LanguageFamily("zls", "", "South Slavic languages", "", null);
        public static LanguageFamily West_Slavic = new LanguageFamily("zlw", "", "West Slavic languages", "", null);
        public static LanguageFamily Zande = new LanguageFamily("znd", "znd", "Zande languages", "Zande (individual language) (zne) is an individual language covered by this collection code", null);
        #endregion
    }
}
