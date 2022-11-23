
namespace GeldAutomat_ATM_.UI
{
    public static class WillkommeSprachen
    {

        public static string[] Willkomme()
        {
            string lines = "------------------------";

            string language = LanguageSelection.LangSelect();
            string ATMnumber = "";
            string ATMPin = "";
            string[] UserInput = new string[2];
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
                    if (attempts == 3)
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
                    Console.Write("\t\tBitte geben Sie hier Ihre Geldautomatennummer ein: \t");
                    ATMnumber = Console.ReadLine();
                    Console.Write("\t\tKindly type in your PIN: \t"); ATMPin = Console.ReadLine();

                    attempts++;
                    if (attempts == 3)
                    {
                        Environment.Exit(0);
                    }
                }
                Utility.UtilDeutsche();
            }else if (language == "Igbo")
            {
                Console.WriteLine($"\n\n\t{lines} Nnoo na ATM Console m {lines}\n\n");
                while (ATMnumber.Length != 8 || ATMPin.Length !=4)
                {
                    Console.Write("\n\n");
                    Console.Write("|\t\tBiko jiri obioma tinye nomba ATM gi ebe a: \t");
                    ATMnumber = Console.ReadLine();
                    Console.Write("\t\tKindly type in your PIN: \t"); ATMPin = Console.ReadLine();
                    attempts++;
                    
                    if(ATMnumber.Length != 8)
                    {
                        Console.Write("\n\n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\t\tCheck your ATM Number and try again");
                        Console.ResetColor();
                    }else if (ATMPin.Length != 4)
                    {
                        Console.Write("\n\n");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\t\tCheck your ATM Pin and try again");
                        Console.ResetColor();
                    }
                    if (attempts > 4)
                    {
                        Environment.Exit(0);
                    }
                }

                Utility.UtilIgbo();
            }
            UserInput[0] = ATMnumber;
            UserInput[1] = ATMPin;
            
            return UserInput;
            Console.Clear();
        }
    }
}
