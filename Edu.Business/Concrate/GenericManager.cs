using Edu.Business.Abstract;
using Edu.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Business.Concrate
{
    public class GenericManager<T>(IRepository<T> _repository) : IGenericService<T> where T : class
    {
        public int TCount()
        {
            return _repository.Count();
        }

        public void TCreate(T entity)
        {
            _repository.Create(entity);
        }

        public void TDelete(int Id)
        {
            _repository.Delete(Id);
        }

        public int TFilteredCount(Expression<Func<T, bool>> pradicate)
        {
            return _repository.FilteredCount(pradicate);
        }

        public List<T> TFilteredList(Expression<Func<T, bool>> pradicate)
        {
            return _repository.FilteredList(pradicate);
        }

        public T TGetByFilter(Expression<Func<T, bool>> pradicate)
        {
            return _repository.GetByFilter(pradicate);
        }

        public T TGetById(int Id)
        {
            return _repository.GetById(Id);
        }

        public List<T> TGetList()
        {
            return _repository.GetList();
        }

        public void TUpdate(T entity)
        {
             _repository.Update(entity);
        }
    }
}
