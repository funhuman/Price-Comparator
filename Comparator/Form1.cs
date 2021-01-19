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
            if (priceBoxA.Text != "" && priceBoxB.Text != "" && weightBoxA.Text != "")
            {
                double priceA = Convert.ToDouble(priceBoxA.Text);
                double priceB = Convert.ToDouble(priceBoxB.Text);
                double weightA = Convert.ToDouble(weightBoxA.Text);
                double weightB = Math.Round(weightA / priceA * priceB, 2);
                if (weightB >= 0)
                {
                    weightBoxB.Text = weightB.ToString();
                }
            }
            else
            {
                weightBoxB.Text = "";
            }
        }

        private void weightBoxB_TextChanged(object sender, EventArgs e)
        {
            if (priceBoxA.Text != "" && weightBoxA.Text != "" && weightBoxB.Text != "")
            {
                double priceA = Convert.ToDouble(priceBoxA.Text);
                double weightA = Convert.ToDouble(weightBoxA.Text);
                double weightB = Convert.ToDouble(weightBoxB.Text);
                double priceB = Math.Round(priceA / weightA * weightB, 2);
                if (priceB >= 0)
                {
                    priceBoxB.Text = priceB.ToString();
                }
            }
            else
            {
                priceBoxB.Text = "";
            }
        }

        private void weightComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            priceBoxB_TextChanged(sender, e);
        }

        private void priceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            priceBoxB_TextChanged(sender, e);
        }
    }
}
