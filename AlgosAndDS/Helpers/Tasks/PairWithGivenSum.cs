using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AlgosAndDS.Helpers.Tasks
{
    // Given an array arr[] of n integers and a target value,
    // the task is to find whether there is a pair of elements in the array whose sum is equal to target.
    // This problem is a variation of 2Sum problem.


    public static class PairWithGivenSum
    {
        public static ResultModel SolvePairWithGivenSumNaive(int[] array, int target)
        {
            ResultModel result = new ResultModel();
            result.Result = false;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] + array[j] == target && i != j)
                    {
                        result.Result = true;
                        result.firstIndex = i;
                        result.secondIndex = j;
                        break;
                    };
                }
            }
            return result;
        }

        public class ResultModel
        {
            public bool Result { get; set; }
            public int? firstIndex { get; set; }
            public int? secondIndex { get; set; }
        }
    }
}
