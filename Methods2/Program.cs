using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2
{
    class Program
    {
        static int score;
        static int health;

        static void Main(string[] args)
        {
            //Initializaion
            score = 0;
            health = 100;

            Title();

            ShowHUD();
            TakeDamage(28);
            ShowHUD();




            Console.ReadKey(true);

        }

        static void TakeDamage(int damage)
        {
            health -= damage;
            Console.WriteLine("--------------");
            Console.WriteLine("Player has taken " + damage + " damage");
            Console.WriteLine("--------------");
            Console.WriteLine();
            Console.ReadKey(true);
        }
        static void ShowHUD()
        {

            Console.WriteLine("[=======HUD=======]");
            Console.WriteLine("Health = " + health);
            Console.WriteLine("Score = " + score);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("[=================]");
            Console.WriteLine();
            Console.ReadKey(true);
        }

        static void Title()
        {
            Console.WriteLine("++++++++++++++++++++++++");
            Console.WriteLine();
            Console.WriteLine("Welcome to replace_name!");
            Console.WriteLine();
            Console.WriteLine("you know actual ");
            Console.WriteLine("games exist right?");
            Console.WriteLine("++++++++++++++++++++++++");
            Console.WriteLine();

            Console.ReadKey(true);
        }
    }
}
