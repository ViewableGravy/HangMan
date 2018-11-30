using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HangMan
{
    public class Computer
    {

        public int wordlength;
        private char[] _word;
        private Player _player;
        private ArrayList _ttlWords;

        //private Arraylist<char> alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        private ArrayList alphabet = new ArrayList("abcdefghijklmnopqrstuvwxyz".ToCharArray());

        public Computer(Player player)
        {
            _player = player;
            GetGameInformation();
            ReadInTextFile();
        }

        public void GetGameInformation()
        {
            wordlength = _player.WordLength();
            _word = new char[wordlength];
        }

        public char ChooseLetter()
        {
            int letterAmount = CalculateBasic();
            return (char)alphabet[letterAmount];
        }

        public int CalculateBasic()
        {
            Random rnd = new Random();
            return rnd.Next(0, alphabet.Count);
        }

        private int CalculateFromArray()
        {
            // { "s" , "\0", "\0", "s", "\0"}
            // next time on the gravy channel
            // find most common letter and then guess that number rather than randomly

            return 0;
        }
        
        public void IsLetterCorrect()
        {
            string iscorrectletter;
            char chr = ChooseLetter();
            Console.Write("is the letter " + chr + " in your word? type yes or no ");
            alphabet.Remove(chr);
            bool exit = false;
            while (!exit)
            {
                iscorrectletter = Console.ReadLine();
                if (iscorrectletter == "yes")
                {
                    Console.Write("type the position(s) position in the word the letter is with commas between each position number ");
                    string str = Console.ReadLine();

                    string[] arr = str.Split(',');
                    foreach (string strr in arr)
                    {
                        _word[(Convert.ToInt32(strr)-1)] = chr;
                    }
                    exit = true;
                }
                else if (iscorrectletter == "no")
                {
                    exit = true;
                }
                else
                    Console.WriteLine("Please enter Yes or No");
            }

        }

        public char[] Word
        {
            get { return _word; }
        }

        public void ReadInTextFile()
        {
            _ttlWords = new ArrayList(File.ReadAllLines("C:/Users/Lleyton/Desktop/Coding/C#/Hangman/words.txt").Where(x => x.Length.Equals(wordlength)).ToList());
            //foreach (string str in _ttlWords)
            //{
            //    Console.WriteLine(str);
            //}
        }
    }
}
