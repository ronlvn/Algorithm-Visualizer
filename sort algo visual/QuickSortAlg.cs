
using System.Collections.Generic;

namespace sort_algo_visual
{
    internal class QuickSortAlg : BaseSortAlg
    {
        public override List<Bar[]> Sort(Bar[] arrInit)
        {
            Bar[] arr = (Bar[])arrInit.Clone();
            QuickSortHelper(arr, 0, arr.Length - 1);
            return frames;

        }

        private void QuickSortHelper(Bar[] arr, int low, int high)
        {
            if (low < high){
                int par = Partition(arr, low, high);
                QuickSortHelper(arr, low, par - 1);
                QuickSortHelper(arr, par + 1, high);
            }
        }


        private int Partition(Bar[] arr, int low, int high)// הפיווט הוא האיבר האחרון
        {
            int pivot = arr[high].Value;
            int i = low-1;
            for (int j = low; j <= high - 1; j++){
                if (arr[j].Value < pivot)
                    Swap(arr, ++i, j);
            }
            Swap(arr, i+1, high);
            return i+1;
        }
    }
}
