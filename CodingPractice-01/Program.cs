using System;

////1
//Counter c = new Counter(5);
//Console.WriteLine(-c);
//c++;
//Console.WriteLine(c);


//struct Counter
//{
//    public int Value;
//    public Counter(int value)
//    {
//        Value = value;
//    }
//    public static Counter operator -(Counter a)
//    {
//        return new Counter(-a.Value);
//    }
//    public static Counter operator ++(Counter a)
//    {
//        return new Counter(a.Value+1); 
//    }
//    public override string ToString()
//    {
//        return Value.ToString();
//    }
//}

////2
//Fraction fraction1 = new Fraction(1, 2);
//Fraction fraction2 = new Fraction(1, 3);
//Console.WriteLine(fraction1 + fraction2);
//Console.WriteLine(fraction1 * fraction2);
//struct Fraction
//{
//    public int Numerator;
//    public int Denominator;
//    public Fraction(int numerator, int denominator)
//    {
//        Numerator = numerator;
//        Denominator = denominator;
//    }
//    public static Fraction operator +(Fraction a, Fraction b)
//    {
//        return new Fraction((a.Numerator * b.Denominator) + (b.Numerator * a.Denominator), (a.Denominator * b.Denominator));
//    }
//    public static Fraction operator *(Fraction a, Fraction b)
//    {
//        return new Fraction(a.Numerator * b.Numerator, a.Denominator * b.Denominator);
//    }
//    public override string ToString()
//    {
//        return $"{Numerator} / {Denominator}";
//    }
//}

////3
//Money money1 = new Money(1000, "KRW");
//Money money2 = new Money(2000, "KRW");
//Console.WriteLine(money1 == money2);
//Console.WriteLine(money1 < money2);
//struct Money
//{
//    public decimal Amount;
//    public string Currency;

//    public Money(decimal amount, string currency)
//    {
//        Amount = amount;
//        Currency = currency;
//    }
//    public static bool operator ==(Money m1, Money m2)
//    {
//        return m1.Amount == m2.Amount;
//    }
//    public static bool operator !=(Money m1, Money m2)
//    {
//        return !(m1 == m2);
//    }
//    public static bool operator <(Money m1, Money m2)
//    {
//        if (m1.Currency != m2.Currency)
//        {
//            throw new InvalidOperationException("통화가 다릅니다.");
//        }
//        return m1.Amount < m2.Amount;   
//    }
//    public static bool operator >(Money m1, Money m2)
//    {
//        if (m1.Currency != m2.Currency)
//        {
//            throw new InvalidOperationException("통화가 다릅니다.");
//        }
//        return m1.Amount > m2.Amount;
//    }
//    public override bool Equals(object obj) 
//    { 
//        if(obj is Money other)
//        {
//            return this == other;
//        }
//        return false;
//    }
//    public override int GetHashCode()
//    {
//        return HashCode.Combine(Amount, Currency);
//    }
//}

////4
//Vector2 v = new Vector2(1, 2);
//Console.WriteLine(v += new Vector2(3, 4));
//struct Vector2
//{
//    int X;
//    int Y;
//    public Vector2(int x, int y)
//    {
//        X = x; 
//        Y = y;
//    }
//    public static Vector2 operator +(Vector2 v1, Vector2 v2)
//    {
//        return new Vector2(v1.X + v2.X, v1.Y + v2.Y);
//    }
//    public override string ToString()
//    {
//        return $"({X}, {Y})";
//    }
//}

//5
Celsius temp = 36.5;
double value = temp;
Console.WriteLine(value);
struct Celsius
{
    public double Degrees;
    public Celsius(double degrees)
    {
        Degrees = degrees;
    }
    public static implicit operator double(Celsius c)
    {
        return c.Degrees;
    }
    public static implicit operator Celsius(double d)
    {
        return new Celsius(d);
    }
}