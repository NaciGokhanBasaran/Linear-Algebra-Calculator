using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearAlgebraCalculatorr
{
    internal class LinearAlgebraFormulas
    {
        public static double Determinant(double[,] m)
        {
            return (m[0, 0] * m[1, 1] * m[2, 2] + (m[1, 0] * m[2, 1] * m[0, 2]) + (m[2, 0] * m[0, 1] * m[1, 2])) - (m[0, 2] * m[1, 1] * m[2, 0] + (m[1, 2] * m[2, 1] * m[0, 0]) + (m[2, 2] * m[0, 1] * m[1, 0]));


        }
        public static double[,] MatrixMultp(double[,] m1, double[,] m2)
        {
            double[,] newMatrix = new double[3, 3];
            int row1 = m1.GetLength(0);
            int column1 = m1.GetLength(1);
            int column2 = m2.GetLength(1);

            for (int i = 0; i < row1; i++)
            {
                for (int j = 0; j < column2; j++)
                {
                    for (int k = 0; k < column1; k++)
                    {
                        newMatrix[i, j] += m1[i, k] * m2[k, j];
                    }
                }
            }
            return newMatrix;
        }

        public static double[,] inverse(double[,] m)
        {

            return m;
        }

        public static double[,] ToRowEchelonForm(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int lead = 0;

            for (int r = 0; r < rows; r++)
            {
                if (lead >= cols)
                {
                    break;
                }
                    

                int i = r;
                while (matrix[i, lead] == 0)
                {
                    i++;
                    if (i == rows)
                    {
                        i = r;
                        lead++;
                        if (lead == cols)
                            return matrix;
                    }
                }

             
                if (i != r)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        double temp = matrix[r, j];
                        matrix[r, j] = matrix[i, j];
                        matrix[i, j] = temp;
                    }
                }

           
                double leadValue = matrix[r, lead];
                for (int j = 0; j < cols; j++)
                {
                    matrix[r, j] /= leadValue;
                }

              
                for (int k = 0; k < rows; k++)
                {
                    if (k != r)
                    {
                        double factor = matrix[k, lead];
                        for (int j = 0; j < cols; j++)
                        {
                            matrix[k, j] -= factor * matrix[r, j];
                        }
                    }
                }

                lead++;
            }

            return matrix;
        }



    }
}
