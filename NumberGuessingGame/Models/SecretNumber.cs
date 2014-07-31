using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NumberGuessingGame.Models
{
    public class SecretNumber
    {
        private int? _number;
        const int MaxNumberOfGuesses = 7;

        public bool CanMakeGuess { get; }
        public int Count { get; }
        public IList<GuessedNumber> GuessedNumber { get; }
        public GuessedNumber LastGuessedNumber { get; }
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
    }

    enum Outcome { Indefinite, Low, High, Right, NoMoreGuesses, OldGuess }
}