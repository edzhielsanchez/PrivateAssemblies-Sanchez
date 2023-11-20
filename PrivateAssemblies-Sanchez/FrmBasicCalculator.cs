using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace PrivateAssemblies_Sanchez
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }
        float opperand1, opperand2;

        private void btnCompute_Click(object sender, EventArgs e)
        {
            float opperand1 = float.Parse(tbOpperand2.Text);
            float opperand2 = float.Parse(tbOpperand1.Text);

            if (cbOperator.Text == "+")
            {
                lblTotal.Text = "" + BasicComputation.Addition(opperand1, opperand2);
            }
            else if (cbOperator.Text == "-")
            {
                lblTotal.Text = "" + BasicComputation.Subtraction(opperand1, opperand2);
            }
            else if (cbOperator.Text == "*")
            {
                lblTotal.Text = "" + BasicComputation.Multiplication(opperand1, opperand2);
            }
            else if (cbOperator.Text == "/")
            {
                lblTotal.Text = "" + BasicComputation.Divition(opperand1, opperand2);
            }

        }

        private void FrmBasicCalculator_Load(object sender, EventArgs e)
        {
            cbOperator.Items.Add("+");
            cbOperator.Items.Add("-");
            cbOperator.Items.Add("*");
            cbOperator.Items.Add("/");

        }
    }
}
