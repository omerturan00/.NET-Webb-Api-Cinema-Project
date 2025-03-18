using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Edu.DataAccess.Abstract
{
    public interface IRepository<T> where T : class
    {
        List<T> GetList();
        T GetByFilter(Expression<Func<T, bool>> pradicate);
        T GetById(int Id);
        void Create(T entity);
        void Update(T entity);
        void Delete(int Id);
        int Count();
        int FilteredCount(Expression<Func<T, bool>> pradicate);
        List<T> FilteredList(Expression<Func<T, bool>> pradicate);


    }
}
