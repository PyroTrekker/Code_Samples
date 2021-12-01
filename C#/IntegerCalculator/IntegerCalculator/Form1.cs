using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegerCalculator
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblEqualTo_Click(object sender, EventArgs e)
        {

        }

        private void txtRight_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int num1, num2;
            if ((txtLeft.Text == "") || (txtRight.Text == ""))
            {
                MessageBox.Show("Empty operand");
                txtLeft.Text = "";
                txtRight.Text = "";
                txtResult.Text = "";
                cmbOperator.SelectedIndex = -1;
            }
            else if (cmbOperator.SelectedIndex == -1)
            {
                MessageBox.Show("Missing operator");
                txtLeft.Text = "";
                txtRight.Text = "";
                txtResult.Text = "";
                cmbOperator.SelectedIndex = -1;
            }
            else if (((cmbOperator.SelectedIndex == 3) || (cmbOperator.SelectedIndex == 4)) && (txtRight.Text == "0"))
            {
                MessageBox.Show("Divide by zero");
                txtLeft.Text = "";
                txtRight.Text = "";
                txtResult.Text = "";
                cmbOperator.SelectedIndex = -1;
            }       
            else            
            {
                Int32.TryParse(txtLeft.Text, out num1);
                Int32.TryParse(txtRight.Text, out num2);

                switch (cmbOperator.SelectedIndex)
                {
                    case 0: 
                        txtResult.Text = (num1 + num2) + "";
                        break;
                    case 1: 
                        txtResult.Text = (num1 - num2) + "";
                        break;
                    case 2:
                        txtResult.Text = (num1 * num2) + "";
                        break;
                    case 3:
                        txtResult.Text = (num1 / num2) + "";
                        break;
                    case 4:
                        txtResult.Text = (num1 % num2) + "";
                        break;


                }
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtLeft.Text = "";
            txtRight.Text = "";
            txtResult.Text = "";
            cmbOperator.SelectedIndex = -1;
        }
    }
}
