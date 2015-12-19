using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using MVCCodeFirst.Data.Infrastructure;
using MVC_CodeFirst.Models;

namespace MVCCodeFirst.Data.Repository
{
    public class EmployeeRepository : Infrastructure.RepositoryBase<Employee>, IEmployeeRepository
    {

        public EmployeeRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }
    }
}