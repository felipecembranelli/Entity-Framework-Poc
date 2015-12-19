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
    public class EmployeeDepartmentHistoryRepository : Infrastructure.RepositoryBase<EmployeeDepartmentHistory>, IEmployeeDepartmentHistoryRepository
    {

        public EmployeeDepartmentHistoryRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {

        }

        public IList<EmployeeDepartmentHistory> GetByEmployee(int employeeId)
        {
            //var result = (base.GetAll().Where(e => e.BusinessEntityID == employeeId)).ToList();

            var result = this.DbSet.Where(e => e.BusinessEntityID == employeeId).ToList();

            return result;
        }

        public IList<EmployeeDepartmentHistory> GetByDepartment(int departmentId)
        {
            return (base.GetAll().Where(e => e.DepartmentID == departmentId)).ToList();

        }

        public IList<EmployeeDepartmentHistory> GetByDepartmentAndEmployee(int departmentId, int employeeId)
        {
            return (base.GetAll().Where(e => e.DepartmentID == departmentId && e.BusinessEntityID== employeeId)).ToList();

        }

        public object GetByDepartmentAndEmployeeFull(int departmentId, int employeeId)
        {
            //dbMVCSampleEntities dbCtx;

            //dbCtx = (dbMVCSampleEntities)this.DatabaseFactory.Get();

            //var result = (from h in dbCtx.EmployeeDepartmentHistory
            //              join e in dbCtx.Employee on h.BusinessEntityID equals e.BusinessEntityID
            //              where e.BusinessEntityID == employeeId && h.DepartmentID == departmentId
            //              select new { employeeNam = e.Person.FirstName, h.Department.Name }).ToList();

            return null;

        }

        public object GetByDepartmentAndEmployeeFull2(int departmentId, int employeeId)
        {
            var result = DbSet.Where(e => e.BusinessEntityID == employeeId && e.DepartmentID == departmentId)
                .Select(r => new { r.Employee.Person.FirstName, r.Department.Name }).ToList();
                                    

            return result;

        }

        public object GetByDepartmentAndEmployeeFull3(int departmentId, int employeeId)
        {
            //var result = DbSet.Where(e => e.BusinessEntityID == employeeId && e.DepartmentID == departmentId)
            //    .Select(r => new { r.Employee.Person.FirstName,
            //                       r.Department.Name,
            //                       r.Employee.BirthDate,
            //                       r.Employee.Person.EmailAddress
            //                    }
            //    ).ToList();


            //return result;

            return null;

        }
    }
}