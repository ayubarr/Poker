using Poker.Interfaces;
using Poker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Controllers
{
    public static class CardController 
    {
        public static string RankCheck(Card card)
        {
            string rank = "";
            foreach (var r in Card.RanksDic)
            {
                if (card.Rank == r.Key) rank = r.Value;
            }
            return rank;
        }

        public static string SuitCheck(Card card)
        {
            string suit = "";
            foreach (var r in Card.SuitsDic)
            {
                if (card.Suit == r.Key) suit = r.Value;
            }
            return suit;
        }     
    }
}
