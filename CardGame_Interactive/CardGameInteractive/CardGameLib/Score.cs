namespace CardGameLib;

/// <summary>
/// Define the score of the game
/// </summary>
public struct Score
{
    /// <summary>
    /// Players current score
    /// </summary>
    private int _playerScore;
    
    /// <summary>
    /// Dealers current score
    /// </summary>
    private int _houseScore;

    public int PlayerScore
    {
        get
        {
            return _playerScore;
        }
    }

    public int HouseScore
    {
        get
        {
            return _houseScore;
        }
    }
}