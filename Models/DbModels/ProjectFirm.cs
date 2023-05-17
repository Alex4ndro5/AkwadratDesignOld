using System.ComponentModel.DataAnnotations.Schema;

namespace AkwadratDesign.Models.DbModels
{
    public class ProjectFirm
    {
        public int FirmsId { get; set; }
        public int ProjectsId { get; set; }
        public Firm Firm { get; set; } = null!;
        public Project Project { get; set; } = null!;
    }
}
