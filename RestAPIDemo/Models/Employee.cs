using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RestAPIDemo.Models
{
    public class Employee
    {
        public Guid Id { get; set; }

        //[Required(ErrorMessage = "Please enter email")]
        public string Name { get; set; }

        public string Email { get; set; }
    }
}
