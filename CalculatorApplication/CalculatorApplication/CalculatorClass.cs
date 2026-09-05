using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApplication
{
    public delegate T Information<T>(T arg1, T arg2);

    internal class CalculatorClass
    {
        public Information<double> info;

        private Information<double> calculateEvent;

        public event Information<double> CalculateEvent
        {
            add
            {
                calculateEvent += value;
                Console.WriteLine("Added the Delegate");
            }
            remove
            {
                calculateEvent -= value;
                Console.WriteLine("Removed the Delegate");
            }
        }

        public double RaiseCalculateEvent(double num1, double num2)
        {
            return calculateEvent?.Invoke(num1, num2) ?? 0.0;
        }

        public double GetSum(double num1, double num2)
        {
            return num1 + num2;
        }

        public double GetDifference(double num1, double num2)
        {
            return num1 - num2;
        }

        public double GetProduct(double num1, double num2)
        {
            return num1 * num2;
        }

        public double GetQuotient(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
