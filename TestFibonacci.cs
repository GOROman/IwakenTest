using System;
using Microsoft.VisualStudio.TestTools.UnitTesting; // Assuming MSTest framework

// Assuming FibonacciSequence class is in Fibonacci.cs and will be compiled alongside
// If it's in a separate assembly, a reference would be needed.
// For simplicity here, we assume it's available.

[TestClass]
public class FibonacciTests
{
    [TestMethod]
    public void TestFibonacci_Zero()
    {
        Assert.AreEqual(0, FibonacciSequence.Fibonacci(0));
    }

    [TestMethod]
    public void TestFibonacci_One()
    {
        Assert.AreEqual(1, FibonacciSequence.Fibonacci(1));
    }

    [TestMethod]
    public void TestFibonacci_Positive()
    {
        Assert.AreEqual(55, FibonacciSequence.Fibonacci(10));
    }

    [TestMethod]
    public void TestFibonacci_LargeNumber()
    {
        Assert.AreEqual(6765, FibonacciSequence.Fibonacci(20));
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentOutOfRangeException))]
    public void TestFibonacci_NegativeInput()
    {
        FibonacciSequence.Fibonacci(-1);
    }

    [TestMethod]
    public void TestFibonacci_NegativeInput_WithMessageVerification() // More specific test
    {
        try
        {
            FibonacciSequence.Fibonacci(-5);
            Assert.Fail("Expected ArgumentOutOfRangeException was not thrown.");
        }
        catch (ArgumentOutOfRangeException ex)
        {
            // Optionally, verify the parameter name or part of the message
            Assert.IsTrue(ex.Message.Contains("Input must be a non-negative integer."));
            Assert.AreEqual("n", ex.ParamName); // Check if the parameter name is correct
        }
    }
}

// How to compile and run (example using .NET CLI):
// 1. Ensure you have the .NET SDK installed.
// 2. Create a project: `dotnet new mstest -n FibonacciProject` (this creates a test project)
// 3. Add your Fibonacci.cs (or ensure FibonacciSequence class is part of the project)
//    and TestFibonacci.cs files to this project.
// 4. Navigate to the project directory in the terminal.
// 5. Run tests: `dotnet test`
//
// If Fibonacci.cs is a separate file not part of a project, you might compile manually:
// csc /target:library Fibonacci.cs
// csc /reference:Fibonacci.dll /target:library TestFibonacci.cs /r:"path_to_mstest_framework.dll"
// (Manual compilation for tests is complex due to framework dependencies, `dotnet test` is preferred)
