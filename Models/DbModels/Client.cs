using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AkwadratDesign.Models.DbModels
{
    public class Client :IdentityUser
    {
        [Key]
        private int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]  
        public string  Surname { get; set; }
        [Required]  
        public string Email { get; set; }
        [Required]
        public string Message { get; set; } 

    }
}
