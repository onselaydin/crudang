using crudang.EF;
using crudang.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crudang.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult getEmployee()
        {
            Dal _oDal = new Dal();
            List<Employee> ListOfEmployee = _oDal.employess.ToList();
            return Json(ListOfEmployee, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult SaveEmployee(Employee _oEmployee)
        {
            Dal _oDal = new Dal();
            _oDal.employess.Add(_oEmployee);
            _oDal.SaveChanges();
            List<Employee> ListOfEmployee = _oDal.employess.ToList();
            return Json(ListOfEmployee, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult GetemployeeByID(int id)
        {
            Dal _oDal = new Dal();
            Employee _oEmployee = new Employee();
            _oEmployee = _oDal.employess.Find(id);
            return Json(_oEmployee, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult UpdateData(Employee _oEmployee)
        {
            Dal _oDal = new Dal();
            _oDal.Entry(_oEmployee).State = System.Data.Entity.EntityState.Modified;
            _oDal.SaveChanges();

            List<Employee> ListOfEmployee = _oDal.employess.ToList();
            return Json(ListOfEmployee, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult DeleteData(int ID)
        {
            Dal _oDal = new Dal();
            Employee _oEmployee = new Employee();
            _oEmployee = _oDal.employess.Find(ID);
            _oDal.Entry(_oEmployee).State = System.Data.Entity.EntityState.Deleted;
            _oDal.SaveChanges();

            List<Employee> ListOfEmployee = _oDal.employess.ToList();
            return Json(ListOfEmployee, JsonRequestBehavior.AllowGet);
        }
    }
}