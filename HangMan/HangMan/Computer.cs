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
        public int wrongGuessesMade;
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
            wrongGuessesMade = 0;
        }
        
        private int CalculateFromArray()
        {
            /*
            Guessing first letter
                1 get every word that is the a correct length
                2 find the most occuring letter
                    a. find if a letter occurs in a word
                        1. only count it once per word (do not count again if it occurs more than once in a word)
                    b. sort by count of the number of words that each letter occurs in
                        1. since each letter is only incremented by one if occurring in a word this is just
                           from most occurring to least occurring
                3. if letter guessed is wrong
                    a. eliminate the letter as a guessable option
                    b. eliminate words that contain the letter
                    c. repeat step 2 with the new parameters

            this method was derived from the following article
            http://datagenetics.com/blog/april12012/index.html
            

            guessing second letter
            */
            return 0;
        }

        // checks if a letter is correct and if it is adds it to the word
        public void GuessLetter()
        {
            char letter = ChooseLetter();
            if (LetterIsCorrect(letter))
                AddLetterToWord(letter);
            else
                wrongGuessesMade++;
        }

        private char ChooseLetter()
        {
            int letterAmount = CalculateBasic();
            char letter = (char)alphabet[letterAmount];
            alphabet.Remove(letter);
            return letter;
        }

        //guesses a letter randomly
        private int CalculateBasic()
        {
            Random rnd = new Random();
            return rnd.Next(0, alphabet.Count);
        }

        //checks if a letter is correct
        private bool LetterIsCorrect(char letter)
        {
            return _player.BoolConfirmation("is the letter " + letter + " in your word? type yes or no ");
        }

        // adds a letter to a word
        private void AddLetterToWord(char letter)
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

        private bool CheckPositions(string[] positions)
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

        private bool isNumber(string number)
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
