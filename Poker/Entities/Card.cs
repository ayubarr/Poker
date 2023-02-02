using Poker.Enums;
using Poker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Models
{
    public class Card : ICheck
    {
        public Ranks Rank { get; set; }
        public Suits Suit { get; set; }
        string[] ranks = {"2", "3", "4", "5", "6", "7", "8", "9", "10",
        "J", "Q", "K", "A"};

        string[] suits = { "\u2660", "\u2665", "\u2666", "\u2663" }; //♠ ♥ ♦ ♣

        public void ViewCard(Card card)
        {
            string rank = RankCheck(card);
            string suit = SuitCheck(card);
          
            Console.Write($"[{rank}{suit}] ");
         
        }
        public string RankCheck(Card card)
        {
            string rank = "";
            if (card.Rank == Ranks.Two) rank = "2";
            else if(card.Rank == Ranks.Three) rank = "3";
            else if(card.Rank == Ranks.Four) rank = "4";
            else if(card.Rank == Ranks.Five) rank = "5";
            else if(card.Rank == Ranks.Six) rank = "6";
            else if (card.Rank == Ranks.Seven) rank = "7";
            else if (card.Rank == Ranks.Eight) rank = "8";
            else if (card.Rank == Ranks.Nine) rank = "9";
            else if (card.Rank == Ranks.Ten) rank = "10";
            else if (card.Rank == Ranks.Jack) rank = "J";
            else if (card.Rank == Ranks.Queen) rank = "Q";
            else if (card.Rank == Ranks.King) rank = "K";
            else if (card.Rank == Ranks.Ace) rank = "A";
            return rank;
        }
        public string SuitCheck(Card card)
        {
            string suit = "";
            if (card.Suit == Suits.Spades) suit = "\u2660";
            else if (card.Suit == Suits.Clubs) suit = "\u2663";
            else if (card.Suit == Suits.Hearts) suit = "\u2665";
            else if (card.Suit == Suits.Diamonds) suit = "\u2666";

            return suit;
        }

    }
}
