namespace Standard_Calculator
{
    public partial class Form1 : Form
    {
        private double resultValue = 0;
        private string operationPerformed = "";
        private bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBoxAnswer.Text == "0") || (isOperationPerformed))
                textBoxAnswer.Clear();

            isOperationPerformed = false;
            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBoxAnswer.Text.Contains("."))
                    textBoxAnswer.Text = textBoxAnswer.Text + button.Text;
            }
            else
            {
                textBoxAnswer.Text = textBoxAnswer.Text + button.Text;
            }
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                buttonEqual.PerformClick();
                operationPerformed = button.Text;
                resultLabel.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {
                operationPerformed = button.Text;
                resultValue = double.Parse(textBoxAnswer.Text);
                resultLabel.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
        }

        private void clearButton_click(object sender, EventArgs e)
        {
            textBoxAnswer.Text = "0";
            resultValue = 0;
            resultLabel.Text = "";
        }

        private void clearEntryButton_click(object sender, EventArgs e)
        {
            textBoxAnswer.Text = "0";
        }

        private void equalButton_click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBoxAnswer.Text = (resultValue + double.Parse(textBoxAnswer.Text)).ToString();
                    break;
                case "-":
                    textBoxAnswer.Text = (resultValue - double.Parse(textBoxAnswer.Text)).ToString();
                    break;
                case "*":
                    textBoxAnswer.Text = (resultValue * double.Parse(textBoxAnswer.Text)).ToString();
                    break;
                case "/":
                    textBoxAnswer.Text = (resultValue / double.Parse(textBoxAnswer.Text)).ToString();
                    break;
                default:
                    break;
            }
            resultValue = double.Parse(textBoxAnswer.Text);
            resultLabel.Text = "";
        }

        private void Form_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textBoxAnswer;
        }

        private void textBoxAnswer_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resultLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
