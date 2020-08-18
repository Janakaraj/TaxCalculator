using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TaxCalculatorNS;
namespace TaxCalculator.Tests
{
    [TestClass]
    public class TaxCalculatorUnitTests
    {
        [TestMethod]
        public void CalculateTax_ValidInputAge0to60_Slab1_returnTax()
        {
            int age = 22;
            double salary = 100000;
            double expectedTax = 0.0;
            var t1 = new TaxCalculatorNS.TaxCalculator(age, salary);
            var tax = t1.CalculateTax();
            Assert.AreEqual(tax, expectedTax);
        }
        [TestMethod]
        public void CalculateTax_ValidInputAge0to60_Slab1UpperBoundryValues_returnTax()
        {
            int age = 60;
            double salary = 250000;
            double expectedTax = 0.0;
            var t1 = new TaxCalculatorNS.TaxCalculator(age, salary);
            var tax = t1.CalculateTax();
            Assert.AreEqual(tax, expectedTax);
        }
        [TestMethod]
        public void CalculateTax_ValidInputAge0to60_Slab1LowerBoundryValues_returnTax()
        {
            int age = 0;
            double salary = 0;
            double expectedTax = 0.0;
            var t1 = new TaxCalculatorNS.TaxCalculator(age, salary);
            var tax = t1.CalculateTax();
            Assert.AreEqual(tax, expectedTax);
        }
        [TestMethod]
        public void CalculateTax_ValidInputAge0to60_Slab2_returnTax()
        {
            int age = 22;
            double salary = 400000;
            double expectedTax = (salary * 5) / 100;
            var t1 = new TaxCalculatorNS.TaxCalculator(age, salary);
            var tax = t1.CalculateTax();
            Assert.AreEqual(tax, expectedTax);
        }
        [TestMethod]
        public void CalculateTax_ValidInputAge0to60_Slab2UpperBoundryValue_returnTax()
        {
            int age = 60;
            double salary = 500000;
            double expectedTax = (salary * 5) / 100;
            var t1 = new TaxCalculatorNS.TaxCalculator(age, salary);
            var tax = t1.CalculateTax();
            Assert.AreEqual(tax, expectedTax);
        }
        [TestMethod]
        public void CalculateTax_ValidInputAge0to60_Slab2LowerBoundryValue_returnTax()
        {
            int age = 0;
            double salary = 250001;
            double expectedTax = (salary * 5) / 100;
            var t1 = new TaxCalculatorNS.TaxCalculator(age, salary);
            var tax = t1.CalculateTax();
            Assert.AreEqual(tax, expectedTax);
        }

