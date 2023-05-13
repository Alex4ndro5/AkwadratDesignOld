using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AkwadratDesign.Models.DbModels
{
    public class Firm
    {
        [Key]  
        public int Id { get; set; }
        [Required]
        public string FirmName { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Client Client { get; set; }

        public List<ProjectFirm> ProjectFirms { get; set; }
    }
}
