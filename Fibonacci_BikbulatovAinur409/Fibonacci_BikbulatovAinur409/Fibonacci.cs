using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_BikbulatovAinur409
{
    internal class Fibonacci
    {
        public static int CountFibonacci(int n)
        {
            if (n == 0) return 0;

            int[,] matrix = { { 1, 1 }, { 1, 0 } };
            int[,] result = new int[2, 2];
            MatrixPow.PowMatrix(matrix, n - 1, result);

            return result[0, 0];
        }
    }
}
