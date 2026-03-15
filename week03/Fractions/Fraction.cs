// week03/Fractions/Fraction.cs
using System;

/// <summary>
/// The Fraction class represents a mathematical fraction.
/// It demonstrates encapsulation by keeping the numerator
/// and denominator private and providing controlled access
/// through public methods.
/// </summary>
public class Fraction
{
    // Private attributes (encapsulation)
    // These cannot be accessed directly from outside the class
    private int _top;
    private int _bottom;

    /// <summary>
    /// Constructor with no parameters.
    /// Initializes the fraction to 1/1.
    /// </summary>
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    /// <summary>
    /// Constructor that accepts only the numerator.
    /// Denominator defaults to 1.
    /// Example: new Fraction(5) -> 5/1
    /// </summary>
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;
    }

    /// <summary>
    /// Constructor that accepts both numerator and denominator.
    /// Example: new Fraction(3,4) -> 3/4
    /// </summary>
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    /// <summary>
    /// Getter for the numerator.
    /// </summary>
    public int GetTop()
    {
        return _top;
    }

    /// <summary>
    /// Setter for the numerator.
    /// Allows controlled modification of the numerator.
    /// </summary>
    public void SetTop(int top)
    {
        _top = top;
    }

    /// <summary>
    /// Getter for the denominator.
    /// </summary>
    public int GetBottom()
    {
        return _bottom;
    }

    /// <summary>
    /// Setter for the denominator.
    /// </summary>
    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    /// <summary>
    /// Returns the fraction as a string representation.
    /// Example: 3/4
    /// </summary>
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    /// <summary>
    /// Returns the decimal value of the fraction.
    /// Example: 3/4 -> 0.75
    /// </summary>
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}