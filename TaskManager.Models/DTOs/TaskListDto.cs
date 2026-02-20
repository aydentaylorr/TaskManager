namespace TaskManager.Models.DTOs
{
    public class TaskListDto
    {
        public Guid TaskId { get; set; }
        public string Title { get; set; }
        public int CategoryId { get; set; }
        public string Category { get; set; }
        public int StatusId { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
