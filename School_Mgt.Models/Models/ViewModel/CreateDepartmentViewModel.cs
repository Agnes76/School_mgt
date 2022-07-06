using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Mgt.Models.Models.ViewModel
{
    public class CreateDepartmentViewModel
    {
        [Required(ErrorMessage = "Please enter Department Name")]
        [Display(Name = "DepartmentName")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,20}$",
      ErrorMessage = "Characters are not allowed.")]
        public string DepartmentName { get; set; }
        [Required]
        [RegularExpression("([0-9]+)", ErrorMessage = "Please enter valid Number")]
        public int Size { get; set; }
    }
}
