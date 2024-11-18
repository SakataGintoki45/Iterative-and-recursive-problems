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
    }
}
