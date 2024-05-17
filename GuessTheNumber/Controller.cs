namespace GuessTheNumber
{
    public class Controller
    {

        private Model _model;


        public Controller(Model model)
        {
           _model = model;
        }


        public void Start(IView view)
        {
            int guess, attempts;

            view.WelcomeMessage();
            _model.GenerateRandNumber();


            do
            {
                view.DisplayText("Take a guess: ");

                // read guess
                guess   = view.ReadGuess();
                
                // increment attempts
                attempts = _model.IncrementAttempts();

                // Check if correct guess
                if (_model.GuessAttemp(guess))
                {
                    view.DisplayTextLine(
                        "Congratulations! You guessed the number correctly!");

                    view.DisplayTextLine("Number of attempts: " + attempts);

                    break;
                }

                // Check if hint is higher or lower
                if (_model.HintGuess(guess))
                {
                    view.DisplayTextLine(
                        "The number is higher than your guess.");
                }

                else
                {
                    view.DisplayTextLine(
                        "The number is lower than your guess.");
                }

                // end of loop
            } while (!_model.GuessAttempt(guess));


            // End message
            view.EndMessage();

        }        
    }
}