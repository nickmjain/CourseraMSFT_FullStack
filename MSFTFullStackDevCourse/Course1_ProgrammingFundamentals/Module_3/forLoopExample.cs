
public class forLoopExample
{
    public static void Run()
    {
        int[] numbers = {20, 15, 17, 3, 8, 9};
        int sum = 0;
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
            sum = sum + num;
        }
        Console.WriteLine("Sum: " + sum);
    }
}
