using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace PlayerManagerMVC
{
    public class Controller
    {
        /// The list of all players (MODELS)
        private readonly List<Player> playerList;


        // --------------------------- CONSTRUCTOR -----------------------------
        
        /// <summary>
        /// Receives our model and view (UI)
        /// </summary>
        /// <param name="players">
        /// Model to be received, it's a list of players
        /// </param>
        /// <param name="view">
        /// Interface of the view, it's the UI
        /// </param>
        public Controller(List<Player> players)
        {

            // Initialize the constructor with a player List
            playerList  = players;

            // Initialize the constructor with a View ref (UI)
            //this.view   = view;

        }


        public void Start(IView view)
        {
            int option = 0;


             // Main program loop
            do
            {
                // Show menu and get user option
                option = view.MainMenu();

                // Determine the option specified by the user and act on it
                switch (option)
                {
                    case 1:
                        {
                            // Insert Player
                            view.InsertPlayer();
                            break;
                        }
                    case 2:
                        {
                            // List all Players
                            view.ListPlayers(playerList);
                            break;
                        }
                    case 3:
                        {
                            int score = 0; 
                            // Request minimum score
                            score = view.AskForMinimumScore();

                            // List all Players with score greater than a user input
                            view.ListPlayersWithScoreGreaterThan(playerList, score);

                            break;

                        }
                    case 4:
                        {   
                            // Final message
                            view.EndMassage();
                            break;
                        }
                        
                    default: { view.InvalidOption(); break; }
                }


                // Wait for user to press a key...
                view.AfterMenu();

                // Loop keeps going until players choses to quit (option 4)
            } while (option != 4);
        }
    }
}