using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static sort_algo_visual.ArrayGenLogic;

namespace sort_algo_visual
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized; // להפתח במסך מלא
            GenerateNewRandomArray();
            pictureBox1.Invalidate();
        }



        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            GenerateNeededArray();
            pictureBox1.Invalidate();
        }

        private void GenerateNeededArray()
        {
            if (arrType.SelectedItem == null) return;
            string order = arrType.SelectedItem.ToString();
            switch (order) { 
                case "Random":
                    ArrayGenLogic.GenerateNewRandomArray();
                    pictureBox1.Invalidate();
                    break;
                case "Sorted":
                    ArrayGenLogic.GenerateSortedArray();
                    pictureBox1.Invalidate();
                    break;
                case "Reversed":
                    ArrayGenLogic.GenerateReversedArray();
                    pictureBox1.Invalidate();
                    break;
                case "Best Case":
                    if (cmbAlgorithm.SelectedItem == null) return;
                    string alg = cmbAlgorithm.SelectedItem.ToString();
                    switch (alg) { 
                        case "Bubble Sort":
                            ArrayGenLogic.GenerateSortedArray();
                            pictureBox1.Invalidate();
                            break;
                        case "Quick Sort":
                            ArrayGenLogic.GenerateSortedArray();
                            pictureBox1.Invalidate();
                            break;
                        case "Bogo Sort":
                            ArrayGenLogic.GenerateSortedArray();
                            pictureBox1.Invalidate();
                            break;
                        case "Merge Sort":
                            ArrayGenLogic.GenerateSortedArray();
                            pictureBox1.Invalidate();
                            break;
                    }
                    break;

                case "Worst Case":
                    if (cmbAlgorithm.SelectedItem == null) return;
                    alg = cmbAlgorithm.SelectedItem.ToString();
                    switch (alg)
                    {
                        case "Bubble Sort":
                            ArrayGenLogic.GenerateReversedArray();
                            pictureBox1.Invalidate();
                            break;
                        case "Quick Sort":
                            ArrayGenLogic.GenerateSortedArray();


                            for (int i = 0; i < size; i++){
                                int mid = i / 2;
                                int temp = currentArray[mid].Value;
                                currentArray[mid].Value = currentArray[i].Value;
                                currentArray[i].Value = temp;
                            }

                            for (int i = 0; i < size; i++)
                                currentArray[i].BarColor = GetRainbowColor(currentArray[i].Value - 1, size);

                            frames = new List<Bar[]>();
                            frames.Add((Bar[])currentArray.Clone());
                            currentFrame = 0;

                            pictureBox1.Invalidate();

                            break;
                        case "Bogo Sort":
                            ArrayGenLogic.GenerateNewRandomArray();
                            pictureBox1.Invalidate();
                            break;
                        case "Merge Sort":
                            currentArray = new Bar[size];

                            
                            for (int i = 0; i < size; i++){
                                currentArray[i].Value = i + 1;
                                currentArray[i].BarColor = GetRainbowColor(i, size);
                            }

                            MergeSortWorstCaseEzer(currentArray);
                            void MergeSortWorstCaseEzer(Bar[] arr){
                                    if (arr.Length <= 1) return;

                                    Bar[] left = arr.Where((val, index) => index % 2 == 0).ToArray();
                                    Bar[] right = arr.Where((val, index) => index % 2 != 0).ToArray();

                                MergeSortWorstCaseEzer(left);
                                MergeSortWorstCaseEzer(right);
                                    left.CopyTo(arr, 0);
                                    right.CopyTo(arr, left.Length);
                            }
                            frames = new List<Bar[]>();
                            frames.Add((Bar[])currentArray.Clone());
                            currentFrame = 0;
                            pictureBox1.Invalidate();
                            break;
                    }
                    break;
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cmbAlgorithm.SelectedItem == null) return;
            string alg = cmbAlgorithm.SelectedItem.ToString();

            Stopwatch sw = new Stopwatch();
            sw.Start();

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
            sw.Stop();
            if (frames.Count < 10000)
                timeandaction.Text = $"Time: {sw.Elapsed.TotalMilliseconds} ms, Actions: {frames.Count}";
            else
                timeandaction.Text = $"Bogo sort took too much time!";

            // החלק של האנימציה, לא קשור למדידת הזמן
            currentFrame = 0;
            timer1.Start(); 
        }
          
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (currentFrame < frames.Count - 1){
                currentFrame++;
                pictureBox1.Invalidate();
            }
            else { timer1.Stop();
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (frames == null || frames.Count <= currentFrame)
                return;

            Bar[] frame = frames[currentFrame];
            float stepWidth = (float)pictureBox1.Width / frame.Length;
            float gap = 5.0f;
            float barWidth = Math.Max(1, stepWidth - gap);

            for (int i = 0; i < frame.Length; i++)
            {
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

        
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            size = trackBar1.Value;
            timer1.Stop();
            GenerateNeededArray();
            pictureBox1.Invalidate();

        }

        private void arrType_SelectedIndexChanged(object sender, EventArgs e)
        {
            timer1.Stop(); 
            GenerateNeededArray();
            pictureBox1.Invalidate();
        }
    }
}