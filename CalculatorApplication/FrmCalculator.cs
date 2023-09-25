namespace CalculatorApplication
{
    public partial class FrmCalculator : Form
    {
        public FrmCalculator()
        {
            InitializeComponent();
        }

        private void FrmCalculator_Load(object sender, EventArgs e)
        {

        }

        private CalculatorClass cal = new CalculatorClass();
        double num1, num2;

        private void btncalculate_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtBoxInput1.Text);
            num2 = Convert.ToDouble(txtBoxInput2.Text);

            if (cbOperator.SelectedItem.ToString() == "+")
            {
                cal.CalculateEvent += new Formula<double>(cal.GetSum);
                lblDisplayTotal.Text = cal.GetSum(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetSum);
            }
            else if (cbOperator.SelectedItem.ToString() == "-")
            {
                cal.CalculateEvent += new Formula<double>(cal.GetDifference);
                lblDisplayTotal.Text = cal.GetDifference(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetDifference);
            }
            else if (cbOperator.SelectedItem.ToString() == "*")
            {
                cal.CalculateEvent += new Formula<double>(cal.GetProduct);
                lblDisplayTotal.Text = cal.GetProduct(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetProduct);
            }
            else if (cbOperator.SelectedItem.ToString() == "/")
            {
                cal.CalculateEvent += new Formula<double>(cal.GetQuotient);
                lblDisplayTotal.Text = cal.GetQuotient(num1, num2).ToString();
                cal.CalculateEvent -= new Formula<double>(cal.GetQuotient);
            }

        }

        private void cbOperator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}