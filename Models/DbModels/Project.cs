using AkwadratDesign.Data.Enum;
using System.ComponentModel.DataAnnotations;

namespace AkwadratDesign.Models.DbModels
{
    public class Project
    {
        [Key]
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public TypeProject Type { get; set; }
        public TypeClient TypeClient { get; set; }

        public List<ProjectFirm> ProjectFirms { get; } = new();
        public List<Firm> Firms { get; } = new();

        public Project()
        {
            
        }

        public Project(string title, string description, string image, TypeProject type, TypeClient typeClient)
        {
            Title = title;
            Description = description;
            Image = image;
            Type = type;
            TypeClient = typeClient;
        }
    }
}
