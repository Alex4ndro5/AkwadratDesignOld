using AkwadratDesign.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace AkwadratDesign.Models.DbModels
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string? Image { get; set; }
        public Data.Enum.Type Type { get; set; }
        public TypeClient TypeClient { get; set; }

        public List<ProjectFirm> ProjectFirms { get; set;}
    }
}
