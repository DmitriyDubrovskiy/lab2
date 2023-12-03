using System;

class User
{
    private string _login;
    private string _firstName;
    private string _lastName;
    private int _age;
    private readonly DateTime _registrationDate; // Поле, що ініціалізується лише один раз

    // Конструктор класу User
    public User(string login, string firstName, string lastName, int age)
    {
        _login = login;
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
        _registrationDate = DateTime.Now; // Ініціалізація поля "дата заповнення анкети"
    }

    // Метод для виведення інформації про користувача на екран
    public void DisplayUserInfo()
    {
        Console.WriteLine($"Логін: {_login}");
        Console.WriteLine($"Ім'я: {_firstName}");
        Console.WriteLine($"Прізвище: {_lastName}");
        Console.WriteLine($"Вік: {_age}");
        Console.WriteLine($"Дата заповнення анкети: {_registrationDate}");
    }
}
