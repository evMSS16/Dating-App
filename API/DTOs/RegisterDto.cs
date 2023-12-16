using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterDto
    {
        internal readonly char[] Password;

        [Required]
        public string UserName { get; internal set; }

        [Required]
        public string Username { get; internal set; }
    }
}