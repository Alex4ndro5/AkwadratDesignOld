using Microsoft.AspNetCore.Identity;

namespace AkwadratDesign.Models
{
    public class Subject : IdentityUser 
    {
        private int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }  
        public string Message { get; set; }

    }
}
