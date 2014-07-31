using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumberGuessingGame.Models
{
    public enum Outcome { Indefinite, Low, High, Right, NoMoreGuesses, OldGuess }

    public class SecretNumber
    {
        private int? _number;
        const int MaxNumberOfGuesses = 7;

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

        }

        public int MakeGuess(int guess)
        {
            return 0;
        }

        
        public SecretNumber()
        {
            // EMPTY!
        }
    }

    public struct GuessedNumber
    {
        public int? Number;
        private Outcome Outcome;
    }

    
}