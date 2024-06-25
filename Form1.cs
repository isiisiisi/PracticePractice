namespace PracticePractice
{
    public partial class calculator : Form
    {
        private Class1 solver;
        public calculator()
        {
            InitializeComponent();
            solver = new Class1();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Substring(0, txtResult.Text.Length - 1);
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn4.Text;
            txtResult.SelectionStart = txtResult.Text.Length;
            txtResult.ScrollToCaret();
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn0.Text;
            txtResult.SelectionStart = txtResult.Text.Length;
            txtResult.ScrollToCaret();
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn7.Text;
            txtResult.SelectionStart = txtResult.Text.Length;
            txtResult.ScrollToCaret();
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn8.Text;
            txtResult.SelectionStart = txtResult.Text.Length;
            txtResult.ScrollToCaret();
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn9.Text;
            txtResult.SelectionStart = txtResult.Text.Length;
            txtResult.ScrollToCaret();
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn5.Text;
            txtResult.SelectionStart = txtResult.Text.Length;
            txtResult.ScrollToCaret();
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn6.Text;
            txtResult.SelectionStart = txtResult.Text.Length;
            txtResult.ScrollToCaret();
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn1.Text;
            txtResult.SelectionStart = txtResult.Text.Length;
            txtResult.ScrollToCaret();
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn2.Text;
            txtResult.SelectionStart = txtResult.Text.Length;
            txtResult.ScrollToCaret();
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            txtResult.Text += btn3.Text;
            txtResult.SelectionStart = txtResult.Text.Length;
            txtResult.ScrollToCaret();
        }

        private void BtnDecimal_Click(object sender, EventArgs e)
        {
            if (!txtResult.Text.Contains("."))
            {
                if (txtResult.Text == string.Empty)
                    txtResult.Text = "0.";
                else
                    txtResult.Text += btnDecimal.Text;
            }

            txtResult.SelectionStart = txtResult.Text.Length;
            txtResult.ScrollToCaret();
        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = txtResult.Text;
                var result = solver.Evaluate(expression);
                lblResult.Text = result.ToString("0.00");
            }
            catch (Exception ex)
            {
                lblResult.Text = "Error";
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            txtResult.Text += btnAdd.Text;
            txtResult.SelectionStart = txtResult.Text.Length;
            txtResult.ScrollToCaret();
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            txtResult.Text += btnSubtract.Text;
            txtResult.SelectionStart = txtResult.Text.Length;
            txtResult.ScrollToCaret();
        }

        private void BtnMultiply_Click(object sender, EventArgs e)
        {
            txtResult.Text += "*";
            txtResult.SelectionStart = txtResult.Text.Length;
            txtResult.ScrollToCaret();
        }

        private void BtnDivide_Click(object sender, EventArgs e)
        {
            txtResult.Text += btnDivide.Text;
            txtResult.SelectionStart = txtResult.Text.Length;
            txtResult.ScrollToCaret();
        }

        private void BtnPara1_Click(object sender, EventArgs e)
        {
            txtResult.Text += btnPara1.Text;
            txtResult.SelectionStart = txtResult.Text.Length;
            txtResult.ScrollToCaret();
        }

        private void btnPara2_Click(object sender, EventArgs e)
        {
            txtResult.Text += btnPara2.Text;
            txtResult.SelectionStart = txtResult.Text.Length;
            txtResult.ScrollToCaret();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            lblResult.Text = string.Empty;
        }
    }
}

