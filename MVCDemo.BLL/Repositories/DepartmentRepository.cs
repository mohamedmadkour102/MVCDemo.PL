using Microsoft.EntityFrameworkCore;
using MVCDemo.BLL.Interfaces;
using MVCDemo.DAL.Data;
using MVCDemo.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCDemo.BLL.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly AppDbContext _dbContext1;
        public DepartmentRepository(AppDbContext dbContext) { 
            _dbContext1 = dbContext;
        }
            
        public int Add(Department department)
        {
            _dbContext1.Departments.Add(department); // Added state 
            return _dbContext1.SaveChanges();
        }

        public int Delete(Department department)
        {
            _dbContext1.Departments.Remove(department);
            return _dbContext1.SaveChanges();
        }

        public IEnumerable<Department> GetAll()
        {
            return _dbContext1.Departments.AsNoTracking().ToList(); // لاني عايز ارجعهم بس عملت نو تراكينج 
        }

        public Department GetById(int id)
        {
            var department = _dbContext1.Departments.Find(id);
            return department;
        }

        public int Update(Department department)
        {
            _dbContext1.Departments.Update(department);
            return _dbContext1.SaveChanges();
        }
    }
}
