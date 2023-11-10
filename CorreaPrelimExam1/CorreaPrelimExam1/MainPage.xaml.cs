using System.Security.Cryptography;

namespace CorreaPrelimExam1
{
    public partial class MainPage : ContentPage
    {
        int currentState = 1;
        string operatorMath;
        double firstNum, secondNum, pi;

        public MainPage()
        {
            InitializeComponent();
            OnClear(this, null);
        }
        void OnClear(object sender, EventArgs e)
        {
            firstNum = 0;
            secondNum = 0;
            currentState = 1;
            this.result.Text = "0";
            this.input.Text = "";

        }
        void OnDel(object sender, EventArgs e)
        {
            int index = result.Text.Length;
            index--;
            result.Text = result.Text.Remove(index);
            if (result.Text == "0")
            {
                result.Text = "";

            }
        }
        void OnX2(object sender, EventArgs e)
        {
            if (firstNum == 0)
                return;
            firstNum = firstNum * firstNum;
            this.result.Text = firstNum.ToString();
        }

        void OnNumberSelection(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string btnPressed = button.Text;

            if (this.result.Text == "0" || currentState < 0)
            {
                this.result.Text = string.Empty;
                if (currentState < 0)
                    currentState *= -1;
            }

            this.result.Text += btnPressed;

            double number;
            if (double.TryParse(this.result.Text, out number))
            {
                this.result.Text = number.ToString("N0");
                if (currentState == 1)
                {
                    firstNum = number;
                }
                else
                {
                    secondNum = number;
                }
            }
        }

        void OnOperatorSelection(object sender, EventArgs e)
        {
            currentState = -2;
            Button button = (Button)sender;
            string btnPressed = button.Text;
            operatorMath = btnPressed;

            this.input.Text = operatorMath.ToString();

        }

        void OnCalculate(object sender, EventArgs e)
        {
            input.Text = firstNum + operatorMath.ToString() + secondNum;
            if (currentState == 2)

            {
                var result = Calculate.DoCalculation(firstNum, secondNum, operatorMath);

                this.result.Text = result.ToString();
                firstNum = result;
                currentState = -1;
            }
        }
        void OnPi(object sender, EventArgs e)
        {
            pi = Math.PI;
            input.Text = "";
            this.result.Text = pi.ToString();
        }

        void OnE(object sender, EventArgs e)
        {
            double exp = Math.Exp(1);
            input.Text = "";
            this.result.Text = exp.ToString();
        }

        void OnSquareRoot(object sender, EventArgs e)
        {
            double sqrtx = Math.Sqrt(firstNum);
            input.Text = "√(" + firstNum + ")";
            this.result.Text = sqrtx.ToString();
        }
        void OnMod(object sender, EventArgs e)
        {
            // Check if there is a first number to perform the modulo operation.
            if (currentState == 1)
            {
                currentState = -2; // Set the state to expect the second number.
                operatorMath = "%"; // Set the operator to modulo.
                input.Text += firstNum.ToString() + " % "; // Update the input label.
                result.Text = "0"; // Clear the result field.
            }
        }
        void OnFactorial(object sender, EventArgs e)
        {
            if (currentState == 1)
            {
                int n = (int)firstNum;
                double resultValue = 1;

                for (int i = 1; i <= n; i++)
                {
                    resultValue *= i;
                }

                result.Text = resultValue.ToString();
                input.Text = firstNum.ToString() + "!";
                firstNum = resultValue;
                currentState = -1;
            }
        }


        void OnLog(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string btnPressed = button.Text;

            double log = Math.Log10(firstNum);

            this.input.Text += btnPressed;
            input.Text = "Log(" + firstNum + ")";
            this.result.Text = log.ToString();
        }

        void Onln(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string btnPressed = button.Text;

            double ln = Math.Log(firstNum);

            this.input.Text += btnPressed;
            input.Text = "Ln(" + firstNum + ")";
            this.result.Text = ln.ToString();
        }
        void OnTenToTheX(object sender, EventArgs e)
        {
            if (currentState == 1)
            {
                // Calculate 10^firstNum and set it as the result.
                double resultValue = Math.Pow(10, firstNum);

                // Update the result and input fields.
                result.Text = resultValue.ToString();
                input.Text = "10^" + firstNum.ToString();

                // Reset the calculator state.
                firstNum = resultValue;
                currentState = -1;
            }
        }

    }
}