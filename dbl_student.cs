//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentDataCRUD_MVC.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class dbl_student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required(ErrorMessage ="Required")]
        [EmailAddress]
        public string Email { get; set; }

        [MinLength(11,ErrorMessage ="Number should be 11 Digit")]
        public string Mobile { get; set; }
        public string Address { get; set; }
    }
}