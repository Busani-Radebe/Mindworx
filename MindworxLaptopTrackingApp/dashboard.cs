using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MindworxLaptopTrackingApp

{
    public partial class dashboard : Form
    {

        public dashboard()
        {
            InitializeComponent();

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void InitializeChart()
        {
            // Mock data for the chart
            var seriesCollection = new SeriesCollection
            {
                new LineSeries
                {
                    Title = "Devices Online",
                    Values = new ChartValues<double> { 10, 30, 50, 20, 40 }
                },
                new LineSeries
                {
                    Title = "Applications Uploaded",
                    Values = new ChartValues<double> { 20, 40, 30, 10, 50 }
                },
                new LineSeries
                {
                    Title = "Locked Devices",
                    Values = new ChartValues<double> { 50, 20, 10, 40, 30 }
                }
            };

            cartesianChart1.Series = seriesCollection;

            // Adding labels and other settings
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Time",
                Labels = new[] { "Jan", "Feb", "Mar", "Apr", "May" }
            });

            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Values",
                LabelFormatter = value => value.ToString("N")
            });
        }

        private void cartesianChart1_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void btnSetNotification_Click(object sender, EventArgs e)
        {
            
        }
    }
}
