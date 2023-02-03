using Poker.Enums;
using Poker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ObjectiveC;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Entities
{
    public class Deck
    {
        public List<Card> deck = new List<Card>();
        public Card[] arrayDeck = {};
        public void CreateDeck()
        {
            int ranksQuantity = EnumHelper<int>.GetEnumQuantity(typeof(Ranks));
            int suitsQuantity = EnumHelper<int>.GetEnumQuantity(typeof(Suits));
            for(int i = 0; i < ranksQuantity; i++)
            {
                for (int j = 0; j < suitsQuantity; j++)
                {
                    Card card = new Card();
                    card.Rank = EnumHelper<Ranks>.GetRanksByIndex(i);
                    card.Suit = EnumHelper<Suits>.GetRanksByIndex(j);
                    deck.Add(card);
                }
            }
        }
        public List<Card> ShuffleDeck()
        {
           List<Card> newList = new List<Card>();
           List<Card> oldList = deck.ToList();
           while(oldList.Count > 0)
           {
                int rnd = new Random().Next(0, oldList.Count -1);
                newList.Add(oldList[rnd]);
                oldList.RemoveAt(rnd);
           }
            if (CheckDeck(newList)) return newList;
            else return null;
        }
        public bool CheckDeck(List<Card> newList)
        {
            HashSet<Card> hashSetDeck = newList.ToHashSet();
            if (deck.Count == hashSetDeck.Count)
            {
                deck.Clear();
                AddNewDeckListElements(newList);
                return true;
            }
            return false;
        }
        public void AddNewDeckListElements(List<Card> newList)
        {
            deck.AddRange(newList);
            //foreach (Card card in newList)
            //{
            //    deck.Add(card);
            //}
        }
    }
}
