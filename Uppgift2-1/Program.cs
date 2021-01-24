using System;

namespace Uppgift2
{
    class Program
    {
        static void Main(string[] args)
        {            
            do
            {
                Startmeny();
                Menyval();

            } while (true);

            
            


        }
        private static void Startmeny()
        {
            Console.WriteLine(
                "Det här är huvudmenyn, skriv in siffra för ditt val:" +
                "\n 0 - Gå ur programmet" +
                "\n 1 - Beräkna biljetter" +
                "\n 2 - repetativ inskrift" +
                "\n 3 - Selektivt plock av ord i mening\n"
                );
        }
        private static void Menyval()
        {
            switch (Console.ReadLine())
            {
                case "0":
                    Environment.Exit(0);
                    break;
                case "1":

                    break;

                case "2":

                    break;

                case "3":

                    break;

                default:
                    Console.WriteLine("Felaktigt kommando\n");
                    break;
            };            
        }
    }
}
