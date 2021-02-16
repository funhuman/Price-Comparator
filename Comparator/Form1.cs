using System;
using System.Windows.Forms;

namespace Comparator
{
    public partial class ComparatorForm : Form
    {
        public ComparatorForm()
        {
            InitializeComponent();
        }

        private void priceBoxB_TextChanged(object sender, EventArgs e)
        {
            if (priceBoxB.ReadOnly)
            {
                return;
            }
            if (priceBoxA.Text != "" && priceBoxB.Text != "" && weightBoxA.Text != "")
            {
                double priceA = Convert.ToDouble(priceBoxA.Text);
                double priceB = Convert.ToDouble(priceBoxB.Text);
                double weightA = Convert.ToDouble(weightBoxA.Text);
                double weightB = Math.Round(weightA / priceA * priceB, 2);
                weightBoxB.Text = weightB.ToString();
            }
        }

        private void weightBoxB_TextChanged(object sender, EventArgs e)
        {
            if (weightBoxB.ReadOnly)
            {
                return;
            }
            if (priceBoxA.Text != "" && weightBoxA.Text != "" && weightBoxB.Text != "")
            {
                double priceA = Convert.ToDouble(priceBoxA.Text);
                double priceB;
                double weightA = Convert.ToDouble(weightBoxA.Text);
                double weightB = Convert.ToDouble(weightBoxB.Text);
                priceB = Math.Round(priceA / weightA * weightB, 2);
                priceBoxB.Text = priceB.ToString();
            }
        }

        private void priceBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Press CR(carriage return) -> Switching mode
            if (e.KeyChar == (char)13)
            {
                if (priceBoxB.ReadOnly)
                {
                    priceBoxB.ReadOnly = false;
                    weightBoxB.ReadOnly = true;
                    priceBoxB.Text = "";
                    priceBoxB.Focus();
                }
                else
                {
                    priceBoxB.ReadOnly = true;
                    weightBoxB.ReadOnly = false;
                    weightBoxB.Text = "";
                    weightBoxB.Focus();
                }
            }
            // Press Point -> Duplicate checking
            if (e.KeyChar == (char)46)
            {
                TextBox textBox = (TextBox)sender;
                if (textBox.Text.Contains("."))
                {
                    e.Handled = true;
                }
            }
            // Only allowed Numbers/Backspace/Delete
            if (!char.IsNumber(e.KeyChar)
                && e.KeyChar != (char)8 && e.KeyChar != (char)127)
            {
                e.Handled = true;
            }
        }
    }
}
