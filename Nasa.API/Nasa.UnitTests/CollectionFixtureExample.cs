using System;
using Xunit;
using Xunit.Abstractions;

namespace Nasa.UnitTests;

public class DatabaseFixtureExample : IDisposable
{
    public Guid? SomeConnectionToDatabase { get; set; }
    
    // SetUp
    public DatabaseFixtureExample()
    {
        SomeConnectionToDatabase = Guid.NewGuid();
    }

    // TearDown
    public void Dispose()
    {
        SomeConnectionToDatabase = null;
    }
}

[CollectionDefinition("Database collection")]
public class CollectionFixtureExample : ICollectionFixture<DatabaseFixtureExample>
{
    // This class has no code, and is never created. Its purpose is simply
    // to be the place to apply [CollectionDefinition] and all the
    // ICollectionFixture<> interfaces.
}

[Collection("Database collection")]
public class CollectionFixtureTestsExample
{
    DatabaseFixtureExample fixture;
    private readonly ITestOutputHelper testOutputHelper;

    public CollectionFixtureTestsExample(DatabaseFixtureExample fixture, ITestOutputHelper testOutputHelper)
    {
        this.fixture = fixture;
        this.testOutputHelper = testOutputHelper;
    }
    
    [Fact]
    public void Test1()
    {
        testOutputHelper.WriteLine(fixture.SomeConnectionToDatabase.ToString());
        testOutputHelper.WriteLine($"{nameof(CollectionFixtureTestsExample)} {nameof(Test1)}");
    }

    [Fact]
    public void Test2()
    {
        testOutputHelper.WriteLine(fixture.SomeConnectionToDatabase.ToString());
        testOutputHelper.WriteLine($"{nameof(CollectionFixtureTestsExample)} {nameof(Test2)}");
    }
}

[Collection("Database collection")]
public class CollectionFixtureTestsExample2
{
    DatabaseFixtureExample fixture;
    private readonly ITestOutputHelper testOutputHelper;

    public CollectionFixtureTestsExample2(DatabaseFixtureExample fixture, ITestOutputHelper testOutputHelper)
    {
        this.fixture = fixture;
        this.testOutputHelper = testOutputHelper;
    }
    
    [Fact]
    public void Test1()
    {
        testOutputHelper.WriteLine(fixture.SomeConnectionToDatabase.ToString());
        testOutputHelper.WriteLine($"{nameof(CollectionFixtureTestsExample2)} {nameof(Test1)}");
    }

    [Fact]
    public void Test2()
    {
        testOutputHelper.WriteLine(fixture.SomeConnectionToDatabase.ToString());
        testOutputHelper.WriteLine($"{nameof(CollectionFixtureTestsExample2)} {nameof(Test2)}");
    }
}