using System;

class Employee
{
    private string _lastName;
    private string _firstName;

    // Конструктор класу Employee
    public Employee(string lastName, string firstName)
    {
        _lastName = lastName;
        _firstName = firstName;
    }

    // Метод для розрахунку окладу та податкового збору
    public void CalculateSalaryAndTax(string position, int experience)
    {
        // Припустимо, що базовий оклад залежить від посади та стажу
        double baseSalary = 30000; // Приклад базового окладу

        // Розрахунок окладу з урахуванням посади та стажу
        double salary = baseSalary + (experience * 1000);

        // Розрахунок податкового збору (припустимо 15%)
        double tax = 0.15 * salary;

        // Виведення інформації про співробітника, оклад та податковий збір
        Console.WriteLine($"Інформація про співробітника:");
        Console.WriteLine($"Прізвище: {_lastName}");
        Console.WriteLine($"Ім'я: {_firstName}");
        Console.WriteLine($"Посада: {position}");
        Console.WriteLine($"Оклад: {salary:C}");
        Console.WriteLine($"Податковий збір: {tax:C}");
    }
}
