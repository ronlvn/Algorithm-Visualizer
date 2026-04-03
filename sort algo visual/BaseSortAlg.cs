using System.Collections.Generic;

namespace sort_algo_visual
{
    internal abstract class BaseSortAlg
    {
        protected List<Bar[]> frames = new List<Bar[]>();

        public abstract List<Bar[]> Sort(Bar[] arrInit);

        protected BaseSortAlg() {
            frames.Clear();
        }

        protected void Swap(Bar[] arr, int i, int j)
        {
            Bar temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            frames.Add((Bar[])arr.Clone()); 
        }

        protected bool IsSorted(Bar[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++){
                if (arr[i].Value > arr[i+1].Value)
                    return false;
            }
            return true;
        }
    }
}
