
using System.Collections.Generic;


namespace sort_algo_visual
{
    internal class MergeSortAlg : BaseSortAlg
    {
        public override List<Bar[]> Sort(Bar[] arrInit)
        {
            Bar[] arr = (Bar[])arrInit.Clone();
            frames.Add((Bar[])arr.Clone());
            MergeSortHelper(arr, 0, arr.Length - 1);

            return frames;
        }

        private void MergeSortHelper(Bar[] arr, int left, int right) 
        {
            if (left < right){
                int mid = left + (right - left) / 2; ///
                MergeSortHelper(arr, left, mid);/// מפצל לתתי מערכים
                MergeSortHelper(arr, mid + 1, right);///
                Merge(arr, left, mid, right); // מיזוג שני חצאים ממויינים
            }
        }

        private void Merge(Bar[] arr, int left, int mid, int right) // החלק של המיזוג שני מערכים ממויינים
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            Bar[] leftArray = new Bar[n1];
            Bar[] rightArray = new Bar[n2];

            for (int i = 0; i < n1; ++i)
                leftArray[i] = arr[left + i];
            for (int j = 0; j < n2; ++j)
                rightArray[j] = arr[mid + 1 + j];

            int iMerge = 0, jMerge = 0;
            int kMerge = left;

            while (iMerge < n1 && jMerge < n2){
                if (leftArray[iMerge].Value <= rightArray[jMerge].Value){
                    arr[kMerge] = leftArray[iMerge];
                    iMerge++;
                }
                else{
                    arr[kMerge] = rightArray[jMerge];
                    jMerge++;
                }

                frames.Add((Bar[])arr.Clone());
                kMerge++;
            }

            while (iMerge < n1){
                arr[kMerge] = leftArray[iMerge];
                iMerge++;
                frames.Add((Bar[])arr.Clone());
                kMerge++;
            }

            while (jMerge < n2){
                arr[kMerge] = rightArray[jMerge];
                jMerge++;
                frames.Add((Bar[])arr.Clone());
                kMerge++;
            }
        }
    }
}
