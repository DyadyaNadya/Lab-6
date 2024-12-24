public static class MeowDetect
{
    public static void Meowable(IEnumerable<IMeowable> meowables)
    {
        foreach(var meowable in meowables)
        {
            meowable.Meow();
        }
    }
}