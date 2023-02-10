using Poker.Interfaces;
using Poker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Entities
{
    public class Hand : IPokerPlayble
    {
        public List<Card> handList = new List<Card>();
        public void AddCards(Deck deck, int cardsValue)
        {

            for (int i = 0; i < cardsValue; i++)
            {
              //int rnd = new Random().Next(0, deck.deckList.Count());
                handList.Add(deck.deckList[deck.deckList.Count -1]); 
                deck.deckList.RemoveAt(deck.deckList.Count -1);
            }
        }
        public void DeleteCards(Deck deck)
        {
            foreach (Card card in handList)
                deck.deckList.Add(card);
            
              handList.Clear();
        }

        public void ReplaceCard(Deck deck, int cardIndex)
        {

            deck.deckList.Add(handList[cardIndex]);
            handList.RemoveAt(cardIndex);
            AddCards(deck, 1);
        }

        public void ViewCards()
        {
            foreach (Card card in handList)           
                card.ViewCard(card);
        }
    }
}
