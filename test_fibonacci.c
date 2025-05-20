#include <stdio.h>
#include <assert.h>

// Include the fibonacci function directly or declare its signature
// If fibonacci.c is compiled separately, you would declare:
// extern int fibonacci(int n);
#include "fibonacci.c" // Assuming fibonacci.c is in the same directory

int main() {
    int tests_passed = 0;
    int tests_failed = 0;

    // Test cases
    // fibonacci(0) should return 0
    if (fibonacci(0) == 0) {
        tests_passed++;
    } else {
        tests_failed++;
        printf("Test failed: fibonacci(0) != 0\n");
    }

    // fibonacci(1) should return 1
    if (fibonacci(1) == 1) {
        tests_passed++;
    } else {
        tests_failed++;
        printf("Test failed: fibonacci(1) != 1\n");
    }

    // fibonacci(10) should return 55
    if (fibonacci(10) == 55) {
        tests_passed++;
    } else {
        tests_failed++;
        printf("Test failed: fibonacci(10) != 55\n");
    }

    // fibonacci(20) should return 6765
    if (fibonacci(20) == 6765) {
        tests_passed++;
    } else {
        tests_failed++;
        printf("Test failed: fibonacci(20) != 6765\n");
    }

    // fibonacci(-1) should return -1
    if (fibonacci(-1) == -1) {
        tests_passed++;
    } else {
        tests_failed++;
        printf("Test failed: fibonacci(-1) != -1\n");
    }

    // Using assert for some tests as an alternative
    assert(fibonacci(0) == 0);
    assert(fibonacci(1) == 1);
    assert(fibonacci(10) == 55);
    assert(fibonacci(20) == 6765);
    assert(fibonacci(-1) == -1);
    // If using asserts, the program will terminate on failure. 
    // The manual checks above provide a summary.
    // For a more robust test runner with asserts, you'd typically run each in a separate process
    // or use a testing framework. The current structure with manual checks and then asserts
    // means asserts will only run if manual checks pass (or rather, don't cause termination).
    // For this task, let's assume the above manual checks are primary for reporting.

    // Summary
    if (tests_failed == 0) {
        printf("All %d tests passed!\n", tests_passed);
    } else {
        printf("%d tests passed.\n", tests_passed);
        printf("%d tests failed.\n", tests_failed);
    }

    // Compilation instructions:
    // gcc fibonacci.c test_fibonacci.c -o test_fibonacci
    // Or if fibonacci.c is already compiled into an object file (e.g., fibonacci.o):
    // gcc fibonacci.o test_fibonacci.c -o test_fibonacci
    // To run: ./test_fibonacci

    return tests_failed == 0 ? 0 : 1; // Return 0 on success, 1 on failure
}
