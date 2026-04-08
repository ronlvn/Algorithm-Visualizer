using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace sort_algo_visual
{
    internal static class ArrayGenLogic
    {
        public static Bar[] currentArray;
        public static List<Bar[]> frames;
        public static int currentFrame = 0;
        public static int size = 50;
        private static Random rand = new Random();


        public static void GenerateNewRandomArray()
        {
            currentArray = new Bar[size];
            for (int i = 0; i < size; i++)
            {
                currentArray[i].Value = i + 1;
                currentArray[i].BarColor = GetRainbowColor(i, size);
            }

            Shuffle(currentArray);
            frames = new List<Bar[]>();
            frames.Add((Bar[])currentArray.Clone());
            currentFrame = 0;
        }



        public static void GenerateSortedArray()
        {
            currentArray = new Bar[size];
            for (int i = 0; i < size; i++)
            {
                currentArray[i].Value = i + 1;
                currentArray[i].BarColor = GetRainbowColor(i, size);
            }
            frames = new List<Bar[]>();
            frames.Add((Bar[])currentArray.Clone());
            currentFrame = 0;
            
        }



        public static void GenerateReversedArray()
        {
            currentArray = new Bar[size];
            for (int i = 0; i < size; i++)
            {
                currentArray[i].Value = size - i;
                currentArray[i].BarColor = GetRainbowColor(size - i - 1, size);
            }
            frames = new List<Bar[]>();
            frames.Add((Bar[])currentArray.Clone());
            currentFrame = 0;
        }

        public static Color GetRainbowColor(int index, int total) // מחזיר צבע תלוי אינדקס וכמות איברים
        {
            float hue = ((float)index / total) * 360f;
            return ColorFromHSV(hue, 0.8f, 0.9f);
        }

        public static void Shuffle(Bar[] arr)
        {
            for (int i = arr.Length - 1; i > 0; i--)
            {
                int k = rand.Next(i + 1);
                Bar temp = arr[i];
                arr[i] = arr[k];
                arr[k] = temp;
            }
        }

        public static Color ColorFromHSV(double hue, double saturation, double value)// hsv to rgb conversion (thanks gemini)
        {
            int hi = Convert.ToInt32(Math.Floor(hue / 60)) % 6;
            double f = hue / 60 - Math.Floor(hue / 60);
            value = value * 255;
            int v = Convert.ToInt32(value);
            int p = Convert.ToInt32(value * (1 - saturation));
            int q = Convert.ToInt32(value * (1 - f * saturation));
            int t = Convert.ToInt32(value * (1 - (1 - f) * saturation));

            if (hi == 0) return Color.FromArgb(255, v, t, p);
            if (hi == 1) return Color.FromArgb(255, q, v, p);
            if (hi == 2) return Color.FromArgb(255, p, v, t);
            if (hi == 3) return Color.FromArgb(255, p, q, v);
            if (hi == 4) return Color.FromArgb(255, t, p, v);
            return Color.FromArgb(255, v, p, q);
        }

    }
}
