using System;
using System.Collections.Generic;
using System.Text;

struct Celsius
{
    public double Degrees;
    public Celsius(double degrees)
    {
        Degrees = degrees; 
    }
    public static explicit operator Fahrenheit(Celsius c)
    {
        return new Fahrenheit(c.Degrees * 9 / 5 + 32);
    }
    public static explicit operator Celsius(Fahrenheit f)
    {
        return new Celsius((f.Degrees - 32) * 5 / 9);
    }
    public override string ToString()
    {
        return $"{Degrees}°C";
    }
}

