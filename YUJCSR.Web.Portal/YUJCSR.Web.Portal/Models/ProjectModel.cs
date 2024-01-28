namespace YUJCSR.Web.Portal.Models
{
    public class ProjectModel
    {
        public string? ProjectID { get; set; }
        public string? RefID { get; set; }
        public string? Title { get; set; }
        public string? AreOfInterest { get; set; }
        public string? DevelopmentGoal { get; set; }
        public string? ProjectDescription { get; set; }
        public string? Location { get; set; }
        public decimal? TotalBudget { get; set; }
        public Int32? DurationInMonths { get; set; }
        public decimal? ExpectedOutcome { get; set; }
        public string? Amenities { get; set; }
        public string? Experts { get; set; }
    }
}
