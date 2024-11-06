using System.Windows;
using System.Windows.Controls;

namespace ZadanieEgzaminacyjne;

public partial class ResultWindow : Window
{
    public ResultWindow()
    {
        InitializeComponent();
        DataContext = this;
        int points = Dices.GetPoints();

        ListViewItem listViewItem = new ListViewItem();
        listViewItem.Style = (Style)FindResource("ListViewItemStyle");
        listViewItem.Content = $"Gracz: {Game.NickName}, Wynik: {points}, Data: {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")}";
        ResultsView.Items.Add(listViewItem);
    }

    private void PlayAgainButtonClick(object sender, RoutedEventArgs e)
    {
        MainWindow mainWindow = new MainWindow();
        mainWindow.Show();
        Close();
    }
}