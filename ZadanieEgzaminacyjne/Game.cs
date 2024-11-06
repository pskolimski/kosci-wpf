namespace ZadanieEgzaminacyjne;

/************************************************
klasa:      Game
opis:       Klasa przechowująca informacje o grze.
pola:       NickName - nick gracza
autor:      Patryk Skolimowski
************************************************/
public static class Game
{
    public static string NickName { get; private set; }
    public static string Result { get; set; }

    /***********************************************
    nazwa funkcji: RegisterPlayer
    opis funkcji: Funkcja rejestruje gracza w grze.
    parametry: nickName - nick gracza
    zwracany typ i opis: brak
    autor: Patryk Skolimowski
    ************************************************/
    public static void RegisterPlayer(string nickName)
    {
        NickName = nickName;
    }
}