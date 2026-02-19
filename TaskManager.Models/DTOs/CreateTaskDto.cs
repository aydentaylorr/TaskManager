namespace TaskManager.Models.DTOs
{
    public class CreateTaskDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int StatusId { get; set; }
        public int CategoryId { get; set; }
        public Guid UserId { get; set; }
    }
}
