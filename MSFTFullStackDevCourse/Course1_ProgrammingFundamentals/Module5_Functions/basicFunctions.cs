
public class basicFunctions
{
    public static int calculateTotal(int[] values)
    {
        int sum = 0;
        foreach (int num in values)
        {
            Console.WriteLine(num);
            sum = sum + num;
        }
        Console.WriteLine("sum of array " + sum);
        return sum;
    }

    public static double triangleArea (double b, double h)
    {
        double area = b * h / 2;
        Console.WriteLine("Area of triangle: with b= " +b + "and height = " + h + " is "+ area);
        return area;
    }
}
