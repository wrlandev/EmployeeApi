namespace EmployeeApi.Models
{
    public interface IEmployeeRepository
    {
        void Add(EmployeeModel employee);
        List<EmployeeModel> GetAll();
    }
}
