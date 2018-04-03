namespace FunctionMaximum.GUI
{
	partial class Plot
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

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
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.functionPlot = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.bestValueListBox = new System.Windows.Forms.ListBox();
			this.bestResultLabel = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.functionPlot)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// functionPlot
			// 
			this.functionPlot.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			chartArea1.Name = "ChartArea1";
			this.functionPlot.ChartAreas.Add(chartArea1);
			this.functionPlot.Location = new System.Drawing.Point(0, -1);
			this.functionPlot.Name = "functionPlot";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
			series1.Name = "Series1";
			this.functionPlot.Series.Add(series1);
			this.functionPlot.Size = new System.Drawing.Size(408, 463);
			this.functionPlot.TabIndex = 0;
			this.functionPlot.Text = "chart1";
			// 
			// bestValueListBox
			// 
			this.bestValueListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.bestValueListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.bestValueListBox.FormattingEnabled = true;
			this.bestValueListBox.Location = new System.Drawing.Point(5, 38);
			this.bestValueListBox.Name = "bestValueListBox";
			this.bestValueListBox.Size = new System.Drawing.Size(192, 423);
			this.bestValueListBox.TabIndex = 20;
			this.bestValueListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.bestValueListBox_DrawItem);
			// 
			// bestResultLabel
			// 
			this.bestResultLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.bestResultLabel.AutoSize = true;
			this.bestResultLabel.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bestResultLabel.Location = new System.Drawing.Point(3, 0);
			this.bestResultLabel.Name = "bestResultLabel";
			this.bestResultLabel.Size = new System.Drawing.Size(194, 27);
			this.bestResultLabel.TabIndex = 19;
			this.bestResultLabel.Text = "Best results:";
			this.bestResultLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.bestResultLabel, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.bestValueListBox, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(403, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 464);
			this.tableLayoutPanel1.TabIndex = 21;
			// 
			// Plot
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(603, 464);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.functionPlot);
			this.Name = "Plot";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Plot";
			((System.ComponentModel.ISupportInitialize)(this.functionPlot)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart functionPlot;
		private System.Windows.Forms.ListBox bestValueListBox;
		private System.Windows.Forms.Label bestResultLabel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}