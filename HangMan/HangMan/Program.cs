using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Player _player = new Player();
            Computer computer = new Computer(_player);

            bool endgame = false;
            bool computerWin = false;

            while (!endgame)
            {
                try
                {

                    string playerResponse = _player.GetResponse(new string[] { "--------------------------------------",
                                                       "What would you like to do?",
                                                       "",
                                                       "Recieve new guess:    | Guess ",
                                                       "View current hangman: | Hangman",
                                                       "concede:              | concede",
                                                       "quit:                 | quit",
                                                       "",
                                                       "Please Type the corresponding word: " });

                    switch ( playerResponse )
                    {
                        case "Guess":
                        case "guess":
                            computer.GuessLetter();
                            _player.ShowGameState(computer);
                            break;
                        case "Hangman":
                        case "hangman":
                            _player.ShowGameState(computer);
                            break;
                        case "Concede":
                        case "concede":
                            computerWin = true;
                            break;
                        case "Quit":
                        case "quit":
                            endgame = true;
                            break;
                        default:
                            _player.Message("Please Enter a valid response");
                            break;
                    }
                    
                    Console.WriteLine();
                    if (!computer.Word.Contains('\0') || computerWin )
                    {
                        endgame = true;
                        Console.WriteLine("The computer won, you're trash");
                    }
                    if (computer.guessesmade == 11)
                    {
                        endgame = true;
                        Console.WriteLine("Congrats broskie, you won");
                    }
                }
                catch
                {
                    Console.WriteLine("GameError");
                    Console.ReadLine();
                    endgame = true;
                }

            }
            Console.ReadKey();
        }
        
    }
}
