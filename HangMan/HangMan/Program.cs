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
            int guesslimit = 5;
            //char currentletter;
            while (!endgame)
            {
                try
                {
                    computer.GuessLetter();

                    foreach (char ltr in computer.Word)
                    {
                        if (ltr == '\0')
                            Console.Write(".");
                        else
                            Console.Write(ltr);
                    }
                    
                    Console.WriteLine();

                    
                    if (!computer.Word.Contains('\0'))
                    {
                        endgame = true;
                        Console.WriteLine("The computer won, you're trash");

                    }

                    if (guesslimit == 0)
                    {
                        endgame = true;
                        Console.WriteLine("Congrats broskie, you won");
                    }

                } catch
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
