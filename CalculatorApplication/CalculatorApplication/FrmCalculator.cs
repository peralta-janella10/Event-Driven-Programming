using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {

        CalculatorClass cal;

        public FrmCalculator()
        {
            InitializeComponent();

            cal = new CalculatorClass();

            cbOperator.Items.Clear();
            cbOperator.Items.Add("+");
            cbOperator.Items.Add("-");
            cbOperator.Items.Add("*");
            cbOperator.Items.Add("/");
            cbOperator.SelectedIndex = 0;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtFirstNumber.Text);
            double num2 = Convert.ToDouble(txtSecondNumber.Text);

            string op = cbOperator.SelectedItem.ToString();

            switch (op)
            {
                case "+":
                    cal.CalculateEvent += cal.GetSum;
                    break;
                case "-":
                    cal.CalculateEvent += cal.GetDifference;
                    break;
                case "*":
                    cal.CalculateEvent += cal.GetProduct;
                    break;
                case "/":
                    cal.CalculateEvent += cal.GetQuotient;
                    break;
            }

            var total = cal.RaiseCalculateEvent(num1, num2);
            lblAnswer.Text = total.ToString();

            switch (op)
            {
                case "+":
                    cal.CalculateEvent -= cal.GetSum;
                    break;
                case "-":
                    cal.CalculateEvent -= cal.GetDifference;
                    break;
                case "*":
                    cal.CalculateEvent -= cal.GetProduct;
                    break;
                case "/":
                    cal.CalculateEvent -= cal.GetQuotient;
                    break;
            }
        }
    }
}
