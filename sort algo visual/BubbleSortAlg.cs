
using System.Collections.Generic;

namespace sort_algo_visual
{
    internal class BubbleSortAlg : BaseSortAlg
    {
        public override List<Bar[]> Sort(Bar[] arrInit)
        {
            Bar[] arr = (Bar[])arrInit.Clone();
            frames.Add((Bar[])arr.Clone());

            for (int i = 0; i < arr.Length - 1; i++){
                for (int j = 0; j < arr.Length - i - 1; j++){
                    if (arr[j].Value > arr[j + 1].Value)
                        Swap(arr, j, j + 1);
                }
            }
            return frames;
        }
    }
}
