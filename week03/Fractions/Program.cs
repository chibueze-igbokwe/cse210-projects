using System;

class Program
{
    static void Main(string[] args)
    {
        // Create fraction using default constructor (1/1)
        Fraction f1 = new Fraction();

        Console.WriteLine(f1.GetFractionString());
        Console.WriteLine(f1.GetDecimalValue());

        // Create fraction using single parameter constructor (6/1)
        Fraction f2 = new Fraction(5);

        Console.WriteLine(f2.GetFractionString());
        Console.WriteLine(f2.GetDecimalValue());

        // Create fraction using two parameter constructor (3/4)
        Fraction f3 = new Fraction(3, 4);

        Console.WriteLine(f3.GetFractionString());
        Console.WriteLine(f3.GetDecimalValue());

        // Create another fraction (1/3)
        Fraction f4 = new Fraction(1, 3);

        Console.WriteLine(f4.GetFractionString());
        Console.WriteLine(f4.GetDecimalValue());

        // Demonstrate setters and getters
        Fraction f5 = new Fraction();

        f5.SetTop(2);
        f5.SetBottom(5);

        Console.WriteLine(f5.GetFractionString());
        Console.WriteLine(f5.GetDecimalValue());
    }
}