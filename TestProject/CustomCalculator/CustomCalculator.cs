using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CustomCalculator
{
    public partial class CustomCalculator : UserControl
    {

        private static string currentCalculation = string.Empty;
        private static List<string> operators = new List<string>() { "+", "-", "*", "/", "^" };


        public CustomCalculator() => InitializeComponent();


        private void button_Click(object sender, EventArgs e)
        {
            textBoxError.Text = string.Empty;


            var isOperator = operators.Contains((sender as Button).Text);
            var isLastCharOperator = false;
            if (currentCalculation.Length > 0)
            {
                isLastCharOperator = operators.Contains(currentCalculation.Substring(currentCalculation.Length - 1, 1));
            }
            if (isOperator && isLastCharOperator)
            {
                currentCalculation = currentCalculation.Remove(currentCalculation.Length - 1, 1);
            }

            currentCalculation += (sender as Button).Text;
            textBoxOutput.Text = currentCalculation;
        }

        private void button_Equals_Click(object sender, EventArgs e)
        {
            textBoxError.Text = "";

            if (currentCalculation.Length == 0)
            {
                textBoxOutput.Text = "0";
                return;
            }


            var formattedCalculation = currentCalculation.ToString().Replace("∞", "1/0");
            
            var index = formattedCalculation.IndexOf("^");
            var tst = textBoxOutput.Text;

            try
            {
                if (index == -1)
                {
                    textBoxOutput.Text = new DataTable().Compute(formattedCalculation, null).ToString();
                }
                else
                {
                    var calculatedBeforeIndex = int.Parse(new DataTable().Compute(formattedCalculation.Substring(0, index), null).ToString());
                    var calculatedAfterIndex = int.Parse(new DataTable().Compute(formattedCalculation.Substring(index + 1), null).ToString());

                    var result = calculatedBeforeIndex;
                    for (int i = 1; i < calculatedAfterIndex; i++)
                    {
                        result *= calculatedBeforeIndex;
                    }

                    textBoxOutput.Text = result.ToString();
                }

                currentCalculation = textBoxOutput.Text;
            }
            catch (Exception ex)
            {
                textBoxOutput.Text = "0";
                currentCalculation = "";
                textBoxError.Text = "Ошибка ввода";
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBoxOutput.Text = "0";
            currentCalculation = string.Empty;
            textBoxError.Text = string.Empty;
        }

        private void button_ClearEntry_Click(object sender, EventArgs e)
        {
            if (currentCalculation.Length > 0)
            {
                currentCalculation = currentCalculation.Remove(currentCalculation.Length - 1, 1);
            }
            //if(currentCalculation.Contains())

            textBoxOutput.Text = currentCalculation;
        }

        private void textBoxOutput_TextChanged(object sender, EventArgs e)
        {

        }
        private bool znak = true;
        private void button19_Click(object sender, EventArgs e)
        {          
                            
                var temp=textBoxOutput.Text;
                if (temp.Length != 0)
                {
                    var govno1 = temp[0];

                    if (temp[0].ToString().Contains("-"))
                    {
                        textBoxOutput.Text = textBoxOutput.Text.Remove(0, 1);
                    }
                    else
                {
                    textBoxOutput.Text = "-" + textBoxOutput.Text;
                }
                    znak = true;

                }             
                
               

            
            currentCalculation = textBoxOutput.Text;



           
        }
    }
}
