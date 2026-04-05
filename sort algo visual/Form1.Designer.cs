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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.topPanel = new System.Windows.Forms.Panel();
            this.arrType = new System.Windows.Forms.ComboBox();
            this.timeandaction = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.tbSpeed = new System.Windows.Forms.TrackBar();
            this.cmbAlgorithm = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1588, 524);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.LightGray;
            this.topPanel.Controls.Add(this.arrType);
            this.topPanel.Controls.Add(this.timeandaction);
            this.topPanel.Controls.Add(this.trackBar1);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.lblSpeed);
            this.topPanel.Controls.Add(this.tbSpeed);
            this.topPanel.Controls.Add(this.cmbAlgorithm);
            this.topPanel.Controls.Add(this.btnStart);
            this.topPanel.Controls.Add(this.btnReset);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1588, 60);
            this.topPanel.TabIndex = 1;
            // 
            // arrType
            // 
            this.arrType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.arrType.FormattingEnabled = true;
            this.arrType.Items.AddRange(new object[] {
            "Sorted",
            "Reversed",
            "Random",
            "Best Case",
            "Worst Case"});
            this.arrType.Location = new System.Drawing.Point(356, 18);
            this.arrType.Name = "arrType";
            this.arrType.Size = new System.Drawing.Size(120, 21);
            this.arrType.TabIndex = 8;
            this.arrType.SelectedIndexChanged += new System.EventHandler(this.arrType_SelectedIndexChanged);
            // 
            // timeandaction
            // 
            this.timeandaction.AutoSize = true;
            this.timeandaction.Location = new System.Drawing.Point(1585, 21);
            this.timeandaction.Name = "timeandaction";
            this.timeandaction.Size = new System.Drawing.Size(0, 13);
            this.timeandaction.TabIndex = 7;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(732, 9);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(150, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(691, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "גודל:";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(482, 21);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(47, 13);
            this.lblSpeed.TabIndex = 0;
            this.lblSpeed.Text = "מהירות:";
            // 
            // tbSpeed
            // 
            this.tbSpeed.Location = new System.Drawing.Point(535, 9);
            this.tbSpeed.Maximum = 100;
            this.tbSpeed.Minimum = 1;
            this.tbSpeed.Name = "tbSpeed";
            this.tbSpeed.Size = new System.Drawing.Size(150, 45);
            this.tbSpeed.TabIndex = 1;
            this.tbSpeed.Value = 50;
            this.tbSpeed.Scroll += new System.EventHandler(this.tbSpeed_Scroll);
            // 
            // cmbAlgorithm
            // 
            this.cmbAlgorithm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAlgorithm.FormattingEnabled = true;
            this.cmbAlgorithm.Items.AddRange(new object[] {
            "Bubble Sort",
            "Quick Sort",
            "Merge Sort",
            "Bogo Sort"});
            this.cmbAlgorithm.Location = new System.Drawing.Point(230, 18);
            this.cmbAlgorithm.Name = "cmbAlgorithm";
            this.cmbAlgorithm.Size = new System.Drawing.Size(120, 21);
            this.cmbAlgorithm.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(118, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 35);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "התחל מיון";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(12, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 35);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "מערך חדש";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1588, 584);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.topPanel);
            this.Name = "Form1";
            this.Text = "Algorithm Visualizer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label timeandaction;
        private System.Windows.Forms.ComboBox arrType;
    }
}

