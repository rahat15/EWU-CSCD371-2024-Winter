// TestProjectName.Tests
namespace ClassDemo.Tests;

// ClassNameTests
public class ProgramTests
{
    Program Program { get; set; }

    // Constructors run before every test
    public ProgramTests()
    {
        Program = TestInitialize();
    }

    int _InstanceCount = 0;

    private static Program TestInitialize()
    {
        return new Program();
    }

    [Theory]
    [InlineData("Inigo.Montoya", "goodpassword")]
    [InlineData("Princess.Buttercup", "goodpassword")]
    [InlineData("Count.Rugen", "goodpassword")]
    [InlineData("Wesley", "goodpassword")]
    [InlineData("Dread.Pirate.Roberts", "goodpassword")]
    // MethodUnderTest_ConditionUnderTest_ExpectedResult
    public void TryLogin_WithGoodPassword_SuccessfulLogin(string username, string password)
    {
        Assert.True(Program.TryLogin(username, password));
    }

    [Fact]
    // MethodUnderTest_ConditionUnderTest_ExpectedResult
    public void TryLogin_InigoMontoyaWithGoodPassword_SuccessfulLogin()
    {
        Assert.Equal(0, _InstanceCount);
        string username = "Inigo.Montoya";
        string password = "goodpassword";
        _InstanceCount++;

        Assert.True(Program.TryLogin(username, password));
    }

    [Fact]
    public void TryLogin_InigoMontoyaWithGoodPassword_FailedLogin()
    {
        Assert.Equal(0, _InstanceCount);
        _InstanceCount++;

        Assert.False(Program.TryLogin("Inigo.Montoya", "badpassword"));
    }

    [Fact]
    public void TryLogin_PrincessButtercupWithGoodPassword_SuccessfulLogin()
    {
        Assert.True(Program.TryLogin("Princess.Buttercup", "goodpassword"));
    }

    [Fact]
    public void Login_PrincessButtercupWithGoodPassword_SuccessfulLogin()
    {
        Program.Login(username: "Princess.Buttercup", password: "goodpassword");
    }

    [Fact]
    public void Login_PrincessButtercupWithBadPassword_FailedLogin()
    {
        Assert.Throws<InvalidOperationException>(
            () => Program.Login(username: "Princess.Buttercup", password: "badpassword"));
    }

    [Fact]
    public void Login_PrincessButtercupWithBadPasswordTryCatch_FailedLogin()
    {
        try
        {
            Program.Login(username: "Princess.Buttercup", password: "badpassword");
        }
        catch (InvalidOperationException)
        {
            return;
        }
        Assert.Fail("Exception not thrown for bad login.");
    }

}