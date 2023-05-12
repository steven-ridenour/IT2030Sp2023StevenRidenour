using System.ComponentModel.DataAnnotations;

namespace StevensGameCorner.Models
{
    public class ContactModel
    {

        [Required(ErrorMessage = "Please enter a username.")]
        [RegularExpression("^[a-zA-Z0-9]+$", ErrorMessage = "First name may not contain special characters.")]
        [StringLength(30, ErrorMessage = "First name must be 30 characters or less.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name.")]
        [RegularExpression("^[a-zA-Z0-9]+$", ErrorMessage = "Last name may not contain special characters.")]
        [StringLength(30, ErrorMessage = "First name must be 30 characters or less.")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Please enter your address.")]
        public string? Address { get; set; }

        [Required(ErrorMessage = "Please enter your phone number.")]
        [RegularExpression("^\\+?[1-9][0-9]{7,14}$", ErrorMessage = "Phone number must only contain digits")]
        [StringLength(10, ErrorMessage = "First name must be 10 digits")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please enter your email.")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "Please enter a message.")]
        public string? Message { get; set; }

        [Key]
        public int ContactId { get; set; }


    }
}
