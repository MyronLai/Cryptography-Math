﻿using System;
using System.Collections.Generic;
using System.Numerics;

namespace Cryptography_Math
{
    class Program
    {
        public static void factor()
        {
            Console.WriteLine("enter a number");
            BigInteger respond = BigInteger.Parse(Console.ReadLine());
            Console.WriteLine("calculating...");
            for (BigInteger i = 1; i < respond + 1; i++)
            {
                if (respond % i == 0)
                {
                    Console.WriteLine($"{i}");
                }
            }
            Console.WriteLine("DONE");
        }

        public static void GCF()
        {
            Console.WriteLine("Enter a number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number");
            int secondNumber = int.Parse(Console.ReadLine());

            int whatNum = 0;

            if (firstNumber > secondNumber)
            {
                whatNum = secondNumber;
            }

            else
            {
                whatNum = firstNumber;
            }

            for (int i = 1; i < whatNum + 1; i++)
            {
                if (firstNumber % i == 0 && secondNumber % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("DONE");
        }

        public static void Relatively_Prime()
        {
            Console.WriteLine("Enter a number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number");
            int secondNumber = int.Parse(Console.ReadLine());

            int whatNum = 0;

            List<int> factors = new List<int>();

            if (firstNumber > secondNumber)
            {
                whatNum = secondNumber;
            }

            else
            {
                whatNum = firstNumber;
            }

            for (int i = 1; i < whatNum + 1; i++)
            {
                if (firstNumber % i == 0 && secondNumber % i == 0)
                {
                    factors.Add(i);
                }
            }

            if (factors.Count == 1)
            {
                Console.WriteLine("True");
            }

            else
            {
                Console.WriteLine("False");
            }
            Console.WriteLine("DONE");
        }

        public static void isPrime()
        {
            List<BigInteger> factors = new List<BigInteger>();

            Console.WriteLine("enter a number");
            BigInteger respond = BigInteger.Parse(Console.ReadLine());
            for (BigInteger i = 1; i < respond + 1; i++)
            {
                if (respond % i == 0)
                {
                    factors.Add(i);
                }
            }

            if (factors.Count == 2)
            {
                Console.WriteLine("True");
            }

            else
            {
                Console.WriteLine("False");
            }

            Console.WriteLine("DONE");
        }

        public static void uniqueRelativelyPrime()
        {
            Console.WriteLine("Calculating...");

            for (int i = 0; i < 101; i++)
            {
                for (int j = i + 1; j < 101; j++)
                {
                    int firstNumber = i;

                    int secondNumber = j;

                    int whatNum = 0;

                    List<int> factors = new List<int>();

                    if (firstNumber > secondNumber)
                    {
                        whatNum = secondNumber;
                    }

                    else
                    {
                        whatNum = firstNumber;
                    }

                    for (int k = 1; k < whatNum + 1; k++)
                    {
                        if (firstNumber % k == 0 && secondNumber % k == 0)
                        {
                            factors.Add(k);
                        }
                    }

                    if (factors.Count == 1)
                    {
                        Console.WriteLine($"Number 1: {firstNumber}, Number 2: {secondNumber}");
                    }
                }
            }

            Console.WriteLine("DONE");
        }

        public static void multiplicativeInverse()
        {
            Console.WriteLine("Enter a number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number");
            int num2 = int.Parse(Console.ReadLine());

            int x = 0;

            int result = 0;

            while (true)
            {
                if ((x * (num1)) % num2 == 1)
                {
                    result = x;
                    break;
                }

                else
                {
                    x++;
                }

                Console.WriteLine($"X: {x}, Number 1: {num1}, Number 2: {num2}, Result: {(x * (num1)) % num2}");
            }

            Console.WriteLine($"Result number: {result}");
        }

        public static BigInteger Factorial(int num)
        {
            if (num < 1)
            {
                return 1;
            }


            return num * Factorial(num -1);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();

            int length = input.Length;

            char[] letters = new char[length];

            for (int i = 0; i < length; i++)
            {
                letters[i] = input[i];
            }

            for (int i = 0; i < length; i++)
            {
                char extra = letters[i];
                if (i >= letters.Length)
                {
                    char extra2 = letters[0];
                    letters[0] = letters[i];
                    letters[i] = extra2;
                }
                else
                {
                    letters[i] = letters[i + 1];
                    letters[i + 1] = extra;
                }
            }


            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{i}: {letters[i]}");
            }

            Console.WriteLine(Factorial(length));

            Console.ReadKey();
        }
    }
}