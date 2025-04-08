using System.Diagnostics;

namespace CardGameApp;

/// <summary>
/// Defines the Card used in the card game
/// </summary>
public class Card
{
    /// <summary>
    /// The suit of the given card
    /// </summary>
    private CardSuit _suit;
    
    /// <summary>
    /// The value of the card
    /// </summary>
    private byte _value;

    public Card(byte value, CardSuit suit)
    {
        _value = value;
        _suit = suit;
    }

    public byte Value
    {
        get
        {
            return _value;
        }
    }

    public CardSuit Suit
    {
        get
        {
            return _suit;
        }
        set
        {
            _suit = value;
        }
        
    }

    public String CardName
    {
        get
        {
            switch (_value)
            {
                case 1:
                    return "Ace";
                
                case 13:
                    return "King";
                
                case 12:
                    return "Queen";
                
                case 11:
                    return "Jack";
                
                default:
                    //convert to numeric value into string
                    return _value.ToString();
            }
        }
    }

    public String SuitName
    {
        get
        {
            switch(_suit)
            {
                case CardSuit.Clubs:
                    return "Clubs";
                    
                case CardSuit.Diamonds:
                    return "Diamonds";
                
                case CardSuit.Hearts:
                    return "Hearts";
                
                case CardSuit.Spades:
                    return "Spades";
                
                default:
                    Debug.Assert(false, "Unknown suit value");
                    return _suit.ToString();
            }
        }
    }
}