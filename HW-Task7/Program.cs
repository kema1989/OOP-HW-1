using System;
using System.Collections.Generic;

namespace HW_Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static int[] Method(int[] array, params int[] del)
        {
            var newList = new List<int>();
            int counter = 0;
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < del.Length; j++)
                {
                    if(array[i] == del[j])
                    {
                        counter++;
                        
                    }
                }
            }

            int[] newArray = new int[array.Length - counter];

            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < del.Length; j++)
                {
                    if(array[i] == del[j])
                    {

                    }
                }
            }
        }
    }
}
