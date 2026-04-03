using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace sort_algo_visual
{
    public partial class Form1 : Form
    {
        private Bar[] currentArray;
        private List<Bar[]> frames;
        private int currentFrame = 0;
        private Random rand = new Random();
        int size = 50;

        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // להפתח במסך מלא
            GenerateNewArray();
        }

        private void GenerateNewArray()
        {
            currentArray = new Bar[size];
            for (int i = 0; i < size; i++){
                currentArray[i].Value = i+1;
                currentArray[i].BarColor = GetRainbowColor(i, size);
            }

            Shuffle(currentArray);
            frames = new List<Bar[]>();
            frames.Add((Bar[])currentArray.Clone());
            currentFrame = 0;
            pictureBox1.Invalidate();
        }

        private Color GetRainbowColor(int index, int total) // מחזיר צבע תלוי אינדקס וכמות איברים
        {
            float hue = ((float)index / total) * 360f;
            return ColorFromHSV(hue, 0.8f, 0.9f);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            GenerateNewArray();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cmbAlgorithm.SelectedItem == null) return;
            string alg = cmbAlgorithm.SelectedItem.ToString();

            switch (alg){
                case "Bubble Sort":
                    frames = new BubbleSortAlg().Sort(currentArray);
                    break;

                case "Quick Sort":

                    frames = new QuickSortAlg().Sort(currentArray);
                    break;

                case "Bogo Sort":
                    frames = new BogoSortAlg().Sort(currentArray);
                    break;

                case "Merge Sort":
                    frames = new MergeSortAlg().Sort(currentArray);
                    break;
            }

            currentFrame = 0;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentFrame < frames.Count - 1){
                currentFrame++;
                pictureBox1.Invalidate();
            }
            else { timer1.Stop(); }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (frames == null || frames.Count <= currentFrame)
                return;

            Bar[] frame = frames[currentFrame];
            float stepWidth = (float)pictureBox1.Width / frame.Length;
            float gap = 5.0f;
            float barWidth = Math.Max(1, stepWidth - gap);

            for (int i = 0; i < frame.Length; i++){
                int barHeight = (int)(((float)frame[i].Value / frame.Length) * (pictureBox1.Height - 40));
                float x = (i * stepWidth) + (gap / 2);
                float y = pictureBox1.Height - barHeight;

                using (SolidBrush brush = new SolidBrush(frame[i].BarColor))
                {
                    e.Graphics.FillRectangle(brush, x, y, barWidth, barHeight);
                }
            }
        }

        private void tbSpeed_Scroll(object sender, EventArgs e)
        {
            timer1.Interval = 101 - tbSpeed.Value;
        }

        private void Shuffle(Bar[] arr)
        {
            for (int i = arr.Length - 1; i > 0; i--){
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

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            size = trackBar1.Value;
            timer1.Stop();
            GenerateNewArray();

        }
    }
}