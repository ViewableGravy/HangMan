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
            Console.WriteLine("Please Enter your word length");
            return Convert.ToInt32(Console.ReadLine());
        }
        
    }
}
