using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public interface IView
    {

        void WelcomeMessage();

        void DisplayText(string text);

        void DisplayTextLine(string text);

        void EndMessage();

        int ReadGuess();

        
    }


}