/*
 *Hello Professor. I made one program that contain everything that was asked in the 2 excercise in one program Hope that is not a problem
 *Since 6.1, 7.1 and 7.2 were all the same i integrated a catch FormatException, an OverflowException, and a DivideByZeroException. 
 * i also created a method called  IsOperator that if the correct operator was use, and a IsValidData method that check if the user input is within the range that was given
 */


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleCAlculatorException_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
      
        private void button1_Click(object sender, EventArgs e)
        {
            try {            decimal numOne = Convert.ToInt32(txtBox1.Text);

            decimal numTwo = Convert.ToInt32(txtBox2.Text);
            char operand = Convert.ToChar(txtoperand.Text);
            decimal  result = 0;
      calculate( numOne,numTwo,  operand, result);
            }
            //this catch format exception
            catch (FormatException ex)
            {
                DialogResult dialogResult = MessageBox.Show(ex.Message);
                txtResult.Text = Convert.ToString(dialogResult);
            }
            catch (System.OverflowException ex) {
              DialogResult dialogResult = MessageBox.Show(ex.Message);
               txtResult.Text = Convert.ToString(dialogResult);
           }

        }

        //this call the calculate method and provide it with the user input
        private void calculate( decimal numOne, decimal numTwo, char operand, decimal result) 
        { 
            //this also check the operator the user enter
            try {

                    isOperator(numOne,numTwo,operand,result);

            }
            //this catch deivide by zero exception
            catch (System.DivideByZeroException ex)
            {
                DialogResult dialogResult = MessageBox.Show(ex.Message);
                txtResult.Text = Convert.ToString(dialogResult); }



        }


        //this check if the correct operator is use than call the other method (isValiddata) to chack if the input is within the range
        private void isOperator(decimal numOne, decimal numTwo, char operand, decimal result)
        {
            IsValidData(numOne, numTwo, operand, result);
        }
       private void  IsValidData (decimal numOne, decimal numTwo, char operand, decimal result)
        {
                if (numOne >= 0 && numOne <= 1000000 || numTwo >= 0 && numTwo <= 1000000)
                {
            if (operand == '+')
            {
                result = numOne + numTwo;
                txtResult.Text = Convert.ToString(result);
            }

            else if (operand == '-')

            {
                result = numOne - numTwo;
                txtResult.Text = Convert.ToString(result);
            }

            else if (operand == '/')

            {
                result = numOne / numTwo;
                txtResult.Text = Convert.ToString(result);
            }

            else if (operand == '*')

            {
                result = numOne * numTwo;
                txtResult.Text = Convert.ToString(result);
            }
            else { txtResult.Text = "invalid Operand"; }
                }

                else { txtResult.Text = "out of range"; }
            }

        //clear the form 
        private void txtClear_Click(object sender, EventArgs e)
        {
           txtResult.Text= String.Empty;
            txtBox1.Text = String.Empty;
            txtBox2.Text = String.Empty;
            txtoperand.Text= String.Empty;
        }

        //close the form
        private void txtClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
