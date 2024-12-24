public class Count : IMeowable
{
    private readonly IMeowable _count;
    public int Meow_Count { get; private set; } = 0;

    public Count (IMeowable count)
    {
        _count = count;
    }

    public void Meow()
    {
        Meow_Count++;
        _count.Meow();
    }
}
       