namespace FunctionMaximum.Core.GUI
{
	partial class MainGui
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
			this.noChromosomesTextBox = new System.Windows.Forms.TextBox();
			this.noChromosomesLabel = new System.Windows.Forms.Label();
			this.noGenesLabel = new System.Windows.Forms.Label();
			this.noGenesTextBox = new System.Windows.Forms.TextBox();
			this.mutationRateLabel = new System.Windows.Forms.Label();
			this.mutationRateTextBox = new System.Windows.Forms.TextBox();
			this.elitismTrackBar = new System.Windows.Forms.TrackBar();
			this.elitismLabel = new System.Windows.Forms.Label();
			this.cutPointsLabel = new System.Windows.Forms.Label();
			this.cutPointsTrackBar = new System.Windows.Forms.TrackBar();
			this.noGenerationsLabel = new System.Windows.Forms.Label();
			this.noGenerationsTextBox = new System.Windows.Forms.TextBox();
			this.execButton = new System.Windows.Forms.Button();
			this.elitismValueLabel = new System.Windows.Forms.Label();
			this.cutPointsValueLabel = new System.Windows.Forms.Label();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.subtitleLabel = new System.Windows.Forms.Label();
			this.titleLabel = new System.Windows.Forms.Label();
			this.dividerLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.elitismTrackBar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cutPointsTrackBar)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// noChromosomesTextBox
			// 
			this.noChromosomesTextBox.Location = new System.Drawing.Point(168, 201);
			this.noChromosomesTextBox.Name = "noChromosomesTextBox";
			this.noChromosomesTextBox.Size = new System.Drawing.Size(100, 22);
			this.noChromosomesTextBox.TabIndex = 1;
			this.noChromosomesTextBox.Text = "12";
			this.noChromosomesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noGenerationsTextBox_KeyPress);
			this.noChromosomesTextBox.Leave += new System.EventHandler(this.noChromosomesTextBox_Leave);
			// 
			// noChromosomesLabel
			// 
			this.noChromosomesLabel.AutoSize = true;
			this.noChromosomesLabel.Location = new System.Drawing.Point(8, 206);
			this.noChromosomesLabel.Name = "noChromosomesLabel";
			this.noChromosomesLabel.Size = new System.Drawing.Size(154, 17);
			this.noChromosomesLabel.TabIndex = 1;
			this.noChromosomesLabel.Text = "Chromosomes number:";
			// 
			// noGenesLabel
			// 
			this.noGenesLabel.AutoSize = true;
			this.noGenesLabel.Location = new System.Drawing.Point(56, 244);
			this.noGenesLabel.Name = "noGenesLabel";
			this.noGenesLabel.Size = new System.Drawing.Size(106, 17);
			this.noGenesLabel.TabIndex = 3;
			this.noGenesLabel.Text = "Genes number:";
			// 
			// noGenesTextBox
			// 
			this.noGenesTextBox.Location = new System.Drawing.Point(168, 239);
			this.noGenesTextBox.Name = "noGenesTextBox";
			this.noGenesTextBox.Size = new System.Drawing.Size(100, 22);
			this.noGenesTextBox.TabIndex = 2;
			this.noGenesTextBox.Text = "6";
			this.noGenesTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noGenerationsTextBox_KeyPress);
			this.noGenesTextBox.Leave += new System.EventHandler(this.noGenesTextBox_Leave);
			// 
			// mutationRateLabel
			// 
			this.mutationRateLabel.AutoSize = true;
			this.mutationRateLabel.Location = new System.Drawing.Point(67, 281);
			this.mutationRateLabel.Name = "mutationRateLabel";
			this.mutationRateLabel.Size = new System.Drawing.Size(95, 17);
			this.mutationRateLabel.TabIndex = 5;
			this.mutationRateLabel.Text = "Mutation rate:";
			// 
			// mutationRateTextBox
			// 
			this.mutationRateTextBox.Location = new System.Drawing.Point(168, 276);
			this.mutationRateTextBox.Name = "mutationRateTextBox";
			this.mutationRateTextBox.Size = new System.Drawing.Size(100, 22);
			this.mutationRateTextBox.TabIndex = 3;
			this.mutationRateTextBox.Text = "0.12";
			this.mutationRateTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mutationRateTextBox_KeyPress);
			// 
			// elitismTrackBar
			// 
			this.elitismTrackBar.Location = new System.Drawing.Point(316, 167);
			this.elitismTrackBar.Maximum = 12;
			this.elitismTrackBar.Name = "elitismTrackBar";
			this.elitismTrackBar.Size = new System.Drawing.Size(184, 56);
			this.elitismTrackBar.TabIndex = 4;
			this.elitismTrackBar.Value = 2;
			this.elitismTrackBar.ValueChanged += new System.EventHandler(this.elitismTrackBar_ValueChanged);
			// 
			// elitismLabel
			// 
			this.elitismLabel.AutoSize = true;
			this.elitismLabel.Location = new System.Drawing.Point(313, 147);
			this.elitismLabel.Name = "elitismLabel";
			this.elitismLabel.Size = new System.Drawing.Size(48, 17);
			this.elitismLabel.TabIndex = 7;
			this.elitismLabel.Text = "Elitism";
			// 
			// cutPointsLabel
			// 
			this.cutPointsLabel.AutoSize = true;
			this.cutPointsLabel.Location = new System.Drawing.Point(313, 218);
			this.cutPointsLabel.Name = "cutPointsLabel";
			this.cutPointsLabel.Size = new System.Drawing.Size(123, 17);
			this.cutPointsLabel.TabIndex = 9;
			this.cutPointsLabel.Text = "Cut points number";
			// 
			// cutPointsTrackBar
			// 
			this.cutPointsTrackBar.Location = new System.Drawing.Point(316, 238);
			this.cutPointsTrackBar.Name = "cutPointsTrackBar";
			this.cutPointsTrackBar.Size = new System.Drawing.Size(184, 56);
			this.cutPointsTrackBar.TabIndex = 6;
			this.cutPointsTrackBar.Value = 2;
			this.cutPointsTrackBar.ValueChanged += new System.EventHandler(this.cutPointsTrackBar_ValueChanged);
			// 
			// noGenerationsLabel
			// 
			this.noGenerationsLabel.AutoSize = true;
			this.noGenerationsLabel.Location = new System.Drawing.Point(20, 170);
			this.noGenerationsLabel.Name = "noGenerationsLabel";
			this.noGenerationsLabel.Size = new System.Drawing.Size(142, 17);
			this.noGenerationsLabel.TabIndex = 11;
			this.noGenerationsLabel.Text = "Generations number:";
			// 
			// noGenerationsTextBox
			// 
			this.noGenerationsTextBox.Location = new System.Drawing.Point(168, 167);
			this.noGenerationsTextBox.Name = "noGenerationsTextBox";
			this.noGenerationsTextBox.Size = new System.Drawing.Size(100, 22);
			this.noGenerationsTextBox.TabIndex = 0;
			this.noGenerationsTextBox.Text = "40";
			this.noGenerationsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.noGenerationsTextBox_KeyPress);
			// 
			// execButton
			// 
			this.execButton.Location = new System.Drawing.Point(188, 344);
			this.execButton.Name = "execButton";
			this.execButton.Size = new System.Drawing.Size(198, 55);
			this.execButton.TabIndex = 12;
			this.execButton.Text = "Execute";
			this.execButton.UseVisualStyleBackColor = true;
			this.execButton.Click += new System.EventHandler(this.execButton_Click);
			// 
			// elitismValueLabel
			// 
			this.elitismValueLabel.AutoSize = true;
			this.elitismValueLabel.Location = new System.Drawing.Point(517, 167);
			this.elitismValueLabel.Name = "elitismValueLabel";
			this.elitismValueLabel.Size = new System.Drawing.Size(16, 17);
			this.elitismValueLabel.TabIndex = 13;
			this.elitismValueLabel.Text = "2";
			// 
			// cutPointsValueLabel
			// 
			this.cutPointsValueLabel.AutoSize = true;
			this.cutPointsValueLabel.Location = new System.Drawing.Point(517, 238);
			this.cutPointsValueLabel.Name = "cutPointsValueLabel";
			this.cutPointsValueLabel.Size = new System.Drawing.Size(16, 17);
			this.cutPointsValueLabel.TabIndex = 14;
			this.cutPointsValueLabel.Text = "2";
			// 
			// statusStrip1
			// 
			this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar,
            this.toolStripStatusLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 437);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(594, 25);
			this.statusStrip1.TabIndex = 19;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripProgressBar
			// 
			this.toolStripProgressBar.Name = "toolStripProgressBar";
			this.toolStripProgressBar.Size = new System.Drawing.Size(100, 19);
			this.toolStripProgressBar.Visible = false;
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(108, 20);
			this.toolStripStatusLabel.Text = "Waiting for run";
			// 
			// subtitleLabel
			// 
			this.subtitleLabel.AutoSize = true;
			this.subtitleLabel.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.subtitleLabel.Location = new System.Drawing.Point(142, 65);
			this.subtitleLabel.Name = "subtitleLabel";
			this.subtitleLabel.Size = new System.Drawing.Size(294, 27);
			this.subtitleLabel.TabIndex = 20;
			this.subtitleLabel.Text = "f(x) = 4x^4+3x^3+2x^2+x+1";
			// 
			// titleLabel
			// 
			this.titleLabel.AutoSize = true;
			this.titleLabel.Font = new System.Drawing.Font("Garamond", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.titleLabel.Location = new System.Drawing.Point(46, 21);
			this.titleLabel.Name = "titleLabel";
			this.titleLabel.Size = new System.Drawing.Size(487, 31);
			this.titleLabel.TabIndex = 21;
			this.titleLabel.Text = "Genetic algorithm - Function maximum";
			// 
			// dividerLabel
			// 
			this.dividerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dividerLabel.AutoSize = true;
			this.dividerLabel.Font = new System.Drawing.Font("Garamond", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.dividerLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
			this.dividerLabel.Location = new System.Drawing.Point(32, 102);
			this.dividerLabel.Name = "dividerLabel";
			this.dividerLabel.Size = new System.Drawing.Size(468, 27);
			this.dividerLabel.TabIndex = 22;
			this.dividerLabel.Text = "______________________________________";
			this.dividerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainGui
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(594, 462);
			this.Controls.Add(this.dividerLabel);
			this.Controls.Add(this.titleLabel);
			this.Controls.Add(this.subtitleLabel);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.cutPointsValueLabel);
			this.Controls.Add(this.elitismValueLabel);
			this.Controls.Add(this.execButton);
			this.Controls.Add(this.noGenerationsLabel);
			this.Controls.Add(this.noGenerationsTextBox);
			this.Controls.Add(this.cutPointsLabel);
			this.Controls.Add(this.cutPointsTrackBar);
			this.Controls.Add(this.elitismLabel);
			this.Controls.Add(this.elitismTrackBar);
			this.Controls.Add(this.mutationRateLabel);
			this.Controls.Add(this.mutationRateTextBox);
			this.Controls.Add(this.noGenesLabel);
			this.Controls.Add(this.noGenesTextBox);
			this.Controls.Add(this.noChromosomesLabel);
			this.Controls.Add(this.noChromosomesTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "MainGui";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Genetic algorithm - Function maximum";
			((System.ComponentModel.ISupportInitialize)(this.elitismTrackBar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cutPointsTrackBar)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox noChromosomesTextBox;
		private System.Windows.Forms.Label noChromosomesLabel;
		private System.Windows.Forms.Label noGenesLabel;
		private System.Windows.Forms.TextBox noGenesTextBox;
		private System.Windows.Forms.Label mutationRateLabel;
		private System.Windows.Forms.TextBox mutationRateTextBox;
		private System.Windows.Forms.TrackBar elitismTrackBar;
		private System.Windows.Forms.Label elitismLabel;
		private System.Windows.Forms.Label cutPointsLabel;
		private System.Windows.Forms.TrackBar cutPointsTrackBar;
		private System.Windows.Forms.Label noGenerationsLabel;
		private System.Windows.Forms.TextBox noGenerationsTextBox;
		private System.Windows.Forms.Button execButton;
		private System.Windows.Forms.Label elitismValueLabel;
		private System.Windows.Forms.Label cutPointsValueLabel;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.Label subtitleLabel;
		private System.Windows.Forms.Label titleLabel;
		private System.Windows.Forms.Label dividerLabel;
	}
}

