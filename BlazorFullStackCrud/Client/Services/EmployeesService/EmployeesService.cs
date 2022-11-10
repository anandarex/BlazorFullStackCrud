using System.Net.Http.Json;

namespace BlazorFullStackCrud.Client.Services.EmployeesService
{
    public class EmployeesService : IEmployeesService
    {
        private readonly HttpClient _http;
        public EmployeesService(HttpClient http)
        {
            _http = http;
        }

        public List<Employees> Workers { get; set; } = new List<Employees>();
        public HttpClient Http { get; }

        public async Task GetEmployees()
        {
            var result = await _http.GetFromJsonAsync<List<Employees>>("api/employees");
            if (result != null)
                Workers = result;
        }

        public Task<Employees> GetSingleWorkers(int id)
        {
            throw new NotImplementedException();
        }
    }
}
