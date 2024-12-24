public class Cat:IMeowable
{
    private string Name;
    public string name
    {
        get { return Name; }
        set { Name = value; }
    }

     public Cat (string name)
    {
        this.name = name;
    }

    public override string ToString()
    {
        return $"»м€: {name}";
    }

    public void Meow()
    {
        Console.WriteLine($"{name}: ћ€у!");
    }

    public void MeowN(int N)
    {
        if (N <= 0) 
        {
            Console.WriteLine($"{name} хочет помолчать.");
        }

        string meowing = string.Join("-", Enumerable.Repeat("м€у", N));
        Console.WriteLine($"{name}: {meowing}!");

    }

}