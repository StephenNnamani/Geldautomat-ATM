
namespace GeldAutomat_ATM_.UI
{
    public static class WillkommeSprachen
    {

        public static string Willkomme()
        {
            string lines = "------------------------";

            string language = LanguageSelection.LangSelect();
            string ATMnumber = "";
            string ATMPin = "";

            int attempts = 0;
            if(language == "English")
            {
                Console.WriteLine($"\n\n\t{lines} Welcome To My Console ATM {lines}\n\n");
                while (ATMnumber.Length != 8 || ATMPin.Length != 4)
                {
                    Console.Write("|\t\tPlease kindly insert your ATM number here: \t");
                    ATMnumber = Console.ReadLine();
                    Console.Write("\t\tKindly type in your PIN: \t"); ATMPin = Console.ReadLine();

                    attempts++; 
                    if (ATMnumber.Length != 8)
                    {
                        Console.Write("\n\n");
                        Utility.ErrorColor("Check your ATM Number and try again");
                    }
                    else if (ATMPin.Length != 4)
                    {
                        Console.Write("\n\n");
                        Utility.ErrorColor("Check your ATM Number and try again");

                    }
                    if (attempts > 4)
                    {
                        Environment.Exit(0);
                    }
                }
                Utility.Util();
            }else if(language == "German")
            {
                Console.WriteLine($"\n\n\t{lines} Willkommen bei meinem Konsolenautomaten {lines}\n\n");
                while (ATMnumber.Length != 8 || ATMPin.Length != 4)
                {
                    Console.Write("Bitte geben Sie hier Ihre Geldautomatennummer ein: \t");
                    ATMnumber = Console.ReadLine();
                    Console.Write("\t\tKindly type in your PIN: \t"); ATMPin = Console.ReadLine();
                    attempts++;

                    if (ATMnumber.Length != 8)
                    {
                        Console.Write("\n\n");
                        Utility.ErrorColor("Check your ATM Number and try again");
                    }
                    else if (ATMPin.Length != 4)
                    {
                        Console.Write("\n\n");
                        Utility.ErrorColor("Check your ATM Number and try again");

                    }
                    if (attempts > 4)
                    {
                        Environment.Exit(0);
                    }
                }
                Utility.UtilDeutsche();
            }else if (language == "Igbo")
            {
                Console.WriteLine($"\n\n{lines} Nnoo na ATM Console m {lines}\n\n");
                while (ATMnumber.Length != 8 || ATMPin.Length !=4)
                {
                    Console.Write("\n\n");
                    Console.Write("Biko jiri obioma tinye nomba ATM gi ebe a: \t");
                    ATMnumber = Console.ReadLine();
                    Console.Write("\t\tKindly type in your PIN: \t"); ATMPin = Console.ReadLine();
                    attempts++;
                    
                    if(ATMnumber.Length != 8)
                    {
                        Console.Write("\n\n");
                        Utility.ErrorColor("Check your ATM Number and try again");
                    }else if (ATMPin.Length != 4)
                    {
                        Console.Write("\n\n");
                        Utility.ErrorColor("Check your ATM Number and try again");

                    }
                    if (attempts > 4)
                    {
                        Environment.Exit(0);
                    }
                }

                Utility.UtilIgbo();
            }
            
            Console.Clear();
            return ATMPin;
        }
    }
}
