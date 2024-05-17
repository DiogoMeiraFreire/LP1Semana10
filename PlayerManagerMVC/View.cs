using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerManagerMVC
{
    public class View : IView
    {

        private readonly Controller controller;

        private readonly List<Player> players;

        public View(Controller con, List<Player> playerList)
        {
            controller = con;
            players = playerList;
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

        }

        public void EndMassage()
        {

        }

        public Player InsertPlayer()
        {
            int score;

             // Request player name
            Console.Write("Inserir Nome: ");

            string name = Console.ReadLine(); //               => store name

            Console.WriteLine();                        // Enter

            // Request player score
            Console.Write("Inserir Score: ");
            score = int.Parse(Console.ReadLine()); //   => store & convert score

            Console.WriteLine();                       // Enter


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