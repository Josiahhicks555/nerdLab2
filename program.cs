using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nerd_Labyrinth_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Start.Game_start();
            Console.WriteLine("Below is the player check()");
            Start.Player_Check();
            AddPoints(1);
            AddPoints(1);
            AddPoints(1);
            AddPoints(2);
            AddPoints(1);
            Console.ReadKey();
        }

        public static int AddPoints(int playerNumber)
        {

        Console.WriteLine($"{Start.NewPlayer[playerNumber].Name} current score is: {Start.NewPlayer[playerNumber].PlayerScore}");

         Start.NewPlayer[playerNumber].PlayerScore = Start.NewPlayer[playerNumber].PlayerScore + 1;

         Console.WriteLine($"{Start.NewPlayer[playerNumber].Name} New Score is now:  {Start.NewPlayer[playerNumber].PlayerScore}");
           return Start.NewPlayer[playerNumber].PlayerScore;

        }
    }
}
    

