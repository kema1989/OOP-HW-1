using System;

namespace OOP_HW_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var array1 = new int[10] { 8, 4, 2, 7, 5, 10, 1, 9, 3, 6 };

            var arrayClone = (int[])array1.Clone(); 

            var array2 = array1;

            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] += SortDesc(arrayClone)[i];
            }

            foreach (int num in array2)
            {
                Console.Write(num + " ");
            }

            Console.ReadKey();
        }

        static int[] SortDesc(int[] array)
        {
            int temp;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
    }
}
