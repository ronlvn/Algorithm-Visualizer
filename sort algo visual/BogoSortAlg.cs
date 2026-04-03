using System;
using System.Collections.Generic;

namespace sort_algo_visual
{
    internal class BogoSortAlg : BaseSortAlg
    {
        private Random rand = new Random();

        public override List<Bar[]> Sort(Bar[] arrInit)
        {
            Bar[] arr = (Bar[])arrInit.Clone();
            frames.Add((Bar[])arr.Clone());
            int attempts = 0;
            //  מוגבל במספר נסיונות כיוון שבוגו עם חסם עליון אינסוף לכן צריך לשים גבול עד כמה ניסיונות יש לו, אחרת תוכנה קורסת
            // נבחר 10000 כדי לתת לו את אותו חסם עליון של מיון בועות
            // יצליח בממוצע למיין עד 7 איברים לפני שתוכנית תעצר
            while (!IsSorted(arr) && attempts < 10000){
                Shuffle(arr);
                frames.Add((Bar[])arr.Clone());
                attempts++;
            }
            return frames;
        }

        private void Shuffle(Bar[] arr)
        {
            for (int i = arr.Length - 1; i > 0; i--){
                int k = rand.Next(i+1);
                Bar temp = arr[i];
                arr[i] = arr[k];
                arr[k] = temp;
            }
        }
    }
}
