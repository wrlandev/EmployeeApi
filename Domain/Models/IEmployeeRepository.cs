using EmployeeApi.Domain.DTOs;

namespace EmployeeApi.Domain.Models
{
    public interface IEmployeeRepository
    {
        void Add(EmployeeModel employee);
        List<EmployeeDto> GetAll(int pageNumber, int pageQuantity);
        EmployeeModel? Get(int id);
    }
}
