using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Calculator : Form
    {
        decimal num1, num2, result;
        string opertr;
        bool AutoCompu;
        bool isOpertrClick;


        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;


        public Calculator()
        {
            InitializeComponent();

            panelTitleBar.MouseDown += panelTitleBar_MouseDown;

            panelTitleBar.MouseMove += panelTitleBar_MouseMove;

            panelTitleBar.MouseUp += panelTitleBar_MouseUp;
        }

        private void panelTitleBar_MouseDown(object sender, EventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panelTitleBar_MouseMove(object sender, EventArgs e)
        {
            if (dragging)
            {
                Point diff = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(diff));
            }
        }

        private void panelTitleBar_MouseUp(object sender, EventArgs e)
        {
            dragging = false;
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (txtDisplay.Text == "0")
                txtDisplay.Clear();

            if (isOpertrClick)
            {
                txtDisplay.Clear();
                AutoCompu = true;
                isOpertrClick = false;
            }
            txtDisplay.Text += button.Text;
        }

        private void btnOpertr_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;


            if(AutoCompu)
            {
                num2 = decimal.Parse(txtDisplay.Text);

                result = Compute(num1, num2, opertr);
                opertr = button.Text;

                txtDisplay.Text = result.ToString();
                txtPreview.Text = $"{result} {opertr}";

                num1 = result;
                isOpertrClick = true;
                AutoCompu = false;
                return;
            }

            num1 = Convert.ToDecimal(txtDisplay.Text);

            isOpertrClick = true;
            opertr = button.Text;
            txtPreview.Text = num1 + " " + opertr;

            
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.Text = "0";
            num1 = 0;
            num2 = 0;
            result = 0;
            AutoCompu = false;
            isOpertrClick = false;
            txtPreview.Clear();
        }

        private void btnNeg_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDecimal(txtDisplay.Text);

            txtDisplay.Text = "-" + num1;
            txtPreview.Text = $"negate ({num1})";
        }


        #region EventHandlers
        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
            if (string.IsNullOrEmpty(txtDisplay.Text))
            {
                txtDisplay.Text = "0";
            }
        }

        private void btnSq2_Click(object sender, EventArgs e)
        {
            num1 = decimal.Parse(txtDisplay.Text);

            result = num1 * num1;

            txtDisplay.Text = result.ToString();
            txtPreview.Text = $"sqr({num1})";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!txtDisplay.Text.Contains("."))
                txtDisplay.Text += ".";

        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            num2 = decimal.Parse(txtDisplay.Text);

            result = Compute(num1, num2, opertr);

            txtDisplay.Text = result.ToString();
            txtPreview.Text = $"{num1} {opertr} {num2} = ";
        }
        private void txtPreview_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            AdjustFontSize(textBox);
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion

        #region Private Methods
        private void AdjustFontSize(TextBox textBox)
        {
            int minFontSize = 6;  // Define the minimum font size
            int maxFontSize = 20; // Define the maximum font size
            int currentFontSize = maxFontSize;

            // Set initial font size to the maximum
            textBox.Font = new Font(textBox.Font.FontFamily, currentFontSize);

            // Measure the text size
            Size textSize = TextRenderer.MeasureText(textBox.Text, textBox.Font);

            // Reduce font size until text fits within the TextBox width
            while (textSize.Width > textBox.Width && currentFontSize > minFontSize)
            {
                currentFontSize--;
                textBox.Font = new Font(textBox.Font.FontFamily, currentFontSize);
                textSize = TextRenderer.MeasureText(textBox.Text, textBox.Font);
            }
        }

        private decimal Compute(decimal num1,decimal num2,string opertr)
        {
            decimal result = 0;
            try
            {
                switch (opertr)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        result = num1 / num2;
                        break;
                }
            }
            catch (Exception ex)
            {
                txtPreview.Text = "Syntax Error " + ex.Message;
                num1 = 0;
                num2 = 0;
                result = 0;
            }
            return result;
        }
        #endregion


    }
}
