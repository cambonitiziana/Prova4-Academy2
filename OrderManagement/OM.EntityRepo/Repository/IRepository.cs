using OM.EntityRepo.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace OM.EntityRepo.Repository
{
    public interface IRepository<T> where T: IEntity
    {
        bool Create(T item);
        bool Update(T item);
        bool Delete(T item);
        T GetById(int id);

        IEnumerable<T> GetAll();

       
    }
}
