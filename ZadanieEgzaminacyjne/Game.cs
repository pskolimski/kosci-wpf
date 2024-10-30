namespace ZadanieEgzaminacyjne;

public static class Game
{
    public static string NickName { get; private set; }
    public static string Result { get; set; }

    public static void RegisterPlayer(string nickName)
    {
        NickName = nickName;
    }
}