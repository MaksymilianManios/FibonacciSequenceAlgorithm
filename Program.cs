using Microsoft.VisualBasic.CompilerServices;
using System;

namespace FibonacciSequenceAlgorithm
{
    class Program
    {
        public static int FibonacciAlgorithmArray(int FibonacciSequencePosition) // for my program value 0 is 0th fibonacci sequence argument...
        {
            int[] Arguments = new int[FibonacciSequencePosition+1];
            Arguments[0] = 0;
            Arguments[1] = 1;
            for (int i = 2; i <= FibonacciSequencePosition; i++)
            {
                Arguments[i] = Arguments[i - 1] + Arguments[i - 2];
            }
            return Arguments[FibonacciSequencePosition];
            // array stores first n sequence arguments
            // where last one is the biggest and also the one we are aiming for here 
            // it takes a lot of memory but would be useful if we need more inf 
            // than only value of n-th arg...             
        }
        public static int FibonacciAlgorithmSingleValue(int FibonacciSequencePosition)
        {
            int SmallerValueArgument = 0;
            int GreaterValueArgument = 1;
            int Buffer;
            for(int i = 2; i <= FibonacciSequencePosition; i++)
            {
                Buffer = GreaterValueArgument + SmallerValueArgument;
                SmallerValueArgument = GreaterValueArgument;
                GreaterValueArgument = Buffer;
            }
            return GreaterValueArgument;
        }
        static void Main(string[] args)
        {            
            int FibonacciSequencePosition;
            do
            {
                Console.WriteLine("Argument : ");
                FibonacciSequencePosition = int.Parse(Console.ReadLine());
            } while (FibonacciSequencePosition < 2);
            Console.WriteLine("Wartosc Array : " + FibonacciAlgorithmArray(FibonacciSequencePosition));
            Console.WriteLine("Wartosc Single Value : " + FibonacciAlgorithmSingleValue(FibonacciSequencePosition));
        }
    }
}
