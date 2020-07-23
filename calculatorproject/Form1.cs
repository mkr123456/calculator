using System;
using System.Windows.Forms;

namespace calculatorproject
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        string operatorClicked = "";
        private bool isOperaterClicked;
        bool isOperatorClicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void click_button(object sender, EventArgs e)
        {
            if (resultBox.Text == "0" || (isOperatorClicked))
                resultBox.Clear();

            isOperatorClicked = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!resultBox.Text.Contains("."))
                    resultBox.Text = resultBox.Text + button.Text;

            }
            else
                resultBox.Text = resultBox.Text + button.Text;
            }

        private void Operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultValue != 0)
            {
                equalBtn.PerformClick();
                operatorClicked = button.Text;
                isOperatorClicked = true;



            }
            else

            {
                operatorClicked = button.Text;
                resultValue = Double.Parse(resultBox.Text);
                isOperatorClicked = true;
            }


            

            

        }
    }

}