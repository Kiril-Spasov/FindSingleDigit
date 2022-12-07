using System;
using System.IO;
using System.Windows.Forms;

namespace FindSingleDigit
{
    public partial class FormFindSingleDigit : Form
    {
        public FormFindSingleDigit()
        {
            InitializeComponent();
        }

        private void BtnCalculateSignleDigit_Click(object sender, EventArgs e)
        {
            string line = "";

            string path = Application.StartupPath + @"\onedigit.txt";
            StreamReader streamReader = new StreamReader(path);

            bool finished = false;

            while (!finished)
            {
                line = streamReader.ReadLine();

                if (line == null)
                {
                    finished = true;
                }
                else
                {
                    TxtResult.Text += "Sum of digits in " + line + " = " + CalculateSingleDigit(line) + Environment.NewLine;
                }
            }
        }

        private int CalculateSingleDigit(string input)
        {
            int total = 0;

            //Find the sum of all digits.
            for (int i = 0; i < input.Length; i++)
            {
                total += Convert.ToInt32(input.Substring(i, 1));
            }

            //Repeat until the sum is a single digit.
            while (total > 9)
            {
                string newNumber = total.ToString();
                int newTotal = 0;

                for (int i = 0; i < newNumber.Length; i++)
                {
                    newTotal += Convert.ToInt32(newNumber.Substring(i, 1));
                }

                total = newTotal;
            }
            return total;
        }
    }
}
