using System.Windows;

namespace ZadanieEgzaminacyjne;

public static class Dices
{
    public static List<Dice> DicesList { get; set; } = new List<Dice>();

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