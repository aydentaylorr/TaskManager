using System.Net.Http.Json;
using TaskManager.Models.DTOs;

namespace TaskManager.WinForms.Services
{
    public class AuthApiService
    {
        private readonly HttpClient _httpClient;

        public AuthApiService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://localhost:7250/");
        }

        public async Task<bool> RegisterAsync(RegisterUserDto dto)
        {
            var response = await _httpClient.PostAsJsonAsync(
                "api/auth/register", dto);

            return response.IsSuccessStatusCode;
        }

        public async Task<Guid?> LoginAsync(LoginDto dto)
        {
            var response = await _httpClient.PostAsJsonAsync(
                "api/auth/login", dto);

            if (!response.IsSuccessStatusCode)
                return null;

            var userId = await response.Content.ReadFromJsonAsync<Guid>();

            return userId;
        }
    }
}
