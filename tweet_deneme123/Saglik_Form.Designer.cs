﻿namespace tweet_deneme123
{
    partial class Saglik_Form
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(443, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(75, 4);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(3, 38);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(979, 199);
            this.listBox2.TabIndex = 1;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(443, 12);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(75, 4);
            this.listBox3.TabIndex = 2;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.chart2.BorderlineColor = System.Drawing.Color.Wheat;
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(606, 247);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series1.Legend = "Legend1";
            series1.Name = "Çocuk";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Gray;
            series2.Legend = "Legend1";
            series2.Name = "Diğerleri";
            this.chart2.Series.Add(series1);
            this.chart2.Series.Add(series2);
            this.chart2.Size = new System.Drawing.Size(376, 173);
            this.chart2.TabIndex = 18;
            this.chart2.Text = "chart2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "SAĞLIK TWEETLERİ";
            // 
            // Saglik_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(994, 432);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Saglik_Form";
            this.ShowIcon = false;
            this.Text = "Saglik_Form";
            this.Load += new System.EventHandler(this.Saglik_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label1;
    }
}