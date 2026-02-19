namespace TaskManager.Models.Entities
{
    public class TaskItem
    {
        public Guid TaskId { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int StatusId { get; set; }
        public TaskStatus Status { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        // Owner
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
