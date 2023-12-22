namespace WinFormsApp1
{
    partial class AktienForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            AktieSelec = new ComboBox();
            Aktienchart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)Aktienchart).BeginInit();
            SuspendLayout();
            // 
            // AktieSelec
            // 
            AktieSelec.FormattingEnabled = true;
            AktieSelec.Location = new Point(69, 73);
            AktieSelec.Name = "AktieSelec";
            AktieSelec.Size = new Size(212, 38);
            AktieSelec.TabIndex = 1;
            AktieSelec.SelectedIndexChanged += AktieSelec_SelectedIndexChanged;
            // 
            // Aktienchart
            // 
            chartArea1.Name = "ChartArea1";
            Aktienchart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            Aktienchart.Legends.Add(legend1);
            Aktienchart.Location = new Point(436, 73);
            Aktienchart.Name = "Aktienchart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            Aktienchart.Series.Add(series1);
            Aktienchart.Size = new Size(897, 712);
            Aktienchart.TabIndex = 2;
            Aktienchart.Text = "Aktienkurs";
            // 
            // AktienForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 900);
            Controls.Add(Aktienchart);
            Controls.Add(AktieSelec);
            Margin = new Padding(5, 6, 5, 6);
            Name = "AktienForm";
            Text = "Hello";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Aktienchart).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ComboBox AktieSelec;
        private System.Windows.Forms.DataVisualization.Charting.Chart Aktienchart;
    }
}