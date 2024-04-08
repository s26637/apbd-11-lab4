using System;
using Xunit;
using LegacyApp;

namespace TestProject3
{
    public class Tests
    {
        [Fact]
        public void Test1()
        {
            var userService = new UserService();

            var result = userService.AddUser(
                null,
                "Pawlak",
                "mail123@mail.com",
                DateTime.Parse("2005-05-05"),
                1);
            Assert.True(true);
        }
    }
}