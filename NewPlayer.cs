using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nerd_Labyrinth_2
{
    class NewPlayer
    {
        public string Name;
        public int Age;
        public int Health;
        public double PlayerAttack;
        public int PlayerScore;
        public string PlayerNumber;

        public NewPlayer(string name, int age, int playerScore, string playerNumber)
        {
            this.Name = name;
            this.Age = age;
            this.PlayerScore = playerScore;
            this.PlayerNumber = playerNumber;
        }

        public static double PlayerRandomAttack(int age)
        {
            Random r = new Random();
            double AttackMultiplier = r.NextDouble();
            double PlayerAttack = AttackMultiplier * age;
            Console.WriteLine($"AttackMultiplier = {AttackMultiplier}");
            Console.WriteLine($"PlayerAttack = {PlayerAttack}");
            return PlayerAttack;
        }


        
    }
}
