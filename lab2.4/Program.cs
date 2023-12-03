class Program
{
    static void Main()
    {
        // Створення екземпляра класу User
        User user = new User("john_doe", "John", "Doe", 25);

        // Виведення інформації про користувача на екран
        user.DisplayUserInfo();
    }
}
