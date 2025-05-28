using System;
using static System.Formats.Asn1.AsnWriter;
using System.Numerics;

namespace SwitchCaseHighScore
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Highscore(250, "Bob");
            Highscore(650, "Rick");
            Highscore(999, "Joshua");
            Console.Read();
        }
        static int HScore = 600;
        static string HSPlayer = "Joshua";
        public static void Highscore(int score, string player)
        {
            if(score > HScore)
            {
                Console.WriteLine("New Highscore is {0}!", score);
                Console.WriteLine("New Highscore holder is {0}!", player);
                HScore = score;
                HSPlayer = player;
            }
            else
            {
                Console.WriteLine("The Old Highscore of {0} could not be broken and is still held by {1}.", HScore,HSPlayer);

            }
        }

        
    }
}