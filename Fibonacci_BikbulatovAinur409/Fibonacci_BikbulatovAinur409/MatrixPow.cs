using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci_BikbulatovAinur409
{
    internal class MatrixPow
    {
        public static void PowMatrix(int[,] matrix, int power, int[,] result)
        {
            int[,] temp = new int[2, 2];
            result[0, 0] = 1;
            result[0, 1] = 0;
            result[1, 0] = 0;
            result[1, 1] = 1;

            while (power > 0)
            {
                if ((power & 1) == 1)
                {
                    MatrixMul.MulMatrix(result, matrix, temp);
                    result[0, 0] = temp[0, 0];
                    result[0, 1] = temp[0, 1];
                    result[1, 0] = temp[1, 0];
                    result[1, 1] = temp[1, 1];
                }
                MatrixMul.MulMatrix(matrix, matrix, temp);
                matrix[0, 0] = temp[0, 0];
                matrix[0, 1] = temp[0, 1];
                matrix[1, 0] = temp[1, 0];
                matrix[1, 1] = temp[1, 1];
                power /= 2;
            }
        }
    }
}
