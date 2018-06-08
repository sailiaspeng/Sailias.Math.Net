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
        public Matrix TextMatix;
        private void button1_Click(object sender, EventArgs e)
        {
            this.richTextBox1.Clear();
            int row = int.Parse(this.rowInput.Text);
            int col = int.Parse(this.colInput.Text);
            string valueText = this.valueInput.Text.ToString();
            string[] values = valueText.Split(',');
            double[] relValues = new double[values.Length];
            int i = 0;
            foreach (var item in values)
            {
                relValues[i] = double.Parse(item);
                i++;
            }
            TextMatix = new Matrix(row, col, relValues);
            for (int j = 0; j < TextMatix.RowCount; j++)
            {
                if (j > 0)
                    this.richTextBox1.Text += "\n";
                for (int k = 0; k < TextMatix.ColCount; k++)
                {
                    if (k != TextMatix.ColCount - 1)
                        this.richTextBox1.Text += TextMatix.Value[j][k] + ",";
                    else  this.richTextBox1.Text += TextMatix.Value[j][k];
                }

            }



        }
    }
}
