using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Employee
    {
        [Key]
        [DisplayName("ID")]
        public int EmployeeId { get; set; }
        [DisplayName("Name")]
        [Required]
        public string FullName { get; set; }
        [DisplayName("Code")]
        public string EmployeeCode { get; set; }
        [DisplayName("Position")]
        public string EmployeePosition { get; set; }
        [DisplayName("Office location")]
        public string OfficeLocation { get; set; }
    }
}
