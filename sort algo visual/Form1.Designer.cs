namespace sort_algo_visual
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ComboBox cmbAlgorithm;
        private System.Windows.Forms.TrackBar tbSpeed;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Timer timer1;


        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox1 = new PictureBox();
            topPanel = new Panel();
            arrType = new ComboBox();
            timeandaction = new Label();
            trackBar1 = new TrackBar();
            label1 = new Label();
            lblSpeed = new Label();
            tbSpeed = new TrackBar();
            cmbAlgorithm = new ComboBox();
            btnStart = new Button();
            btnReset = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbSpeed).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 60);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1588, 524);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            // 
            // topPanel
            // 
            topPanel.BackColor = Color.LightGray;
            topPanel.Controls.Add(arrType);
            topPanel.Controls.Add(timeandaction);
            topPanel.Controls.Add(trackBar1);
            topPanel.Controls.Add(label1);
            topPanel.Controls.Add(lblSpeed);
            topPanel.Controls.Add(tbSpeed);
            topPanel.Controls.Add(cmbAlgorithm);
            topPanel.Controls.Add(btnStart);
            topPanel.Controls.Add(btnReset);
            topPanel.Dock = DockStyle.Top;
            topPanel.Location = new Point(0, 0);
            topPanel.Name = "topPanel";
            topPanel.Size = new Size(1588, 60);
            topPanel.TabIndex = 1;
            // 
            // arrType
            // 
            arrType.DropDownStyle = ComboBoxStyle.DropDownList;
            arrType.FormattingEnabled = true;
            arrType.Items.AddRange(new object[] { "Sorted", "Reversed", "Random", "Best Case", "Worst Case" });
            arrType.Location = new Point(356, 18);
            arrType.Name = "arrType";
            arrType.Size = new Size(120, 23);
            arrType.TabIndex = 8;
            arrType.SelectedIndexChanged += arrType_SelectedIndexChanged;
            // 
            // timeandaction
            // 
            timeandaction.AutoSize = true;
            timeandaction.Location = new Point(1585, 21);
            timeandaction.Name = "timeandaction";
            timeandaction.Size = new Size(0, 15);
            timeandaction.TabIndex = 7;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(732, 9);
            trackBar1.Maximum = 100;
            trackBar1.Minimum = 1;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(150, 45);
            trackBar1.TabIndex = 6;
            trackBar1.Value = 50;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(691, 21);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 5;
            label1.Text = "גודל:";
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Location = new Point(482, 21);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(48, 15);
            lblSpeed.TabIndex = 0;
            lblSpeed.Text = "מהירות:";
            // 
            // tbSpeed
            // 
            tbSpeed.Location = new Point(535, 9);
            tbSpeed.Maximum = 100;
            tbSpeed.Minimum = 1;
            tbSpeed.Name = "tbSpeed";
            tbSpeed.Size = new Size(150, 45);
            tbSpeed.TabIndex = 1;
            tbSpeed.Value = 50;
            tbSpeed.Scroll += tbSpeed_Scroll;
            // 
            // cmbAlgorithm
            // 
            cmbAlgorithm.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbAlgorithm.FormattingEnabled = true;
            cmbAlgorithm.Items.AddRange(new object[] { "Bubble Sort", "Quick Sort", "Merge Sort", "Bogo Sort", "Heap Sort" });
            cmbAlgorithm.Location = new Point(230, 18);
            cmbAlgorithm.Name = "cmbAlgorithm";
            cmbAlgorithm.Size = new Size(120, 23);
            cmbAlgorithm.TabIndex = 2;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(118, 12);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(100, 35);
            btnStart.TabIndex = 3;
            btnStart.Text = "התחל מיון";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(12, 12);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(100, 35);
            btnReset.TabIndex = 4;
            btnReset.Text = "מערך חדש";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // timer1
            // 
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            ClientSize = new Size(1588, 584);
            Controls.Add(pictureBox1);
            Controls.Add(topPanel);
            Name = "Form1";
            Text = "Algorithm Visualizer";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            topPanel.ResumeLayout(false);
            topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbSpeed).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label timeandaction;
        private System.Windows.Forms.ComboBox arrType;
    }
}

