
using System.Linq;
using EmployeeManagement.Data;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public ActionResult Index()
    {
        var db = new EMSContext();
        var employees = db.Employees.Select(x => x.Gender == 'm');

        return View(employees);
    }

    public ActionResult Detail(string firstName)
    {
        var employees = Employee.GetEmployees();
        var employee = employees.FirstOrDefault(x => x.FirstName == firstName);
        
        return View(employee);
    }
    
    public ActionResult Add()
    {
        return View();
    }

    [HttpPost]
    public ActionResult<bool> Add(Employee employee)  // Model binding
    {
        return true;
    }
}
