using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace KaratsubaMultiplication.Common
{
    public static class KaratsubaAlgorithm
    {
        private static BigInteger RaiseTen(int Power)
        {
            return BigInteger.Pow(10, Power);
        }

        public static BigInteger Multiply(int Length, BigInteger FirstNumber, BigInteger SecondNumber)
        {
            if (Length == 1) return FirstNumber * SecondNumber;
            else
            {
                Length /= 2;
                BigInteger FirstNumber_LeftHalf = FirstNumber / 10;
                BigInteger FirstNumber_RightHalf = FirstNumber % 10;

                BigInteger SecondNumber_LeftHalf = SecondNumber / 10;
                BigInteger SecondNumber_RightHalf = SecondNumber % 10;

                BigInteger Step1 = Multiply(Length, FirstNumber_LeftHalf, SecondNumber_LeftHalf);
                BigInteger Step2 = Multiply(Length, FirstNumber_RightHalf, SecondNumber_RightHalf);
                BigInteger Step3 = Multiply(1, FirstNumber_LeftHalf + FirstNumber_RightHalf, SecondNumber_LeftHalf + SecondNumber_RightHalf);
                BigInteger Step4 = Step3 - Step2 - Step1;
                return Step1 * RaiseTen(Step2.ToString().Length) + Step2 + Step4 * RaiseTen(Step2.ToString().Length / 2);
            }
        }
    }
}
