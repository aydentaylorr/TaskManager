namespace TaskManager.Models.Entities
{
    public class TaskStatus
    {
        public Guid StatusId { get; set; } = Guid.NewGuid();
        public string StatusName { get; set; }
    }
}
