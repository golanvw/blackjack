using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inleveropdracht_1
{
    class Program
    {
        static void Main(string[] args)
        {
         int v = 1;
            int w = 2;
            int q = 3;
            int s = 4;
            string naam1;
            string naam2;
            string naam3;
            string naam4;

            naam1 = string.Format(Console.ReadLine());
            naam2 = string.Format(Console.ReadLine());
            naam3 = string.Format(Console.ReadLine());
            naam4 = string.Format(Console.ReadLine());

            if (spelers == v)
            {
               
                Console.WriteLine("naam speler 1:");
                naam1 = string.Format(Console.ReadLine());
             
               

            }
           
            else if (spelers == w)
            {
                Console.WriteLine("naam speler 1: ");
                naam1 = string.Format(Console.ReadLine());
                Console.WriteLine("naam speler 2: ");
                naam2 = string.Format(Console.ReadLine());
               


            }
             
            if(spelers == q)
            {
                Console.WriteLine("naam speler 1:");
                naam1 = string.Format(Console.ReadLine());
                Console.WriteLine("naam speler 2:");
                naam2 = string.Format(Console.ReadLine());
                Console.WriteLine("naam speler 3:");
                naam3 = string.Format(Console.ReadLine());

            }
         

            if (spelers == s )
            {
                Console.WriteLine("naam speler 1:");
                naam1 = string.Format(Console.ReadLine());
                Console.WriteLine("naam speler 2:");
                naam2 = string.Format(Console.ReadLine());
                Console.WriteLine("naam speler 3:");
                naam3 = string.Format(Console.ReadLine());
                Console.WriteLine("naam speler 4:");
                naam4 = string.Format(Console.ReadLine());
            }
        }
    }
}
