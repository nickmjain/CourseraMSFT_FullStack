using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course2_IntrotoCSharp.Module_2
{
    public class ToDoList
    {
        public static string[] tasks = new string[10];
        public static int taskCount = 0;
        public static void AddTask()
        {
            Console.WriteLine("Please enter the task:");
            string task = Console.ReadLine();
            tasks[taskCount] = task;
            taskCount++;
        }
        public static void ViewTasks()
        {
            Console.WriteLine("The current tasks are:");
            for (int i = 0; i < taskCount; i++)
            {
                Console.WriteLine((1+1) + "." + tasks[i]);
            }
        }

        public static void CompleteTask()
        {
            Console.WriteLine("Please enter the task number to complete:");
            int taskNumber = Convert.ToInt32(Console.ReadLine());
            if (taskNumber > 0 && taskNumber <= taskCount)
            {
                for (int i = taskNumber - 1; i < taskCount - 1; i++)
                {
                    tasks[i] = tasks[i + 1];
                }
                taskCount--;
            }
            else
            {
                Console.WriteLine("Invalid task number");
            }
        }

    }
}
