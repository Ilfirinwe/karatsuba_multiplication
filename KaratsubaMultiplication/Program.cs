using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KaratsubaMultiplication.Common;
using System.Numerics;

namespace KaratsubaMultiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            BigInteger nFirstNumber = -1;
            string sFirstNumber = "";
            while (nFirstNumber < 1)
            {
                sFirstNumber = Console.ReadLine();
                BigInteger.TryParse(sFirstNumber, out nFirstNumber);
            }
            Console.WriteLine("\nВведите второе число. Количество цифр в обоих числах должно быть одинаковым.");
            BigInteger nSecondNumber = -1;
            string sSecondNumber = "";
            while (nSecondNumber < 1)
            {
                sSecondNumber = Console.ReadLine();
                if (sFirstNumber.Length == sSecondNumber.Length) BigInteger.TryParse(sSecondNumber, out nSecondNumber);
            }

            Console.WriteLine("\nВы ввели числа " + nFirstNumber.ToString() + " и " + nSecondNumber.ToString());
            BigInteger Result = KaratsubaAlgorithm.Multiply(sFirstNumber.Length, nFirstNumber, nSecondNumber);

            Console.WriteLine("Результат перемножения чисел: " + Result.ToString());

            Console.ReadLine();
        }
    }
}
