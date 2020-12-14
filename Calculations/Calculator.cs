using System;

namespace Calculations
{
    public static class Calculator
    {
        /// <summary>
        /// Calculate the following sum 1/1 + 1/2 + 1/3 + ... + 1/n, where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumOne(int n)
        {
            double sum = 0;
            if (n > 0)
            {
                for (double i = 1; i < n + 1; i++)
                {
                    sum += 1 / i;
                }
            }

            return sum;
        }
        
        /// <summary>
        /// Calculate the following sum
        /// 1/(1*2) - 1/(2*3) + 1/(3*4) + ... + (-1)^(n+1) / (n * (n + 1)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumTwo(int n)
        {
            double sum = 0;
            double sign = 1;

            for (double i = 1; i <= n; i++)
            {
                sum += sign * (1.0 / (i * (i + 1)));
                sign = -sign;
            }

            return sum;
        }
        
        /// <summary>
        /// Calculate the following sum
        /// 1/1^5 + 1/2^5 + 1/3^5 + ... + 1/n^5, where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumThree(int n)
        {
            int multiplier = 5;
            double sum = 0;
            for (int i = 1; i < n + 1; i++)
            {
                sum += 1 / Math.Pow(i, multiplier);
            }

            return sum;
        }
        
        /// <summary>
        /// Calculate the following sum
        /// 1/(3 * 3) + 1/(5 * 5) + 1/(7 * 7) + ... + 1/((2 * n + 1) * (2 * n + 1)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumFour(int n)
        {
            double sum = 0;
            for (double i = 1; i < n + 1; i++)
            {
                sum += 1 / Math.Pow((2 * i) + 1, 2);
            }
            
            return sum;
        }

        /// <summary>
        /// Calculate the following product
        /// (1 + 1/(1 * 1)) * (1 + 1/(2 * 2)) * (1 + 1/(3 * 3)) * ... * (1 + 1/(n * n)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Product of elements.</returns>
        public static double GetProductOne(int n)
        {
            double sum = 1;
            for (double i = 1; i < n + 1; i++)
            {
                sum *= 1 + (1 / Math.Pow(i, 2));
            }

            return sum;
        }
        
        /// <summary>
        /// Calculate the following sum
        /// -1/3 + 1/5 - 1/7 + ... + (-1)^n / (2 * n + 1), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumFive(int n)
        {
            double sum = 0;
            int sign = -1;
            int denominator = 3;

            for (int i = 1; i < n + 1; i++)
            {
                sum += (double)sign / denominator;
                sign *= -1;
                denominator += 2;
            }

            return sum;
        }

        /// <summary>
        /// Calculate the following sum
        /// 1!/1 + 2!/(1+1/2) + 3!/(1+1/2+1/3) + ... + 1*2*...* n/ (1+1/2+1/3+...+1/n), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumSix(int n)
        {
            double totalSum = 0;
            double harmonicSum = 0;
            double factorialProduct = 1;

            for (int i = 1; i < n + 1; i++)
            {
                harmonicSum += 1.0 / i;
                factorialProduct *= i;
                totalSum += factorialProduct / harmonicSum;
            }

            return totalSum;
        }

        /// <summary>
        /// Calculate the following sum
        /// Sqrt(2 + Sqrt(2 + ... + Sqrt(2))), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumSeven(int n)
        {
            double sum = 0;
            for (int i = 1; i < n + 1; i++)
            {
                sum = Math.Sqrt(2 + sum);
            }

            return sum;
        }
        
        /// <summary>
        /// Calculate the following sum
        /// 1/sin(1) + 1/(sin(1)+sin(2)) + ...+  1/(sin(1)+sin(2)+...+sin(n)), where n > 0.
        /// </summary>
        /// <param name="n">Number of elements.</param>
        /// <returns>Sum of elements.</returns>
        public static double GetSumEight(int n)
        {
            double sum = 0.0;
            double radians = Math.PI / 180.0;
            for (int i = 1; i <= n; i++)
            {
                double nestedSum = 0.0;
                for (int j = 1; j <= i; j++)
                {
                    nestedSum += Math.Sin(j * radians);
                }

                sum += 1.0 / nestedSum;
            }

            return sum;
        }
    }
}
