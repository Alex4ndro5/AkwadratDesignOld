namespace AkwadratDesign.Models
{
    public class Firm 
    {
        private int  Id { get; set; }
        public string  FirmName { get; set; }
        public List<ProjectFirm> ProjectFirms { get; set; }
    }
}
