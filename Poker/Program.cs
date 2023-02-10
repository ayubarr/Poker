using Poker.Controllers;
using Poker.Entities;
using Poker.Models;


Deck deck = new Deck();
deck.CreateDeck();
deck.ShuffleDeck();
Hand hand = new Hand();
Game game = new Game();

foreach (Card card in deck.deckList)
{
    card.ViewCard(card);
}
bool session = true;


ButtonController.ViewMainMenu(hand, deck, game);
