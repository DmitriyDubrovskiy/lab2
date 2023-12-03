class Program
{
    static void Main()
    {
        // Створення екземпляра класу Converter з курсами валют
        Converter converter = new Converter(usd: 28.0, eur: 33.0, pln: 7.5);

        // Приклад конвертації гривні в іншу валюту
        double amountInUah = 1000.0;
        double convertedAmount = converter.ConvertToCurrency(amountInUah, "usd");
        Console.WriteLine($"{amountInUah} UAH = {convertedAmount} USD");

        // Приклад конвертації іншої валюти в гривню
        double amountInCurrency = 50.0;
        double convertedAmountToUah = converter.ConvertToUah(amountInCurrency, "eur");
        Console.WriteLine($"{amountInCurrency} EUR = {convertedAmountToUah} UAH");
    }
}

