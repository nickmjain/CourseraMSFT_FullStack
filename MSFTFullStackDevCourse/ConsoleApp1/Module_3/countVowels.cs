
public class countVowels
{
    public static void Run()
    {
        string text = "Hello World";
        int vowelCount = 0;

        foreach (char c in text.ToLower())
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
            {
                vowelCount++;
            }
        }
        Console.WriteLine("Hello World has 3 vowels");
        Console.WriteLine("Vowel Count calculated by program: " + vowelCount);
    }
}
