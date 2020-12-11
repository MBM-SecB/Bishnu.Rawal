using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.Models
{
    public class Department
    {        
        public int Id { get; set; }
        
        [Required]
        [MinLength(5)]
        public string Name { get; set; }

        [Required]
        public string Code { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }

        public List<Employee> Employees { get; set; }
    }
}