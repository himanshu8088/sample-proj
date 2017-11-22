using Epf.Core.Data;
using Epf.Core.Manager;
using Epf.Core.Model;
using Epf.Core.Validator;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

namespace Epf.Core.Tests
{
    public class EmployeeValidatorTest
    {
        [Fact]
        public void Validate_ShouldSuccess_WhenValidInput()
        {
            var employee = new Employee() {
                Name="DS",
                Age=23
            };

            EmployeeValidator employeeValidator = new EmployeeValidator();
            var validationResult=employeeValidator.Validate(employee);

            Assert.True(validationResult.IsValid);
        }
        
    }
}








//var options = new DbContextOptionsBuilder<AccountContext>()
//                           .UseInMemoryDatabase("accountDb")
//                           .Options;

//var account1 = new Account()
//{

//};

//            using (var accountContext = new AccountContext(options))
//            {
//                AccountManager accountManager = new AccountManager(accountContext);
//accountManager.Add(account1);
//            }