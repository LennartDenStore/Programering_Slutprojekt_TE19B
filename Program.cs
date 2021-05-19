using System;

namespace Faling_rocks
{
    class Program
    {
        static void Main(string[] args)
        {

            // Start meny (cases)
            Console.WriteLine("Välkomen till Faling rooks!");
            Console.WriteLine("Skriv Start eller 1 för att tarta programet!");
            Console.WriteLine("Ifal du vill avsluta programet skriv End eller 2");
            Console.WriteLine("");
            
            string svar = "";
            while (svar != "2")
            {

                svar = Console.ReadLine();
                Console.WriteLine();

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

            // Start game
            static void StartGame()
            {
                Console.WriteLine("SPLET BÖRJAR NÄR DU RÖR DIG!");
                Console.WriteLine("Spelet går utt på att dundvika de falande stenarna, och att råra på dig så många gånger som möjlight");
                Console.WriteLine("Du splar genom att trycka på tangenterna a och d. a gör så att du går åt vänster och b gör så att du går åt höger");
                Console.WriteLine("Varje gång du rör dig så kommer sternarna ett steg längre ner");
            }

            // Loade obekts and map

            // movment (if loop)

            // if player hit by objekt open menue to restart or exit game loop

            //if player isent hit by objekt loop movment and objekts untill loop ends

            // if player preses escape open menue (return to game, restart or exit)

            // if exit end game

        }
    }
}
