using System;
using System.ComponentModel.DataAnnotations;

namespace Portal.Models.Binding
{
    public class AddStudentBindingModel
    {
        [Required, DataType(DataType.Text)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
        [DataType(DataType.Text), MinLength(11), MaxLength(12)]
        public string PhoneNumber { get; set; }
    }
}