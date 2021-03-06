﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCDatabaseFirst.Data.Infrastructure;
using MVC;

namespace MVCDatabaseFirst.Data.Repository
{
    
    public interface IEmployeeDepartmentHistoryRepository: IRepository<EmployeeDepartmentHistory>
    {
        IList<EmployeeDepartmentHistory> GetByEmployee(int employeeId);
    }
}
 