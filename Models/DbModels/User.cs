using System.ComponentModel.DataAnnotations;

namespace AkwadratDesign.Models.DbModels
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
 