using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Percobaan1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //INI P3_M1
            InitializeComponent();
            chart1.Series[0].Name = "SIN";
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[0].BorderWidth = 5;
            chart1.Series[0].Color = Color.Red;
            chart1.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            chart1.Series[1].Name = "COS";
            chart1.Series[1].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[1].BorderWidth = 5;
            chart1.Series[1].Color = Color.Yellow;
            chart1.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            chart1.Series[2].Name = "TAN";
            chart1.Series[2].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[2].BorderWidth = 5;
            chart1.Series[2].Color = Color.Blue;
            chart1.Legends[0].Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = !(timer1.Enabled);
            if (timer1.Enabled == true)
                button1.Text = "STOP";
            else
                button1.Text = "START";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        
            timer1.Interval = (int)numericUpDown1.Value;

            //Series1
            double amplitudes = (double)numericUpDown2.Value;
            double frequencys = (double)numericUpDown3.Value;
            double s = amplitudes * Math.Sin(2 * Math.PI * frequencys * time);
            if (chart1.Series[0].Points.Count > 40)
                chart1.Series[0].Points.RemoveAt(0);
            
            chart1.Series[0].Points.AddY(s);
            
     
            //Series2
            double amplitudec = (double)numericUpDown5.Value;
            double frequencyc = (double)numericUpDown4.Value;
            double c = amplitudec * Math.Cos(2 * Math.PI * frequencyc * time);
            if (chart1.Series[1].Points.Count > 40)
                chart1.Series[1].Points.RemoveAt(0);
            
            chart1.Series[1].Points.AddY(c);
            
   
            
            //Series3
            double amplitudet = (double)numericUpDown7.Value;
            double frequencyt = (double)numericUpDown6.Value;
            double t = amplitudet * Math.Tan(2 * Math.PI * frequencyt * time);
            if (chart1.Series[2].Points.Count > 40)
                chart1.Series[2].Points.RemoveAt(0);
           
            chart1.Series[2].Points.AddY(t);

            time += 0.01;
            
        }

        private double time = 0.0;
    
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
        
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
