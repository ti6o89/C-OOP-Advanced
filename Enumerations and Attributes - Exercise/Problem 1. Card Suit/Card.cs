using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Card : IComparable<Card>
{
    public Card(string rank, string suit)
    {
        this.Rank = (Rank)Enum.Parse(typeof(Rank), rank);
        this.Suit = (Suit)Enum.Parse(typeof(Suit), suit);
    }

    public Rank Rank { get; set; }

    public Suit Suit { get; set; }

    public int Power
    {
        get { return (int)this.Rank + (int)this.Suit; }
    }

    public int CompareTo(Card other)
    {
        return this.Power - other.Power;
    }

    public override string ToString()
    {
        return $"Card name: {this.Rank} of {this.Suit}; Card power: {(int)this.Rank + (int)this.Suit}";
    }

    public override bool Equals(object obj)
    {
        if (obj == null)
        {
            return false;
        }
        Card card = obj as Card;


        return this.Power.Equals(card.Power);
    }
}

