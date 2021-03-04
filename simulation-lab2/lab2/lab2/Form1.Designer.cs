
namespace lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTimeVal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCont = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.numericHeight = new System.Windows.Forms.NumericUpDown();
            this.numericSpeed = new System.Windows.Forms.NumericUpDown();
            this.numericAngle = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.numericMass = new System.Windows.Forms.NumericUpDown();
            this.numericSpace = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpace)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.numericSpace);
            this.panel1.Controls.Add(this.numericMass);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.labelTimeVal);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnCont);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.numericHeight);
            this.panel1.Controls.Add(this.numericSpeed);
            this.panel1.Controls.Add(this.numericAngle);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1108, 113);
            this.panel1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(327, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Space:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mass:";
            // 
            // labelTimeVal
            // 
            this.labelTimeVal.AutoSize = true;
            this.labelTimeVal.Location = new System.Drawing.Point(600, 33);
            this.labelTimeVal.Name = "labelTimeVal";
            this.labelTimeVal.Size = new System.Drawing.Size(13, 13);
            this.labelTimeVal.TabIndex = 10;
            this.labelTimeVal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(558, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Time:";
            // 
            // btnCont
            // 
            this.btnCont.Enabled = false;
            this.btnCont.Location = new System.Drawing.Point(669, 84);
            this.btnCont.Name = "btnCont";
            this.btnCont.Size = new System.Drawing.Size(75, 23);
            this.btnCont.TabIndex = 8;
            this.btnCont.Text = "Continue";
            this.btnCont.UseVisualStyleBackColor = true;
            this.btnCont.Click += new System.EventHandler(this.btnCont_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(561, 84);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(468, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericHeight
            // 
            this.numericHeight.Location = new System.Drawing.Point(103, 74);
            this.numericHeight.Name = "numericHeight";
            this.numericHeight.Size = new System.Drawing.Size(120, 20);
            this.numericHeight.TabIndex = 5;
            // 
            // numericSpeed
            // 
            this.numericSpeed.Location = new System.Drawing.Point(103, 48);
            this.numericSpeed.Name = "numericSpeed";
            this.numericSpeed.Size = new System.Drawing.Size(120, 20);
            this.numericSpeed.TabIndex = 4;
            this.numericSpeed.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericAngle
            // 
            this.numericAngle.Location = new System.Drawing.Point(103, 21);
            this.numericAngle.Name = "numericAngle";
            this.numericAngle.Size = new System.Drawing.Size(120, 20);
            this.numericAngle.TabIndex = 3;
            this.numericAngle.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Height:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Speed:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Angle:";
            // 
            // chart1
            // 
            chartArea2.AxisX.Maximum = 25D;
            chartArea2.AxisX.Minimum = 0D;
            chartArea2.AxisY.Maximum = 6D;
            chartArea2.AxisY.Minimum = 0D;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chart1.Location = new System.Drawing.Point(0, 113);
            this.chart1.Name = "chart1";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1108, 446);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // numericMass
            // 
            this.numericMass.Location = new System.Drawing.Point(396, 21);
            this.numericMass.Name = "numericMass";
            this.numericMass.Size = new System.Drawing.Size(120, 20);
            this.numericMass.TabIndex = 13;
            this.numericMass.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numericSpace
            // 
            this.numericSpace.Location = new System.Drawing.Point(396, 55);
            this.numericSpace.Name = "numericSpace";
            this.numericSpace.Size = new System.Drawing.Size(120, 20);
            this.numericSpace.TabIndex = 14;
            this.numericSpace.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1108, 559);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericSpace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericHeight;
        private System.Windows.Forms.NumericUpDown numericSpeed;
        private System.Windows.Forms.NumericUpDown numericAngle;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnCont;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label labelTimeVal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericSpace;
        private System.Windows.Forms.NumericUpDown numericMass;
    }
}

