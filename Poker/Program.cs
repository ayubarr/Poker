using Poker.Entities;
using Poker.Models;

Card DiamondsKing = new Card();
DiamondsKing.Rank = Poker.Enums.Ranks.King;
DiamondsKing.Suit = Poker.Enums.Suits.Diamonds;
DiamondsKing.ViewCard(DiamondsKing);

Deck deck1 = new Deck();
deck1.CreateDeck();

foreach (Card card in deck1.deck)
{
    card.ViewCard(card);
}
Console.WriteLine("Напишите 1 чтобы перемешать");
string enter = Console.ReadLine();
if(enter == "1")
{
    deck1.ShuffleDeck();
    foreach (Card card in deck1.deck)
    {
        card.ViewCard(card);
    }
}
