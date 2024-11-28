namespace AlgosAndDS.Helpers;
public static class ArrayFunctions
{
    public static int[] GetOrderedArray(int numberOfElements)
    {
        var array = new int[numberOfElements];
        for (int i = 0; i < numberOfElements; i++)
        {
            array[i] = i;
        }
        return array;
    }

    public static int[] RandomizeWithOrderByAndGuid(int[] array) =>
    array.OrderBy(x => Guid.NewGuid()).ToArray();
    public static int[] GetRandomArrayWithRepetitions(int numberOfElements, int maxValue)
    {
        var array = new int[numberOfElements];
        for (int i = 0; i < numberOfElements; i++)
        {
            array[i] = Random.Shared.Next(maxValue);
        }
        return array;
    }


}