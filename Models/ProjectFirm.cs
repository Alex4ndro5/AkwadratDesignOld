using AkwadratDesign.Models.DbModels;
using Microsoft.Extensions.Hosting;

namespace AkwadratDesign.Models
{
    public class ProjectFirm
    {
        public int FirmsId { get; set; }
        public int ProjectsId { get; set; }
        public Firm Firm { get; set; } = null!;
        public Project Project { get; set; } = null!;
    }
}
