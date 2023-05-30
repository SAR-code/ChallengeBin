namespace TicTacToeV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            bool inputCorrect = true;

            do
            {
                if (player == 2)
                {
                    player = 1;
                    PlayerInput.InputXorO(player, input);
                } else if ( player == 1)
                {
                    player= 2;
                    PlayerInput.InputXorO(player, input);
                }
                PlayField.SetField();

                char[] playerChars = { 'X', 'O' };

                foreach(char playerChar in playerChars)
                {
                    if (((PlayField.playField[0, 0] == playerChar) && (PlayField.playField[0, 1] == playerChar) && (PlayField.playField[0, 2] == playerChar))
                        || ((PlayField.playField[0, 0] == playerChar) && (PlayField.playField[0, 1] == playerChar) && (PlayField.playField[0, 2] == playerChar))
                        || ((PlayField.playField[1, 0] == playerChar) && (PlayField.playField[1, 1] == playerChar) && (PlayField.playField[1, 2] == playerChar))
                        || ((PlayField.playField[2, 0] == playerChar) && (PlayField.playField[2, 1] == playerChar) && (PlayField.playField[2, 2] == playerChar))
                        || ((PlayField.playField[0, 1] == playerChar) && (PlayField.playField[1, 1] == playerChar) && (PlayField.playField[2, 1] == playerChar))
                        || ((PlayField.playField[0, 0] == playerChar) && (PlayField.playField[1, 0] == playerChar) && (PlayField.playField[2, 0] == playerChar))
                        || ((PlayField.playField[0, 0] == playerChar) && (PlayField.playField[0, 1] == playerChar) && (PlayField.playField[0, 2] == playerChar))
                        || ((PlayField.playField[0, 2] == playerChar) && (PlayField.playField[1, 2] == playerChar) && (PlayField.playField[2, 2] == playerChar))
                        || ((PlayField.playField[0, 0] == playerChar) && (PlayField.playField[1, 1] == playerChar) && (PlayField.playField[2, 2] == playerChar))
                        || ((PlayField.playField[0, 2] == playerChar) && (PlayField.playField[1, 1] == playerChar) && (PlayField.playField[2, 0] == playerChar))
                        )
                    {
                        if (playerChar == 'X')
                        {
                            Console.WriteLine("\nPlayer 2 has won this match!");
                        } else
                        {
                            Console.WriteLine("\nPlayer 1 has won this match!");
                        }

                        Console.WriteLine("Please press any key to reset the game");
                        Console.ReadKey();
                        PlayField.ResetField();
                        break;
                    }
                    else if (PlayField.turns == 10)
                    {
                        Console.WriteLine("Draw");
                        Console.WriteLine("Please press any key to reset the game");
                        Console.ReadKey();
                        PlayField.ResetField();
                        break;
                    }
                }

                do
                {
                    Console.WriteLine("\nPlayer {0}: Select a number on the field!", player);
                    try
                    {
                        input = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Please Enter a number");
                    }

                    if ((input == 1) && (PlayField.playField[0, 0] == '1'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 2) && (PlayField.playField[0, 1] == '2'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 3) && (PlayField.playField[0, 2] == '3'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 4) && (PlayField.playField[1, 0] == '4'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 5) && (PlayField.playField[1, 1] == '5'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 6) && (PlayField.playField[1, 2] == '6'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 7) && (PlayField.playField[2, 0] == '7'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 8) && (PlayField.playField[2, 1] == '8'))
                    {
                        inputCorrect = true;
                    }
                    else if ((input == 9) && (PlayField.playField[2, 2] == '9'))
                    {
                        inputCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("\n Incorrect input! Please use another field");
                        inputCorrect = false;
                    }
                } while (!inputCorrect);
            } while (true);
            
            
        }
    }
}