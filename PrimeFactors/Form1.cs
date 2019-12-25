using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PrimeFactors

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int number;
        public const int primeNumber=2;
       // primes = new List<int>();

        private void buttonStart_Click(object sender, EventArgs e)
        {

            number = Convert.ToInt32(textBoxNumber.Text);
           
            if (number%2==0)
            {
                
            }
            //MessageBox.Show(number.ToString());
        }
    }
}
