namespace EmployeeApi.Domain.Models
{
    public interface IEmployeeRepository
    {
        void Add(EmployeeModel employee);
        List<EmployeeModel> GetAll(int pageNumber, int pageQuantity);
        EmployeeModel? Get(int id);
    }
}
