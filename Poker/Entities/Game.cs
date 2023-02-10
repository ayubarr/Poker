using Poker.Interfaces;
using Poker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Entities
{
    public class Game : IPokerPlayble
    {
        public List<Card> pokerList = new List<Card>();

        public void AddCards(Deck deck, int cardValue)
        {
            for (int i = 0; i < cardValue; i++)
            {
                pokerList.Add(deck.deckList[deck.deckList.Count - 1]);
                deck.deckList.RemoveAt(deck.deckList.Count - 1);
            }
        }
        public void DeleteCards(Deck deck)
        {
            foreach (Card card in pokerList)
                deck.deckList.Add(card);

            pokerList.Clear();
        }
        public void ReplaceCard(Deck deck, int cardIndex)
        {
            deck.deckList.Add(pokerList[cardIndex]);
            pokerList.RemoveAt(cardIndex);
            AddCards(deck, 1);
        }
        public void ViewCards()
        {
            foreach (Card card in pokerList)
                card.ViewCard(card);
        }
    }
}
