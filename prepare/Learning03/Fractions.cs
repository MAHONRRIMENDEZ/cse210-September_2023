using System;
using System.Security.Cryptography.X509Certificates;

public class Fractions
{
    private int _top;
    private int _bottom;

    public Fractions()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fractions(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fractions(int topNumber, int botNumber)
    {
        _top = topNumber;
        _bottom = botNumber;
    }

    public int GetTop()
    {
        return _top;
    }

    public void SetTopp(int top)
    {
        _top = top;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }


}