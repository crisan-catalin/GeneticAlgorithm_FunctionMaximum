using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FunctionMaximum.GUI;
using FunctionMaximum.GUI.Properties;

namespace FunctionMaximum.Core.GUI
{
	public partial class MainGui : Form
	{
		public int NoGenerations { get; set; }
		public int NoChromosomes { get; set; }
		public int NoGenes { get; set; }
		public double MutationRate { get; set; }
		public int NoCutPoints { get; set; }
		public int Elitism { get; set; }

		private readonly List<Point> _results;

		public MainGui()
		{
			InitializeComponent();
			_results = new List<Point>();
		}

		private void ShowLoading()
		{
			toolStripStatusLabel.Text = Resources.loading;
			toolStripProgressBar.Visible = true;
			toolStripProgressBar.Maximum = NoGenerations;
		}

		private void HideLoading()
		{
			toolStripProgressBar.Visible = false;
			toolStripStatusLabel.Text = Resources.done;
		}

		private void UpdateProperties()
		{
			NoGenerations = int.Parse(noGenerationsTextBox.Text);
			NoChromosomes = int.Parse(noChromosomesTextBox.Text);
			NoGenes = int.Parse(noGenesTextBox.Text);
			MutationRate = double.Parse(mutationRateTextBox.Text.Replace('.', ','));
			NoCutPoints = int.Parse(cutPointsValueLabel.Text);
			Elitism = int.Parse(elitismValueLabel.Text);
		}

		private void RunGeneticAlgorithm()
		{
			Population population = new Population(NoChromosomes, NoGenes, Elitism, NoCutPoints, MutationRate);

			double functionParameter;
			double maximumFunction = population.BestSolution(out functionParameter);

			for (int i = 0; i < NoGenerations; i++)
			{
				_results.Add(new Point((int)functionParameter, (int)maximumFunction));

				toolStripProgressBar.Increment(1);

				try
				{
					population.Evolve();
				}
				catch (Exception)
				{
					MessageBox.Show(Resources.value_too_big_error, Resources.warning, MessageBoxButtons.OK,
						MessageBoxIcon.Warning);
					return;
				}

				maximumFunction = population.BestSolution(out functionParameter);
			}
		}

		private void execButton_Click(object sender, EventArgs e)
		{
			UpdateProperties();
			ShowLoading();
			RunGeneticAlgorithm();
			HideLoading();

			Plot plot = new Plot(_results);
			plot.ShowDialog(this);
		}

		private void noGenerationsTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		private void mutationRateTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
			}
		}

		private void elitismTrackBar_ValueChanged(object sender, EventArgs e)
		{
			int noChromosomes = int.Parse(noChromosomesTextBox.Text);
			if (elitismTrackBar.Value % 2 != noChromosomes % 2)
			{
				var valueMustBe = noChromosomes % 2 == 0 ? "even" : "odd";
				errorProvider.SetError(elitismTrackBar, $"Chromosomes number must be {valueMustBe}");
				execButton.Enabled = false;
			}
			else
			{
				errorProvider.Clear();
				execButton.Enabled = true;
			}

			elitismValueLabel.Text = elitismTrackBar.Value.ToString();
		}

		private void cutPointsTrackBar_ValueChanged(object sender, EventArgs e)
		{
			cutPointsValueLabel.Text = cutPointsTrackBar.Value.ToString();
		}

		private void noChromosomesTextBox_Leave(object sender, EventArgs e)
		{
			elitismTrackBar.Maximum = Int32.Parse(noChromosomesTextBox.Text);
			elitismTrackBar_ValueChanged(sender, e);
		}

		private void noGenesTextBox_Leave(object sender, EventArgs e)
		{
			cutPointsTrackBar.Maximum = Int32.Parse(noGenesTextBox.Text);
			cutPointsTrackBar_ValueChanged(sender, e);
		}
	}
}