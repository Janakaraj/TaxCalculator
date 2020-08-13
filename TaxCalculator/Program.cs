using System;

namespace TaxCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                try
                {
                    int age = 0;
                    double salary = 0;
                    bool isAgeNegative = true;
                    bool isSalaryNegative = true;
                    while (isAgeNegative)
                    {
                        Console.WriteLine("Please enter your age");
                        age = Convert.ToInt32(Console.ReadLine());
                        if (age >= 0)
                        {
                            isAgeNegative = false;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Age cannot be negative");
                        }
                    }
                    while (isSalaryNegative)
                    {
                        Console.WriteLine("Please enter your anual salary");
                        salary = Convert.ToDouble(Console.ReadLine());
                        if (salary >= 0)
                        {
                            isSalaryNegative = false;
                        }
                        else
                        {
                            Console.WriteLine();
                            Console.WriteLine("Salary cannot be negative");
                        }
                    }

                    Console.WriteLine();
                    TaxCalculator t1 = new TaxCalculator(age, salary);
                    Console.WriteLine("Calculated tax : Rs {0}", t1.CalculateTax());
                    Console.WriteLine();
                    Console.WriteLine("Do you want to exit?");
                    Console.WriteLine("Type : yes or no");
                    string answer = Console.ReadLine();
                    if (answer == "yes")
                    {
                        exit = true;
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
