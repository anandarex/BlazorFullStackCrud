namespace BlazorFullStackCrud.Client.Services.EmployeesService
{
    public interface IEmployeesService
    {
        List<Employees> Workers { get; set; }
        Task GetEmployees();
        Task<Employees> GetSingleWorkers(int id);

    }
}
