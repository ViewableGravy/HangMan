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
        //private ArrayList _ttlWords;
        
        private ArrayList alphabet = new ArrayList("abcdefghijklmnopqrstuvwxyz".ToCharArray());

        public Computer(Player player)
        {
            _player = player;
            GetGameInformation();
        }

        public void GetGameInformation()
        {
            wordlength = _player.WordLength();
            _word = new char[wordlength];
        }
        
        private int CalculateFromArray()
        {
            // { "s" , "\0", "\0", "s", "\0"}
            // next time on the gravy channel
            // find most common letter and then guess that number rather than randomly

            return 0;
        }

        // checks if a letter is correct and if it is adds it to the word
        public void GuessLetter()
        {
            char letter = ChooseLetter();

            if (IsLetterCorrect(letter))
                AddLetterToWord(letter);
        }

        //checks if a letter is correct
        public bool IsLetterCorrect(char letter)
        {
            alphabet.Remove(letter);
            string userResponse = _player.GetResponse("is the letter " + letter + " in your word? type yes or no ");
            bool exit = false;
            while (!exit)
            {
                if (userResponse == "yes")
                    return true;
                else if (userResponse == "no")
                    return false;
                else
                    userResponse = _player.GetResponse("Please enter Yes or No");
            }
            return false;
        }

        // adds a letter to a word
        public void AddLetterToWord(char letter)
        {
            string str = _player.GetResponse("type the position(s) that the letter occurs: separate multiple values with commas. e.g. 1,2,4: ");
            string[] positions = str.Split(',');
            foreach (string number in positions)
            {
                _word[(Convert.ToInt32(number) - 1)] = letter;
            }
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

        public char[] Word
        {
            get { return _word; }
        }

    }
}
