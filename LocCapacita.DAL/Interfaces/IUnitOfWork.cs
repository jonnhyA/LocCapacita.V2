using System;
using System.Data.Entity;


namespace LocCapacita.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {

        DbContext Context { get; }
        void Commit();
    }
}
