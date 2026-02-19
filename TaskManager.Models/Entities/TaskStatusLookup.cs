namespace TaskManager.Models.Entities
{
    public class TaskStatusLookup
    {
        public int StatusId { get; set; }
        public string StatusName { get; set; }
        public ICollection<TaskItem> Tasks { get; set; }
    }
}
