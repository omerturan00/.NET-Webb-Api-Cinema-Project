using Edu.DataAccess.Abstract;
using Edu.DataAccess.DbContextes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Edu.DataAccess.Repositories
{
    public class GenericRepository<T>(EduContext _eduContext) : IRepository<T> where T : class
    {
        public DbSet<T> Table { get => _eduContext.Set<T>();}

        public int Count()
        {
            return Table.Count();
        }

        public void Create(T entity)
        {
            Table.Add(entity);
            _eduContext.SaveChanges();
        }

        public void Delete(int Id)
        {
            var entity = Table.Find(Id);
            Table.Remove(entity);
            _eduContext.SaveChanges();
        }

        public int FilteredCount(Expression<Func<T, bool>> pradicate)
        {
            return Table.Where(pradicate).Count();
        }

        public List<T> FilteredList(Expression<Func<T, bool>> pradicate)
        {
            return Table.Where(pradicate).ToList();
        }

        public T GetByFilter(Expression<Func<T, bool>> pradicate)
        {
            return Table.Where(pradicate).FirstOrDefault();
        }

        public T GetById(int Id)
        {
            return Table.Find(Id);
        }

        public List<T> GetList()
        {
            return Table.ToList();
        }

        public void Update(T entity)
        {
            Table.Update(entity);
            _eduContext.SaveChanges();
        }
    }
}
