namespace TaskManager.Models.Entities
{
    public class TaskStatus
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public ICollection<TaskItem> Tasks { get; set; }
    }
}
