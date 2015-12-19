using MVC_CodeFirst.Infrastructure;
using MVCCodeFirst.Data;
using System.Data.Entity;

namespace MVCCodeFirst.Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private SampleContext dataContext;

        public string ConnectionString { get; set; }

        public DbContext Get()
        {
            return dataContext ?? (dataContext = new SampleContext(ConnectionString));
        }
        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}
