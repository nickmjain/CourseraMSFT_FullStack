
public class basicSyntax
{
    public static void Run()
    {
        int age;
        Console.WriteLine("Enter your age: ");
        string? ageInput = Console.ReadLine();
        if (ageInput == null)
        {
            Console.WriteLine("Invalid non integer input");
            return;
        }
        else
        {
            age = int.Parse(ageInput);
        }
  

        // if statements
        if (age >= 18)
        {
            Console.WriteLine("You are an adult");
        }
        else
        {
            Console.WriteLine("You are a minor");
        }

        // switch statements, each case can only be testing for a singular value
        switch (age)
        {
            case 18:
                Console.WriteLine("You are 18 years old");
                break;
            case 21:
                Console.WriteLine("You are 21 years old");
                break;
            default:
                Console.WriteLine("You are neither 18 nor 21 years old");
                break;
        }

        // for loop practice
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("For loop i = " + i);
        }


        // while loop practice
        int counter = 1;
        while (counter < 10)
        {
            Console.WriteLine("While loop counter = " + counter);
            counter++;
        }

        // do while loops, will always run at least once
        int doWhileCounter = 10;
        do 
        {
            Console.WriteLine("Do While loop counter = " + doWhileCounter);
            doWhileCounter++;
        } while (doWhileCounter < 10);


        // iterating through the array in two ways
        int[] numbers = { 20, 15, 14, 3, 22, 26 };
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] % 2 == 0) Console.WriteLine("For loop array, even elements at position " + i + " is value " + numbers[i]);    
        }
        foreach (int number in numbers)
        {
            if (number % 2 != 0) Console.WriteLine("For loop array, odd element: " + number);
        }

        // use of break and continue
        // First loop stops after iteration 5
        // second loop skips iteration 5
        for (int i = 0; i < 10; i++)
        {
            if (i == 5) break;
            Console.WriteLine("Break loop i = " + i);
        }
        for (int i = 0; i < 10; i++)
        {
            if (i == 5) continue;
            Console.WriteLine("Break loop i = " + i);
        }

    }
}
