using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UnitTest_Mock.Models;
using UnitTest_Mock.Services;

namespace UnitTest_Mock.Controllers
{
    public class EmployeeController : ControllerBase
    {
        #region Property
        private readonly IEmployeeService _employeeService;
        #endregion

        #region Constructor
        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        #endregion

        [HttpGet(nameof(GetEmployeeById))]
        public async Task<string> GetEmployeeById(int empID)
        {
            var result = await _employeeService.GetEmployeebyId(empID);
            return result;
        }

        [HttpGet(nameof(GetEmployeeDetails))]
        public async Task<Employee> GetEmployeeDetails(int empID)
        {
            var result = await _employeeService.GetEmployeeDetails(empID);
            return result;
        }


    }
}
