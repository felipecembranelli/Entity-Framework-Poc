using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity.Core.EntityClient;
using System.Collections.Generic;
using MVCDatabaseFirst.Data.Repository;
using MVCDatabaseFirst.Data.Infrastructure;

namespace EFTests
{
    [TestClass]
    public class EmployeeDatabaseFirstTest
    {

        [TestInitialize]
        public void Initialize()
        {

            
        }

        [TestMethod]
        public void DbFirst_EmployeeRepository_GetAll_ReturnsAllEmployees()
        {
            //Arrange
            EmployeeRepository objRepo;
            objRepo = new EmployeeRepository(new DatabaseFactory());

            //Act
            var result = objRepo.GetAll();

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void DbFirst_EmployeeDepartmentHistoryRepository_GetAll_ReturnsAllEmployeeDeptHistory()
        {
            //Arrange
            EmployeeDepartmentHistoryRepository objRepo;

            objRepo = new EmployeeDepartmentHistoryRepository(new DatabaseFactory());

            objRepo.Log = Console.Write;

            //Act
            var result = objRepo.GetAll();

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void DbFirst_EmployeeDepartmentHistoryRepository_GetByEmployeeId_ReturnsAllEmployeeDeptHistory()
        {
            //Arrange
            EmployeeDepartmentHistoryRepository objRepo;

            objRepo = new EmployeeDepartmentHistoryRepository(new DatabaseFactory());

            objRepo.Log = Console.Write;

            //Act
            var result = objRepo.GetByEmployee(1);

            //Assert
            Assert.IsTrue(result.Count > 0);
        }

        [TestMethod]
        public void DbFirst_EmployeeDepartmentHistoryRepository_GetByDeptId_ReturnsAllEmployeeDeptHistory()
        {
            //Arrange
            EmployeeDepartmentHistoryRepository objRepo;

            objRepo = new EmployeeDepartmentHistoryRepository(new DatabaseFactory());

            
            objRepo.Log = Console.Write;

            //Act
            var result = objRepo.GetByDepartment(2);

            //Assert
            Assert.IsTrue(result.Count > 0);
        }

        [TestMethod]
        public void DbFirst_EmployeeDepartmentHistoryRepository_GetByDeptIdAndEmpId_ReturnsAllEmployeeDeptHistory()
        {
            //Arrange
            EmployeeDepartmentHistoryRepository objRepo;

            objRepo = new EmployeeDepartmentHistoryRepository(new DatabaseFactory());

            objRepo.Log = Console.Write;

            //Act
            var result = objRepo.GetByDepartmentAndEmployee(16,1);

            //Assert
            Assert.IsTrue(result.Count > 0);
        }

        [TestMethod]
        public void DbFirst_EmployeeDepartmentHistoryRepository_GetByDeptIdAndEmpId_ReturnsAllEmployeeDeptHistoryFull()
        {
            //Arrange
            EmployeeDepartmentHistoryRepository objRepo;

            objRepo = new EmployeeDepartmentHistoryRepository(new DatabaseFactory());

            objRepo.Log = Console.Write;

            //Act
            var result1 = objRepo.GetByDepartmentAndEmployeeFull(16, 1);
            var result2 = objRepo.GetByDepartmentAndEmployeeFull2(16, 1);
            var result3 = objRepo.GetByDepartmentAndEmployeeFull3(16, 1);

            //Assert
        }
    }
}
