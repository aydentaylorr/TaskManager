namespace TaskManager.Models.DTOs
{
    public class CreateCategoryDto
    {
        public string CategoryName { get; set; }
        public Guid UserId { get; set; }
    }
}
