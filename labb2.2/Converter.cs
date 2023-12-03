using System;

class Converter
{
    private double _usdRate;
    private double _eurRate;
    private double _plnRate;

    // Користувальницький конструктор
    public Converter(double usd, double eur, double pln)
    {
        _usdRate = usd;
        _eurRate = eur;
        _plnRate = pln;
    }

    // Метод для конвертації гривні в іншу валюту
    public double ConvertToCurrency(double amount, string currency)
    {
        switch (currency.ToLower())
        {
            case "usd":
                return amount / _usdRate;
            case "eur":
                return amount / _eurRate;
            case "pln":
                return amount / _plnRate;
            default:
                throw new ArgumentException("Непідтримувана валюта");
        }
    }

    // Метод для конвертації іншої валюти в гривню
    public double ConvertToUah(double amount, string currency)
    {
        switch (currency.ToLower())
        {
            case "usd":
                return amount * _usdRate;
            case "eur":
                return amount * _eurRate;
            case "pln":
                return amount * _plnRate;
            default:
                throw new ArgumentException("Непідтримувана валюта");
        }
    }
}