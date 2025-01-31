namespace CardGameInteractive;

/// <summary>
/// I know a thing or two about cardgames myself.
/// https://media.discordapp.net/attachments/1083988122062307431/1173019918577434624/IMG_20231111_170121.jpg?ex=679df12e&is=679c9fae&hm=2f8e38ff0a47cf0c59fc33bf81d6aed5395d664eedbcf422ab683dea12d8b8f1&=&format=webp&width=1440&height=647
/// Main Class for Card Game
/// </summary>
public class CardGame
{
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
}