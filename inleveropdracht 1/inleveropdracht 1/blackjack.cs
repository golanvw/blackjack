using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inleveropdracht_1
{
    class Blackjack
    {
        public Table table;
        
        public void StartGame()
      {

           Console.WriteLine("aantal spelers( 1 t/m 4 ):");
            int spelers = Int32.Parse(Console.ReadLine());

          
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
            string keuze;
            string doorgaan;
            int spelerswaarde;
            



            

            if (spelers == v)
            {
                do
                {
                    
                    spelerswaarde = 0 ;
                    Console.WriteLine("naam speler 1:");
                    naam1 = string.Format(Console.ReadLine());
                    Console.WriteLine("inzet speler 1 (geheel getal):");
                    inzet1 = Int32.Parse(Console.ReadLine());
                   
                    do
                    {
                                              
                        Console.WriteLine(naam1);
                        Console.WriteLine("Kaart:" );
                        Console.WriteLine("Inzet speler 1: " + inzet1);
                        Console.WriteLine("Inzet verdubbelen of niet? ");
                        keuze = string.Format(Console.ReadLine());
                        if (keuze == "verdubbelen")
                        {

                            int tt = inzet1 * 2;
                            inzet1 = tt;

                        }
                        Console.WriteLine("Wil je een kaart pakken of niks doen? (k/n)");
                        doorgaan = Console.ReadLine();
                        Console.ReadKey();
                    } while (doorgaan != "n" || spelerswaarde < 21);
                    if (spelerswaarde < 21)
                    {
                        Console.WriteLine("Je hebt " + spelerswaarde + " punten gehaald");
                    }
                    else
                    {
                        Console.WriteLine("Je hebt te veel punten, dus helaas heb je verloren");
                    }
                    Console.WriteLine("Wil je nog een keer spelen? (y/n)");
                    doorgaan = Console.ReadLine();
                } while (doorgaan == "y");
                  
            }


            if (spelers == w)
            {
                do
                {
                    spelerswaarde = 0;
                    Console.WriteLine("naam speler 1: ");
                    naam1 = string.Format(Console.ReadLine());
                    Console.WriteLine("inzet speler 1:");
                    inzet1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("naam speler 2: ");
                    naam2 = string.Format(Console.ReadLine());
                    Console.WriteLine("inzet speler 2:");
                    inzet2 = Int32.Parse(Console.ReadLine());
                    do
                    {
                        Console.WriteLine(naam1);
                        Console.WriteLine("kaart:");
                        Console.WriteLine("inzet speler 1: " + inzet1);
                        Console.WriteLine("inzet verdubbelen of niet? ");
                        keuze = string.Format(Console.ReadLine());
                        if (keuze == "verdubbelen")
                        {
                            int tt = inzet1 * 2;
                            inzet1 = tt;

                        }
                        Console.WriteLine("wil je een kaart pakken of niks doen? (k/n)");
                        doorgaan = string.Format(Console.ReadLine());
                        Console.ReadKey();
                        Console.WriteLine(naam2);
                        Console.WriteLine("kaart:");
                        Console.WriteLine("inzet speler 2: " + inzet2);
                        Console.WriteLine("inzet verdubbelen of niet? ");
                        keuze = string.Format(Console.ReadLine());
                        if (keuze == "verdubbelen")
                        {
                            int ww = inzet1 * 2;
                            inzet2 = ww;

                        }
                        Console.WriteLine("wil je een kaart pakken of niks doen? (k/n)");
                        doorgaan = string.Format(Console.ReadLine());
                        Console.ReadKey();
                    } while (doorgaan != "n" || spelerswaarde < 21);
                    if (spelerswaarde < 21)
                    {
                        Console.WriteLine("je hebt " + spelerswaarde + " punten gehaald");
                    }
                    else
                    {
                        Console.WriteLine("je hebt te veel punten, dus helaas heb je verloren");
                    }
                    Console.WriteLine("wil je nog een keer spelen? (y/n)");
                    doorgaan = Console.ReadLine();
                } while (doorgaan == "y");
            }

            if (spelers == q)
            {
                do
                {
                    spelerswaarde = 0;
                    Console.WriteLine("naam speler 1:");
                    naam1 = string.Format(Console.ReadLine());
                    Console.WriteLine("inzet speler 1:");
                    inzet1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("naam speler 2:");
                    naam2 = string.Format(Console.ReadLine());
                    Console.WriteLine("inzet speler 2:");
                    inzet2 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("naam speler 3:");
                    naam3 = string.Format(Console.ReadLine());
                    Console.WriteLine("inzet speler 3:");
                    inzet3 = Int32.Parse(Console.ReadLine());
                    do
                    {
                        Console.WriteLine(naam1);
                        Console.WriteLine("kaart:");
                        Console.WriteLine("inzet speler 1: " + inzet1);
                        Console.WriteLine("inzet verdubbelen of niet? ");
                        keuze = string.Format(Console.ReadLine());
                        if (keuze == "verdubbelen")
                        {
                            int tt = inzet1 * 2;
                            inzet1 = tt;

                        }
                        Console.WriteLine("wil je een kaart pakken of niks doen? (k/n)");
                        doorgaan = string.Format(Console.ReadLine());
                        Console.ReadKey();
                        Console.WriteLine(naam2);
                        Console.WriteLine("kaart:");
                        Console.WriteLine("inzet speler 2: " + inzet2);
                        Console.WriteLine("inzet verdubbelen of niet? ");
                        keuze = string.Format(Console.ReadLine());
                        if (keuze == "verdubbelen")
                        {
                            int ww = inzet2 * 2;
                            inzet2 = ww;

                        }
                        Console.WriteLine("wil je een kaart pakken of niks doen? (k/n)");
                        doorgaan = string.Format(Console.ReadLine());
                        Console.ReadKey();
                        Console.WriteLine(naam3);
                        Console.WriteLine("kaart:");
                        Console.WriteLine("inzet speler 3: " + inzet3);
                        Console.WriteLine("inzet verdubbelen of niet? ");
                        keuze = string.Format(Console.ReadLine());
                        if (keuze == "verdubbelen")
                        {
                            int rr = inzet3 * 2;
                            inzet3 = rr;

                        }
                        Console.WriteLine("wil je een kaart pakken of niks doen? (k/n)");
                        doorgaan = string.Format(Console.ReadLine());
                        Console.ReadKey();
                    } while (doorgaan != "n" || spelerswaarde < 21);
                    if (spelerswaarde < 21)
                    {
                        Console.WriteLine("je hebt " + spelerswaarde + " punten gehaald");
                    }
                    else
                    {
                        Console.WriteLine("je hebt te veel punten, dus helaas heb je verloren");
                    }
                    Console.WriteLine("wil je nog een keer spelen? (y/n)");
                    doorgaan = Console.ReadLine();
                } while (doorgaan == "y");
            }


            if (spelers == s)
            {
                do
                {
                    spelerswaarde = 0;

                    Console.WriteLine("naam speler 1:");
                    naam1 = string.Format(Console.ReadLine());
                    Console.WriteLine("inzet speler 1:");
                    inzet1 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("naam speler 2:");
                    naam2 = string.Format(Console.ReadLine());
                    Console.WriteLine("inzet speler 2:");
                    inzet2 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("naam speler 3:");
                    naam3 = string.Format(Console.ReadLine());
                    Console.WriteLine("inzet speler 3:");
                    inzet3 = Int32.Parse(Console.ReadLine());
                    Console.WriteLine("naam speler 4:");
                    naam4 = string.Format(Console.ReadLine());
                    Console.WriteLine("inzet speler 4:");
                    inzet4 = Int32.Parse(Console.ReadLine());
                    do
                    {
                        Console.WriteLine(naam1);
                        Console.WriteLine("kaart:");
                        Console.WriteLine("inzet speler 1: " + inzet1);
                        Console.WriteLine("inzet verdubbelen of niet? ");
                        keuze = string.Format(Console.ReadLine());
                        if (keuze == "verdubbelen")
                        {
                            int tt = inzet1 * 2;
                            inzet1 = tt;
                            
                        }
                        Console.WriteLine("wil je een kaart pakken of niks doen? (k/n)");
                        doorgaan = string.Format(Console.ReadLine());
                        Console.ReadKey();
                        Console.WriteLine(naam2);
                        Console.WriteLine("kaart:");
                        Console.WriteLine("inzet speler 2: " + inzet2);
                        Console.WriteLine("inzet verdubbelen of niet? ");
                        keuze = string.Format(Console.ReadLine());
                        if (keuze == "verdubbelen")
                        {
                            int ww = inzet2 * 2;
                            inzet2 = ww;
                           
                        }
                        Console.WriteLine("wil je een kaart pakken of niks doen? (k/n)");
                        doorgaan = string.Format(Console.ReadLine());
                        Console.ReadKey();
                        Console.WriteLine(naam3);
                        Console.WriteLine("kaart:");
                        Console.WriteLine("inzet speler 3: " + inzet3);
                        Console.WriteLine("inzet verdubbelen of niet? ");
                        keuze = string.Format(Console.ReadLine());
                        if (keuze == "verdubbelen")
                        {
                            int rr = inzet3 * 2;
                            inzet3 = rr;
                            
                        }
                        Console.WriteLine("wil je een kaart pakken of niks doen? (k/n)");
                        doorgaan = string.Format(Console.ReadLine());
                        Console.ReadKey();
                        Console.WriteLine(naam4);
                        Console.WriteLine("kaart:");
                        Console.WriteLine("inzet speler 4: " + inzet4);
                        Console.WriteLine("inzet verdubbelen of niet? ");
                        keuze = string.Format(Console.ReadLine());
                        if (keuze == "verdubbelen")
                        {
                            int aa = inzet4 * 2;
                            inzet4 = aa;
                            
                        }
                        Console.WriteLine("wil je een kaart pakken of niks doen? (k/n)");
                        doorgaan = string.Format(Console.ReadLine());
                        Console.ReadKey();
                    } while (doorgaan != "n" || spelerswaarde < 21);
                    if (spelerswaarde < 21)
                    {
                        Console.WriteLine("je hebt " + spelerswaarde + " punten gehaald");
                    }
                    else
                    {
                        Console.WriteLine("je hebt te veel punten, dus helaas heb je verloren");
                    }
                    Console.WriteLine("wil je nog een keer spelen? (y/n)");
                    doorgaan = Console.ReadLine();
                } while (doorgaan == "y");
            }
        }

        private void DealCards(List<Card> cards)
        {

        }
    }
}
