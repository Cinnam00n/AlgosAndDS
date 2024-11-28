
using Functions;

internal class Program
{
    private static void Main(string[] args)
    {
        var array = ArrayFunctions.GetOrderedArray(5);

        Console.WriteLine("[{0}]", string.Join(", ", array));

        Console.ReadLine();
    }
}