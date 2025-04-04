namespace CardGameInteractive;

public partial class MainPage : ContentPage
{

    private CardGame _cardGame;
    public MainPage()
    {
        InitializeComponent();
        
        _cardGame = new CardGame();
    }
 }