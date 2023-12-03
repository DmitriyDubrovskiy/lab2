class Program
{
    static void Main()
    {
        // Створення екземпляра класу Address
        Address myAddress = new Address
        {
            Index = "12345",
            Country = "Україна",
            City = "Київ",
            Street = "Вулиця Київська",
            House = "10",
            Apartment = "5"
        };

        // Виведення на екран значень полів адреси
        Console.WriteLine("Індекс: " + myAddress.Index);
        Console.WriteLine("Країна: " + myAddress.Country);
        Console.WriteLine("Місто: " + myAddress.City);
        Console.WriteLine("Вулиця: " + myAddress.Street);
        Console.WriteLine("Будинок: " + myAddress.House);
        Console.WriteLine("Квартира: " + myAddress.Apartment);
    }
}
