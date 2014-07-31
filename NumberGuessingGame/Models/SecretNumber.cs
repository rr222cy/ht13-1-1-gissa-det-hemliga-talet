using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumberGuessingGame.Models
{
    public enum Outcome { Indefinite, Low, High, Right, NoMoreGuesses, OldGuess }

    public class SecretNumber
    {
        const int MaxNumberOfGuesses = 7;

        private int? _number;
        
        public bool CanMakeGuess
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public IList<GuessedNumber> GuessedNumber 
        {
            get
            {
                throw new NotImplementedException();
            } 
        }

        public GuessedNumber LastGuessedNumber 
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int? Number { get; set; }
        
        public void Initialize()
        {
            // Randomizing a number between 1 and 100.
            Random randomNumber = new Random();
            _number = randomNumber.Next(1, 101);
        }

        public int MakeGuess(int guess)
        {
            return 0;
        }

        
        public SecretNumber()
        {
            Initialize();
        }
    }

    public struct GuessedNumber
    {
        public int? Number;
        private Outcome Outcome;
    }   
}