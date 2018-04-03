using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FunctionMaximum.GUI
{
	public partial class Plot : Form
	{
		public List<Point> Points { get; set; }

		public Plot(List<Point> points)
		{
			InitializeComponent();

			Points = points;
			Points.Sort((firstPoint, secondPoint) => firstPoint.Y - secondPoint.Y);

			PlotGraph();
		}

		public void PlotGraph()
		{
			var maxValue = Points.Max(point => point.X);
			bestValueListBox.Items.Clear();

			functionPlot.Series.Add("Function");
			functionPlot.Series["Function"].ChartType = SeriesChartType.Line;
			functionPlot.Series["Function"].Color = Color.Orange;
			for (int i = -Math.Abs(maxValue); i <= Math.Abs(maxValue); i++)
			{
				functionPlot.Series["Function"].Points.AddXY(i,
					4 * (int) Math.Pow(i, 4) + 3 * (int) Math.Pow(i, 3) + 2 * (int) Math.Pow(i, 2) + i + 1
				);
			}

			functionPlot.Series.Add("Points");
			functionPlot.Series["Points"].ChartType = SeriesChartType.Point;
			functionPlot.Series["Points"].Color = Color.DeepSkyBlue;
			for (int i = 0; i < Points.Count - 1; i++)
			{
				functionPlot.Series["Points"].Points.AddXY(Points[i].X, Points[i].Y);
				bestValueListBox.Items.Insert(0, $"f({Points[i].X}) = {Points[i].Y}");
			}

			functionPlot.Series.Add("Best_Value");
			functionPlot.Series["Best_Value"].ChartType = SeriesChartType.Point;
			functionPlot.Series["Best_Value"].Color = Color.Red;
			functionPlot.Series["Best_Value"].Points.AddXY(Points[Points.Count - 1].X, Points[Points.Count - 1].Y);
			bestValueListBox.Items.Insert(0, $"f({Points[Points.Count - 1].X}) = {Points[Points.Count - 1].Y}");
		}

		private void bestValueListBox_DrawItem(object sender, DrawItemEventArgs e)
		{
			if (e.Index == 0)
			{
				e.Graphics.FillRectangle(Brushes.GreenYellow, e.Bounds);
			}

			e.Graphics.DrawString(bestValueListBox.Items[e.Index].ToString(), e.Font, new SolidBrush(Color.Black),
				e.Bounds.Location);
		}
	}
}