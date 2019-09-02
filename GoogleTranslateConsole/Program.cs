using Google_Translate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoogleTranslateConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            GoogleTranslator translator = new GoogleTranslator(Language.Russian);
            Console.WriteLine(translator.Translate("Test"));
            Console.WriteLine(translator.Translate("Tost"));
            Console.WriteLine(translator.Translate("Bug"));
            Console.WriteLine(translator.Translate("Cunt"));
            Console.WriteLine(translator.Translate("Dick"));
            Console.WriteLine(translator.Translate("Fuck"));
            Console.WriteLine(translator.Translate("Best"));
            Console.WriteLine(translator.Translate("Dust"));
            Console.WriteLine(translator.Translate("Big"));
            Console.WriteLine(translator.Translate("Dog"));
            Console.Read();
        }
    }
}
