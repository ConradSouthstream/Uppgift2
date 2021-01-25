using System;
using System.Collections.Generic;
using System.Text;

namespace Uppgift2
{
    class Meny3
    {
        public static void Selektivtredje()
        {
            
            Console.WriteLine("skriv en mening med minst 3 ord");
            string[] mening = Console.ReadLine().Split(' ');
            Console.WriteLine(mening[2]);
            /*
             experimenterade med "var", 
             lyckades inte finna en lösning som kunde navigera i variabeln             
             */
        }

    }
}
