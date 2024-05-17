using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class Model
    {
        private int _targetNumber;

        private int _attempts;

        
        public void GenerateRandNumber()
        {
            // Generate a random number
            Random random = new Random();

            // Generate a number between 1 and 100
            _targetNumber = random.Next(1, 101);

            //_view.DisplayText("Number generated: " + _targetNumber);
            Console.WriteLine("Number generated: " + _targetNumber);
        }

        public int IncrementAttempts()
        {
            _attempts++;

            return _attempts;
        }

        public bool GuessAttempt(int guess)
        {
          
            return guess == _targetNumber;
        }

        public bool HintGuess(int guess)
        {
            if (guess < _targetNumber)
            {
                return true;
            }
            else
            {
                
                return false;
            }

        }
    }
}