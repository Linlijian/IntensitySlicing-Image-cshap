namespace IntensitySlicing
{
    partial class Hit
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
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartOriginal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartGImage = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartColor2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartColor2)).BeginInit();
            this.SuspendLayout();
            // 
            // chartOriginal
            // 
            chartArea1.Name = "ChartArea1";
            this.chartOriginal.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartOriginal.Legends.Add(legend1);
            this.chartOriginal.Location = new System.Drawing.Point(12, 12);
            this.chartOriginal.Name = "chartOriginal";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Original";
            this.chartOriginal.Series.Add(series1);
            this.chartOriginal.Size = new System.Drawing.Size(647, 158);
            this.chartOriginal.TabIndex = 1;
            this.chartOriginal.Text = "Original";
            // 
            // chartGImage
            // 
            chartArea2.Name = "ChartArea1";
            this.chartGImage.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartGImage.Legends.Add(legend2);
            this.chartGImage.Location = new System.Drawing.Point(12, 176);
            this.chartGImage.Name = "chartGImage";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "R";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "B";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "G";
            this.chartGImage.Series.Add(series2);
            this.chartGImage.Series.Add(series3);
            this.chartGImage.Series.Add(series4);
            this.chartGImage.Size = new System.Drawing.Size(647, 158);
            this.chartGImage.TabIndex = 1;
            this.chartGImage.Text = "GImage";
            // 
            // chartColor2
            // 
            chartArea3.Name = "ChartArea1";
            this.chartColor2.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartColor2.Legends.Add(legend3);
            this.chartColor2.Location = new System.Drawing.Point(12, 340);
            this.chartColor2.Name = "chartColor2";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "(102,255,255)";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "(102,102,255)";
            series7.ChartArea = "ChartArea1";
            series7.Legend = "Legend1";
            series7.Name = "(102,255,102)";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "(255,102,255)";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "(255,255,102)";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "(255,102,102)";
            this.chartColor2.Series.Add(series5);
            this.chartColor2.Series.Add(series6);
            this.chartColor2.Series.Add(series7);
            this.chartColor2.Series.Add(series8);
            this.chartColor2.Series.Add(series9);
            this.chartColor2.Series.Add(series10);
            this.chartColor2.Size = new System.Drawing.Size(647, 158);
            this.chartColor2.TabIndex = 1;
            this.chartColor2.Text = "Color2";
            // 
            // Hit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 502);
            this.Controls.Add(this.chartColor2);
            this.Controls.Add(this.chartGImage);
            this.Controls.Add(this.chartOriginal);
            this.Name = "Hit";
            this.Text = "Hit";
            this.Load += new System.EventHandler(this.Hit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartColor2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartOriginal;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGImage;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartColor2;
    }
}