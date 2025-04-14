using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            int played = 0;
            string opt = "";
            do
            {
                Console.Clear();
                Console.WriteLine("Enter 1 to play game or enter 2 to exit: ");
                opt = Console.ReadLine();
                Console.WriteLine();
                Console.Clear();

                Deck deck = new Deck();
                deck.shuffle();
                BlackJackHand player = new BlackJackHand();
                BlackJackHand dealer = new BlackJackHand();

                if (opt == "1")
                {
                    bool gameRunning = true;
                    Console.WriteLine($"Games Played: {played}");
                    Console.WriteLine($"Games Won: {score}");
                    Deck cards = new Deck();
                    cards.shuffle();

                    player.addCard(cards.dealCard());
                    player.addCard(cards.dealCard());
                    dealer.addCard(cards.dealCard());
                    dealer.addCard(cards.dealCard());

                    while (gameRunning)
                    {
                        player.showHand("Player");
                        dealer.showHand("Dealer");

                        Console.Write("Hit or Stand? (h/s): ");
                        string choice = Console.ReadLine().ToLower();

                        if (choice == "h")
                        {
                            player.addCard(cards.dealCard());

                            if (player.getBlackJackValue() > 21)
                            {
                                Console.WriteLine("Player Busts! Dealer Wins.");
                                break;
                            }
                        }
                        else if (choice == "s")
                        {
                            break;
                        }
                    }

                    dealer.showHand("Dealer");
                    while (dealer.shouldDraw())
                    {
                        dealer.addCard(cards.dealCard());
                        dealer.showHand("Dealer");
                    }

                    int playerScore = player.getBlackJackValue();
                    int dealerScore = dealer.getBlackJackValue();

                    Console.WriteLine($"Player Score: {playerScore}");
                    Console.WriteLine($"Dealer Score: {dealerScore}");

                    if (dealerScore > 21 || playerScore > dealerScore)
                    {
                        Console.WriteLine("Player Wins!");
                        score++;
                    }
                    else if (playerScore < dealerScore)
                    {
                        Console.WriteLine("Dealer Wins!");
                    }
                    else
                    {
                        Console.WriteLine("It's a Tie!");
                    }
                    Console.ReadKey();
                    played++;
                }
            } while (opt != "2");
        }
    }
}
