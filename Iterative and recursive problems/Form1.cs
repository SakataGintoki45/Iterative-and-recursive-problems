namespace Iterative_and_recursive_problems
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRecursive_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumber.Text, out int n))
            {
                int result = FibonacciRecursive(n);
                lblResult.Text = $"Result (Recursive): {result}";
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private int FibonacciRecursive(int n)
        {
            if (n <= 1)
                return n;
            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        private int FibonacciIterative(int n)
        {
            if (n <= 1)
                return n;

            int a = 0, b = 1, c = 0;
            for (int i = 2; i <= n; i++)
            {
                c = a + b;
                a = b;
                b = c;
            }
            return c;
        }

        private void btnIterative_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumber.Text, out int n))
            {
                int result = FibonacciIterative(n);
                lblResult.Text = $"Result (Iterative): {result}";
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private int FactorialRecursive(int n)
        {
            if (n == 0) 
                return 1;
            return n * FactorialRecursive(n - 1); 
        }

        private int FactorialIterative(int n)
        {
            int result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        private void btnRecursiveFactorial_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumberFactorial.Text, out int n) && n >= 0) 
            {
                int result = FactorialRecursive(n);
                lblResultFactorial.Text = $"Result (Recursive): {result}";
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void btnIterativeFactorial_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumberFactorial.Text, out int n) && n >= 0) 
            {
                int result = FactorialIterative(n);
                lblResultFactorial.Text = $"Result (Iterative): {result}";
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }
    }
}
