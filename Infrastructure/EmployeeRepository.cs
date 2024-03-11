using EmployeeApi.Models;

namespace EmployeeApi.Infrastructure
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

        public List<EmployeeModel> GetAll()
        {
            return _context.Employees.ToList();
        }
    }
}
