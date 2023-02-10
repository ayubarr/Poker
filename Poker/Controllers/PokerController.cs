using Poker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Controllers
{
    public static class PokerController
    {
        public static string CheckHand(List<Card> hand)
        {
            if (IsRoyalFlush(hand)) return "Royal Flush";
            if (IsStraightFlush(hand)) return "Straight Flush";
            if (IsFourOfAKind(hand)) return "Four of a Kind";
            if (IsFullHouse(hand)) return "Full House";
            if (IsFlush(hand)) return "Flush";
            if (IsStraight(hand)) return "Straight";
            if (IsThreeOfAKind(hand)) return "Three of a Kind";
            if (IsTwoPairs(hand)) return "Two Pairs";
            if (IsOnePair(hand)) return "One Pair";
            return "High Card";
        }
        private static bool IsRoyalFlush(List<Card> hand)
        {
            return IsStraightFlush(hand) && hand.Exists(c => c.Rank == Enums.Ranks.Ace);   //Exist проверят на наличее. С  это одна из карт в коллекции, и если её ранг Ace то вернется true
        }

        private static bool IsStraightFlush(List<Card> hand)
        {
            return IsFlush(hand) && IsStraight(hand);
        }

        private static bool IsFourOfAKind(List<Card> hand)
        {
            return hand.Exists(c => hand.FindAll(d => d.Rank == c.Rank).Count == 4);   //FindAll - находит все случаи где карта d = карте c по рангу
        }

        private static bool IsFullHouse(List<Card> hand)
        {
            var groups = hand.GroupBy(c => c.Rank);
            return groups.Count() == 2 && groups.Any(g => g.Count() == 3); // Any это проверка на наличие в колекции такого элемента у которого Count == 3
        }

        private static bool IsFlush(List<Card> hand)
        {
            return hand.GroupBy(c => c.Suit).Count() == 1;   //GroupBy сгрупперовать по условию( в данном случае по мастям)
        }
        private static bool IsStraight(List<Card> hand)
        {
            hand = hand.OrderBy(c => c.Rank).ToList();    //OrderBy отсортировать С по рангу масим
            for (int i = 1; i < hand.Count; i++)
            {
                if (hand[i].Rank - hand[i - 1].Rank != 1) return false;
            }
            return true;
        }
        private static bool IsThreeOfAKind(List<Card> hand)
        {
            return hand.Exists(c => hand.FindAll(d => d.Rank == c.Rank).Count == 3);
        }

        private static bool IsTwoPairs(List<Card> hand)
        {
            var groups = hand.GroupBy(c => c.Rank);
            return groups.Count() == 3 && groups.Any(g => g.Count() == 2);
        }

        private static bool IsOnePair(List<Card> hand)
        {
            return hand.Exists(c => hand.FindAll(d => d.Rank == c.Rank).Count == 2);
        }
    }
}
