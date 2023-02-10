using Poker.Entities;
using Poker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker.Interfaces
{
    public interface IPokerPlayble
    {
        public void AddCards(Deck deck, int cardValue);              //C
        public void ViewCards();                                  //R
        public void ReplaceCard(Deck deck, int cardIndex);      //U
        public void DeleteCards(Deck deck);                               //D
    }
}
