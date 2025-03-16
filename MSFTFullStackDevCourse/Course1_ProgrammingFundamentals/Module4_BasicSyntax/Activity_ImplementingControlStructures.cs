
public class ImplementingControlStructures
{
    public static void Run()
    {
        int dataNeedsGB = 7;
        string plan;

        switch (dataNeedsGB)
        {
            case 2:
                plan = "Basic Plan";
                break;
            case 5:
                plan = "Standard Plan";
                break;
            case 10:
                plan = "Premium Plan";
                break;
            default:
                plan = "Elite Plan";
                break;
        }
        Console.WriteLine("You need " + dataNeedsGB + "GB of data. We recommend the " + plan);


    }
}
