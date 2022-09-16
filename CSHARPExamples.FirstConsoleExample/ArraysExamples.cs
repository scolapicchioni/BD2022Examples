using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPExamples.FirstConsoleExample {
    public class ArraysExamples {
        public void Lab01() {
            /*
             Write a program that reads ten integer numbers from the console, then calculates the sum of these numbers. 
             Store the numbers in an array. 
            */

            int[] numbers = new int[10];

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++) {
                Console.Write($"Please insert number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine()!);
                sum += numbers[i];
            }

            Console.Write("The sum of ");
            for (int i = 0; i < numbers.Length; i++) {
                Console.Write($"{numbers[i]} {(i < numbers.Length - 1 ? " + " : "")}");
            }
            Console.WriteLine($" is {sum}");
        }
        public void Example01() {

            //value type
            int number;

            //reference type
            int[] numbers =

            //object
            new int[10];

            numbers[0] = 1;
            numbers[1] = 10;
            numbers[5] = 1111;
            numbers[2] = 341;
            numbers[7] = 156;

            
            numbers = new int[] { 1, 10, 0, 111, 341 };

            int[] copy = numbers;

            copy[0] = 123456;
            Console.WriteLine(numbers[^1]);

            int howManyPerRow = int.Parse(Console.ReadLine());

            int[,] matrix = new int[10, 3];

            PrintMatrix(matrix);

            ChangeArray(copy);

            int i = 0;
            Index index = ^1;

            Range range = 2..4;

            //numbers[2..4]

            string[] names = { "Frank", "James", "Mark", "Paul" };
            //for (int i = 0; i < names.Length; i++) {
            //    string name = names[i];

            //}

            foreach (string name in names) {

            }

        }

        internal void ChangeArray(int[] anArray) {
            for (int i = 0; i < anArray.Length; i++) {
                anArray[i] = anArray[i] * 5;
            }
        }

        internal void PrintMatrix(int[,] matrixToPrint) {
            for (int r = 0; r < matrixToPrint.GetLength(0); r++) {
                for (int c = 0; c < matrixToPrint.GetLength(1); c++) {
                    Console.Write($"{matrixToPrint[r,c]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}
