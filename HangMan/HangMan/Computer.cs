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
        public void GuessLetter(ref int guessesLeft)
        {
            char letter = ChooseLetter();
            if (LetterIsCorrect(letter))
                AddLetterToWord(letter);
            else
                guessesLeft--;
        }

        public char ChooseLetter()
        {
            int letterAmount = CalculateBasic();
            char letter = (char)alphabet[letterAmount];
            alphabet.Remove(letter);
            return letter;
        }

        public int CalculateBasic()
        {
            Random rnd = new Random();
            return rnd.Next(0, alphabet.Count);
        }

        //checks if a letter is correct
        public bool LetterIsCorrect(char letter)
        {
            return _player.BoolConfirmation("is the letter " + letter + " in your word? type yes or no ");
        }

        // adds a letter to a word
        public void AddLetterToWord(char letter)
        {
            string message = "type the position(s) that the letter occurs: separate multiple values with commas: ";
            string[] positions = null;
            bool exit = false;

            while (!exit)
            {
                while (!exit)
                {
                    //gets the positions from the user
                    string stringPositions = _player.GetResponse(message);

                    //converts the string to a set of strings containing each position
                    positions = ConvertToPositionsArray(stringPositions);

                    if (positions == null)
                    {
                        _player.Message("There was an input error, please enter your value(s) again");
                        exit = false;
                    }
                    else
                        exit = true;
                }
                
                exit = _player.BoolConfirmation("put " + letter + " in position(s) " + GetPositionString(positions) + ": ");
                if (exit == false)
                    message = "Where would you like " + letter + " then?: ";
            }
            foreach (string number in positions)
            {
                _word[(Convert.ToInt32(number) - 1)] = letter;
            }
            
        }

        private string GetPositionString(string[] positions)
        {
            string temp = "";
            if (positions.Length == 1)
            {
                return positions[0];
            }
            else if (positions.Length == 2) 
            {
                return positions[0] + " and " + positions[1];
            }
            else
            {
                for (int i = 0; i < positions.Length; i++)
                {
                    temp = temp + positions[i];
                    if (i == positions.Length - 1)
                        return temp;
                    if (i == positions.Length - 2)
                    {
                        temp = temp + " and ";
                    }
                    else
                        temp = temp + ", ";
                }
                return null;
            }
        }

        private string[] ConvertToPositionsArray(string userIndicatedPositions)
        {
            string[] positions = userIndicatedPositions.Split(',');
            
            //checks that the converted array is valid including the inputs
            if (!CheckPositions(positions))
                return null;
            
            return positions;
        }

        public bool CheckPositions(string[] positions)
        {
            // checks there is an appropriate amount of letter positions chosen
            if (positions.Length > wordlength)
                return false;
            
            //checks that each input is a number
            foreach (string number in positions)
            {
                if (!isNumber(number))
                    return false;
            }
            
            int[] numbers = new int[positions.Length];
            for (int i = 0; i < positions.Length; i++)
            {
                //adds number to numbers in index i
                numbers[i] = Convert.ToInt32(positions[i]);

                //checks that the number is shorter than the word length
                if (numbers[i] > wordlength)
                    return false;
                   
                // checks that there is not already a letter in the position
                for (int j = 0; j < Word.Length; j++)
                {
                    if (Word[j] != '\0' && j == numbers[i] - 1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public bool isNumber(string number)
        {
            var isNumeric = int.TryParse(number, out int n);
            if (isNumeric)
                return true;
            return false;
        }

        public char[] Word
        {
            get { return _word; }
        }

    }
}
