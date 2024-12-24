public class Lion : IMeowable
{
    private string Name;

    public string name
    {
        get { return Name; }
        set { Name = value; }
    }

    public Lion (string name)
    {
        this.name = name;
    }

    public void Meow()
    {
        Console.WriteLine($"{name}: ÌÐÐÐÐßßßÓ!!");
    }
}