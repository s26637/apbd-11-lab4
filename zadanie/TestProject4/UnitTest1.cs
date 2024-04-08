using LegacyApp;

namespace TestProject4;

public class UnitTest1
{
    [Fact]
    public void TestMail()
    {
        var userService = new UserService();

        var result = userService.AddUser(
            "Marek",
            "Pawlak",
            "mail123mailcom",
            DateTime.Parse("2000-05-05"),
            1);
        Assert.False(result);
    }
    
    [Fact]
    public void TestFirstNameIsEmpty()
    {
        var userService = new UserService();

        var result = userService.AddUser(
            null,
            "Pawlak",
            "mail123mailcom",
            DateTime.Parse("2000-05-05"),
            1);
        Assert.False(result);
    }
    
    [Fact]
    public void TestLastNameIsEmpty()
    {
        var userService = new UserService();

        var result = userService.AddUser(
            "Marek",
            null,
            "mail123mailcom",
            DateTime.Parse("2000-05-05"),
            1);
        Assert.False(result);
    }
    

    [Fact]
    public void TestAge()
    {
        var userService = new UserService();

        var result = userService.AddUser(
            "Marek",
            "Pawlak",
            "mail123@mail.com",
            DateTime.Parse("2005-05-05"),
            1);
        
        Assert.False(result);
    }
}