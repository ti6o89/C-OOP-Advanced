using System.Collections.Generic;
using System.Linq;

public class Player
{
    private string name;
    private IList<Card> cards;

    public Player(string name)
    {
        this.Name = name;
        this.Cards = new List<Card>();
    }

    public string Name { get; private set; }

    public IList<Card> Cards { get; private set; }

    public Card HighestPoweredCard()
    {
        var card = this.Cards.OrderByDescending(c => c.Power).FirstOrDefault();
        return card;
    }

    public void AddCard(Card card)
    {
        this.Cards.Add(card);
    }
}
