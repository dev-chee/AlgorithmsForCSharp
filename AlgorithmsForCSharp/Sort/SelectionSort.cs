using System;
using System.Collections.Generic;

namespace AlgorithmsForCSharp.Sort
{
    public static class SelectionSort
    {
        public static void Sort<T>(T[] array) where T : IComparable<T>
        {
            for (var i = 0; i < array.Length - 1; i++)
            {
                var min = i;

                for (var j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(array[min]) < 0) min = j;
                }

                if (min != i) Swap(array, i, min);
            }
        }

        private static void Swap<T>(IList<T> array, int first, int second)
        {
            var temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }
}