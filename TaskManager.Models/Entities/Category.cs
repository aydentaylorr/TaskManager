namespace TaskManager.Models.Entities
{
    public class Category
    {
        public Guid CategoryId { get; set; } = Guid.NewGuid();
        public string CategoryName { get; set; }
        public int UserId { get; set; }
    }
}
