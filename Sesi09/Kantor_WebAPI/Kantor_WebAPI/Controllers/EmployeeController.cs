using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kantor_WebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Kantor_WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private EmployeeContext _context;
        
        public EmployeeController(EmployeeContext context)
        {
            this._context = context;
        }

        [HttpGet(Name = "Get All")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItems()
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.GetAllEmployee();
        }

        [HttpGet("id", Name ="Get One")]
        public ActionResult<IEnumerable<EmployeeItem>> GetEmployeeItem(string id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.GetEmployee(id);
        }


         [HttpPost]
         public ActionResult<IEnumerable<EmployeeItem>> SetEmployeeItem(EmployeeItem newEmployee)
         {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            return _context.SetEmployee(newEmployee);
         }

        [HttpPut("id", Name = "Update")]
        public ActionResult<IEnumerable<EmployeeItem>> UpdateEmployeeItem(string id, EmployeeItem employee)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            if(_context.GetEmployee(id).Count == 0)
            {
                return NotFound("Id Not Found"); 
            } else
            {
                return _context.UpdateEmployee(id, employee);
            }

            
        }

        [HttpDelete("id", Name = "Delete")]
        public ActionResult<IEnumerable<EmployeeItem>> DeleteEmployeeItem(string id)
        {
            _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
            if (_context.DeleteEmployee(id))
            {

                return Ok("Employee Deleted");
            }
            
                return NotFound("Employee with id = " + id + " Not Found");
         
        }


    }
}
