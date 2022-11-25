using GeldAutomat_ATM_.UI;

namespace GeldAutomat_ATM_.App
{
    internal class ATMApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("start");
            string ATMPin = WillkommeSprachen.Willkomme();
            LoginValidator.UserChecks(ATMPin);
           
           
        }
    }
}
