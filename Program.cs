using System;

namespace AreArraysEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Put in the array's first three elements.");
            int[] arr1 = new int[3];
            arr1[0] = int.Parse(Console.ReadLine());
            arr1[1] = int.Parse(Console.ReadLine());
            arr1[2] = int.Parse(Console.ReadLine());

            Console.WriteLine("Put in the array's second three elements.");
            int[] arr2 = new int[3];
            arr2[0] = int.Parse(Console.ReadLine());
            arr2[1] = int.Parse(Console.ReadLine());
            arr2[2] = int.Parse(Console.ReadLine());

            if (arr1[0] == arr2[0] && arr1[1] == arr2[1] && arr1[2] == arr2[2])
            {
                Console.WriteLine("Both arrays are equal.");
            }
            else
            {
                Console.WriteLine("Both arrays are not equal.");
            }
            

        }
    }
}
