public class Fraction:IClonable, IOperationable
{
    private int Numerator;
    private int Denominator;

    public int numerator
    {
        get { return Numerator; }
        set { Numerator = value; }
    }

    public int denominator
    {
        get { return Denominator; }
        set { Denominator = value; }
    }


    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Знаменатель не может быть равен нулю");
        }
        if (denominator < 0)
        {
            denominator *= -1;
            numerator *= -1;

        }

        this.numerator = numerator;
        this.denominator = denominator;
        Simplify();
    }

    public override string ToString()
    {
        return $"{numerator}/{denominator}";
    }

    public static Fraction operator +(Fraction a, Fraction b)
    {
        int numerator_c;
        int denominator_c;
        if (a.denominator != b.denominator)
        {
            numerator_c = a.numerator * b.denominator + b.numerator * a.denominator;
            denominator_c = a.denominator * b.denominator;
        }
        else
        {
            denominator_c = a.denominator;
            numerator_c = a.numerator + b.numerator;
        }

        return new Fraction(numerator_c, denominator_c);
    }

    public static Fraction operator +(int a, Fraction b)
    {
        return b + new Fraction(a, 1);
    }

    //Вычисление наибольшего общего делителя
    private static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return Math.Abs(a);
    }

    //Упрощение дроби
    private void Simplify()
    {
        int gcd = GCD (this.numerator, this.denominator);
        numerator /= gcd;
        denominator /= gcd;
    }

    public static Fraction operator -(Fraction a, Fraction b) 
    {
        int numerator_c;
        int denominator_c;
        if (a.denominator == b.denominator)
        {
            denominator_c = a.denominator;
            numerator_c = a.numerator - b.numerator;
        }
        else
        {
            denominator_c = a.denominator * b.denominator;
            numerator_c = a.numerator * b.denominator - b.numerator * a.denominator; 
        }
        return new Fraction(numerator_c, denominator_c);
    }

    public static Fraction operator - (Fraction a, int b)
    {
        Fraction c = new Fraction(b, 1);
        return a - c;
    }

    public static Fraction operator -(int b, Fraction a)
    {
        Fraction c = new Fraction(b, 1); 
        return c - a; 
    }

    public static Fraction operator *(Fraction a, Fraction b) 
    {
        return new Fraction(a.numerator * b.numerator, a.denominator * b.denominator);

    }

    public static Fraction operator *(int a, Fraction b)
    {
        return new Fraction(a * b.numerator, b.denominator);
    }

    public static Fraction operator /(Fraction a, Fraction b) 
    {
        if (b.numerator == 0)
        {
            throw new ArgumentException("Нельзя делить на 0");

        }
        
            int numerator_c = a.numerator * b.denominator;
            int denominator_c = a.denominator * b.numerator;

            return new Fraction(numerator_c, denominator_c);
       
    }


    public override bool Equals(object? obj)
    {
        if (obj is Fraction && obj != null)
        {
            Fraction a = (Fraction)obj;
            return a.numerator == numerator && a.denominator == denominator;
        }
        return false;
    }

    public Fraction Clone()
    {
        return new Fraction((int)numerator, (int)denominator);
    }

    public double GetValue()
    {
        return (double)numerator / denominator;
    }

    public void SetNumerator(int numerator)
    {
        this.numerator = numerator;
    }

    public void SetDenominator(int denominator) 
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Знаменатель не может быть равен 0");
        }
        this.denominator = denominator;
    }



}