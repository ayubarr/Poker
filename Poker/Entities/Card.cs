using Poker.Controllers;
using Poker.Enums;
using Poker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Models
{
    public class Card 
    {
        public Ranks Rank { get; set; }
        public Suits Suit { get; set; }
      
        public static Dictionary<Ranks, string> RanksDic = new Dictionary<Ranks, string>
        {
            {Enums.Ranks.Two, "2" },
            {Enums.Ranks.Three, "3" },
            {Enums.Ranks.Four, "4" },
            {Enums.Ranks.Five, "5" },
            {Enums.Ranks.Six, "6" },
            {Enums.Ranks.Seven, "7" },
            {Enums.Ranks.Eight, "8" },
            {Enums.Ranks.Nine, "9" },
            {Enums.Ranks.Ten, "10" },
            {Enums.Ranks.Jack, "J" },
            {Enums.Ranks.Queen, "Q" },
            {Enums.Ranks.King, "K" },
            {Enums.Ranks.Ace, "A" },
        };
        public static Dictionary<Suits, string> SuitsDic = new Dictionary<Suits, string>
        {
            {Enums.Suits.Spades, "\u2660" },
            {Enums.Suits.Clubs, "\u2663" },
            {Enums.Suits.Hearts, "\u2665" },
            {Enums.Suits.Diamonds, "\u2666" },
        };
        

        public void ViewCard(Card card)
        {
            string rank = CardController.RankCheck(card);
            string suit = CardController.SuitCheck(card);
            Console.Write($"[{rank}{suit}] ");
        }

    }
}
