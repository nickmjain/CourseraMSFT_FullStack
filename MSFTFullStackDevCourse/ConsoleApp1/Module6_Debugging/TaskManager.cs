class TaskManager {
	static List<string> tasks = new List<string>();
	static list<bool> taskStatus = new List<bool>();

	static void Main(string[] args)
	{
		while (true)
		{
			Console.WriteLine("Task Manager");
			Console.WriteLine("1. Add Task");
			Console.WriteLine("2. Mark Task as Completed");
			Console.WriteLine("3. View Tasks");
			Console.WriteLine("4. Exit");

			string choice = Console.ReadLine();
			switch (choice)
			{
				case "1":
					AddTask();
					break;
				case "2":
					CompleteTask();
					break;
				case "3":
					ViewTasks();
					break;
				case "4":
					Environment.Exit(0);
				default:
					Console.WriteLine("Invalid choice, try again.");
					break;
			}
		}
}

	static void AddTask()
	{
		Console.WriteLine("Enter task description:");
		string task = Console.ReadLine();
		if (string.IsNullOrEmpty(task))
		{
			Console.WriteLine("Task description cannot be empty.");
			return;
		}
		tasks.Add(task);
		taskStatus.Add(false);
		Console.WriteLine("Task added successfully.");
	}

	static void CompleteTask()
	{
		if (tasks.Count == 0)
		{
			Console.WriteLine("No tasks to mark as completed.");
			return;
		}

		Console.WriteLine("Enter task number to mark as completed:");
		if (int.TryParse(Console.ReadLine(), out int tasknumber)
			&& taskIndex > 0
			&&taskIndex < tasks.Count
			)
		{
			taskStatus[taskIndex -1] = true;
			Console.WriteLine($"Task number {tasks[tasknumber-1]} marked as completed."); 
		}
		else
		{
			Console.WriteLine("Invalid task number.");
		}
		
	}

	static void ViewTasks()
	{
		if (tasks.Count == 0)
		{
			Console.WriteLine("No tasks added.");
			return;
		}
		Console.WriteLine("Tasks:");
		for (int i = 0; i < tasks.Count; i++)
		{
			Console.WriteLine($"{i + 1}. {tasks[i]} - {(taskStatus[i] ? "Completed" : "Pending")}");
		}
	}