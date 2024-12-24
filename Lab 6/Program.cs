public class Program
{
    static void Main(string[] args)
    {
        Cat Barsik = new Cat("Барсик");
        Cat Markiz = new Cat("Маркиз");
        Lion Alex = new Lion("Алекс");
        Lion Mufasa = new Lion("Муфаса");
        Console.WriteLine("==========Задание 1.1==========");
        Barsik.Meow();
        Barsik.MeowN(3);

        Console.WriteLine("\n==========Задание 1.2==========");
        var cats = new List<Cat> { Barsik, Markiz };
        MeowDetect.Meowable(cats);

        var bigboys = new List<Lion> { Alex, Mufasa };
        MeowDetect.Meowable(bigboys);


        Console.WriteLine("\n==========Задание 1.3==========");
        var CountBarsik = new Count(Barsik);
        MeowDetect.Meowable(new List<IMeowable> {CountBarsik});

        CountBarsik.Meow();
        CountBarsik.Meow();
        Console.WriteLine($"Барсик мяукал {CountBarsik.Meow_Count} раз(а)");

        Console.WriteLine("\n==========Задание 2==========");
        Fraction f1 = new Fraction(0, 3);
        Fraction f2 = new Fraction(3, 5);
        Fraction f3 = new Fraction(-5, 6);
        Fraction f4 = f1 + f3;

        Console.WriteLine(f4);
        Console.WriteLine(f1);
        Console.WriteLine("0 + 3/5 = " + $"{f1 + f2}");
        Console.WriteLine("3/5 - 5/6 = " + $"{f2 + f3}");
        Console.WriteLine("3/5 + 5/6 = " + $"{f2 - f3}");
        Console.WriteLine("-5/6 / 3/5 = " + $"{f3 / f2}");
        Console.WriteLine("-5/6 * 3/5 = " + $"{f3 * f2}");

        Console.WriteLine($"{(f1 + f2) / f3 - 5}");

    }
}
