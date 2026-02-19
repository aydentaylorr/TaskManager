namespace TaskManager.Models.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public ICollection<TaskItem> Tasks { get; set; }
    }
}
