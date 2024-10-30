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

        AttemptsRemaining.Content = Attempts;
    }

    private void ResetButtonClick(object sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void RollButtonClick(object sender, RoutedEventArgs e)
    {
        Random random = new Random();
        foreach (var image in images)
        {
            image.Source = new BitmapImage(new Uri($"kosci/{random.Next(1, 6)}.png", UriKind.Relative));
        }

        Attempts--;
        AttemptsRemaining.Content = Attempts;
    }

    private void EndGameButtonClick(object sender, RoutedEventArgs e)
    {
        ResultWindow resultWindow = new ResultWindow();
        resultWindow.Show();
        Close();
    }
}