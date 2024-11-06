using System.Windows;

namespace ZadanieEgzaminacyjne;

/************************************************
klasa:      Dices
opis:       Klasa przechowująca informacje o kostkach.
pola:       DicesList - lista kostek
autor:      Patryk Skolimowski
************************************************/
public static class Dices
{
    public static List<Dice> DicesList { get; set; } = new List<Dice>();

    /***********************************************
    nazwa funkcji: GetPoints
    opis funkcji: Funkcja zwraca punkty za kostki.
    parametry: brak
    zwracany typ i opis: int - liczba punktów
    autor: Patryk Skolimowski
    ************************************************/
    public static int GetPoints()
    {
        int points = 0;

        foreach (var dice in DicesList)
        {
            if (DicesList.FindAll(el => el.Value == dice.Value).Count >= 2)
            {
                points += dice.Value;
            }
        }

        return points;
    }
}