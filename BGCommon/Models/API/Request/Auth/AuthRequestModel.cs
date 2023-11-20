using System.ComponentModel.DataAnnotations;

namespace BGCommon.Models.API
{
    public class AuthRequestModel
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
