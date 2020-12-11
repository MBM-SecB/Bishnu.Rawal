
using System.Linq;
using EmployeeManagement.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class EmployeeController : Controller
{
    private EMSContext db;

    public EmployeeController(EMSContext _db)
    {
        db = _db;
    }

    public ActionResult Index()
    {
        var employees = db.Employees.Include(x => x.Department).ToList();
        return View(employees);
    }

    public ActionResult Detail(int id)
    {
        var employee = db.Employees.Find(id);
        return View(employee);
    }

    public ActionResult Add()
    {
        var departments = db.Departments.ToList();
        ViewData["depOptions"] = departments;
        return View();
    }

    [HttpPost]
    public ActionResult Add(Employee employee)  // Model binding
    {
        db.Employees.Add(employee);
        db.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    public ActionResult Edit(int id)
    {
        var employee = db.Employees.Find(id);
        return View(employee);
    }

    [HttpPost]
    public ActionResult Edit(Employee employee)
    {
        db.Employees.Attach(employee);
        db.Employees.Update(employee);
        db.SaveChanges();

        return RedirectToAction(nameof(Index));
    }

    public ActionResult Delete(int id)
    {
        var employee = db.Employees.Find(id);
        
        return View(employee);
    }
    
    [HttpPost]
    public ActionResult Delete(Employee employee)
    {        
        db.Employees.Attach(employee);
        db.Employees.Remove(employee);
        db.SaveChanges();

        return RedirectToAction(nameof(Index));
    }
}
