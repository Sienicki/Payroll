using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollApp
{
    class Staff
    {
        private float hourlyRate;
        private int hoursWorked;

        public float TotalPay { get; protected set; }
        public float  BasicPay { get; private set; }
        public string NameOfStaff { get; private set; }
        public int HoursWorked
        {
            get
            {
                return hoursWorked;
            }
            set
            {
                if (value > 0)
                {
                    hoursWorked = value;
                }
                else
                {
                    hoursWorked = 0;
                }
            }
        }
        public Staff(string name, float rate)
        {
            NameOfStaff = name;
            hourlyRate = rate;
        }
            
        public virtual void CalculatePay()
        {
            Console.WriteLine("Calculating Pay...");
            BasicPay = hoursWorked * hourlyRate;
            TotalPay = BasicPay;
        }
        public override string ToString()
        {
            return  "\nNameOfStaff = " + NameOfStaff + 
                "\nhourlyRate = " + hourlyRate + 
                "\nhoursWorked = " + hoursWorked + 
                "\nBasicPay = " + BasicPay + 
                "\n\nTotalPay = " + TotalPay;
        }

    }
}
