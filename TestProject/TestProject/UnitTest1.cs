namespace TestProject;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(true);
    }
    
    [Fact]
    public void FalseIsFalseandStringIsEmpty()
    {
        Assert.False(!true);
        Assert.Empty("");
    }
}
