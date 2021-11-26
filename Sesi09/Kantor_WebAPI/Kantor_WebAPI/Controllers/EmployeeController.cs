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


        // [HttpPost]
        // public ActionResult<IEnumerable<EmployeeItem>> SetEmployeeItem(string id, string nama, string jenisKelamin, string alamat)
        // {
        //     _context = HttpContext.RequestServices.GetService(typeof(EmployeeContext)) as EmployeeContext;
        //     if (ModelState.IsValid)
        //     {
        //         _context.SetEmployee(id, nama, jenisKelamin, alamat);

        //         return new JsonResult("BERHASIL");

        //     }
        //     return new JsonResult("something went wrong") { StatusCode = 500 };
        // }
    }
}
