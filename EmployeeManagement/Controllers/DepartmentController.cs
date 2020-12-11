using System.Linq;
using EmployeeManagement.Data;
using EmployeeManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement.Controllers
{
    public class DepartmentController : Controller
    {
        private EMSContext db;

        public DepartmentController(EMSContext _db)
        {
            db = _db;
        }

        public ActionResult Index()
        {
            var departments = db.Departments.ToList();

            return View(departments);
        }

        public ActionResult Detail(int id)
        {
            var departments = db.Departments.Include(x => x.Employees);
            var department = departments.FirstOrDefault(x => x.Id == id);
            
            return View(department);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add([FromForm] Department department)
        {
            db.Departments.Add(department);
            db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public ActionResult Edit(int id)
        {
            var department = db.Departments.Find(id);
            return View(department);
        }

        [HttpPost]
        public ActionResult Edit(Department department)
        {
            db.Departments.Attach(department);
            db.Departments.Update(department);
            db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public ActionResult Delete(int id)
        {
            var department = db.Departments.Find(id);

            return View(department);
        }

        [HttpPost]
        public ActionResult Delete(Department department)
        {
            db.Departments.Attach(department);
            db.Departments.Remove(department);
            db.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}