using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift2
{
    class Meny1
    {
        public static int Summa;
        public static int Antalsälskap;

        public static void Rabatt()
        {
            string Menystatus = "stay";
            do
            {
                

                Console.WriteLine(
                    "Alternativ:" +
                    "\n 1 - skriv in ålder för rabbat uträkning." +
                    "\n 2 - visa estimerad pris summa" +
                    "\n 3 - gå tillbaka till huvudmeny");

                switch (Console.ReadLine())
                {
                    case "1":
                        Åldersamling();                        
                        break;
                    case "2":
                        Console.WriteLine(
                            $"total kostnad på sälskapet av {Antalsälskap} personer är: " +
                            $"\n{Summa}kr");
                        break;
                    case "3":
                        Menystatus = "out";
                        break;
                    default:
                        Console.WriteLine("Skriv ett giltigt kommando");
                        break;
                }
            } while (Menystatus == "stay");
            
         }  
        public static void Åldersamling()
        {
            int antalsällskap = 0;
            int summa = 0;

            Console.WriteLine("Skriv in ålder per person i sällskapet:");
            string Menystatus2 = "samlainfo";
            do
            {            
                Console.WriteLine(
                    $"Ålder på person {antalsällskap + 1}?:" +
                    $"\n(Annars skriv 0 för att gå tillbaka)");
                int answer = int.Parse(Console.ReadLine()) ;
                if (answer == 0)
                {
                    Menystatus2 = "Info samlad";
                    break;
                }
                else if (answer < 20)
                {
                    antalsällskap++;
                    summa += 80;
                    Console.WriteLine("Giltig för ungdoms rabatt, 80kr");
                }
                else if (answer > 64)
                {
                    antalsällskap++;
                    summa += 90;
                    Console.WriteLine("Giltig för pensionärs rabatt, 90kr");
                }
                
                else
                {
                    antalsällskap++;
                    summa += 120;
                    Console.WriteLine("Giltig för vanligt pris, 120kr");
                }
            } while (Menystatus2 == "samlainfo");
            Summa = summa;
            Antalsälskap = antalsällskap;
        }

    }
}
