using System.ComponentModel.DataAnnotations;

namespace Week14_Identity.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string password { get; set; }
    }
}
