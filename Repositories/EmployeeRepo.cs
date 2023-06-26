using FirstApp.Database;
using FirstApp.Models;

namespace FirstApp.Repositories
{
    public interface IEmployeeRepo
    {
        void Create(Employee employee);
        void Delete(Employee employee);
        void Update(Employee employee);
        List<Employee> GetAll();
        Employee? Get(int id);
    }

    public class EmployeeRepo : IEmployeeRepo
    {
        AppDbContext _dbContext;
        public EmployeeRepo(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Employee> GetAll()
        {
            return _dbContext.Employees.ToList();
        }

        public Employee? Get(int id)
        {
            return _dbContext.Employees.Find(id);
        }

        public void Update(Employee employee)
        {
            _dbContext.Employees.Update(employee);
            _dbContext.SaveChanges();
        }

        public void Create(Employee employee)
        {
            _dbContext.Add(employee);
            _dbContext.SaveChanges();
        }

        public void Delete(Employee employee)
        {
            _dbContext.Remove(employee);
            _dbContext.SaveChanges();
        }
    }
}
