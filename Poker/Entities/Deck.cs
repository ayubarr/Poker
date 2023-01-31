﻿using Poker.Enums;
using Poker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Entities
{
    public class Deck
    {
        public HashSet<Card> deck { get; set; }

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
                    card.Suit = EnumHelper<Suits>.GetRanksByIndex(i);
                    deck.Add(card);
                }
            }
        }

  
        public void DrawCard(Card card)
        {

        }


    }
}
