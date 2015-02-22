using System;
using Project.Domain.Abstract;

namespace Project.Persistence
{
    public interface IUnitOfWork
    {
        IRepository<T> Repository<T>() where T : Info;  
        void Save();
    }
}
