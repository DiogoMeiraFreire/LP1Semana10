using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManagerMVC
{
    public class View : IView
    {
        
        private readonly Controller _controller;

        private readonly List<Player> _playerList;

        public View(Controller controller, List<Player> playerList)
        {
            _controller = controller;
            _playerList = playerList;
        }


        public int MainMenu()
        {
            Console.WriteLine(
                "Welcome\n1: Inserir jogador\n" 
                +"2: Listar jogadores\n3: Players with highest score\n4: Sair");

            return int.Parse(Console.ReadLine());

        }
        public void AfterMenu()
        {   
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }

        public void EndMassage()
        {

        }

        public Player InsertPlayer()
        {
            int score;

             // Request player name
            Console.Write("Inserir Nome: ");

            //store name
            string name = Console.ReadLine(); 

            Console.WriteLine();

            // Request player score
            Console.Write("Inserir Score: ");
            score = int.Parse(Console.ReadLine()); //store & convert score

            Console.WriteLine();


            try{ 
                // attempt to add player
                
                Console.WriteLine($"Added {name} with score {score}"); // extra

                return new Player(name, score);

            }   

            catch (Exception e) { // catch exception
                Console.WriteLine(
                    $"ERRO: Não foi possível adicionar jogador: {e.Message}");

                 return null;
            }
        }

        public void InvalidOption()
        {
            Console.WriteLine("Opção inválida");
        }


        public void ListPlayers(List<Player> playersToList)
        {
            foreach (Player player in playersToList)
            {
                Console.WriteLine(player);
            }
        }


        public int AskForMinimumScore()
        {
            Console.WriteLine("Insira o score mínimo: ");
            return int.Parse(Console.ReadLine());
        }


        public void ListPlayersWithScoreGreaterThan(List<Player> playersToList, int score)
        {
            foreach (Player player in playersToList)
            {
                if(player.Score > score)
                {
                    Console.WriteLine(player);
                }
                
            }
        }
    }
}