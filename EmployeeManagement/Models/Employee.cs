using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Employee
{
    [Required(ErrorMessage = "We need first name")]
    [Display(Name = "First Name")]    
    public string FirstName { get; set; }

    [Required(ErrorMessage = "We need your parent name")]
    [Display(Name = "Last Name")]
    public string Surname { get; set; }
    
    public string Address { get; set; }

    public char Gender { get; set; } = 'M';    
    public double Salary { get; set; }

    public static List<Employee> GetEmployees()
    {
        // Object initializer
        var employee1 = new Employee { FirstName = "Bishnu", Surname = "Rawal", Address = "Ktm", Salary = 100.0 };
        var employee2 = new Employee { FirstName = "Ram", Surname = "Basnet", Address = "Bhaktapur", Salary = 10000.0 };
        var employee3 = new Employee { FirstName = "KP", Surname = "Oli", Address = "Ktm", Salary = 100.0 };
        var employee4 = new Employee { FirstName = "Bishnu1", Surname = "Rawal", Address = "Ktm", Salary = 100.0 };
        var employee5 = new Employee { FirstName = "Bishnu2", Surname = "Rawal", Address = "Ktm", Salary = 100.0 };
        var employee6 = new Employee { FirstName = "Bishnu3", Surname = "Rawal", Address = "Ktm", Salary = 100.0 };

        var employees = new List<Employee> { employee1, employee2, employee3, employee4, employee5, employee6 };
        return employees;     
    }
}