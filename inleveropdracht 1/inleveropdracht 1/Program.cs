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

            int spelers;
            Console.WriteLine("aantal spelers:");
            spelers = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("aantal spelers is " + spelers);

            int kaarten;
            Console.WriteLine("aantal kaarten per spelers:");
            kaarten = Int32.Parse(Console.ReadLine());
            //string kaarten = Console.ReadLine();
            //Console.WriteLine("aantal kaarten:" + kaarten);

            int v = 1;
            if (spelers == v)
            Console.Write("naam speler 1:" );


            //Console.WriteLine("naam speler 2:");
            //Console.WriteLine("naam speler 3:");
            //Console.WriteLine("naam speler 4:");

            Console.WriteLine("wat is uw inzet:");
            string inzet = Console.ReadLine();
            Console.WriteLine("inzet:" + inzet);

            
                        
            //string vier = "aantal spelers";
            //Console.Write("\n" + vier);
            //string vijf = "aantal kaarten";
            //Console.Write("\n"+ vijf); 



            Console.ReadLine();
        }
    }
}
