using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace ZadanieEgzaminacyjne;

public partial class GameWindow : Window
{
    private List<Image> images;
    private int Attempts = 5;

    public GameWindow()
    {
        InitializeComponent();

        NickName.Content = Game.NickName;
        images = new List<Image>()
        {
            Image1,
            Image2,
            Image3,
            Image4,
            Image5,
        };

        AttemptsRemaining.Content = $"Pozostało prób: {Attempts}";
    }

    private void ResetButtonClick(object sender, RoutedEventArgs e)
    {
        Dices.DicesList.Clear();
        foreach (var image in images)
        {
            image.Source = new BitmapImage(new Uri("kosci/question.png", UriKind.Relative));
        }

        Attempts = 5;
        AttemptsRemaining.Content = $"Pozostało prób: {Attempts}";
    }

    private void RollButtonClick(object sender, RoutedEventArgs e)
    {
        Dices.DicesList.Clear();
        Random random = new Random();
        foreach (var image in images)
        {
            Dice dice = new Dice(random.Next(1, 6));
            Dices.DicesList.Add(dice);
            image.Source = new BitmapImage(new Uri($"kosci/{dice.Value}.png", UriKind.Relative));
        }

        Attempts--;
        AttemptsRemaining.Content = $"Pozostało prób: {Attempts}";

        if (Attempts == 0)
        {
            EndGameButtonClick(sender, e);
        }
    }

    private void EndGameButtonClick(object sender, RoutedEventArgs e)
    {
        ResultWindow resultWindow = new ResultWindow();
        resultWindow.Show();
        Close();
    }
}