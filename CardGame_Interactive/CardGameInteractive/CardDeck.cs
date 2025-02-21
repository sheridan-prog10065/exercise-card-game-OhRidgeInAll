namespace CardGameInteractive;

/// <summary>
/// Defines the Deck containing the cards in CardGame
/// </summary>
public class CardDeck
{
    /// <summary>
    /// The list of cards comprising the deck
    /// </summary>
    private List<Card> _cardList;

    public CardDeck()
    {
        _cardList = new List<Card>();
    }

    public int CardCount
    {
        get
        {
            return _cardList.Count;
        }
    }
}