
namespace GeldAutomat_ATM_.UI
{
    public static class WillkommeSprachen
    {
        public static void Willkomme()
        {
            string lines = "------------------------";

            string language = LanguageSelection.LangSelect();
            string ATMnumber = "";
            if(language == "English")
            {
                Console.WriteLine($"\n\n\t{lines} Welcome To My Console ATM {lines}\n\n");
                while (ATMnumber.Length != 8)
                {
                    Console.WriteLine("|\t\tPlease kindly insert your ATM number here");
                    ATMnumber = Console.ReadLine();
                    Console.WriteLine(ATMnumber);
                }
            }else if(language == "German")
            {
                Console.WriteLine($"\n\n\t{lines} Willkommen bei meinem Konsolenautomaten {lines}\n\n");
                while (ATMnumber.Length != 8)
                {
                    Console.WriteLine("|\t\tBitte geben Sie hier Ihre Geldautomatennummer ein");
                    ATMnumber = Console.ReadLine();
                    Console.WriteLine(ATMnumber);
                }
            }else if (language == "Igbo")
            {
                Console.WriteLine($"\n\n\t{lines} Nnoo na ATM Console m {lines}\n\n");
                while (ATMnumber.Length != 8)
                {
                    Console.WriteLine("|\t\tBiko jiri obioma tinye nomba ATM gi ebe a");
                    ATMnumber = Console.ReadLine();
                    Console.WriteLine(ATMnumber);
                }
            }
            Utility.Util();
            Console.Clear();
        }
    }
}
