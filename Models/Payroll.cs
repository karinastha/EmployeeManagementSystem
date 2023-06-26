using System.ComponentModel.DataAnnotations;
using System;
namespace FirstApp.Models
{
    public class Payroll
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
            public string Name { get; set; }

            [Required(ErrorMessage = "Profile image is required")]
            public string Profile { get; set; }

            [Required(ErrorMessage = "Gender is required")]
            public string Gender { get; set; }

            [Required(ErrorMessage = "Department is required")]
            public string Department { get; set; }

            [Range(300000, 5000000, ErrorMessage = "Salary must be between 300000 and 5000000")]
            public decimal Salary { get; set; }

            [Required(ErrorMessage = "Start date is required")]
            public DateTime StartDate { get; set; }

            public string Notes { get; set; }
        }
    }

