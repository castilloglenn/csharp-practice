namespace ConsoleApp;

class Program
{
    static void Main(string[] args)
    {
        string test = "This is a test string.";
        int length = test.Length;
        string[] strings = { "Hello", "World", "!" };

        string? nullableString = null;
        if (nullableString != null)
        {
            Console.WriteLine(nullableString);
        }

        int parsedNumber = int.Parse(nullableString!);
        Console.WriteLine(parsedNumber);

        Console.WriteLine("Done!");
    }
}
