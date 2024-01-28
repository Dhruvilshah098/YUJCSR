namespace YUJCSR.Web.Project.Models
{
	public class ResultMilestone
	{
		public List<MilestoneModel> result { get; set; }
	}

	
    public class MilestoneModel
    {
        public string? milestoneID { get; set; }
        public string? milestoneName { get; set; }
        public string? description { get; set; }
        public string? projectID { get; set; }
        public string? activeStatus { get; set; }
        public string? createdBy { get; set; }
        public string? modifiedBy { get; set; }
        public DateTime? createdDate { get; set; }
        public DateTime? modifiedDate { get; set; }
    }

}
