class Program
{
    static void Main()
    {
        // Створення екземпляра класу Employee
        Employee employee = new Employee("Петров", "Іван");

        // Виклик методу для розрахунку окладу та податкового збору
        employee.CalculateSalaryAndTax("Інженер", 5);
    }
}
