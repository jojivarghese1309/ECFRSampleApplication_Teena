namespace ECFRApp.Models
{
    public class CaseFile
    {
        public int Id { get; set; }
        public string CaseNumber { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime FilingDate { get; set; }
        public string Status { get; set; } = "Pending";
        public string FiledBy { get; set; } = string.Empty;
    }
}
