﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Latihan1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //INI P1_M1
            InitializeComponent();
            chart1.Series[0].Name = "SIN";
            chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[0].BorderWidth = 5;
            chart1.Series[0].Color = Color.Red;
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
            double y = amplitude * Math.Sin(2 * Math.PI * frequency * time);
            if (chart1.Series[0].Points.Count > 40)
            {
                chart1.ChartAreas[0].AxisX.Minimum = xmin;
                chart1.ChartAreas[0].AxisX.Maximum = xmin + 40;
                xmin++;
            }
            chart1.Series[0].Points.AddY(y);
            time += 0.01;
        }
        private int xmin = 0;
        private double time = 0.0;
        private double amplitude = 50.0;
        private double frequency = 2.0;

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
