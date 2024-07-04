using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace GenMatrix
{
    public partial class Graphic : Form
    {
        public PlotModel PlotModel { get; private set; }
        public Graphic(List<double> sums)
        {
            InitializeComponent();
            CreateGraphic(sums);
            InitializePlotView();
        }

        private void CreateGraphic(List<double> sums)
        {
            PlotModel = new PlotModel { Title = "Cумма операций в каждом поколении" };

            var series = new LineSeries { Title = "Сумма операций", MarkerType = MarkerType.Circle };

            for(int i = 0; i < sums.Count; i++)
            {
                series.Points.Add(new DataPoint(i+1, sums[i]));
            }

            PlotModel.Series.Add(series);
        }

        private void InitializePlotView()
        {
            var plotView = new PlotView
            {
                Dock = DockStyle.Fill,
                Model = PlotModel
            };

            this.Controls.Add(plotView);
        }

    }
}
