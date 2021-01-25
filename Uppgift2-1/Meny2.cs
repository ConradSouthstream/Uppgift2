using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift2
{
    class Meny2
    {
        public static void Tiogånger()
        {
            Console.WriteLine("\nSkriv in något du vill upprepa 10 gånger:");
            string tiofald = Console.ReadLine();
            string Tiofald = "";
            for (int i = 0; i < 10; i++)
            {
                int num = i;                
                Tiofald += $"{num+=1}.{tiofald},";
            }
            Console.WriteLine("\n"+Tiofald+"\n");            
        }        
    }
}
