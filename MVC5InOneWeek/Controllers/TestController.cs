using MVC5InOneWeek.Models;
using MVC5InOneWeek.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5InOneWeek.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View("MyView");
        }
        public string GetString()
        {
            return "Hello World is old now";
        }
        public ActionResult GetView()
        {
            /* Code for Day - 1
            Employee emp = new Employee();
            emp.FirstName = "Sukesh";
            emp.LastName = "Marla";
            emp.Salary = 20000;

            EmployeeViewModel vmEmp = new EmployeeViewModel();
            vmEmp.EmployeeName = emp.FirstName + " " + emp.LastName;
            vmEmp.Salary = emp.Salary.ToString("C");
            if (emp.Salary > 15000)
            {
                vmEmp.SalaryColor = "yellow";
            }
            else
            {
                vmEmp.SalaryColor = "green";
            }

            vmEmp.UserName = "Admin";

            ViewBag.Employee = emp;
            return View("MyView", vmEmp);*/

            //Code for Day 2
            EmployeeListViewModel employeeListViewModel = new EmployeeListViewModel();
            EmployeeBusinessLayer empBal = new EmployeeBusinessLayer();

            List<Employee> employees = empBal.GetEmployees();
            List<EmployeeViewModel> empViewModels = new List<EmployeeViewModel>();

            foreach(Employee emp in employees)
            {
                EmployeeViewModel empViewModel =  new EmployeeViewModel();
                empViewModel.EmployeeName = emp.FirstName + " " + emp.LastName;
                empViewModel.Salary = emp.Salary.ToString("C");
                if (emp.Salary > 15000)
                {
                    empViewModel.SalaryColor = "yellow";
                }
                else
                {
                    empViewModel.SalaryColor = "green";
                }
                empViewModels.Add(empViewModel);
            }
            employeeListViewModel.Employees = empViewModels;
            employeeListViewModel.UserName = "Admin";
            return View("MyView", employeeListViewModel);

        }
    }
}