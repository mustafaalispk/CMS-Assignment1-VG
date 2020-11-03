using System.ComponentModel.DataAnnotations;

namespace Inlämningsuppgift1.ViewModels
{
    public class ContactViewModel
    {
        [Required(ErrorMessage ="Please enter your name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter your email address")]
        [EmailAddress(ErrorMessage = "You must enter a valid email address")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please enter your message")]
        [MaxLength(length:500, ErrorMessage = "Your message must be no longer then 500 characters")]
        public string Message { get; set; }


    }
}