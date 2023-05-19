using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace AkwadratDesign.Models.DbModels
{
    public class AppUser : IdentityUser
    {
        [Key]
        public int AppUserId { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
 