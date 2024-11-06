namespace ZadanieEgzaminacyjne;

/************************************************
klasa:      Dice
opis:       Klasa przechowująca informacje o kostce.
pola:       Value - wartość kostki
autor:      Patryk Skolimowski
************************************************/
public class Dice
{
    public int Value { get; private set; }

    public Dice(int value)
    {
        this.Value = value;
    }
}