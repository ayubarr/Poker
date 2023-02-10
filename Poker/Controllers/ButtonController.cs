using Poker.Entities;
using Poker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Controllers
{
    public static class ButtonController
    {
        public static void GameButtons(Hand hand, Deck deck, Game game)
        {
            Console.Write("Game Cards");
            if(game.pokerList.Count == 5)
            {
                foreach (Card card in hand.handList)
                {
                    game.pokerList.Add(card);
                }
               string end = PokerController.CheckHand(game.pokerList);
                Console.WriteLine();
               Console.WriteLine(end);
                return;
            }

            Console.SetCursorPosition(0, 8);
            Console.WriteLine("Enter {1} - to check next card");
            Console.SetCursorPosition(0, 9);
            Console.WriteLine("Enter {Backspace} key - to end game and BACK\n" +
                      "Enter {Esc} key - to Exit and End Program");
            string[] keys = new string[]
            {
                "1",
                "Backspace",
                "Escape",
            };
            string choice = Button(keys);

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    Console.Clear();
                    hand.ViewCards();
                    Console.WriteLine("Your Cards\n");
                    Console.SetCursorPosition(0, 3);
                    game.AddCards(deck, 1);
                    game.ViewCards();
                    GameButtons(hand, deck, game);

                    break;
                case "Backspace":
                    Console.Clear();
                    game.DeleteCards(deck);
                    hand.ViewCards();
                    PlayMenuButtons(hand, deck, game);

                    break;
                case "Escape":
                    Environment.Exit(0);
                    break;
            }
        }



        public static void ViewMainMenu(Hand hand, Deck deck, Game game)
        {
            Console.SetCursorPosition(0, 2);
            Console.WriteLine("\nTEXAS HOLDEN");
            MainMenuButtons(hand, deck, game);
        }

        public static void PlayMenuButtons(Hand hand, Deck deck, Game game)
        {
            Console.SetCursorPosition(0, 6);
            Console.WriteLine("Enter {1} - to start game");
            Console.SetCursorPosition(0, 7);
            Console.WriteLine("Enter {Backspace} key - to end game and BACK\n" +
                      "Enter {Esc} key - to Exit and End Program");
            string[] keys = new string[]
            {
                "1",
                "Backspace",
                "Escape",
            };
            string choice = Button(keys);

            switch (choice)
            {
                case "1":
                    Console.Clear();
                    hand.ViewCards();
                    Console.WriteLine("Your Cards\n");
                    Console.SetCursorPosition(0,3);
                    game.AddCards(deck, 3);
                    game.ViewCards();
                    GameButtons(hand, deck, game);
                    break;

                case "Backspace":
                    Console.Clear();
                    hand.DeleteCards(deck);
                    deck.ShuffleDeck();
                    ViewDeck(deck);
                    ViewMainMenu(hand, deck, game);
                    break;
                case "Escape":
                    Environment.Exit(0);
                    break;
            }
        }
        public static void MainMenuButtons(Hand hand, Deck deck, Game game)
        {
            
            Console.WriteLine("Enter {1} start play Poker\n\n" +
                    "Enter {Esc} to Exit and End Program");
            string[] keys = new string[]
            {
                    "1",
                    "Escape"
            };
            string choiceButtom = Button(keys);
            switch (choiceButtom)
            {
                case "1":
                    Console.Clear();                   
                    hand.AddCards(deck, 2);
                    hand.ViewCards();
                    Console.Write("Your Cards\n");
                    PlayMenuButtons(hand, deck, game);
                    break;
                case "Escape":
                    Environment.Exit(0);
                    break;
            }
        }

        public static string Button(string[] keys)
        {
            string input = "";
            do
            {
                var inputKey = Console.ReadKey(true);
                int keyAscii = (int)inputKey.Key;
                if (keyAscii <= 57 && keyAscii >= 49 || keyAscii >= 97 && keyAscii <= 105)
                {
                    input = inputKey.Key.ToString();
                    input = input[input.Length - 1].ToString();
                    if (keys.Contains(input))
                        return input;
                    Button(keys);
                }
                input = inputKey.Key.ToString();
            }
            while (!keys.Contains(input));
            return input;
        }
        public static void ViewDeck(Deck deck)
        {
            foreach (Card card in deck.deckList)
            {
                card.ViewCard(card);
            }
        }
    }
}
