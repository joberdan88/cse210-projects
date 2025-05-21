public class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }

    public Fraction(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    //Get and Set
    public int GetNumerator()
    {
        return _numerator;
    }

    public void SetNumerator(int numerator)
    {
        _numerator = numerator;
    }

    public int GetDenominator()
    {
        return _denominator;
    }

    public void SetDenominator(int denominator)
    {
        _denominator = denominator;
    }


    //Methods to return the representations
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }

    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}    
