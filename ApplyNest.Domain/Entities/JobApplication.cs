using ApplyNest.Domain.Enums;

namespace ApplyNest.Domain.Entities
{
    public class JobApplication
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string JobTitle { get; set; }
        public JobStatus Status { get; set; }
        public DateTime DateApplied { get; set; }
        public string? Notes { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UserId { get; set; } 
        public User User { get; set; }
    }
}
