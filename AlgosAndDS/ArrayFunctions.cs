namespace Functions;
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
}