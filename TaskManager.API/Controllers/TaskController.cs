using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TaskManager.API.Data;
using TaskManager.Models.DTOs;
using TaskManager.Models.Entities;

namespace TaskManager.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaskController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TaskController(AppDbContext context)
        {
            _context = context;
        }

        // GET USER TASKS
        [HttpGet("user/{userId}")]
        public async Task<IActionResult> GetUserTasks(Guid userId)
        {
            var tasks = await _context.TaskItems
                .Where(t => t.UserId == userId)
                .Include(t => t.Category)
                .Include(t => t.Status)
                .Select(t => new TaskListDto
                {
                    TaskId = t.TaskId,
                    Title = t.Title,
                    Category = t.Category.CategoryName,
                    Status = t.Status.StatusName,
                    Description = t.Description
                })
                .ToListAsync();

            return Ok(tasks);
        }

        // ADD TASK
        [HttpPost]
        public async Task<IActionResult> AddTask(CreateTaskDto dto)
        {
            var task = new TaskItem
            {
                Title = dto.Title,
                Description = dto.Description,
                StartDate = dto.StartDate,
                EndDate = dto.EndDate,
                StatusId = dto.StatusId,
                CategoryId = dto.CategoryId,
                UserId = dto.UserId
            };

            _context.TaskItems.Add(task);
            await _context.SaveChangesAsync();

            return Ok(task.TaskId);
        }

        // UPDATE TASK 
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTask(Guid id, UpdateTaskDto dto)
        {
            var task = await _context.TaskItems.FindAsync(id);

            if (task == null)
                return NotFound();

            task.Title = dto.Title;
            task.Description = dto.Description;
            task.StartDate = dto.StartDate;
            task.EndDate = dto.EndDate;
            task.StatusId = dto.StatusId;
            task.CategoryId = dto.CategoryId;

            await _context.SaveChangesAsync();

            return Ok();
        }

        // DELETE TASK
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var task = await _context.TaskItems.FindAsync(id);

            if (task == null)
                return NotFound();

            _context.TaskItems.Remove(task);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}
