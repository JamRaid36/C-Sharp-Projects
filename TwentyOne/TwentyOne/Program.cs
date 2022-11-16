using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyOne;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //string text = "Here is some text.";
            //File.WriteAllText(@"C:\Users\guita\Desktop\21 Game Log\log.txt", text); //writes text to a txt file if file doesnt exist it creates the txt file.

            //string text = File.ReadAllText(@"C:\Users\guita\Desktop\21 Game Log\log.txt"); // Read txt file


            const string casinoName = "Grand Hotel and Casino";

            

            Console.WriteLine("Welcome to the {0}. Let's start by telling me your name?",casinoName);
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello {0}. Would you like to join a game of 21 right now", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya") 
            {
                Player player = new Player(playerName,bank);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\guita\Desktop\21 Game Log\log.txt", true))
                {
                    file.WriteLine(player.Id);
                    
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0) 
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();
        }        
    }
}
