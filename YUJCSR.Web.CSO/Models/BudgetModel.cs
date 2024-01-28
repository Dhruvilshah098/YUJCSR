namespace YUJCSR.Web.Project.Models
{

	public class ResultBudget
    {
        public List<BudgetModel> result { get; set; }
    }

	public class BudgetModel
    {
        public string? budgetID { get; set; }
        public string? projectID { get; set; }
        public string? milestone { get; set; }
        public string? description { get; set; }
        public string? amount { get; set; }
        public string? activeStatus { get; set; }
        public string? createdBy { get; set; }
        public string? modifiedBy { get; set; }
        public DateTime? createdDate { get; set; }
        public DateTime? modifiedDate { get; set; }
    }
}
