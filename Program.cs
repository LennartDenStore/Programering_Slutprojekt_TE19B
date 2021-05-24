using System;

namespace Faling_rocks
{
    class Program
    {
        static int kartBredd = 3;
        static int kartHöjd = 3;
        static string[,] datornsKarta = new string[kartBredd, kartHöjd];
        static Random slump = new Random();
        static void Main(string[] args)
        {
            SkapaKartorna();
            SpelaFalingRicks();
            // Start meny (cases)
            Console.WriteLine("Välkomen till Faling rooks!");
            Console.WriteLine("Skriv Start eller 1 för att tarta programet!");
            Console.WriteLine("Ifal du vill avsluta programet skriv End eller 2");
            Console.WriteLine("");

            string svar = "";
            while (svar != "2")
            {
                RitaSpelplanen();
                svar = Console.ReadLine();
                Console.WriteLine();
                StenarRamllarNer();


                Console.BackgroundColor = ConsoleColor.Black;

                switch (svar)
                {
                    case "1":
                        StartGame();

                        break;

                    case "2":
                        Console.WriteLine(" Tack för att du har testat Falling Rocks!");
                        break;

                    default:
                        break;
                }
            }


        }
        // Start game
        static void StartGame()
        {
            Console.WriteLine("SPLET BÖRJAR NÄR DU RÖR DIG!");
            Console.WriteLine("Spelet går utt på att dundvika de falande stenarna, och att råra på dig så många gånger som möjlight");
            Console.WriteLine("Du splar genom att trycka på tangenterna a och d. a gör så att du går åt vänster och b gör så att du går åt höger");
            Console.WriteLine("Varje gång du rör dig så kommer sternarna ett steg längre ner");
        }

        static void SkapaKartorna()

        {
            for (int y = 0; y < kartHöjd; y++)
            {
                for (int x = 0; x < kartBredd; x++)
                {
                    datornsKarta[x, y] = "-";
                   
                }
            }
        }

        static void SpelaFalingRicks()
        {
            datornsKarta[slump.Next(kartBredd), 0] = "X";
        }
        static void RitaSpelplanen()
        {
            Console.WriteLine("karta");
            for (int y = 0; y < kartHöjd; y++)
            {
                for (int x = 0; x < kartBredd; x++)
                {
                    Console.Write(datornsKarta[x, y]);

                    // Återställ färgen till grå
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                Console.WriteLine();
            }
        }
        static void StenarRamllarNer()
        {
            for (int j = 2; j > 0; j--)
            {
             for (int i = 0; i < 3; i++)
             {
                 datornsKarta[i,j] = datornsKarta[i,j-1];
             }   
            }

        }
        static void ClearFirstLayer()
        {
            datornsKarta[.Next(kartBredd), 0] = "-";
        }

    }
}


/* Variabler, datatyper
Typkonvertering
Input och output (readline och writeline)
If och else
While-loopar och for-loopar
Metoder (gärna med både parametrar och returvärden)
Listor och/eller arrayer
Kommentarer
Korrekt namngivning
Ett tydligt gränssnitt
Kod som är stabil & utan allvarliga fel i syntax och logik */