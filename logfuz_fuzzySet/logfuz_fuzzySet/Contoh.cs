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
using OxyPlot.Axes;

namespace Logika_Fuzzy
{
    public partial class Contoh : Form
    {
        PlotModel model;

        public Contoh()
        {
            InitializeComponent();
            //=== Percobaan Grafik Sin Cos ===
            //var myModel = new PlotModel { Title = "Example 1" };
            //myModel.Series.Add(new FunctionSeries(Math.Cos, 0, 10, 0.1, "cos(x)"));
            //myModel.Series.Add(new FunctionSeries(Math.Sin, 0, 10, 0.1, "sin(x)"));
            //this.plotView1.Model = myModel;

            //=== Percobaan Grafik Kosong ===
            //var model = new PlotModel();
            //model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, Minimum = -20, Maximum = 80 });
            //model.Axes.Add(new LinearAxis { Position = AxisPosition.Left, Minimum = -10, Maximum = 10 });
            //this.plotView1.Model = model;

            //=== Percobaan Grafik Batman ===
            //var model = new PlotModel { Title = "Fun with Bats" };
            //Func<double, double> batFn1 = (x) => 2 * Math.Sqrt(-Math.Abs(Math.Abs(x) - 1) * Math.Abs(3 - Math.Abs(x)) / ((Math.Abs(x) - 1) * (3 - Math.Abs(x)))) * (1 + Math.Abs(Math.Abs(x) - 3) / (Math.Abs(x) - 3)) * Math.Sqrt(1 - Math.Pow((x / 7), 2)) + (5 + 0.97 * (Math.Abs(x - 0.5) + Math.Abs(x + 0.5)) - 3 * (Math.Abs(x - 0.75) + Math.Abs(x + 0.75))) * (1 + Math.Abs(1 - Math.Abs(x)) / (1 - Math.Abs(x)));
            //Func<double, double> batFn2 = (x) => -3 * Math.Sqrt(1 - Math.Pow((x / 7), 2)) * Math.Sqrt(Math.Abs(Math.Abs(x) - 4) / (Math.Abs(x) - 4));
            //Func<double, double> batFn3 = (x) => Math.Abs(x / 2) - 0.0913722 * (Math.Pow(x, 2)) - 3 + Math.Sqrt(1 - Math.Pow((Math.Abs(Math.Abs(x) - 2) - 1), 2));
            //Func<double, double> batFn4 = (x) => (2.71052 + (1.5 - .5 * Math.Abs(x)) - 1.35526 * Math.Sqrt(4 - Math.Pow((Math.Abs(x) - 1), 2))) * Math.Sqrt(Math.Abs(Math.Abs(x) - 1) / (Math.Abs(x) - 1)) + 0.9;
            //model.Series.Add(new FunctionSeries(batFn1, -8, 8, 0.0001));
            //model.Series.Add(new FunctionSeries(batFn2, -8, 8, 0.0001));
            //model.Series.Add(new FunctionSeries(batFn3, -8, 8, 0.0001));
            //model.Series.Add(new FunctionSeries(batFn4, -8, 8, 0.0001));
            //model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom, MaximumPadding = 0.1, MinimumPadding = 0.1 });
            //model.Axes.Add(new LinearAxis { Position = AxisPosition.Left, MaximumPadding = 0.1, MinimumPadding = 0.1 });
            //this.plotView1.Model = model;

            model = new PlotModel { Title = "Fungsi Segitiga" };
            //Func<double, double> func1 = (x) => x<4? 0 : x+100;
            //model.Series.Add(new FunctionSeries(func1, 0, 20, 0.1));
            //model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom });
            //model.Axes.Add(new LinearAxis { Position = AxisPosition.Left });
            //plotView1.Model = model;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);

            Func<double, double> func1 = (x) => (a <= x && x <= b) ? (x - a) / (b - a) : (b <= x && x <= c) ? (x - c) / (b - c) : 0;
            Func<double, double> func2 = (x) => 0.7;
            FunctionSeries series1 = new FunctionSeries(func1, 0, 10, 0.1);
            FunctionSeries series2 = new FunctionSeries(func2, 0, 10, 0.1);
            model.Title = "Fungsi Segitiga";
            model.Series.Add(series1);
            model.Series.Add(series2);
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Bottom });
            model.Axes.Add(new LinearAxis { Position = AxisPosition.Left });
            plotView1.Model = model;
            
        }
    }
}
