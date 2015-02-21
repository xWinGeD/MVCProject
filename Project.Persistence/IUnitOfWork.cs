﻿using System;

namespace Project.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<T> Repository<T>() where T : class;  
        void Save();
    }
}
