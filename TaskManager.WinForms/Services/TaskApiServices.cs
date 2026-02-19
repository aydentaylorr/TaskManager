using System.Net.Http.Json;
using TaskManager.Models.DTOs;

namespace TaskManager.WinForms.Services
{
    public class TaskApiService
    {
        private readonly HttpClient _httpClient;

        public TaskApiService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7250/");
        }

        public async Task<List<TaskListDto>> GetUserTasks(Guid userId)
        {
            return await _httpClient
                .GetFromJsonAsync<List<TaskListDto>>($"api/task/user/{userId}");
        }

        public async Task<bool> AddTask(CreateTaskDto dto)
        {
            var response = await _httpClient.PostAsJsonAsync("api/task", dto);
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> UpdateTask(Guid id, UpdateTaskDto dto)
        {
            var response =
                await _httpClient.PutAsJsonAsync($"api/task/{id}", dto);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteTask(Guid id)
        {
            var response = await _httpClient.DeleteAsync($"api/task/{id}");
            return response.IsSuccessStatusCode;
        }
    }
}
