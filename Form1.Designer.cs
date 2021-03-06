namespace MotionDetection
{
    partial class FireKAM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FireKAM));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.Page3 = new MetroFramework.Controls.MetroTabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.reportHeatmapImageBox = new System.Windows.Forms.PictureBox();
            this.ReportSourceDropdown = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.ReportTypeCB = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GenerateChartBtn = new MetroFramework.Controls.MetroButton();
            this.ToPDF = new MetroFramework.Controls.MetroButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Page2 = new MetroFramework.Controls.MetroTabPage();
            this.MotionPanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.motionImageBox = new Emgu.CV.UI.ImageBox();
            this.Page1 = new MetroFramework.Controls.MetroTabPage();
            this.panelLabel = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox3 = new MetroFramework.Controls.MetroComboBox();
            this.opacityLabel = new MetroFramework.Controls.MetroLabel();
            this.colorLabel = new MetroFramework.Controls.MetroLabel();
            this.gridLabel = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.PedestrianPanel = new System.Windows.Forms.Panel();
            this.capturedImageBox = new Emgu.CV.UI.ImageBox();
            this.SourceComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.recordToggle = new MetroFramework.Controls.MetroToggle();
            this.label3 = new System.Windows.Forms.Label();
            this.Home = new MetroFramework.Controls.MetroTabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.HeatMap = new MetroFramework.Controls.MetroTabControl();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            this.Page3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportHeatmapImageBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.Page2.SuspendLayout();
            this.MotionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.motionImageBox)).BeginInit();
            this.Page1.SuspendLayout();
            this.PedestrianPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capturedImageBox)).BeginInit();
            this.Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.HeatMap.SuspendLayout();
            this.SuspendLayout();
            // 
            // msmMain
            // 
            this.msmMain.Owner = null;
            this.msmMain.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // Page3
            // 
            this.Page3.Controls.Add(this.label1);
            this.Page3.Controls.Add(this.reportHeatmapImageBox);
            this.Page3.Controls.Add(this.ReportSourceDropdown);
            this.Page3.Controls.Add(this.label6);
            this.Page3.Controls.Add(this.label8);
            this.Page3.Controls.Add(this.dateTimePicker2);
            this.Page3.Controls.Add(this.dateTimePicker1);
            this.Page3.Controls.Add(this.ReportTypeCB);
            this.Page3.Controls.Add(this.label11);
            this.Page3.Controls.Add(this.label7);
            this.Page3.Controls.Add(this.label5);
            this.Page3.Controls.Add(this.GenerateChartBtn);
            this.Page3.Controls.Add(this.ToPDF);
            this.Page3.Controls.Add(this.chart1);
            this.Page3.HorizontalScrollbarBarColor = true;
            this.Page3.HorizontalScrollbarSize = 19;
            this.Page3.Location = new System.Drawing.Point(8, 42);
            this.Page3.Margin = new System.Windows.Forms.Padding(6);
            this.Page3.Name = "Page3";
            this.Page3.Size = new System.Drawing.Size(886, 550);
            this.Page3.TabIndex = 2;
            this.Page3.Text = "Graphs";
            this.Page3.VerticalScrollbarBarColor = true;
            this.Page3.VerticalScrollbarSize = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(613, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 26);
            this.label1.TabIndex = 41;
            this.label1.Text = "*Ignore data less then 1%";
            this.label1.Visible = false;
            // 
            // reportHeatmapImageBox
            // 
            this.reportHeatmapImageBox.BackColor = System.Drawing.Color.Transparent;
            this.reportHeatmapImageBox.Location = new System.Drawing.Point(343, 28);
            this.reportHeatmapImageBox.Margin = new System.Windows.Forms.Padding(0);
            this.reportHeatmapImageBox.Name = "reportHeatmapImageBox";
            this.reportHeatmapImageBox.Size = new System.Drawing.Size(531, 497);
            this.reportHeatmapImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.reportHeatmapImageBox.TabIndex = 40;
            this.reportHeatmapImageBox.TabStop = false;
            this.reportHeatmapImageBox.Visible = false;
            // 
            // ReportSourceDropdown
            // 
            this.ReportSourceDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReportSourceDropdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportSourceDropdown.FormattingEnabled = true;
            this.ReportSourceDropdown.Items.AddRange(new object[] {
            "All"});
            this.ReportSourceDropdown.Location = new System.Drawing.Point(151, 39);
            this.ReportSourceDropdown.Name = "ReportSourceDropdown";
            this.ReportSourceDropdown.Size = new System.Drawing.Size(160, 33);
            this.ReportSourceDropdown.TabIndex = 39;
            this.ReportSourceDropdown.DropDown += new System.EventHandler(this.SourceDropdown_DropDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 26);
            this.label6.TabIndex = 38;
            this.label6.Text = "Source";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(244, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 26);
            this.label8.TabIndex = 27;
            this.label8.Text = "End";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "MM/yyyy";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(219, 189);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(118, 32);
            this.dateTimePicker2.TabIndex = 35;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(61, 189);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(118, 32);
            this.dateTimePicker1.TabIndex = 34;
            // 
            // ReportTypeCB
            // 
            this.ReportTypeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ReportTypeCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportTypeCB.FormattingEnabled = true;
            this.ReportTypeCB.Items.AddRange(new object[] {
            "Hourly Report",
            "Daily Reprot",
            "Monthly Report",
            "Yearly Report",
            "Area Report",
            "Heatmap Report"});
            this.ReportTypeCB.Location = new System.Drawing.Point(151, 86);
            this.ReportTypeCB.Name = "ReportTypeCB";
            this.ReportTypeCB.Size = new System.Drawing.Size(160, 33);
            this.ReportTypeCB.TabIndex = 33;
            this.ReportTypeCB.SelectedIndexChanged += new System.EventHandler(this.ReportTypeCB_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 26);
            this.label11.TabIndex = 32;
            this.label11.Text = "Report Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(76, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "Start";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "Time";
            // 
            // GenerateChartBtn
            // 
            this.GenerateChartBtn.Location = new System.Drawing.Point(61, 386);
            this.GenerateChartBtn.Margin = new System.Windows.Forms.Padding(6);
            this.GenerateChartBtn.Name = "GenerateChartBtn";
            this.GenerateChartBtn.Size = new System.Drawing.Size(91, 39);
            this.GenerateChartBtn.TabIndex = 18;
            this.GenerateChartBtn.Text = "Generate";
            this.GenerateChartBtn.Click += new System.EventHandler(this.GenerateChartBtn_Click);
            // 
            // ToPDF
            // 
            this.ToPDF.Location = new System.Drawing.Point(207, 386);
            this.ToPDF.Margin = new System.Windows.Forms.Padding(6);
            this.ToPDF.Name = "ToPDF";
            this.ToPDF.Size = new System.Drawing.Size(92, 39);
            this.ToPDF.TabIndex = 16;
            this.ToPDF.Text = "Save as PDF";
            this.ToPDF.Click += new System.EventHandler(this.ToPDF_Click);
            // 
            // chart1
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.MajorGrid.LineWidth = 0;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.White;
            chartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.White;
            chartArea1.AxisX.ScrollBar.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineWidth = 0;
            chartArea1.CursorX.Interval = 0.01D;
            chartArea1.CursorX.IsUserEnabled = true;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(320, 0);
            this.chart1.Margin = new System.Windows.Forms.Padding(6);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.IsValueShownAsLabel = true;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Camera";
            series1.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.Yes;
            series1.SmartLabelStyle.IsOverlappedHidden = false;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series2.SmartLabelStyle.IsOverlappedHidden = false;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(568, 574);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            this.chart1.Customize += new System.EventHandler(this.chart1_Customize);
            // 
            // Page2
            // 
            this.Page2.Controls.Add(this.MotionPanel);
            this.Page2.HorizontalScrollbarBarColor = true;
            this.Page2.HorizontalScrollbarSize = 19;
            this.Page2.Location = new System.Drawing.Point(8, 42);
            this.Page2.Margin = new System.Windows.Forms.Padding(6);
            this.Page2.Name = "Page2";
            this.Page2.Size = new System.Drawing.Size(886, 550);
            this.Page2.TabIndex = 1;
            this.Page2.Text = "Motion View";
            this.Page2.VerticalScrollbarBarColor = true;
            this.Page2.VerticalScrollbarSize = 20;
            // 
            // MotionPanel
            // 
            this.MotionPanel.Controls.Add(this.pictureBox3);
            this.MotionPanel.Controls.Add(this.motionImageBox);
            this.MotionPanel.Location = new System.Drawing.Point(113, 39);
            this.MotionPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MotionPanel.Name = "MotionPanel";
            this.MotionPanel.Size = new System.Drawing.Size(647, 496);
            this.MotionPanel.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(647, 496);
            this.pictureBox3.TabIndex = 32;
            this.pictureBox3.TabStop = false;
            // 
            // motionImageBox
            // 
            this.motionImageBox.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.motionImageBox.Location = new System.Drawing.Point(0, 0);
            this.motionImageBox.Margin = new System.Windows.Forms.Padding(0);
            this.motionImageBox.Name = "motionImageBox";
            this.motionImageBox.Size = new System.Drawing.Size(647, 496);
            this.motionImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.motionImageBox.TabIndex = 2;
            this.motionImageBox.TabStop = false;
            // 
            // Page1
            // 
            this.Page1.Controls.Add(this.panelLabel);
            this.Page1.Controls.Add(this.metroComboBox3);
            this.Page1.Controls.Add(this.opacityLabel);
            this.Page1.Controls.Add(this.colorLabel);
            this.Page1.Controls.Add(this.gridLabel);
            this.Page1.Controls.Add(this.metroComboBox2);
            this.Page1.Controls.Add(this.metroComboBox1);
            this.Page1.Controls.Add(this.metroToggle1);
            this.Page1.Controls.Add(this.PedestrianPanel);
            this.Page1.HorizontalScrollbarBarColor = true;
            this.Page1.HorizontalScrollbarSize = 19;
            this.Page1.Location = new System.Drawing.Point(8, 42);
            this.Page1.Margin = new System.Windows.Forms.Padding(6);
            this.Page1.Name = "Page1";
            this.Page1.Size = new System.Drawing.Size(886, 550);
            this.Page1.TabIndex = 0;
            this.Page1.Text = "Pedestrian View";
            this.Page1.VerticalScrollbarBarColor = true;
            this.Page1.VerticalScrollbarSize = 20;
            // 
            // panelLabel
            // 
            this.panelLabel.AutoSize = true;
            this.panelLabel.Location = new System.Drawing.Point(680, 257);
            this.panelLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.panelLabel.Name = "panelLabel";
            this.panelLabel.Size = new System.Drawing.Size(48, 19);
            this.panelLabel.TabIndex = 23;
            this.panelLabel.Text = "Panel#";
            // 
            // metroComboBox3
            // 
            this.metroComboBox3.FormattingEnabled = true;
            this.metroComboBox3.ItemHeight = 23;
            this.metroComboBox3.Location = new System.Drawing.Point(770, 257);
            this.metroComboBox3.Margin = new System.Windows.Forms.Padding(6);
            this.metroComboBox3.Name = "metroComboBox3";
            this.metroComboBox3.Size = new System.Drawing.Size(74, 29);
            this.metroComboBox3.TabIndex = 24;
            // 
            // opacityLabel
            // 
            this.opacityLabel.AutoSize = true;
            this.opacityLabel.Location = new System.Drawing.Point(680, 200);
            this.opacityLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.opacityLabel.Name = "opacityLabel";
            this.opacityLabel.Size = new System.Drawing.Size(54, 19);
            this.opacityLabel.TabIndex = 22;
            this.opacityLabel.Text = "Opacity";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(680, 141);
            this.colorLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(49, 19);
            this.colorLabel.TabIndex = 21;
            this.colorLabel.Text = "Colour";
            // 
            // gridLabel
            // 
            this.gridLabel.AutoSize = true;
            this.gridLabel.Location = new System.Drawing.Point(680, 66);
            this.gridLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.gridLabel.Name = "gridLabel";
            this.gridLabel.Size = new System.Drawing.Size(62, 19);
            this.gridLabel.TabIndex = 20;
            this.gridLabel.Text = "Grid Tool";
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.ItemHeight = 23;
            this.metroComboBox2.Location = new System.Drawing.Point(770, 190);
            this.metroComboBox2.Margin = new System.Windows.Forms.Padding(6);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(74, 29);
            this.metroComboBox2.TabIndex = 19;
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(770, 131);
            this.metroComboBox1.Margin = new System.Windows.Forms.Padding(6);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(74, 29);
            this.metroComboBox1.TabIndex = 18;
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Location = new System.Drawing.Point(770, 66);
            this.metroToggle1.Margin = new System.Windows.Forms.Padding(6);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 29);
            this.metroToggle1.TabIndex = 17;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.UseVisualStyleBackColor = true;
            this.metroToggle1.CheckedChanged += new System.EventHandler(this.metroToggle1_CheckedChanged_1);
            // 
            // PedestrianPanel
            // 
            this.PedestrianPanel.BackColor = System.Drawing.SystemColors.Control;
            this.PedestrianPanel.Controls.Add(this.capturedImageBox);
            this.PedestrianPanel.Location = new System.Drawing.Point(8, 54);
            this.PedestrianPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PedestrianPanel.Name = "PedestrianPanel";
            this.PedestrianPanel.Size = new System.Drawing.Size(647, 496);
            this.PedestrianPanel.TabIndex = 7;
            // 
            // capturedImageBox
            // 
            this.capturedImageBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.capturedImageBox.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.capturedImageBox.Location = new System.Drawing.Point(0, 0);
            this.capturedImageBox.Margin = new System.Windows.Forms.Padding(0);
            this.capturedImageBox.Name = "capturedImageBox";
            this.capturedImageBox.Size = new System.Drawing.Size(647, 496);
            this.capturedImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.capturedImageBox.TabIndex = 0;
            this.capturedImageBox.TabStop = false;
            // 
            // SourceComboBox
            // 
            this.SourceComboBox.FormattingEnabled = true;
            this.SourceComboBox.ItemHeight = 23;
            this.SourceComboBox.Items.AddRange(new object[] {
            "Camera",
            "Video File"});
            this.SourceComboBox.Location = new System.Drawing.Point(118, 130);
            this.SourceComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.SourceComboBox.Name = "SourceComboBox";
            this.SourceComboBox.Size = new System.Drawing.Size(74, 29);
            this.SourceComboBox.TabIndex = 28;
            this.SourceComboBox.SelectedIndexChanged += new System.EventHandler(this.SourceComboBox_SelectedIndexChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(28, 130);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(66, 25);
            this.metroLabel2.TabIndex = 27;
            this.metroLabel2.Text = "Source";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(28, 206);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 25);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "Record";
            // 
            // recordToggle
            // 
            this.recordToggle.AutoSize = true;
            this.recordToggle.Location = new System.Drawing.Point(118, 202);
            this.recordToggle.Margin = new System.Windows.Forms.Padding(6);
            this.recordToggle.Name = "recordToggle";
            this.recordToggle.Size = new System.Drawing.Size(80, 29);
            this.recordToggle.TabIndex = 25;
            this.recordToggle.Text = "Off";
            this.recordToggle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.recordToggle.UseVisualStyleBackColor = true;
            this.recordToggle.CheckedChanged += new System.EventHandler(this.recordToggle_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 662);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 8;
            // 
            // Home
            // 
            this.Home.Controls.Add(this.pictureBox1);
            this.Home.Controls.Add(this.pictureBox2);
            this.Home.HorizontalScrollbarBarColor = true;
            this.Home.HorizontalScrollbarSize = 19;
            this.Home.Location = new System.Drawing.Point(8, 42);
            this.Home.Margin = new System.Windows.Forms.Padding(6);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(184, 50);
            this.Home.TabIndex = 3;
            this.Home.Text = "Home";
            this.Home.VerticalScrollbarBarColor = true;
            this.Home.VerticalScrollbarSize = 20;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(654, 429);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(184, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // HeatMap
            // 
            this.HeatMap.Controls.Add(this.Home);
            this.HeatMap.Controls.Add(this.Page3);
            this.HeatMap.Controls.Add(this.Page1);
            this.HeatMap.Controls.Add(this.Page2);
            this.HeatMap.Location = new System.Drawing.Point(220, 56);
            this.HeatMap.Margin = new System.Windows.Forms.Padding(6);
            this.HeatMap.Name = "HeatMap";
            this.HeatMap.SelectedIndex = 3;
            this.HeatMap.Size = new System.Drawing.Size(902, 600);
            this.HeatMap.TabIndex = 11;
            // 
            // timer
            // 
            this.timer.Interval = 5000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FireKAM
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1158, 700);
            this.Controls.Add(this.HeatMap);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SourceComboBox);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.recordToggle);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "FireKAM";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Text = "FireKAM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.FireKAM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.Page3.ResumeLayout(false);
            this.Page3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportHeatmapImageBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.Page2.ResumeLayout(false);
            this.MotionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.motionImageBox)).EndInit();
            this.Page1.ResumeLayout(false);
            this.Page1.PerformLayout();
            this.PedestrianPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.capturedImageBox)).EndInit();
            this.Home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.HeatMap.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Components.MetroStyleManager msmMain;
        private MetroFramework.Controls.MetroTabPage Page3;
        private MetroFramework.Controls.MetroButton ToPDF;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroTabPage Page2;
        private System.Windows.Forms.Panel MotionPanel;
        private Emgu.CV.UI.ImageBox motionImageBox;
        private MetroFramework.Controls.MetroTabPage Page1;
        private System.Windows.Forms.Label label3;
        private Emgu.CV.UI.ImageBox capturedImageBox;
        private MetroFramework.Controls.MetroTabPage Home;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTabControl HeatMap;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroButton GenerateChartBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ReportTypeCB;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroLabel panelLabel;
        private MetroFramework.Controls.MetroComboBox metroComboBox3;
        private MetroFramework.Controls.MetroLabel opacityLabel;
        private MetroFramework.Controls.MetroLabel colorLabel;
        private MetroFramework.Controls.MetroLabel gridLabel;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private System.Windows.Forms.Panel PedestrianPanel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private MetroFramework.Controls.MetroToggle recordToggle;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox SourceComboBox;
        private System.Windows.Forms.ComboBox ReportSourceDropdown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox reportHeatmapImageBox;
        private System.Windows.Forms.Label label1;
    }
}

