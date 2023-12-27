
namespace Tyuiu.KondrakovAA.Sprint7.Project.V9
{
    partial class FormStats_KAA
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartDuration_KAA = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDuration_KAA)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chartDuration_KAA);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(799, 447);
            this.panel1.TabIndex = 0;
            // 
            // chartDuration_KAA
            // 
            this.chartDuration_KAA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(2)))), ((int)(((byte)(60)))));
            this.chartDuration_KAA.BackImageTransparentColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.chartDuration_KAA.BackSecondaryColor = System.Drawing.Color.Fuchsia;
            this.chartDuration_KAA.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            chartArea1.Name = "ChartArea1";
            this.chartDuration_KAA.ChartAreas.Add(chartArea1);
            this.chartDuration_KAA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartDuration_KAA.Location = new System.Drawing.Point(0, 0);
            this.chartDuration_KAA.Name = "chartDuration_KAA";
            this.chartDuration_KAA.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            this.chartDuration_KAA.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Empty,
        System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(2)))), ((int)(((byte)(60)))))};
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chartDuration_KAA.Series.Add(series1);
            this.chartDuration_KAA.Size = new System.Drawing.Size(799, 447);
            this.chartDuration_KAA.TabIndex = 0;
            // 
            // FormStats_KAA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 447);
            this.Controls.Add(this.panel1);
            this.Name = "FormStats_KAA";
            this.Text = "Статистика";
            this.Load += new System.EventHandler(this.setStats);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartDuration_KAA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDuration_KAA;
    }
}