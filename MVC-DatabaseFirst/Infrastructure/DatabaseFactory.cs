using MVCDatabaseFirst.Data;
using System.Data.Entity;
using MVC;

namespace MVCDatabaseFirst.Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private dbMVCSampleEntities dataContext;
        public DbContext Get()
        {
            return dataContext ?? (dataContext = new dbMVCSampleEntities());
        }
        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}
