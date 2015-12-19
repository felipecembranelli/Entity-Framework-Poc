using System;
using MVCCodeFirst.Data;
using System.Data.Entity;

namespace MVCCodeFirst.Data.Infrastructure
{
    public interface IDatabaseFactory : IDisposable
    {
        DbContext Get();
    }
}
