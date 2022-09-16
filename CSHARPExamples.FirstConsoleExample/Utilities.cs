using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPExamples.FirstConsoleExample {
    public class Utilities {
        public static int Greatest(int first, int second) {
            if (first > second)
                return first;
            else if (second > first)
                return second;
            return first;
        }

        public static void Swap(ref int firstParameter, ref int secondParameter) {
            int temp = firstParameter;
            firstParameter = secondParameter;
            secondParameter = temp;
        }

        public static int Factorial(int n) {
            int result = 1;
            for (int i = 1; i <= n; i++) {
                result *= i;
            }
            return result;
        }

        public static int FactorialRecursive(int n) 
        {
            int total = n;
            return run(n);

            int run(int n) {
                if (n == 1) {
                    return total;
                }
                total *= (n-1);
                return run(n - 1);
            }
        }

        public static int FactorialRecursiveRecursive(int n) {
            if (n == 1) {
                return 1;
            }
            return n * FactorialRecursiveRecursive(n - 1);
        }
    }
}
