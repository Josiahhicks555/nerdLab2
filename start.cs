using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nerd_Labyrinth_2
{
    class Start
    {
        public static List<NewPlayer> NewPlayer = new List<NewPlayer>();
        public static int Players;
        public static int Health;
        public static void Game_start()
        {
            Console.WriteLine("Hello");
            Console.WriteLine("How many people will be playing: ");
            Players = Convert.ToInt32(Console.ReadLine());

            for (int p = 0; p < Players; p++)
            {
                string newPlayer = "player" + (p + 1);
                Console.WriteLine($"Hello Player{p + 1}");
                Console.Write("What is your name: ");
                string playerName = Console.ReadLine();

                Console.WriteLine($"{playerName} What a great name. How old are you {playerName}: ");
                int playerAge = Convert.ToInt32(Console.ReadLine());

                NewPlayer Fighter = new NewPlayer(playerName, playerAge, 0, newPlayer);
                Console.WriteLine("Your stats are: ");
                Console.WriteLine($"{Fighter.PlayerNumber} is {Fighter.Name} and your {Fighter.Age} years old.");
                Console.WriteLine("");
                NewPlayer.Add(new NewPlayer(playerName, playerAge, 0, newPlayer));


                
            }

        }

        public static void Player_Check()
        {
            for (int p = 0; p < Players; p++) 
            {
                Console.WriteLine($"{NewPlayer[p].Name} Score = {NewPlayer[p].PlayerScore}");
            }
            NewPlayer[1].PlayerScore = NewPlayer[1].PlayerScore + 1;
            Console.WriteLine($"{NewPlayer[1].Name} Score is: {NewPlayer[1].PlayerScore}");

        }

        public static void Battle_Start()
        {
            for (int p = 0; p < Players; p++)
            {
                Console.WriteLine($"Would you like to attack {NewPlayer[p].Name}");
                Console.ReadLine();
            }
        }

    }
}



