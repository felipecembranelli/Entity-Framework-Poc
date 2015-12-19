using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCCodeFirst.Data.Repository;
using System.Data.Entity.Core.EntityClient;
using MVCCodeFirst.Data.Infrastructure;
using System.Collections.Generic;
using MVC_CodeFirst;

namespace EFTests
{
    [TestClass]
    public class EmployeeCodeFirstTest
    {
        private DatabaseFactory db;

        [TestInitialize]
        public void Initialize()
        {
            db = new DatabaseFactory();
            db.ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["CodeFirstConnection"].ConnectionString;
        }

        [TestMethod]
        public void CodeFirst_EmployeeRepository_GetAll_ReturnsAllEmployees()
        {
            //Arrange
            EmployeeRepository objRepo;
            
            objRepo = new EmployeeRepository(db);

            //Act
            var result = objRepo.GetAll();

            //Assert
            Assert.IsNotNull(result);
        }
        
        [TestMethod]
        public void CodeFirst_EmployeeDepartmentHistoryRepository_GetAll_ReturnsAllEmployeeDeptHistory()
        {
            //Arrange
            EmployeeDepartmentHistoryRepository objRepo;

            objRepo = new EmployeeDepartmentHistoryRepository(db);

            objRepo.Log = Console.Write;

            //Act
            var result = objRepo.GetAll();

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CodeFirst_EmployeeDepartmentHistoryRepository_GetByEmployeeId_ReturnsAllEmployeeDeptHistory()
        {
            //Arrange
            EmployeeDepartmentHistoryRepository objRepo;

            objRepo = new EmployeeDepartmentHistoryRepository(db);

            objRepo.Log = Console.Write;

            //Act
            var result = objRepo.GetByEmployee(1);

            //Assert
            Assert.IsTrue(result.Count > 0);
        }

        [TestMethod]
        public void CodeFirst_EmployeeDepartmentHistoryRepository_GetByDeptId_ReturnsAllEmployeeDeptHistory()
        {
            //Arrange
            EmployeeDepartmentHistoryRepository objRepo;

            objRepo = new EmployeeDepartmentHistoryRepository(db);

            
            objRepo.Log = Console.Write;

            //Act
            var result = objRepo.GetByDepartment(2);

            //Assert
            Assert.IsTrue(result.Count > 0);
        }

        [TestMethod]
        public void CodeFirst_EmployeeDepartmentHistoryRepository_GetByDeptIdAndEmpId_ReturnsAllEmployeeDeptHistory()
        {
            //Arrange
            EmployeeDepartmentHistoryRepository objRepo;

            objRepo = new EmployeeDepartmentHistoryRepository(db);

            objRepo.Log = Console.Write;

            //Act
            var result = objRepo.GetByDepartmentAndEmployee(16,1);

            //Assert
            Assert.IsTrue(result.Count > 0);
        }

        [TestMethod]
        public void CodeFirst_EmployeeDepartmentHistoryRepository_GetByDeptIdAndEmpId_ReturnsAllEmployeeDeptHistoryFull()
        {
            //Arrange
            EmployeeDepartmentHistoryRepository objRepo;

            objRepo = new EmployeeDepartmentHistoryRepository(db);

            objRepo.Log = Console.Write;

            //Act
            var result1 = objRepo.GetByDepartmentAndEmployeeFull(16, 1);
            var result2 = objRepo.GetByDepartmentAndEmployeeFull2(16, 1);
            var result3 = objRepo.GetByDepartmentAndEmployeeFull3(16, 1);

            //Assert
        }
    }
}
