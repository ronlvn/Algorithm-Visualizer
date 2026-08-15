
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace sort_algo_visual.sorts
{
    internal class HeapSortAlg : BaseSortAlg
    {
        public override List<Bar[]> Sort(Bar[] arrInit)
        {
            int n = arrInit.Length;
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                HeapifyUp(arrInit, n, i);
            }
            for (int i = n - 1; i > 0; i--)
            {
                Swap(arrInit, 0, i);
                HeapifyUp(arrInit, i, 0);
            }

            return frames;
        }

        private void HeapifyUp(Bar[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && arr[left].Value > arr[largest].Value)
            {
                largest = left;
            }
            if (right < n && arr[right].Value > arr[largest].Value)
            {
                largest = right;
            }
            if (largest != i)
            {
                Swap(arr, i, largest);
                HeapifyUp(arr, n, largest);
            }
        }
    }
}
