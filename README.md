# IwakenTest
This repository contains implementations of the Fibonacci sequence in various programming languages.

## Fibonacci Implementations

Below are the details for each language implementation, including how to run the code and its corresponding tests.

### Python

- **File:** `fibonacci.py`
  - Implements a `fibonacci(n)` function that calculates the nth Fibonacci number.
  - Includes basic error handling for negative and non-integer inputs.
  - Contains a `if __name__ == '__main__':` block with example usage.

- **Running the code:**
  ```bash
  python fibonacci.py
  ```

- **Test File:** `test_fibonacci.py`
  - Uses the `unittest` module to test the `fibonacci` function.
  - Covers cases like `fibonacci(0)`, `fibonacci(1)`, positive numbers, a larger number, negative input (expecting `ValueError`), and non-integer input (expecting `TypeError`).

- **Running the tests:**
  ```bash
  python -m unittest test_fibonacci.py
  ```

### C

- **File:** `fibonacci.c`
  - Implements an `int fibonacci(int n)` function that calculates the nth Fibonacci number.
  - Returns `-1` for negative inputs as a basic error indicator.
  - Includes a `main()` function with example usage.

- **Running the code (requires compilation):**
  First, compile the C code:
  ```bash
  gcc fibonacci.c -o fibonacci_c_executable
  ```
  Then, run the executable:
  ```bash
  ./fibonacci_c_executable
  ```

- **Test File:** `test_fibonacci.c`
  - Includes `fibonacci.c` and uses `assert.h` along with manual checks for testing.
  - The `main()` function in `test_fibonacci.c` serves as the test runner.
  - Tests cover `fibonacci(0)`, `fibonacci(1)`, positive numbers, a larger number, and negative input (expecting `-1`).

- **Running the tests (requires compilation):**
  First, compile the test code (which includes `fibonacci.c`):
  ```bash
  gcc test_fibonacci.c -o test_fibonacci_c_executable
  ```
  Then, run the test executable:
  ```bash
  ./test_fibonacci_c_executable
  ```
  The program will print "All X tests passed!" on success or indicate failures. It returns 0 on success and 1 on failure.

### C#

- **File:** `Fibonacci.cs`
  - Implements a `public static int Fibonacci(int n)` method within a `FibonacciSequence` class.
  - Throws an `ArgumentOutOfRangeException` for negative inputs.
  - Includes a `Main()` method with example usage.

- **Running the code (requires .NET SDK):**
  Assuming `Fibonacci.cs` is in the current directory:
  1. Create a simple console project if you don't have one:
     ```bash
     dotnet new console -n FibonacciDemo
     cp Fibonacci.cs FibonacciDemo/
     cd FibonacciDemo
     ```
  2. Run the code:
     ```bash
     dotnet run
     ```
     (This will compile and run `Fibonacci.cs` if it has a `Main` method.)

- **Test File:** `TestFibonacci.cs`
  - Uses MSTest framework attributes (`[TestClass]`, `[TestMethod]`, `[ExpectedException]`).
  - Tests cover `Fibonacci(0)`, `Fibonacci(1)`, positive numbers, a larger number, and negative input (expecting `ArgumentOutOfRangeException`).

- **Running the tests (requires .NET SDK and a test project):**
  1. Create a test project (if you haven't already for running the main code, you can create one specifically for tests):
     ```bash
     dotnet new mstest -n FibonacciTestsProject
     ```
  2. Add your `Fibonacci.cs` (the code to be tested) and `TestFibonacci.cs` (the test file) to this project. You might need to adjust namespaces or add a project reference if `Fibonacci.cs` is in a separate project.
     A common way is to have a solution with a library project for `Fibonacci.cs` and a test project for `TestFibonacci.cs`.
     For a simpler setup (assuming `Fibonacci.cs` and `TestFibonacci.cs` are in the same directory as the `.csproj` file of the test project):
     ```bash
     # Make sure Fibonacci.cs is in the test project directory or referenced correctly
     # cp ../Fibonacci.cs . # If it's one level up
     # cp ../TestFibonacci.cs . # If it's one level up
     ```
  3. Navigate to the test project directory:
     ```bash
     # cd FibonacciTestsProject # If you created it in the current directory
     ```
  4. Run the tests:
     ```bash
     dotnet test
     ```
This command will discover and execute tests in the project.
