namespace WindowsFormsApplication3
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
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel1 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Serial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XModMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YModMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZModMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxFlexX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxFlexY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxFlexZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minXValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxYValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minYValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midYValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxXValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.minZValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midZValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XPeakToPeakSelectionX10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YPeakToPeakSelectionX10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZPeakToPeakSelectionX10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.XRMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YRMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ZRMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chartX = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartZ = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.closeButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.timerTextBox = new System.Windows.Forms.MaskedTextBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartZ)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Serial,
            this.Number,
            this.XModMax,
            this.YModMax,
            this.ZModMax,
            this.MaxFlexX,
            this.MaxFlexY,
            this.MaxFlexZ,
            this.maxValue,
            this.minXValue,
            this.midValue,
            this.maxYValue,
            this.minYValue,
            this.midYValue,
            this.maxXValue,
            this.minZValue,
            this.midZValue,
            this.XPeakToPeakSelectionX10,
            this.YPeakToPeakSelectionX10,
            this.ZPeakToPeakSelectionX10,
            this.XRMS,
            this.YRMS,
            this.ZRMS,
            this.SelectedStart,
            this.SelectedEnd});
            this.dataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGrid.Location = new System.Drawing.Point(0, 0);
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(939, 255);
            this.dataGrid.TabIndex = 4;
            // 
            // Time
            // 
            this.Time.FillWeight = 150F;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.Width = 110;
            // 
            // Serial
            // 
            this.Serial.HeaderText = "Series name";
            this.Serial.Name = "Serial";
            this.Serial.Width = 60;
            // 
            // Number
            // 
            this.Number.HeaderText = "Number of points";
            this.Number.Name = "Number";
            this.Number.Width = 50;
            // 
            // XModMax
            // 
            this.XModMax.HeaderText = "X Peak to Peak (x10)";
            this.XModMax.Name = "XModMax";
            this.XModMax.Width = 65;
            // 
            // YModMax
            // 
            this.YModMax.HeaderText = "Y Peak to Peak(x10)";
            this.YModMax.Name = "YModMax";
            this.YModMax.Width = 65;
            // 
            // ZModMax
            // 
            this.ZModMax.HeaderText = "Z Peak to Peak(x10)";
            this.ZModMax.Name = "ZModMax";
            this.ZModMax.Width = 65;
            // 
            // MaxFlexX
            // 
            this.MaxFlexX.HeaderText = "X Peak to Peak for Moving Average(x10)";
            this.MaxFlexX.Name = "MaxFlexX";
            this.MaxFlexX.Width = 70;
            // 
            // MaxFlexY
            // 
            this.MaxFlexY.HeaderText = "Y Peak to Peak for Moving Average(x10)";
            this.MaxFlexY.Name = "MaxFlexY";
            this.MaxFlexY.Width = 70;
            // 
            // MaxFlexZ
            // 
            this.MaxFlexZ.HeaderText = "Z Peak to Peak for Moving Average(x10)";
            this.MaxFlexZ.Name = "MaxFlexZ";
            this.MaxFlexZ.Width = 70;
            // 
            // maxValue
            // 
            this.maxValue.HeaderText = "maxXValue";
            this.maxValue.Name = "maxValue";
            this.maxValue.Visible = false;
            // 
            // minXValue
            // 
            this.minXValue.HeaderText = "minXValue";
            this.minXValue.Name = "minXValue";
            this.minXValue.Visible = false;
            // 
            // midValue
            // 
            this.midValue.HeaderText = "midXValue";
            this.midValue.Name = "midValue";
            this.midValue.Visible = false;
            // 
            // maxYValue
            // 
            this.maxYValue.HeaderText = "maxYValue";
            this.maxYValue.Name = "maxYValue";
            this.maxYValue.Visible = false;
            // 
            // minYValue
            // 
            this.minYValue.HeaderText = "minYValue";
            this.minYValue.Name = "minYValue";
            this.minYValue.Visible = false;
            // 
            // midYValue
            // 
            this.midYValue.HeaderText = "midYValue";
            this.midYValue.Name = "midYValue";
            this.midYValue.Visible = false;
            // 
            // maxXValue
            // 
            this.maxXValue.HeaderText = "maxXValue";
            this.maxXValue.Name = "maxXValue";
            this.maxXValue.Visible = false;
            // 
            // minZValue
            // 
            this.minZValue.HeaderText = "minZValue";
            this.minZValue.Name = "minZValue";
            this.minZValue.Visible = false;
            // 
            // midZValue
            // 
            this.midZValue.HeaderText = "midZValue";
            this.midZValue.Name = "midZValue";
            this.midZValue.Visible = false;
            // 
            // XPeakToPeakSelectionX10
            // 
            this.XPeakToPeakSelectionX10.HeaderText = "X Peak To Peak Selection (X10)";
            this.XPeakToPeakSelectionX10.Name = "XPeakToPeakSelectionX10";
            this.XPeakToPeakSelectionX10.Width = 80;
            // 
            // YPeakToPeakSelectionX10
            // 
            this.YPeakToPeakSelectionX10.HeaderText = "Y Peak To Peak Selection (X10)";
            this.YPeakToPeakSelectionX10.Name = "YPeakToPeakSelectionX10";
            this.YPeakToPeakSelectionX10.Width = 80;
            // 
            // ZPeakToPeakSelectionX10
            // 
            this.ZPeakToPeakSelectionX10.HeaderText = "Z Peak To Peak Selection (X10)";
            this.ZPeakToPeakSelectionX10.Name = "ZPeakToPeakSelectionX10";
            this.ZPeakToPeakSelectionX10.Width = 80;
            // 
            // XRMS
            // 
            this.XRMS.HeaderText = "X RMS Selection (x10)";
            this.XRMS.Name = "XRMS";
            this.XRMS.Width = 60;
            // 
            // YRMS
            // 
            this.YRMS.HeaderText = "Y RMS Selection (x10)";
            this.YRMS.Name = "YRMS";
            this.YRMS.Width = 60;
            // 
            // ZRMS
            // 
            this.ZRMS.HeaderText = "Z RMS Selection (x10)";
            this.ZRMS.Name = "ZRMS";
            this.ZRMS.Width = 60;
            // 
            // SelectedStart
            // 
            this.SelectedStart.HeaderText = "SelectedStart";
            this.SelectedStart.Name = "SelectedStart";
            this.SelectedStart.Visible = false;
            // 
            // SelectedEnd
            // 
            this.SelectedEnd.HeaderText = "SelectedEnd";
            this.SelectedEnd.Name = "SelectedEnd";
            this.SelectedEnd.Visible = false;
            // 
            // chartX
            // 
            this.chartX.BorderlineColor = System.Drawing.Color.DimGray;
            this.chartX.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelAutoFitMaxFontSize = 8;
            chartArea1.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea1.AxisX.ScaleView.Size = 300D;
            chartArea1.AxisX.ScaleView.Zoomable = false;
            chartArea1.AxisX.ScrollBar.BackColor = System.Drawing.Color.White;
            chartArea1.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea1.AxisX.Title = "Time( ss)";
            chartArea1.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            customLabel1.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            customLabel1.Text = "1";
            chartArea1.AxisX2.CustomLabels.Add(customLabel1);
            chartArea1.AxisY.Interval = 0.1D;
            chartArea1.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea1.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.IsStartedFromZero = false;
            chartArea1.AxisY.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisY.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.BackColor = System.Drawing.Color.Black;
            chartArea1.CursorX.IsUserSelectionEnabled = true;
            chartArea1.Name = "ChartArea1";
            this.chartX.ChartAreas.Add(chartArea1);
            this.chartX.Location = new System.Drawing.Point(0, 261);
            this.chartX.Name = "chartX";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.LegendText = "X Max Value";
            series1.MarkerBorderColor = System.Drawing.Color.Red;
            series1.MarkerColor = System.Drawing.Color.Red;
            series1.Name = "SeriesXMax";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.LegendText = "X Min Value";
            series2.Name = "SeriesXMin";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.Fuchsia;
            series3.Legend = "Legend1";
            series3.LegendText = "Mid X";
            series3.Name = "SeriesXMid";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            this.chartX.Series.Add(series1);
            this.chartX.Series.Add(series2);
            this.chartX.Series.Add(series3);
            this.chartX.Size = new System.Drawing.Size(1045, 145);
            this.chartX.TabIndex = 13;
            this.chartX.Text = "chartX";
            // 
            // chartY
            // 
            this.chartY.BorderlineColor = System.Drawing.Color.Gray;
            this.chartY.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelAutoFitMaxFontSize = 8;
            chartArea2.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea2.AxisX.ScaleView.Zoomable = false;
            chartArea2.AxisX.ScrollBar.Enabled = false;
            chartArea2.AxisX.Title = "Time(ss)";
            chartArea2.AxisY.Interval = 0.3D;
            chartArea2.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea2.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea2.AxisY.IsStartedFromZero = false;
            chartArea2.BackColor = System.Drawing.Color.Black;
            chartArea2.BackSecondaryColor = System.Drawing.Color.Black;
            chartArea2.CursorX.IsUserSelectionEnabled = true;
            chartArea2.Name = "ChartArea1";
            this.chartY.ChartAreas.Add(chartArea2);
            this.chartY.Location = new System.Drawing.Point(0, 441);
            this.chartY.Name = "chartY";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Red;
            series4.LegendText = "Y Max Value";
            series4.MarkerBorderColor = System.Drawing.Color.Red;
            series4.MarkerColor = System.Drawing.Color.Red;
            series4.Name = "SeriesYMax";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Red;
            series5.LegendText = "Y Min Value";
            series5.Name = "SeriesYMin";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Fuchsia;
            series6.LegendText = "Mid Y";
            series6.Name = "SeriesYMid";
            this.chartY.Series.Add(series4);
            this.chartY.Series.Add(series5);
            this.chartY.Series.Add(series6);
            this.chartY.Size = new System.Drawing.Size(1045, 111);
            this.chartY.TabIndex = 14;
            this.chartY.Text = "chart5";
            // 
            // chartZ
            // 
            this.chartZ.BorderlineColor = System.Drawing.Color.Gray;
            this.chartZ.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.LabelAutoFitMaxFontSize = 8;
            chartArea3.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea3.AxisX.ScaleView.Zoomable = false;
            chartArea3.AxisX.ScrollBar.Enabled = false;
            chartArea3.AxisY.Interval = 0.2D;
            chartArea3.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea3.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea3.AxisY.IsStartedFromZero = false;
            chartArea3.BackColor = System.Drawing.Color.Black;
            chartArea3.CursorX.IsUserSelectionEnabled = true;
            chartArea3.Name = "ChartArea1";
            this.chartZ.ChartAreas.Add(chartArea3);
            this.chartZ.Location = new System.Drawing.Point(12, 547);
            this.chartZ.Name = "chartZ";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.Red;
            series7.LegendText = "Z Max Value";
            series7.MarkerBorderColor = System.Drawing.Color.Red;
            series7.MarkerColor = System.Drawing.Color.Red;
            series7.Name = "SeriesZMax";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.Red;
            series8.LegendText = "Z Min Value";
            series8.Name = "SeriesZMin";
            series9.BorderWidth = 2;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Color = System.Drawing.Color.Fuchsia;
            series9.LegendText = "Mid Z";
            series9.Name = "SeriesZMid";
            this.chartZ.Series.Add(series7);
            this.chartZ.Series.Add(series8);
            this.chartZ.Series.Add(series9);
            this.chartZ.Size = new System.Drawing.Size(1045, 125);
            this.chartZ.TabIndex = 15;
            this.chartZ.Text = "chart6";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closeButton.Location = new System.Drawing.Point(1067, 133);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 42;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.startButton.Location = new System.Drawing.Point(1067, 50);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 40;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // timerTextBox
            // 
            this.timerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timerTextBox.Location = new System.Drawing.Point(965, 91);
            this.timerTextBox.Mask = "000";
            this.timerTextBox.Name = "timerTextBox";
            this.timerTextBox.Size = new System.Drawing.Size(58, 20);
            this.timerTextBox.TabIndex = 45;
            this.timerTextBox.Text = "10";
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.stopButton.Location = new System.Drawing.Point(1067, 89);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 41;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(962, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 17);
            this.label14.TabIndex = 44;
            this.label14.Text = "Timer (s)";
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.clearButton.Location = new System.Drawing.Point(965, 131);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 26);
            this.clearButton.TabIndex = 43;
            this.clearButton.Text = "Clear values";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 747);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.timerTextBox);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.chartZ);
            this.Controls.Add(this.chartY);
            this.Controls.Add(this.chartX);
            this.Controls.Add(this.dataGrid);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn XModMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn YModMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZModMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxFlexX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxFlexY;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxFlexZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn minXValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn midValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxYValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn minYValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn midYValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxXValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn minZValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn midZValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn XPeakToPeakSelectionX10;
        private System.Windows.Forms.DataGridViewTextBoxColumn YPeakToPeakSelectionX10;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZPeakToPeakSelectionX10;
        private System.Windows.Forms.DataGridViewTextBoxColumn XRMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn YRMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZRMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectedStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectedEnd;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartX;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartY;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartZ;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.MaskedTextBox timerTextBox;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button clearButton;
    }
}