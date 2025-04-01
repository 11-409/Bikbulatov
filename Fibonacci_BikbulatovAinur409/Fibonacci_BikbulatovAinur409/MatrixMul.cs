using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_BikbulatovAinur409
{
    internal class MatrixMul
    {
        public static void MulMatrix(int[,] a, int[,] b, int[,] result)
        {
            int a00 = a[0, 0] * b[0, 0] + a[0, 1] * b[1, 0];
            int a01 = a[0, 0] * b[0, 1] + a[0, 1] * b[1, 1];
            int a10 = a[1, 0] * b[0, 0] + a[1, 1] * b[1, 0];
            int a11 = a[1, 0] * b[0, 1] + a[1, 1] * b[1, 1];

            result[0, 0] = a00;
            result[0, 1] = a01;
            result[1, 0] = a10;
            result[1, 1] = a11;
        }
    }
}
