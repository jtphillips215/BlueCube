using System;
using System.Collections.Generic;
using System.Text;

namespace phillips_james_exam2
{
    public class Balance
    {
        // setting starting balance
        private static double total = 100;

        // getter and setter for balance
        public static double Total
        {
            get
            {
                return total;
            }

            set
            {
                // balance should not be below zero
                if (value >= 0)
                {
                    total = value;
                }

                else
                {
                    total = 0;
                }
            }
        }
    }
}
