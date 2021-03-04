using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    public partial class Form1 : Form
    {
        
        
        Simulation simulation;
        public  void btnCont_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        public  void Stop()
        {
            timer1.Stop();
        }
        public void btnStop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
        public void TimeUpdate(double t) 
        {
            labelTimeVal.Text = "" + t;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            simulation.Tick();
             
        }

      

       
       
        public Form1()
        {
            InitializeComponent();
        }
        public void Clear()
        {
            chart1.Series[0].Points.Clear();
        }
        public void AddDot(double x , double y)
        {
            chart1.Series[0].Points.AddXY(x, y);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            simulation = new Simulation(
                (double)numericAngle.Value,
                (double)numericSpeed.Value,
                (double)numericHeight.Value,
                (double)numericMass.Value,
                (double)numericSpace.Value, this);

            timer1.Start();
            btnStop.Enabled = true;
            btnCont.Enabled = true;

        }
    }
}
