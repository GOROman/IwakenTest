using System;

public class FibonacciSequence
{
    public static int Fibonacci(int n)
    {
        if (n < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(n), "Input must be a non-negative integer.");
        }
        if (n == 0)
        {
            return 0;
        }
        if (n == 1)
        {
            return 1;
        }

        int a = 0;
        int b = 1;
        for (int i = 2; i <= n; i++)
        {
            int temp = a + b;
            a = b;
            b = temp;
        }
        return b;
    }

    public static void Main(string[] args)
    {
        // Example usage
        Console.WriteLine($"Fibonacci(0) = {Fibonacci(0)}");
        Console.WriteLine($"Fibonacci(1) = {Fibonacci(1)}");
        Console.WriteLine($"Fibonacci(2) = {Fibonacci(2)}");
        Console.WriteLine($"Fibonacci(10) = {Fibonacci(10)}");

        try
        {
            Fibonacci(-1);
        }
        catch (ArgumentOutOfRangeException e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}
