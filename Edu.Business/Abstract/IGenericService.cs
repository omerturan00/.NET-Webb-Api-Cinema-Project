using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Business.Abstract
{
    public interface IGenericService<T> where T : class
    {
        List<T> TGetList();
        T TGetByFilter(Expression<Func<T, bool>> pradicate);
        T TGetById(int Id);
        void TCreate(T entity);
        void TUpdate(T entity);
        void TDelete(int Id);
        int TCount();
        int TFilteredCount(Expression<Func<T, bool>> pradicate);
        List<T> TFilteredList(Expression<Func<T, bool>> pradicate);
    }
}
