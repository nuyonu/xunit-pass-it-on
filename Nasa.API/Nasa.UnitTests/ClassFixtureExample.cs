using System;
using Xunit;
using Xunit.Abstractions;

namespace Nasa.UnitTests;

public sealed class ClassFixtureExample : IDisposable
{
    public Guid? SomeConnectionToDatabase { get; set; }
    
    // SetUp For All tests from a class
    public ClassFixtureExample()
    {
        SomeConnectionToDatabase = Guid.NewGuid();
    }

    // TearDown from all tests from a class
    public void Dispose()
    {
        SomeConnectionToDatabase = null;
    }
}

public class ClassFixtureTestsExample : IClassFixture<ClassFixtureExample>
{
    private readonly ClassFixtureExample classFixtureExample;
    private readonly ITestOutputHelper testOutputHelper;

    public ClassFixtureTestsExample(ClassFixtureExample classFixtureExample, ITestOutputHelper testOutputHelper)
    {
        this.classFixtureExample = classFixtureExample;
        this.testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void Test1()
    {
        testOutputHelper.WriteLine(classFixtureExample.SomeConnectionToDatabase.ToString());
        testOutputHelper.WriteLine("Test1.");
    }

    [Fact]
    public void Test2()
    {
        testOutputHelper.WriteLine(classFixtureExample.SomeConnectionToDatabase.ToString());
        testOutputHelper.WriteLine("Test2.");
    }
}

/// <summary>
/// Without class fixture
/// </summary>
public class BaseTestsClass : IDisposable
{
    public Guid? SomeConnectionToDatabase { get; set; }
    
    public BaseTestsClass()
    {
        SomeConnectionToDatabase = Guid.NewGuid();
    }

    public void Dispose()
    {
        SomeConnectionToDatabase = null;
    }
}

public class TestsWithoutClassFixtureExample : BaseTestsClass
{
    private readonly ITestOutputHelper testOutputHelper;

    public TestsWithoutClassFixtureExample(ITestOutputHelper testOutputHelper)
    {
        this.testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void Test1()
    {
        testOutputHelper.WriteLine(SomeConnectionToDatabase.ToString());
        testOutputHelper.WriteLine("Test1.");
    }

    [Fact]
    public void Test2()
    {
        testOutputHelper.WriteLine(SomeConnectionToDatabase.ToString());
        testOutputHelper.WriteLine("Test2.");
    }
}