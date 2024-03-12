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

        public EmployeeModel? Get(int id)
        {
            return _context.Employees.FirstOrDefault(x => x.Id == id);
        }

        public List<EmployeeModel> GetAll(int pageNumber, int pageQuantity)
        {
            return _context.Employees.Skip(pageNumber * pageQuantity).Take(pageQuantity).ToList();
        }
    }
}
