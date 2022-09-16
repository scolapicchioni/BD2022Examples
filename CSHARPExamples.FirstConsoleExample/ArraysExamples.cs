using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSHARPExamples.FirstConsoleExample {
    public class ArraysExamples {
        public void Lab02() {
            int[,] uniqueMatrix = GenerateUniqueMatrix(3, 3);
            PrintMatrix(uniqueMatrix);
        }

        public void PrintMatrix(int[,] matrix) {
            for (int row = 0; row < matrix.GetLength(0); row++) {
                for (int col = 0; col < matrix.GetLength(1); col++) {
                    Console.Write(matrix[row, col] + "  ");
                }
                Console.WriteLine();
            }
        }
        public int[,] GenerateUniqueMatrix(int height, int width) {
            Random randomGenerator = new Random();

            int[,] matrix = new int[height, width];
            bool[] extracted = new bool[width * height];

            for (int row = 0; row < height; row++) {
                for (int col = 0; col < width; col++) {
                    int n;
                    do {
                        n = randomGenerator.Next(1, height * width + 1);
                    } while (extracted[n - 1] == true);
                    extracted[n - 1] = true;
                    matrix[row, col] = n;
                }
            }
            return matrix;
        }
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

        
    }
}
