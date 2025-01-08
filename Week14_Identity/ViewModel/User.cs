using System.ComponentModel.DataAnnotations;
using Week14_Identity.Model;

namespace Week14_Identity.ViewModel
{
    public class User
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string password { get; set; }

    }
}
