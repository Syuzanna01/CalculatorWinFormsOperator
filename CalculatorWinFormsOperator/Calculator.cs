using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorWinFormsOperator
{
    internal class Calculator
    {
        public double number = 0;

        public Calculator() { }

        public Calculator(double n)
        {
            number = n;
        }

        // Overloading of Binary "+" "-" "*" "/" operator
        public static Calculator operator +(Calculator Calc1, Calculator Calc2)
        {
            Calculator Calc3 = new Calculator();
            Calc3.number = Calc1.number + Calc2.number;
            return Calc3;
        }
        public static Calculator operator -(Calculator Calc1, Calculator Calc2)
        {
            Calculator Calc3 = new Calculator();
            Calc3.number = Calc1.number - Calc2.number;
            return Calc3;
        }
        public static Calculator operator *(Calculator Calc1, Calculator Calc2)
        {
            Calculator Calc3 = new Calculator();
            Calc3.number = Calc1.number * Calc2.number;
            return Calc3;
        }
        public static Calculator operator /(Calculator Calc1, Calculator Calc2)
        {
            Calculator Calc3 = new Calculator();
            Calc3.number = Calc1.number / Calc2.number;
            return Calc3;
        }
        public double display()
        {
            return number;
        }
    }
}
