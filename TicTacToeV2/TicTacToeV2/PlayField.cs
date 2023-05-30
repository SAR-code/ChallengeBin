using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeV2
{
    public class PlayField
    {
       public static char[,] playField =
       {
            {'1', '2', '3' },
            {'4', '5', '6' },
            {'7', '8', '9' },
       };

       public static int turns = 0;


        public static void SetField()
        {
            Console.Clear();
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2}", playField[0, 0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2}", playField[1, 0], playField[1, 1], playField[1, 2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} | {1} | {2}", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("   |   |   ");
            turns++;

        }

        public static void ResetField()
        {
            char[,] playFieldInitial =
            {
                { '1', '2', '3'},
                { '4', '5', '6'},
                { '7', '8', '9'},

            };

            playField = playFieldInitial;

            SetField();
            turns = 0;
        }


    }


}
