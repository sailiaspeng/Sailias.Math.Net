using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sailias.Math;

namespace TestForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public Matrix MatrixA;
        public Matrix MatrixB;
        public void SetMatrixAB()
        {
            int row = int.Parse(this.rowInput1.Text);
            int col = int.Parse(this.colInput1.Text);
            string valueText = this.valueInput1.Text.ToString();
            MatrixA = InitMatrix(row, col, valueText);
            DisplayMatrix(MatrixA, this.Atext);
            int row2 = int.Parse(this.rowInput2.Text);
            int col2 = int.Parse(this.colInput2.Text);
            string valueText2 = this.valueInput2.Text.ToString();
            MatrixB = InitMatrix(row2, col2, valueText2);
            DisplayMatrix(MatrixB, this.Btext);
        }
        public void DisplayMatrix(Matrix matrix,RichTextBox control)
        {
            control.Clear();
            for (int j = 0; j < matrix.RowCount; j++)
            {
                if (j > 0)
                   control.Text += "\n";
                for (int k = 0; k < matrix.ColCount; k++)
                {
                    if (k != matrix.ColCount - 1)
                        control.Text += matrix.Value[j][k] + ",";
                    else control.Text += matrix.Value[j][k];
                }

            }
        }
        public Matrix InitMatrix(int row,int col,string valueText)
        {
            string[] values = valueText.Split(',');
            double[] relValues = new double[values.Length];
            int i = 0;
            foreach (var item in values)
            {
                relValues[i] = double.Parse(item);
                i++;
            }
            return  new Matrix(row, col, relValues);
        }
        private void AdditionBtn_Click(object sender, EventArgs e)
        {
            SetMatrixAB();
            //MatrixResult = MatrixOperator.SumOfMatrices(MatrixA, MatrixB);
            Matrix MatrixResult = MatrixA.Add(MatrixB);
            DisplayMatrix(MatrixResult, resultText);
            
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            SetMatrixAB();
            Matrix MatrixResult = MatrixOperator.MultiplyMatrices(MatrixA, MatrixB);
            DisplayMatrix(MatrixResult, resultText);
        }

        private void TransformBtn_Click(object sender, EventArgs e)
        {
            SetMatrixAB();
        }

        private void RankBtn_Click(object sender, EventArgs e)
        {
            SetMatrixAB();
        }
    }
}
