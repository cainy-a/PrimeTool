﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonCheckPrime_Click(object sender, EventArgs e)
        {
            if ( isPrime( Convert.ToInt64( textBoxPrimeToCheck.Text ) ) )
            {
                textBoxIsPrime.Text = "Prime!";
            } else
            {
                textBoxIsPrime.Text = "Not Prime!";
            }
        }

        public static bool isPrime(long number)
        {
            if (number == 1) return false;
            if (number == 2 || number == 3 || number == 5) return true;
            if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0) return false;

            var boundary = (long)Math.Floor(Math.Sqrt(number));

            // You can do less work by observing that at this point, all primes 
            // other than 2 and 3 leave a remainder of either 1 or 5 when divided by 6. 
            // The other possible remainders have been taken care of.
            long i = 6; // start from 6, since others below have been handled.
            while (i <= boundary)
            {
                if (number % (i + 1) == 0 || number % (i + 5) == 0)
                    return false;

                i += 6;
            }

            return true;
        } // Check if number is prime
    }
}
