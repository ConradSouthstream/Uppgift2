using System;

namespace Uppgift2
{
    /*
    För att vara ärlig,
    Jag var väldigt sent ute med att fixa den här uppgiften.
    Jag hoppas det har lärt mig att ge mig på uppgifter tidigare än vad jag gjort hittills,
    För experimenteringen hjälpte mig att begripa mina misstag som utfördes.
    */
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
                "\n 3 - Selektivt plock av ord i mening" +
                "\n 4 - Presentera biljett räkningen\n"
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
                    Meny1.Rabatt();
                    break;
                case "2":
                    Meny2.Tiogånger();
                    break;
                case "3":
                    Meny3.Selektivtredje();
                    break;
                case "4":
                    Console.WriteLine(
                        $"\nför de {Meny1.Antalsälskap} registrerade ska det kosta:" +
                        $"\n{Meny1.Summa}kr\n");
                    break;
                default:
                    Console.WriteLine("Felaktigt kommando\n");
                    break;
            };            
        }
    }    
}
