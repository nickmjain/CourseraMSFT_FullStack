
public class VendingMachine
{
    public static void Run()
    {
        int age;
        Console.WriteLine("Enter your age: ");
        string? input = Console.ReadLine();

        if (input == null)
        {
            Console.WriteLine("Invalid non integer input");
            return;
        }
        else
        {
            age = int.Parse(input);
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
    }
}
