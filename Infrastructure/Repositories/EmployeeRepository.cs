using EmployeeApi.Domain.DTOs;
using EmployeeApi.Domain.Models;

namespace EmployeeApi.Infrastructure.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext _context;
        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Add(EmployeeModel employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public EmployeeModel? Get(int id)
        {
            return _context.Employees.FirstOrDefault(x => x.Id == id);
        }

        public List<EmployeeDto> GetAll(int pageNumber, int pageQuantity)
        {
            return _context.Employees.Skip(pageNumber * pageQuantity)
                .Take(pageQuantity)
                .Select(x =>
                new EmployeeDto()
                {
                    Name = x.Name,
                    Age = x.Age,
                    Photo = x.Photo
                })
                .ToList();
        }
    }
}
