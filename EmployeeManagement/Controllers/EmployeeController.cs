
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public ActionResult Index()
    {
        // Object initializer
        var employee1 = new Employee { FirstName = "Bishnu", Surname = "Rawal", Address = "Ktm", Salary = 100.0 };
        var employee2 = new Employee { FirstName = "Ram", Surname = "Basnet", Address = "Bhaktapur", Salary = 10000.0 };
        var employee3 = new Employee { FirstName = "KP", Surname = "Oli", Address = "Ktm", Salary = 100.0 };
        var employee4 = new Employee { FirstName = "Bishnu", Surname = "Rawal", Address = "Ktm", Salary = 100.0 };
        var employee5 = new Employee { FirstName = "Bishnu", Surname = "Rawal", Address = "Ktm", Salary = 100.0 };
        var employee6 = new Employee { FirstName = "Bishnu", Surname = "Rawal", Address = "Ktm", Salary = 100.0 };

        var employees = new List<Employee> { employee1, employee2, employee3, employee4, employee5, employee6 };
        
        return View(employees);
    }
}
