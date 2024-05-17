using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class View : IView
    {
        private readonly Controller _controller;

        private readonly Model _model;

        public View(Controller controller, Model model)
        {
            _controller     = controller;
            _model          = model;
        }

        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to Guess the Number!");
            Console.WriteLine("I have chosen a number between 1 and 100.");
        }

        public void DisplayText(string text)
        {
            Console.Write(text);
        }

        public void DisplayTextLine(string text)
        {
            Console.WriteLine(text);
        }


        public int ReadGuess()
        {
            return Convert.ToInt32(Console.ReadLine());
        }

        public void EndMessage()
        {
            Console.WriteLine("Thank you for playing Guess the Number!");
        }
    }
}