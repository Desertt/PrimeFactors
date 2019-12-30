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
        public int counter;
        public int primeNumber;
        public int control;

        // primes = new List<int>();

        private void buttonStart_Click(object sender, EventArgs e)
        {

            number = Convert.ToInt32(textBoxNumber.Text);
           
            if (number%2==0)
            {
                MessageBox.Show("Girdiğiniz Sayı Asal Değildir!");
            }
            else
            {
                MessageBox.Show("Girdiğiniz Sayı Asaldır!");
            }
            //MessageBox.Show(number.ToString());
        }

        private void buttonAddToPrimeList_Click(object sender, EventArgs e)
        {
            counter = 0;
            number = Convert.ToInt32(textBoxNumber.Text);
            for (primeNumber=2; primeNumber  < number; primeNumber++)
            {
                control = 0;
                if (number%2==0)
                {
                    control = 1;
                    break;
                }

            }
            if (control==1)
            {
                listBoxPrimes.Items.Add(number + " asal değildir !");
            }
            else
            {
                listBoxPrimes.Items.Add(number + " asaldır !");
                counter++;
            }
        }
    }
}
