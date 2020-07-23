using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace omfs.web.Models
{
    [NotMapped]
    public class LoginUser
    {
        [Required(ErrorMessage = "Is required.")]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Login Email")]
        public string LoginEmail { get; set; }

        [Required(ErrorMessage = "Is required.")]
        [MinLength(8, ErrorMessage = "Must be at least 8 characters")]
        [DataType(DataType.Password)]
        [Display(Name = "Login Password")]
        public string LoginPassword { get; set; }
    }
}