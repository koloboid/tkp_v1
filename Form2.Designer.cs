namespace TKP_V1
{
    partial class Form2
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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.AxisX.Title = "Дні тижня";
            chartArea1.AxisY.Title = "Товари, шт";
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            chartArea1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            chartArea1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.Gold;
            series1.Legend = "Legend1";
            series1.LegendText = "Ручки";
            series1.Name = "Series1";
            series1.XValueMember = "Day";
            series1.YValueMembers = "Pen";
            series2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Blue;
            series2.Legend = "Legend1";
            series2.LegendText = "Олівці";
            series2.Name = "Series2";
            series2.XValueMember = "Day";
            series2.YValueMembers = "Pencil";
            series3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Red;
            series3.Legend = "Legend1";
            series3.LegendText = "Зошити";
            series3.Name = "Series3";
            series3.XValueMember = "Day";
            series3.YValueMembers = "Notebook";
            series4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.VerticalCenter;
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series4.Legend = "Legend1";
            series4.LegendText = "Блокноти";
            series4.Name = "Series4";
            series4.XValueMember = "Day";
            series4.YValueMembers = "Notepad";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(558, 499);
            this.chart1.TabIndex = 0;
            title1.Alignment = System.Drawing.ContentAlignment.MiddleRight;
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            title1.Name = "Title1";
            title1.Text = "Продаж канцтоварів";
            this.chart1.Titles.Add(title1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 499);
            this.Controls.Add(this.chart1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}