using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course2_IntrotoCSharp.Module5
{
    class CoPilotTest
    {
        // Code to get user input of age, verify it's between 1-120 and print it
        public static void GetAge()
        {
            Console.WriteLine("Please enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age >= 1 && age <= 120)
            {
                Console.WriteLine($"Your age is {age}");
            }
            else
            {
                Console.WriteLine("Invalid age entered");
            }
        }

        List<int> numberList = new List<int> { 5, 10, 99, 4, 5, 8, 9, 10, 11, 12 };
        // Code to implement insertion sort on an arbitrary list
        public void InsertionSort(List<int> inputList)
        {
            for (int i = 1; i < inputList.Count; i++)
            {
                int key = inputList[i];
                int j = i - 1;
                while (j >= 0 && inputList[j] > key)
                {
                    numberList[j + 1] = inputList[j];
                    j = j - 1;
                }
                inputList[j + 1] = key;
            }
            Console.WriteLine("Sorted List:");
            foreach (int num in inputList)
            {
                Console.Write(num + " ");
            }
        }
        public void RunInsertionSort()
        {
            InsertionSort(numberList);
        }
    }
}
