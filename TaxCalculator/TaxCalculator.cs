using System;
using System.Collections.Generic;
using System.Text;

namespace TaxCalculatorNS
{
    public class NumberIsNegativeException : Exception
    {
    }
    public class TaxCalculator
    {
        private double _taxPercentageSlab1 = 5.0;
        private double _taxPercentageSlab2 = 20.0;
        private double _taxPercentageSlab3 = 30.0;
        private double Salary { get; set; }
        private int Age { get; set; }
        public TaxCalculator(int age, double salary)
        {
            if (age < 0 || salary < 0)
            {
                throw new NumberIsNegativeException();
            }
            this.Salary = salary;
            this.Age = age;
        }
        public double CalculateTax()
        {
            if (this.Age <= 60)
            {
                if (this.Salary <= 250000)
                {
                    return 0;
                }
                else if (this.Salary > 250000 && this.Salary <= 500000)
                {
                    return (this.Salary * _taxPercentageSlab1) / 100;
                }
                else if (this.Salary > 500000 && this.Salary <= 1000000)
                {
                    return (((this.Salary - 500000) * _taxPercentageSlab2) / 100) + 12500;
                }
                else if (this.Salary > 1000000)
                {
                    return (((this.Salary - 1000000) * _taxPercentageSlab3) / 100) + 112500;
                }
                else
                {
                    return 0;
                }
            }
            else if(this.Age > 60 && this.Age <= 80)
            {
                if (this.Salary <= 300000)
                {
                    return 0;
                }
                else if (this.Salary > 300000 && this.Salary <= 500000)
                {
                    return (this.Salary * _taxPercentageSlab1) / 100;
                }
                else if (this.Salary > 500000 && this.Salary <= 1000000)
                {
                    return (((this.Salary - 500000) * _taxPercentageSlab2) / 100) + 10000;
                }
                else if (this.Salary > 1000000)
                {
                    return (((this.Salary - 1000000) * _taxPercentageSlab3) / 100) + 110000;
                }
                else
                {
                    return 0;
                }
            }
            else if (this.Age > 80)
            {
                if (this.Salary <= 500000)
                {
                    return 0;
                }
                else if (this.Salary > 500000 && this.Salary <= 1000000)
                {
                    return ((this.Salary * _taxPercentageSlab2) / 100);
                }
                else if (this.Salary > 1000000)
                {
                    return (((this.Salary - 1000000) * _taxPercentageSlab3) / 100) + 100000;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }
    }
}
