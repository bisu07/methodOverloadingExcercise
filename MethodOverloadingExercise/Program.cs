using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;

namespace MethodOverloadingExercise
{
    class Program
    {


        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static string Add(int x, int y, bool isCheck)

        {
            var sum = x + y;

            if (isCheck == true && sum > 1)
            {
                return $"{sum}  dollars";
            }
            else if (isCheck == true && sum == 1)
            {
                return $"{sum} dollar";
            }
            else if (isCheck == true && sum < 1)
            {
                return $"{sum} dollar";
            }
            else
            {
                return $"sum.ToString()";
            }

        }

        static void Main(string[] args)
        {
            var x = 2;
            var y = 5;
            var answer = Add(x, y);

            var a = 63.0m;
            var b = 78.0m;
            var decimalAnswer = Add(a, b);
            var nextAnswer = Add(0, 0, true);
            Console.WriteLine($"the total int value:{answer} the decimal total value :{decimalAnswer}");
            Console.WriteLine($"you have :{nextAnswer}");




        }

        

    }
    

    
}
