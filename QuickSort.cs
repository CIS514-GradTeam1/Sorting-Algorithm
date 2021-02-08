using System;

namespace SortingAlgo
{
    class QuickSort
    {
        public static List<T> QuickSort<T>(List<T> elements) where T : IComparable
        {
            var rand = new Random();

            if(elements.Count < 2) return elements;

            var pivot = rand.Next(0, elements.Count-1);
            var val = elements[pivot];

            var lesser = new List<T>();
            var greater = new List<T>();
            for (var i = 0; i < elements.Count; ++i)
            {
                if (i != pivot)
                {
                    if (elements[i].CompareTo(val) < 0)
                    {
                        lesser.Add(elements[i]);
                    }
                    else
                    {
                        greater.Add(elements[i]);
                    }
                }
            }

            var merged = QuickSort(lesser);
            merged.Add(val);
            merged.AddRange(QuickSort(greater));
            return merged;
        }
}