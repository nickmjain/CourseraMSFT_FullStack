using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course6_DatabaseIntegration.Models
{
    public  class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        public DateTime HireDate { get; set; }

        // Foreign Key to Department
        [ForeignKey("Department")]
        public int DepartmentID { get; set; }

        // Navigation property to Department (for estbalishing relationships)
        public virtual Department Department { get; set; }

    }
}
