// Employee.cs (Part 1)
using System;

public partial class Employee
{
    public int EmployeeId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime HireDate { get; set; }
    public decimal BaseSalary { get; set; }
    // Other properties representing employee details

    // You can add other properties related to salary calculation, such as allowances, bonuses, etc.
}

// EmployeeSalaryCalculator.cs (Part 2)
public partial class Employee
{
    // Method to calculate salary based on basic salary and other factors
    public decimal CalculateSalary()
    {
        // Calculate salary based on factors like base salary, allowances, bonuses, etc.
        decimal totalSalary = BaseSalary; // You can add other factors here

        return totalSalary;
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee
        {
            EmployeeId = 1,
            FirstName = "Sunil",
            LastName = "Dagur",
            HireDate = new DateTime(2023, 08, 21),
            BaseSalary = 50000
            // Set other properties
        };

        decimal salary = employee.CalculateSalary();
        Console.WriteLine($"Employee {employee.FirstName} {employee.LastName} has a salary of ${salary}");
    }
}
