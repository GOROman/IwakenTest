def fibonacci(n):
  """
  Calculates the nth Fibonacci number.

  Args:
    n: A non-negative integer.

  Returns:
    The nth Fibonacci number.

  Raises:
    ValueError: If n is negative.
  """
  if not isinstance(n, int):
    raise TypeError("Input must be an integer.")
  if n < 0:
    raise ValueError("Input must be a non-negative integer.")
  elif n == 0:
    return 0
  elif n == 1:
    return 1
  else:
    a, b = 0, 1
    for _ in range(2, n + 1):
      a, b = b, a + b
    return b

if __name__ == '__main__':
  # Example usage
  print(f"fibonacci(0) = {fibonacci(0)}")
  print(f"fibonacci(1) = {fibonacci(1)}")
  print(f"fibonacci(2) = {fibonacci(2)}")
  print(f"fibonacci(10) = {fibonacci(10)}")

  try:
    fibonacci(-1)
  except ValueError as e:
    print(f"Error: {e}")

  try:
    fibonacci(1.5)
  except TypeError as e:
    print(f"Error: {e}")
