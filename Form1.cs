namespace GHesapMak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string selection;
        int FirstNumber;
        int SecondNumber;
        double result;

        private void btn0_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn0.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btn9.Text;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            if (selection == "+")
            {
                SecondNumber = Convert.ToInt32(txtDisplay.Text);
                result = FirstNumber + SecondNumber;
                txtDisplay.Text = result + "";
            }
            else if (selection == "-")
            {
                SecondNumber = Convert.ToInt32(txtDisplay.Text);
                result = FirstNumber - SecondNumber;
                txtDisplay.Text = result + "";
            }
            else if (selection == "*")
            {
                SecondNumber = Convert.ToInt32(txtDisplay.Text);
                result = FirstNumber * SecondNumber;
                txtDisplay.Text = result + "";
            }
            else if (selection == "/")
            {
                SecondNumber = Convert.ToInt32(txtDisplay.Text);
                result = FirstNumber / SecondNumber;
                txtDisplay.Text = result + "";
            }
            else if (selection == "^x")
            {
                SecondNumber = Convert.ToInt32(txtDisplay.Text);
                result = Math.Pow(FirstNumber, SecondNumber);
                txtDisplay.Text = result + "";
            }

        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            selection = "+";
            FirstNumber = Convert.ToInt32(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            selection = "-";
            FirstNumber = Convert.ToInt32(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            selection = "/";
            FirstNumber = Convert.ToInt32(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnMuliple_Click(object sender, EventArgs e)
        {
            selection = "*";
            FirstNumber = Convert.ToInt32(txtDisplay.Text);
            txtDisplay.Clear();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToInt32(txtDisplay.Text);
            txtDisplay.Clear();
            result = Math.Sin((double)FirstNumber);
            txtDisplay.Text = result + "";

        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToInt32(txtDisplay.Text);
            txtDisplay.Clear();
            result = Math.Cos((double)FirstNumber);
            txtDisplay.Text = result + "";
        }

        private void btnCot_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToInt32(txtDisplay.Text);
            txtDisplay.Clear();
            result = 1 / Math.Tan((double)FirstNumber);
            txtDisplay.Text = result + "";
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToInt32(txtDisplay.Text);
            txtDisplay.Clear();
            result = Math.Tan((double)FirstNumber);
            txtDisplay.Text = result + "";
        }

        private void btnArcSin_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToInt32(txtDisplay.Text);
            txtDisplay.Clear();
            result = Math.Asin((double)FirstNumber);
            txtDisplay.Text = result + "";
        }

        private void btnArcCos_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToInt32(txtDisplay.Text);
            txtDisplay.Clear();
            result = Math.Acos((double)FirstNumber);
            txtDisplay.Text = result + "";
        }

        private void btnArcTan_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToInt32(txtDisplay.Text);
            txtDisplay.Clear();
            result = Math.Atan((double)FirstNumber);
            txtDisplay.Text = result + "";
        }

        private void btnArcCot_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToInt32(txtDisplay.Text);
            txtDisplay.Clear();
            result = 1 / Math.Atan((double)FirstNumber);
            txtDisplay.Text = result + "";
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToInt32(txtDisplay.Text);
            txtDisplay.Clear();
            result = 1 / Math.Cos((double)FirstNumber);
            txtDisplay.Text = result + "";
        }

        private void btnCosec_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToInt32(txtDisplay.Text);
            txtDisplay.Clear();
            result = 1 / Math.Sin((double)FirstNumber);
            txtDisplay.Text = result + "";
        }

        private void btnPow_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToInt32(txtDisplay.Text);
            txtDisplay.Clear();
            result = Math.Pow(FirstNumber, 2);
            txtDisplay.Text = result + "";

        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToInt32(txtDisplay.Text);
            txtDisplay.Clear();
            result = Math.Pow(FirstNumber, SecondNumber);
            txtDisplay.Text = result + "";

        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToInt32(txtDisplay.Text);
            txtDisplay.Clear();
            result = Math.Sqrt(FirstNumber);
            txtDisplay.Text = result + "";

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToInt32(txtDisplay.Text);
            txtDisplay.Clear();
            result = Math.Log(FirstNumber);
            txtDisplay.Text = result + "";

        }

        private void btnln_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToInt32(txtDisplay.Text);
            txtDisplay.Clear();
            result = Math.Log(FirstNumber);
            txtDisplay.Text = result + "";

        }

        private void btnAbs_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToInt32(txtDisplay.Text);
            txtDisplay.Clear();
            result = Math.Abs(FirstNumber);
            txtDisplay.Text = result + "";

        }

        private void btnFact_Click(object sender, EventArgs e)
        {
            selection = "Fact";
            FirstNumber = Convert.ToInt32(txtDisplay.Text);
            txtDisplay.Clear();
            int factorial = 1;
            for (int i = FirstNumber; i > 0; i--)
            {
                factorial *= i;
            }
            result = factorial;
            txtDisplay.Text = result + "";

        }
    }

}