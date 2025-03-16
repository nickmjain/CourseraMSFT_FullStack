// See https://aka.ms/new-console-template for more information
using System.Drawing;
using System.Xml.Serialization;
using Course2_IntrotoCSharp.Module_2;
using Course2_IntrotoCSharp.Module4;
using Pastel;

Console.WriteLine("Hello, World!".Pastel(Color.LightGreen));

// Run "Run" method from calculator
Console.WriteLine("\nRunning Calculator method to add 5 + 10");
Calculator.Run();
Console.WriteLine("\nRunning Display Numbers method print numbers 1 to 10");
NumberDisplay.DisplayNumbers();

// Disable
if (false)
{
    Console.WriteLine("\nRunning Greet user method to say Hello Name!");
    UserInput.GreetUser();

    Console.WriteLine("\nRunning Task manager");
    bool running = true;
    while (running)
    {
        Console.WriteLine("\nWhat would you like to do?");
        Console.WriteLine("1. Add a task");
        Console.WriteLine("2. View tasks");
        Console.WriteLine("3. Complete a task");
        Console.WriteLine("4. Exit");
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                ToDoList.AddTask();
                break;
            case "2":
                ToDoList.ViewTasks();
                break;
            case "3":
                ToDoList.CompleteTask();
                break;
            case "4":
                running = false;
                break;
        }
    }

    // Create an instance of asyncPractice and call RunAsync
    asyncPractice asyncPracticeInstance = new asyncPractice();
    await asyncPracticeInstance.SimulateDelayAsync();

}



