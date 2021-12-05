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
            int inzet1;
            int inzet2;
            int inzet3;
            int inzet4;
            int spelers;
            int kaarten;
            string keuze;
            int dubbel;

            Console.WriteLine("aantal spelers:");
            spelers = Int32.Parse(Console.ReadLine());
           
            Console.WriteLine("aantal kaarten per spelers:");
            kaarten = Int32.Parse(Console.ReadLine());
           
            naam1 = string.Format(Console.ReadLine());
            naam2 = string.Format(Console.ReadLine());
            naam3 = string.Format(Console.ReadLine());
            naam4 = string.Format(Console.ReadLine());

           if (spelers == v)
            {
                do
                {
                    Console.WriteLine("naam speler 1:");
                    naam1 = string.Format(Console.ReadLine());
                    Console.WriteLine("inzet speler 1:");
                    inzet1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(naam1);
                    Console.WriteLine("kaart:");
                    Console.Write("inzet speler 1: " + inzet1);
                    Console.WriteLine("wil je nog eens spelen? (y/n)");
                    doorgaan = string.Format(Console.ReadLine());
                } while (doorgaan == "y");


            }

            if (spelers == w)
            {
                do
                {
                    Console.WriteLine("naam speler 1: ");
                    naam1 = string.Format(Console.ReadLine());
                    Console.WriteLine("naam speler 2: ");
                    naam2 = string.Format(Console.ReadLine());
                    Console.WriteLine("inzet speler 1:");
                    inzet1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("inzet speler 2:");
                    inzet2 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(naam1);
                    Console.WriteLine("kaart:");
                    Console.WriteLine(value: "inzet speler 1: " + inzet1);
                    Console.WriteLine(naam2);
                    Console.WriteLine("kaart:");
                    Console.Write("inzet speler 2: " + inzet2);
                    Console.WriteLine("wil je nog eens spelen? (y/n)");
                    doorgaan = string.Format(Console.ReadLine());
                } while (doorgaan == "y");
            }
             
            if(spelers == q)
            {
                do
                {
                    Console.WriteLine("naam speler 1:");
                    naam1 = string.Format(Console.ReadLine());
                    Console.WriteLine("naam speler 2:");
                    naam2 = string.Format(Console.ReadLine());
                    Console.WriteLine("naam speler 3:");
                    naam3 = string.Format(Console.ReadLine());
                    Console.WriteLine("inzet speler 1:");
                    inzet1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("inzet speler 2:");
                    inzet2 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("inzet speler 3:");
                    inzet3 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(naam1);
                    Console.WriteLine("kaart:");
                    Console.WriteLine(value: "inzet speler 1: " + inzet1);
                    Console.WriteLine(naam2);
                    Console.WriteLine("kaart:");
                    Console.WriteLine(value: "inzet speler 2: " + inzet2);
                    Console.WriteLine(naam3);
                    Console.WriteLine("kaart:");
                    Console.WriteLine(value: "inzet speler 3: " + inzet3);
                    Console.WriteLine("wil je nog eens spelen? (y/n)");
                    doorgaan = string.Format(Console.ReadLine());
                } while (doorgaan == "y");
            }
         

            if (spelers == s )
            {
                do
                {
                    Console.WriteLine("naam speler 1:");
                    naam1 = string.Format(Console.ReadLine());
                    Console.WriteLine("naam speler 2:");
                    naam2 = string.Format(Console.ReadLine());
                    Console.WriteLine("naam speler 3:");
                    naam3 = string.Format(Console.ReadLine());
                    Console.WriteLine("naam speler 4:");
                    naam4 = string.Format(Console.ReadLine());
                    Console.WriteLine("inzet speler 1:");
                    inzet1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("inzet speler 2:");
                    inzet2 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("inzet speler 3:");
                    inzet3 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("inzet speler 4:");
                    inzet4 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(naam1);
                    Console.WriteLine("kaart:");
                    Console.WriteLine(value: "inzet speler 1: " + inzet1);
                    Console.WriteLine("inzet verdubbelen of niet");
                    keuze = Console.ReadLine().ToUpper();
                    if (keuze == "verdubbelen")
                    {
                        Console.WriteLine(inzet1 * 2);
                        dubbel = Int32.Parse(Console.ReadLine());
                        Console.WriteLine(dubbel);

                    }

                    Console.WriteLine(naam2);
                    Console.WriteLine("kaart:");
                    Console.WriteLine(value: "inzet speler 2: " + inzet2);
                    Console.WriteLine(naam3);
                    Console.WriteLine("kaart:");
                    Console.WriteLine(value: "inzet speler 3: " + inzet3);
                    Console.WriteLine(naam4);
                    Console.WriteLine("kaart:");
                    Console.WriteLine(value: "inzet speler 4: " + inzet4);
                    Console.WriteLine("wil je nog eens spelen? (y/n)");
                    doorgaan = string.Format(Console.ReadLine());
                } while (doorgaan == "y");
            }
        }
    }
}
