using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan
{
    public class Player
    {
        
        public Player()
        {

        }

        public int WordLength()
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Please Enter your word length");
                string temp = Console.ReadLine();
                var isNumeric = int.TryParse(temp, out int n);
                if (isNumeric)
                {
                    int tempint = Convert.ToInt32(temp);
                    if (tempint != 0)
                        return tempint;
                    Console.WriteLine("Please Enter a value greater than 0");
                }
            }
            return 0;
        }

        public void Message(string message)
        {
            Console.WriteLine(message);
        }

        public string GetResponse(string request)
        {
            Console.Write(request);
            return Console.ReadLine();
        }

        public bool BoolConfirmation(string message)
        {
            string userResponse = GetResponse(message);
            bool exit = false;
            while (!exit)
            {
                if (userResponse == "yes")
                    return true;
                else if (userResponse == "no")
                    return false;
                else
                    userResponse = GetResponse("Please enter Yes or No");
            }
            return false;
        }
        
    }
}
