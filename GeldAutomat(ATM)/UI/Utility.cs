using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeldAutomat_ATM_.UI
{
    public static class Utility
    {
        public static void Util()
        {
            Console.Write("\n\n\t\tPress any to continue");
            Console.ReadLine();
            Console.Write("\t\tloading");
            for (int i = 0; i < 15; i++)
            {
                Console.Write(".");
                Thread.Sleep(200);
            }

        }
        public static void UtilDeutsche()
        {
            Console.Write("\n\n\t\tDrücken Sie eine beliebige Taste, um fortzufahren");
            Console.ReadLine();
            Console.Write("\t\tloading");
            for (int i = 0; i<15; i++)
            {
                Console.Write(".");
                Thread.Sleep(200);
            }
            
        }
        public static void UtilIgbo()
        {
            Console.Write("\n\n\t\tPịa nke ọ bụla ka ịga n'ihu");
            Console.ReadLine();
            Console.Write("\t\tloading");
            for (int i = 0; i < 15; i++)
            {
                Console.Write(".");
                Thread.Sleep(200);
            }

        }

        public static void TitleBar()
        {
            Console.Title ="STEPHEN'S BANK :::::   My ATM Machine";
        }
        public static void TitleBarDeutsch()
        {
            Console.Title = "STEPHEN'S BANK :::::   Meine Geldautomat";
        }
        public static void TitleBarIgbo()
        {
            Console.Title = "STEPHEN'S BANK ::::: Igwe ATM m";
        }


        public static void ProgramColors()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.ResetColor();
        }


    }
}