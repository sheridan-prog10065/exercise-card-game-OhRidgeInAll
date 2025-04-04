namespace CardGameInteractive;

public partial class MainPage : ContentPage
{

    private CardGame _cardGame;
    public MainPage()
    {
        InitializeComponent();
        
        _cardGame = new CardGame();
    }

    private void OnDealCards(object sender, EventArgs e)
    {
        throw new NotImplementedException();
        _cardGame.DealCards();
    }

    private void OnSwitchCards(object sender, EventArgs e)
    {
        throw new NotImplementedException();
        _cardGame.SwitchCards();
    }

    private void OnPlayCards(object sender, EventArgs e)
    {
        throw new NotImplementedException();
        _cardGame.PlayRound();
    }
}