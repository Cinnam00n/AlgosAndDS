
using AlgosAndDS.Helpers;
using AlgosAndDS.Helpers.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {



        var array = ArrayFunctions.GetRandomArrayWithRepetitions(10, 5);
        Console.WriteLine("Array to check in the Pair With Given Sum Problem: ");
        Console.WriteLine("[{0}]", string.Join(", ", array));

        var pairWithGivenSumResult = PairWithGivenSum.SolvePairWithGivenSumNaive(array, 5);

        Console.WriteLine("Test result: {0:S}\n" +
            "first index: {1:G}\n" +
            "second index: {2:G}\n",
            pairWithGivenSumResult.Result,
            pairWithGivenSumResult.firstIndex,
            pairWithGivenSumResult.secondIndex);


        Console.ReadLine();
    }
}