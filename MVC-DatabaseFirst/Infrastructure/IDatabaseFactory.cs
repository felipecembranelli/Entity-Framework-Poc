using System;
using MVCDatabaseFirst.Data;
using System.Data.Entity;

namespace MVCDatabaseFirst.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        DbContext Get();
    }
}
