using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace School_Mgt.Models.ViewModel
{
    public class CreateStudentViewModel
    {
        [Required(ErrorMessage = "Please enter First Name")]
        [Display(Name = "FirstName")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,20}$",
         ErrorMessage = "Characters are not allowed.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Please enter Last Name")]
        [Display(Name = "LastName")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,20}$",
         ErrorMessage = "Characters are not allowed.")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please enter Address")]
        [Display(Name = "Address")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
         ErrorMessage = "Characters are not allowed.")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please enter Phone Number")]
        [Display(Name = "PhoneNumber")]
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please enter Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public string BirthDate { get; set; }
        [Required]
        [RegularExpression("([0-9]+)", ErrorMessage = "Please enter valid Number")]
        public int DepartmentId { get; set; }
    }
}
