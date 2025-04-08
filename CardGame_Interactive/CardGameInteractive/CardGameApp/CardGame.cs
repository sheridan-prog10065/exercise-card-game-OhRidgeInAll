using System.Diagnostics;
using Debug = System.Diagnostics.Debug;

namespace CardGameApp;

/// <summary>
/// I know a thing or two about cardgames myself.
/// https://media.discordapp.net/attachments/1083988122062307431/1173019918577434624/IMG_20231111_170121.jpg?ex=679df12e&is=679c9fae&hm=2f8e38ff0a47cf0c59fc33bf81d6aed5395d664eedbcf422ab683dea12d8b8f1&=&format=webp&width=1440&height=647
/// Main Class for Card Game
/// </summary>
public class CardGame
{
    #region Fields
    
    /// <summary>
    /// Represents the deck of cards the dealer deals from
    /// </summary>
    private CardDeck _cardDeck;

    /// <summary>
    /// The score of the game
    /// </summary>
    private Score _score;

    /// <summary>
    /// Card dealt to the player
    /// </summary>
    private Card _playerCard;

    /// <summary>
    /// Card dealt to the dealer
    /// </summary>
    private Card _houseCard;
    #endregion

    #region Constructors
    /// <summary>
    /// Constructor of the Card Game Class
    /// </summary>
    public CardGame()
    {
        _cardDeck = new CardDeck();
        _cardDeck.ShuffleCards();
        _score = new Score();
        _playerCard = null;
        _houseCard = null;

    }
    
    #endregion

    #region Properties
    /// <summary>
    /// Plays the game
    /// </summary>
    public void Play()
    {
        //TODO: Implement Play()
    }

    /// <summary>
    /// Plays a round of the game
    /// </summary>
    /// <returns>
    ///     +1: the user won the round
    ///     0: there was a tie
    ///     -1: the house won the round
    /// </returns>
    public sbyte PlayRound()
    {
        //Determine the card ranks for the player and house cards
        byte houseRank = DetermineCardRank(_houseCard);
        byte cardRank = DetermineCardRank(_playerCard);
        
        //check which card has the higher rank to determine the winner
        if (cardRank > houseRank)
        {
            //winner genyo
            return 1;
        }
        else if (cardRank < houseRank)
        {
            //House always wins baby
            return -1;
        }
        else
        {
            //it's a tie
            return 0;
        }
    }

    public Score score
    {
        get { return _score; }
        set { _score = value; }
    }

    public Card PlayerCard
    {
        get { return _playerCard; }
    }

    public Card HouseCard
    {
        get { return _houseCard; }
    }

    public bool IsOver
    {
        get { return _cardDeck.CardCount < 2; }
    }
    public bool playerWins
    {
        get
        {
            return this.IsOver && _score.PlayerScore > _score.HouseScore;
        }
    }

    public bool houseWins
    {
        get
        {
            return this.IsOver && _score.PlayerScore < _score.HouseScore;
        }
    }
    #endregion
    
    #region Methods

    /// <summary>
    /// Give a card to both the dealer and the player
    /// </summary>
    public void DealCards()
    {
        bool cardsDealt = _cardDeck.GetPairOfCards(out _playerCard, out _houseCard);
        Debug.Assert(cardsDealt, "Cards could not be dealt. Check the game is not over");
    }

    /// <summary>
    /// Swap cards with the dealer
    /// </summary>
    public void SwitchCards()
    {
        
    }

    /// <summary>
    /// Evaluate who's card is highest
    /// </summary>
    private byte DetermineCardRank(Card card)
    {
        byte cardRank = (card.Value == 1) ? (byte)14 : card.Value;

        return cardRank;
        //Check if the rank is an ace
        if (card.Value == 1)
        {
            return 14;
        }
        else
        {
            return card.Value;
        }
    }

    private void ShowRoundResults()
    {
        //TODO: implement ShowRoundResults()
    }

    private void ShowGameOver()
    {
        //TODO: implement ShowGameOver()
    }
    
    #endregion
}