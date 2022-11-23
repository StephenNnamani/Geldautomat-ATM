using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace GeldAutomat_ATM_.UI
{
    public static class LanguageSelection
    {
        public static string LangSelect()
        {
            Utility.ProgramColors();
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string lines = "------------------------";
            var languages = new Dictionary<int, string>() { { 1, "English" }, { 2, "German" }, { 3, "Igbo" } };

           Console.WriteLine($"\n\n\t{lines} Language Option {lines}\n\n");
            int langSelection;
            string Language = null;
            while (Language == null)
            {
                Console.WriteLine("\t\tPress 1 for English language\n\t\tDrucken Sie die Zwei fur die deutsche Sprache\n\t\tPia ato maka asusu Igbo\n");
                try
                {
                    Console.Write("\t\t");
                    langSelection = int.Parse(Console.ReadLine());
                    Language = languages[langSelection];
                }
                catch
                {
                    Console.WriteLine("\t\tPlease type a number");
                }
                
            }
            if (Language == "English")
            {
                Utility.TitleBar();
            }
            else if (Language == "German")
            {
                Utility.TitleBarDeutsch();
            }
            else if(Language == "Igbo")
            {
                Utility.TitleBarIgbo();
            }
            

            if (Language == "English")
            {
                Utility.Util();
            }else if (Language == "German")
            {
                Utility.UtilDeutsche();
            }
            else
            {
                Utility.UtilIgbo();
            }
            Console.Clear();

            return Language;
            
            
        }
    }
}
