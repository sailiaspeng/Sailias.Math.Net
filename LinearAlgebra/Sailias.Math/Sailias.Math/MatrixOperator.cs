using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sailias.Math
{
    /// <summary>
    /// 矩阵操作静态类
    /// </summary>
    public static class MatrixOperator
    {
        /// <summary>
        /// 求两个矩阵和和
        /// </summary>
        /// <param name="matrixA">矩阵A</param>
        /// <param name="matrixB">矩阵B</param>
        /// <returns></returns>
        public static Matrix SumOfMatrices(Matrix matrixA, Matrix matrixB)
        {
            if (matrixA.RowCount != matrixB.RowCount || matrixA.ColCount != matrixB.ColCount)
            {
                throw new MatrixAdditionException();
            }
            else
            {
                double[] result = new double[matrixA.RowCount * matrixA.ColCount];
                int length = 0;
                for (int i = 0; i < matrixA.RowCount; i++)
                {
                    for (int j = 0; j < matrixA.ColCount; j++)
                    {
                        result[length] = matrixA.Value[i][j] + matrixB.Value[i][j];
                        length++;
                    }
                }
                return new Matrix(matrixA.RowCount, matrixA.ColCount, result);
            }
        }
        /// <summary>
        /// 多个矩阵求和
        /// </summary>
        /// <param name="matrices">矩阵集合</param>
        /// <returns></returns>
        public static Matrix SumOfMatrices(IEnumerable<Matrix> matrices)
        {
            if (matrices.Count() > 0)
            {
                for (int k = 0; k < matrices.Count(); k++)
                {
                    if (k + 1 < matrices.Count())
                    {
                        if (matrices.ElementAt(k).RowCount != matrices.ElementAt(k + 1).RowCount || matrices.ElementAt(k).ColCount != matrices.ElementAt(k + 1).ColCount)
                        {
                            throw new MatrixAdditionException();
                        }
                    }
                }
            }
            else {
                return new Matrix(1, 1, new double[0]);
            }

            int rowcount = matrices.ElementAt(0).RowCount;
            int colcount = matrices.ElementAt(0).ColCount;
            double[] result = new double[matrices.ElementAt(0).RowCount * matrices.ElementAt(0).ColCount];
            int length = 0;
            for (int i = 0; i < rowcount; i++)
            {
                for (int j = 0; j < colcount; j++)
                {
                    for (int m = 0; m < matrices.Count(); m++)
                    {
                        result[length] += matrices.ElementAt(m).Value[i][j];
                    }
                    length++;
                }
            }
            return new Matrix(rowcount, colcount, result);
        }
        /// <summary>
        /// 两个矩阵求积
        /// </summary>
        /// <param name="matrixA"></param>
        /// <param name="matrixB"></param>
        /// <returns></returns>
        public static Matrix MultiplyMatrices(Matrix matrixA, Matrix matrixB)
        {
            if (matrixA == null || matrixB == null)
            {
                throw new MatrixNullException();
            }
            else if (matrixA.ColCount != matrixB.RowCount)
            {
                throw new MatrixMultiplicationException();
            }
            else
            {
                double[] result = new double[matrixA.RowCount * matrixB.ColCount];
                int length = 0;
               
                for (int i = 0; i < matrixA.RowCount;i++ )
                {
                    int k = 0;
                    for (int j = 0;  j < matrixB.RowCount; j++)
                    {
                        result[length]+=(matrixA.Value[i][j] * matrixB.Value[j][k]);
                        if(j+1== matrixB.RowCount&&k+1< matrixB.ColCount)
                        {
                            j = -1;
                            k++;
                            length++;
                        }
                       
                    }
                    length++;
                    //if ((length+1) % matrixA.ColCount == 0)
                    //    i++;

                }
                return new Matrix(matrixA.RowCount, matrixB.ColCount, result);

            }
        }

        public static Matrix MultiplyMatrices(Matrix matrix, double real)
        {
            if (matrix == null)
            {
                throw new MatrixNullException();
            }
            else
            {
                double[] result = new double[matrix.ColCount * matrix.RowCount];
                int length = 0;
                for (int i = 0; i < matrix.RowCount; i++)
                {
                    for (int j = 0; j < matrix.ColCount; j++)
                    {
                        result[length] = matrix.Value[i][j] * real;
                    }
                }
                return new Matrix(matrix.RowCount,matrix.ColCount, result);
            }
        }
    }
}
