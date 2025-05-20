#include <stdio.h>

int fibonacci(int n) {
  if (n < 0) {
    return -1; // Error case for negative input
  } else if (n == 0) {
    return 0;
  } else if (n == 1) {
    return 1;
  } else {
    int a = 0;
    int b = 1;
    int temp;
    for (int i = 2; i <= n; i++) {
      temp = a + b;
      a = b;
      b = temp;
    }
    return b;
  }
}

int main() {
  // Example usage
  printf("fibonacci(0) = %d\n", fibonacci(0));
  printf("fibonacci(1) = %d\n", fibonacci(1));
  printf("fibonacci(2) = %d\n", fibonacci(2));
  printf("fibonacci(10) = %d\n", fibonacci(10));
  printf("fibonacci(-1) = %d\n", fibonacci(-1)); // Test error case
  return 0;
}
