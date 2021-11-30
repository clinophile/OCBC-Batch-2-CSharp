using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace UnitTest_Mock.Models
{
    public class Employee
    {
        //private Models.EmployeeContext context ;
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }

    }
}