        [TestMethod]
        public void CalculateTax_ValidInputAge0to60_Slab3_returnTax()
        {
            int age = 22;
            double salary = 600000;
            double expectedTax = (((salary - 500000) * 20) / 100) + 12500;
            var t1 = new TaxCalculatorNS.TaxCalculator(age, salary);
            var tax = t1.CalculateTax();
            Assert.AreEqual(tax, expectedTax);
        }
        [TestMethod]
        public void CalculateTax_ValidInputAge0to60_Slab3UpperBoundryValue_returnTax()
        {
            int age = 60;
            double salary = 1000000;
            double expectedTax = (((salary - 500000) * 20) / 100) + 12500;
            var t1 = new TaxCalculatorNS.TaxCalculator(age, salary);
            var tax = t1.CalculateTax();
            Assert.AreEqual(tax, expectedTax);
        }
        [TestMethod]
        public void CalculateTax_ValidInputAge0to60_Slab3LowerBoundryValue_returnTax()
        {
            int age = 0;
            double salary = 500001;
            double expectedTax = (((salary - 500000) * 20) / 100) + 12500;
            var t1 = new TaxCalculatorNS.TaxCalculator(age, salary);
            var tax = t1.CalculateTax();
            Assert.AreEqual(tax, expectedTax);
        }
        [TestMethod]
        public void CalculateTax_ValidInputAge0to60_Slab4_returnTax()
        {
            int age = 22;
            double salary = 1200000;
            double expectedTax = (((salary - 1000000) * 30) / 100) + 112500;
            var t1 = new TaxCalculatorNS.TaxCalculator(age, salary);
            var tax = t1.CalculateTax();
            Assert.AreEqual(tax, expectedTax);
        }
        [TestMethod]
        public void CalculateTax_ValidInputAge0to60_Slab4LowerBoundryValue_returnTax()
        {
            int age = 0;
            double salary = 1000001;
            double expectedTax = (((salary - 1000000) * 30) / 100) + 112500;
            var t1 = new TaxCalculatorNS.TaxCalculator(age, salary);
            var tax = t1.CalculateTax();
            Assert.AreEqual(tax, expectedTax);
        }
        [TestMethod]
        public void CalculateTax_ValidInputAge61to80_Slab1_returnTax()
        {
            int age = 65;
            double salary = 100000;
            double expectedTax = 0.0;
            var t1 = new TaxCalculatorNS.TaxCalculator(age, salary);
            var tax = t1.CalculateTax();
            Assert.AreEqual(tax, expectedTax);
        }
        [TestMethod]
        public void CalculateTax_ValidInputAge61to80_Slab1UpperBoundryValue_returnTax()
        {
            int age = 80;
            double salary = 300000;
            double expectedTax = 0.0;
            var t1 = new TaxCalculatorNS.TaxCalculator(age, salary);
            var tax = t1.CalculateTax();
            Assert.AreEqual(tax, expectedTax);
        }
        [TestMethod]
        public void CalculateTax_ValidInputAge61to80_Slab1LowerBoundryValue_returnTax()
        {
            int age = 61;
            double salary = 0;
            double expectedTax = 0.0;
            var t1 = new TaxCalculatorNS.TaxCalculator(age, salary);
            var tax = t1.CalculateTax();
            Assert.AreEqual(tax, expectedTax);
        }
        [TestMethod]
        public void CalculateTax_ValidInputAge61to80_Slab2_returnTax()
        {
            int age = 65;
            double salary = 400000;
            double expectedTax = (salary * 5) / 100;
            var t1 = new TaxCalculatorNS.TaxCalculator(age, salary);
            var tax = t1.CalculateTax();
            Assert.AreEqual(tax, expectedTax);
        }
        [TestMethod]
        public void CalculateTax_ValidInputAge61to80_Slab2UpperBoundryValue_returnTax()
        {
            int age = 80;
            double salary = 500000;
            double expectedTax = (salary * 5) / 100;
            var t1 = new TaxCalculatorNS.TaxCalculator(age, salary);
            var tax = t1.CalculateTax();
            Assert.AreEqual(tax, expectedTax);
        }
        [TestMethod]
        public void CalculateTax_ValidInputAge61to80_Slab2LowerBoundryValue_returnTax()
        {
            int age = 61;
            double salary = 300001;
            double expectedTax = (salary * 5) / 100;
            var t1 = new TaxCalculatorNS.TaxCalculator(age, salary);
            var tax = t1.CalculateTax();
            Assert.AreEqual(tax, expectedTax);
        }
        [TestMethod]
        public void CalculateTax_ValidInputAge61to80_Slab3_returnTax()
        {
            int age = 65;
            double salary = 600000;
            double expectedTax = (((salary - 500000) * 20) / 100) + 10000;
            var t1 = new TaxCalculatorNS.TaxCalculator(age, salary);
            var tax = t1.CalculateTax();
            Assert.AreEqual(tax, expectedTax);
        }
        [TestMethod]
        public void CalculateTax_ValidInputAge61to80_Slab3UpperBoundryValue_returnTax()
        {
            int age = 80;
            double salary = 1000000;
            double expectedTax = (((salary - 500000) * 20) / 100) + 10000;
            var t1 = new TaxCalculatorNS.TaxCalculator(age, salary);
            var tax = t1.CalculateTax();
            Assert.AreEqual(tax, expectedTax);
        }
        [TestMethod]
        public void CalculateTax_ValidInputAge61to80_Slab3LowerBoundryValue_returnTax()
        {
            int age = 61;
            double salary = 500001;
            double expectedTax = (((salary - 500000) * 20) / 100) + 10000;
            var t1 = new TaxCalculatorNS.TaxCalculator(age, salary);
            var tax = t1.CalculateTax();
            Assert.AreEqual(tax, expectedTax);
        }
        [TestMethod]
        public void CalculateTax_ValidInputAge61to80_Slab4BoundryValue_returnTax()
        {
            int age = 65;
            double salary = 1500000;
            double expectedTax = (((salary - 1000000) * 30) / 100) + 110000;
            var t1 = new TaxCalculatorNS.TaxCalculator(age, salary);
            var tax = t1.CalculateTax();
            Assert.AreEqual(tax, expectedTax);
        }
        [TestMethod]
        public void CalculateTax_ValidInputAge61to80_Slab4LowerBoundryValue_returnTax()
        {
            int age = 61;
            double salary = 1000001;
            double expectedTax = (((salary - 1000000) * 30) / 100) + 110000;
            var t1 = new TaxCalculatorNS.TaxCalculator(age, salary);
            var tax = t1.CalculateTax();
            Assert.AreEqual(tax, expectedTax);
        }
        [TestMethod]
        public void CalculateTax_ValidInputAge80Plus_Slab1_returnTax()
        {
            int age = 85;
            double salary = 100000;
            double expectedTax = 0.0;
            var t1 = new TaxCalculatorNS.TaxCalculator(age, salary);
            var tax = t1.CalculateTax();
            Assert.AreEqual(tax, expectedTax);
        }
        [TestMethod]
        public void CalculateTax_ValidInputAge80Plus_Slab1LowerBoundryValue_returnTax()
        {
            int age = 81;
            double salary = 0;
            double expectedTax = 0.0;
            var t1 = new TaxCalculatorNS.TaxCalculator(age, salary);
            var tax = t1.CalculateTax();
            Assert.AreEqual(tax, expectedTax);
        }
        [TestMethod]
        public void CalculateTax_ValidInputAge80Plus_Slab1UpperBoundryValue_returnTax()
        {
            int age = 81;
            double salary = 500000;
            double expectedTax = 0.0;
            var t1 = new TaxCalculatorNS.TaxCalculator(age, salary);
            var tax = t1.CalculateTax();
            Assert.AreEqual(tax, expectedTax);
        }
        [TestMethod]
        public void CalculateTax_ValidInputAge80Plus_Slab2_returnTax()
        {
            int age = 85;
            double salary = 600000;
            double expectedTax = (salary * 20) / 100;
            var t1 = new TaxCalculatorNS.TaxCalculator(age, salary);
            var tax = t1.CalculateTax();
            Assert.AreEqual(tax, expectedTax);
        }
        [TestMethod]
        public void CalculateTax_ValidInputAge80Plus_Slab2LowerBoundryValue_returnTax()
        {
            int age = 81;
            double salary = 500001;
            double expectedTax = (salary * 20) / 100;
            var t1 = new TaxCalculatorNS.TaxCalculator(age, salary);
            var tax = t1.CalculateTax();
            Assert.AreEqual(tax, expectedTax);
        }
        [TestMethod]
        public void CalculateTax_ValidInputAge80Plus_Slab2UpperBoundryValue_returnTax()
        {
            int age = 81;
            double salary = 1000000;
            double expectedTax = (salary * 20) / 100;
            var t1 = new TaxCalculatorNS.TaxCalculator(age, salary);
            var tax = t1.CalculateTax();
            Assert.AreEqual(tax, expectedTax);
        }
        [TestMethod]
        public void CalculateTax_ValidInputAge80Plus_Slab3_returnTax()
        {
            int age = 85;
            double salary = 1500000;
            double expectedTax = (((salary - 1000000) * 30) / 100) + 100000;
            var t1 = new TaxCalculatorNS.TaxCalculator(age, salary);
            var tax = t1.CalculateTax();
            Assert.AreEqual(tax, expectedTax);
        }
        [TestMethod]
        public void CalculateTax_ValidInputAge80Plus_Slab3LowerBoundryValue_returnTax()
        {
            int age = 81;
            double salary = 1000001;
            double expectedTax = (((salary - 1000000) * 30) / 100) + 100000;
            var t1 = new TaxCalculatorNS.TaxCalculator(age, salary);
            var tax = t1.CalculateTax();
            Assert.AreEqual(tax, expectedTax);
        }
        [TestMethod]
        public void CalculateTax_NegativeInput_ThrowsNumberIsNegativeException()
        {
            int age = -10;
            double salary = -100000;
            Assert.ThrowsException<TaxCalculatorNS.NumberIsNegativeException>(()=> { var t1 = new TaxCalculatorNS.TaxCalculator(age, salary); });
        }
        [TestMethod]
        public void CalculateTax_NegativeAge_ThrowsNumberIsNegativeException()
        {
            int age = -10;
            double salary = 100000;
            Assert.ThrowsException<TaxCalculatorNS.NumberIsNegativeException>(() => { var t1 = new TaxCalculatorNS.TaxCalculator(age, salary); });
        }
        [TestMethod]
        public void CalculateTax_NegativeSalary_ThrowsNumberIsNegativeException()
        {
            int age = 10;
            double salary = -100000;
            Assert.ThrowsException<TaxCalculatorNS.NumberIsNegativeException>(() => { var t1 = new TaxCalculatorNS.TaxCalculator(age, salary); });
        }
    }
}
