import unittest
from fibonacci import fibonacci # Assuming fibonacci.py is in the same directory or PYTHONPATH

class TestFibonacci(unittest.TestCase):

    def test_fibonacci_zero(self):
        self.assertEqual(fibonacci(0), 0)

    def test_fibonacci_one(self):
        self.assertEqual(fibonacci(1), 1)

    def test_fibonacci_positive(self):
        self.assertEqual(fibonacci(10), 55)

    def test_fibonacci_large_number(self):
        self.assertEqual(fibonacci(20), 6765)

    def test_fibonacci_negative_input(self):
        with self.assertRaises(ValueError):
            fibonacci(-1)

    def test_fibonacci_non_integer_input(self):
        with self.assertRaises(TypeError):
            fibonacci(1.5)

if __name__ == '__main__':
    unittest.main()
