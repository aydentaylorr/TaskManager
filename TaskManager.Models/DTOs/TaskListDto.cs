namespace TaskManager.Models.DTOs
{
    public class TaskListDto
    {
        public Guid TaskId { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
    }
}
