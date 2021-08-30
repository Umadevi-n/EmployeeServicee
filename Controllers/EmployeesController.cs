using EmployeeServicee.Data;
using EmployeeServicee.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace EmployeeServiceeApp.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        EmployeeServiceeContext _context;
        public EmployeesController(EmployeeServiceeContext context)
        {
            _context = context;
        }
        [HttpPost]
        public IActionResult CreateEmployee(Employee emp)
        {
            _context.Employee.Add(emp);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPost]
        public IActionResult employeeUpdate(Employee emp)
        {
            var result = _context.Employee.FirstOrDefault(e => e.Id == emp.Id);
            if (result != null)
            {
                result.Age = emp.Age;
                result.Name = emp.Name;
                result.Designation = emp.Designation;
                result.City = emp.City;
                result.Country = emp.Country;
                result.ContactNumber = emp.ContactNumber;
                _context.SaveChanges();
                return Ok();

            }
            return NotFound();        }

        [HttpGet]
        public List<Employee> GetEmployee()
        {
            var emp = _context.Employee.ToList();
            return emp;
        }
      
        [HttpPost]
        public IActionResult DeleteEmp(int Id)
        {
            var result = _context.Employee.FirstOrDefault(e => e.Id == Id);
            if (result != null)
            {
                _context.Employee.Remove(result);
                _context.SaveChanges();
                return Ok();

            }
            return NotFound();
        }
        
        //private bool EmployeeExists(int id)
      //  {
        //    throw new NotImplementedException();
        //}
        [HttpGet]
        public Employee GetEmployeeById(int Id)
        {
            var result = _context.Employee.FirstOrDefault(e => e.Id == Id);
            return result;
        }
    }
}
