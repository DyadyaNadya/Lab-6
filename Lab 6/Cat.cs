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
        return $"���: {name}";
    }

    public void Meow()
    {
        Console.WriteLine($"{name}: ���!");
    }

    public void MeowN(int N)
    {
        if (N <= 0) 
        {
            Console.WriteLine($"{name} ����� ���������.");
        }

        string meowing = string.Join("-", Enumerable.Repeat("���", N));
        Console.WriteLine($"{name}: {meowing}!");

    }

}