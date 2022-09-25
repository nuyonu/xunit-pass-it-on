using System;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Nasa.UnitTests;

public class SetupAndTeardownExample : IDisposable, IAsyncLifetime
{
    private readonly ITestOutputHelper testOutputHelper;

    public SetupAndTeardownExample(ITestOutputHelper testOutputHelper)
    {
        this.testOutputHelper = testOutputHelper;
        this.testOutputHelper.WriteLine("Constructor.");
    }

    [Fact]
    public void Test1()
    {
        testOutputHelper.WriteLine("Test 1.");
    }

    [Fact]
    public void Test2()
    {
        testOutputHelper.WriteLine("Test 2.");
    }
    
    public void Dispose()
    {
        testOutputHelper.WriteLine("Dispose.");
    }
    
    public async Task InitializeAsync()
    {
        testOutputHelper.WriteLine("InitializeAsync.");
    }

    async Task IAsyncLifetime.DisposeAsync()
    {
        testOutputHelper.WriteLine("DisposeAsync");
    }
}
