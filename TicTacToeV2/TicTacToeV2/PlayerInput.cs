using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeV2
{
    public class PlayerInput
    {
        public static void InputXorO(int player, int input)
        {
            char playerSign = ' ';

            if (player == 1)
            {
                playerSign = 'X';
            } else if (player == 2)
            {
                playerSign = 'O';
            }

            switch (input)
            {
                case 1: PlayField.playField[0, 0] = playerSign; break;
                case 2: PlayField.playField[0, 1] = playerSign; break;
                case 3: PlayField.playField[0, 2] = playerSign; break;
                case 4: PlayField.playField[1, 0] = playerSign; break;
                case 5: PlayField.playField[1, 1] = playerSign; break;
                case 6: PlayField.playField[1, 2] = playerSign; break;
                case 7: PlayField.playField[2, 0] = playerSign; break;
                case 8: PlayField.playField[2, 1] = playerSign; break;
                case 9: PlayField.playField[2, 2] = playerSign; break;
            }
        }
    }
}
