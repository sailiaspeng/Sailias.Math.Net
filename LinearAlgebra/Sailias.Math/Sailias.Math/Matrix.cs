using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sailias.Math
{
    public class Matrix
    {
        /// <summary>
        /// 矩阵构造方法，如a[0][0]=1,a[0][1]=2,a[1][0]=-1,a[1][1]=1 格式为Matrix(2,2,[1,2,-1,1]) 若值不够，则默认填充0
        /// </summary>
        /// <param name="RowCount"></param>
        /// <param name="ColCount"></param>
        /// <param name="values"></param>
        public Matrix(int RowCount,int ColCount, double[] values){
            this._rowCount = RowCount;
            this._colCount = ColCount;
            this._value = new double[RowCount][];
          //  this._value[this.RowCount] =new double[this._colCount];
            int length = 0;
            for (int i = 0; i < RowCount; i++)
            {
                this._value[i] = new double[ColCount];
                for (int j = 0; j < ColCount; j++)
                {
                    if (values.Length > length)
                        this._value[i][j] = values[length];
                    else this._value[i][j] = 0;
                    length++;
                }
            }
        }
        private int _rowCount;
        /// <summary>
        /// 矩阵的行数
        /// </summary>
        public int RowCount
        {
            get
            {
                return this._rowCount;
            }
        }

        private int _colCount;
        /// <summary>
        /// 矩阵的列数 
        /// </summary>
        public int ColCount
        {
            get
            {
                return this._colCount;
            }
        }
        private double[][] _value;
        public double[][] Value
        {
            get
            {
                return this._value;
            }
        }
        private Matrix _rank;
        public Matrix Rank
        {
            get
            {
                return this._rank;
            }
        }
    }
}
