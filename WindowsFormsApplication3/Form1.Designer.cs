namespace WindowsFormsApplication3
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Data.DataColumn startNumber;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.CustomLabel customLabel2 = new System.Windows.Forms.DataVisualization.Charting.CustomLabel();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
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
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.timerTextBox = new System.Windows.Forms.MaskedTextBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.chartX = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartZ = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DataSetValues = new System.Data.DataSet();
            this.AllValues = new System.Data.DataTable();
            this.XValue = new System.Data.DataColumn();
            this.YValue = new System.Data.DataColumn();
            this.ZValue = new System.Data.DataColumn();
            this.Numb = new System.Data.DataColumn();
            this.TimeValue = new System.Data.DataColumn();
            this.dataColumn1 = new System.Data.DataColumn();
            this.comPort = new System.IO.Ports.SerialPort(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьКакXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьИзXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.экспортВCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.какПользоватьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveAsXMLDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveAsCSVDialog = new System.Windows.Forms.SaveFileDialog();
            this.openXMLDialog = new System.Windows.Forms.OpenFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            startNumber = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllValues)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startNumber
            // 
            startNumber.ColumnName = "startNumber";
            startNumber.DataType = typeof(short);
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            resources.ApplyResources(this.splitContainer1.Panel1, "splitContainer1.Panel1");
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            resources.ApplyResources(this.splitContainer1.Panel2, "splitContainer1.Panel2");
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel2);
            // 
            // splitContainer2
            // 
            resources.ApplyResources(this.splitContainer2, "splitContainer2");
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            resources.ApplyResources(this.splitContainer2.Panel1, "splitContainer2.Panel1");
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            resources.ApplyResources(this.splitContainer2.Panel2, "splitContainer2.Panel2");
            this.splitContainer2.Panel2.Controls.Add(this.closeButton);
            this.splitContainer2.Panel2.Controls.Add(this.startButton);
            this.splitContainer2.Panel2.Controls.Add(this.timerTextBox);
            this.splitContainer2.Panel2.Controls.Add(this.stopButton);
            this.splitContainer2.Panel2.Controls.Add(this.label14);
            this.splitContainer2.Panel2.Controls.Add(this.clearButton);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.dataGrid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // dataGrid
            // 
            resources.ApplyResources(this.dataGrid, "dataGrid");
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGrid.MultiSelect = false;
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGrid_CellMouseClick);
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Time.FillWeight = 150F;
            resources.ApplyResources(this.Time, "Time");
            this.Time.Name = "Time";
            // 
            // Serial
            // 
            resources.ApplyResources(this.Serial, "Serial");
            this.Serial.Name = "Serial";
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            resources.ApplyResources(this.Number, "Number");
            this.Number.Name = "Number";
            // 
            // XModMax
            // 
            this.XModMax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.XModMax, "XModMax");
            this.XModMax.Name = "XModMax";
            // 
            // YModMax
            // 
            this.YModMax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.YModMax, "YModMax");
            this.YModMax.Name = "YModMax";
            // 
            // ZModMax
            // 
            this.ZModMax.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.ZModMax, "ZModMax");
            this.ZModMax.Name = "ZModMax";
            // 
            // MaxFlexX
            // 
            this.MaxFlexX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.MaxFlexX, "MaxFlexX");
            this.MaxFlexX.Name = "MaxFlexX";
            // 
            // MaxFlexY
            // 
            this.MaxFlexY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.MaxFlexY, "MaxFlexY");
            this.MaxFlexY.Name = "MaxFlexY";
            // 
            // MaxFlexZ
            // 
            this.MaxFlexZ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.MaxFlexZ, "MaxFlexZ");
            this.MaxFlexZ.Name = "MaxFlexZ";
            // 
            // maxValue
            // 
            resources.ApplyResources(this.maxValue, "maxValue");
            this.maxValue.Name = "maxValue";
            // 
            // minXValue
            // 
            resources.ApplyResources(this.minXValue, "minXValue");
            this.minXValue.Name = "minXValue";
            // 
            // midValue
            // 
            resources.ApplyResources(this.midValue, "midValue");
            this.midValue.Name = "midValue";
            // 
            // maxYValue
            // 
            resources.ApplyResources(this.maxYValue, "maxYValue");
            this.maxYValue.Name = "maxYValue";
            // 
            // minYValue
            // 
            resources.ApplyResources(this.minYValue, "minYValue");
            this.minYValue.Name = "minYValue";
            // 
            // midYValue
            // 
            resources.ApplyResources(this.midYValue, "midYValue");
            this.midYValue.Name = "midYValue";
            // 
            // maxXValue
            // 
            resources.ApplyResources(this.maxXValue, "maxXValue");
            this.maxXValue.Name = "maxXValue";
            // 
            // minZValue
            // 
            resources.ApplyResources(this.minZValue, "minZValue");
            this.minZValue.Name = "minZValue";
            // 
            // midZValue
            // 
            resources.ApplyResources(this.midZValue, "midZValue");
            this.midZValue.Name = "midZValue";
            // 
            // XPeakToPeakSelectionX10
            // 
            this.XPeakToPeakSelectionX10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.XPeakToPeakSelectionX10, "XPeakToPeakSelectionX10");
            this.XPeakToPeakSelectionX10.Name = "XPeakToPeakSelectionX10";
            // 
            // YPeakToPeakSelectionX10
            // 
            this.YPeakToPeakSelectionX10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.YPeakToPeakSelectionX10, "YPeakToPeakSelectionX10");
            this.YPeakToPeakSelectionX10.Name = "YPeakToPeakSelectionX10";
            // 
            // ZPeakToPeakSelectionX10
            // 
            this.ZPeakToPeakSelectionX10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.ZPeakToPeakSelectionX10, "ZPeakToPeakSelectionX10");
            this.ZPeakToPeakSelectionX10.Name = "ZPeakToPeakSelectionX10";
            // 
            // XRMS
            // 
            this.XRMS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.XRMS, "XRMS");
            this.XRMS.Name = "XRMS";
            // 
            // YRMS
            // 
            this.YRMS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.YRMS, "YRMS");
            this.YRMS.Name = "YRMS";
            // 
            // ZRMS
            // 
            this.ZRMS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            resources.ApplyResources(this.ZRMS, "ZRMS");
            this.ZRMS.Name = "ZRMS";
            // 
            // SelectedStart
            // 
            resources.ApplyResources(this.SelectedStart, "SelectedStart");
            this.SelectedStart.Name = "SelectedStart";
            // 
            // SelectedEnd
            // 
            resources.ApplyResources(this.SelectedEnd, "SelectedEnd");
            this.SelectedEnd.Name = "SelectedEnd";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // closeButton
            // 
            resources.ApplyResources(this.closeButton, "closeButton");
            this.closeButton.Name = "closeButton";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // startButton
            // 
            resources.ApplyResources(this.startButton, "startButton");
            this.startButton.Name = "startButton";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timerTextBox
            // 
            resources.ApplyResources(this.timerTextBox, "timerTextBox");
            this.timerTextBox.Name = "timerTextBox";
            // 
            // stopButton
            // 
            resources.ApplyResources(this.stopButton, "stopButton");
            this.stopButton.Name = "stopButton";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // label14
            // 
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // clearButton
            // 
            resources.ApplyResources(this.clearButton, "clearButton");
            this.clearButton.Name = "clearButton";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.chartX, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.chartY, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.chartZ, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // chartX
            // 
            resources.ApplyResources(this.chartX, "chartX");
            this.chartX.BorderlineColor = System.Drawing.Color.DimGray;
            this.chartX.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.AxisX.IsLabelAutoFit = false;
            chartArea4.AxisX.LabelAutoFitMaxFontSize = 8;
            chartArea4.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea4.AxisX.ScaleView.Size = 300D;
            chartArea4.AxisX.ScaleView.Zoomable = false;
            chartArea4.AxisX.ScrollBar.BackColor = System.Drawing.Color.White;
            chartArea4.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.Gray;
            chartArea4.AxisX.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea4.AxisX.Title = "Time( ss)";
            chartArea4.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea4.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            customLabel2.MarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            customLabel2.Text = "1";
            chartArea4.AxisX2.CustomLabels.Add(customLabel2);
            chartArea4.AxisY.Interval = 0.1D;
            chartArea4.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea4.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.AxisY.IsStartedFromZero = false;
            chartArea4.AxisY.MajorTickMark.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.AxisY.MajorTickMark.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea4.BackColor = System.Drawing.Color.Black;
            chartArea4.CursorX.IsUserSelectionEnabled = true;
            chartArea4.Name = "ChartArea1";
            this.chartX.ChartAreas.Add(chartArea4);
            this.chartX.Name = "chartX";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series10.Color = System.Drawing.Color.Red;
            series10.Legend = "Legend1";
            series10.LegendText = "X Max Value";
            series10.MarkerBorderColor = System.Drawing.Color.Red;
            series10.MarkerColor = System.Drawing.Color.Red;
            series10.Name = "SeriesXMax";
            series10.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Color = System.Drawing.Color.Red;
            series11.Legend = "Legend1";
            series11.LegendText = "X Min Value";
            series11.Name = "SeriesXMin";
            series11.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            series12.BorderWidth = 2;
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Color = System.Drawing.Color.Fuchsia;
            series12.Legend = "Legend1";
            series12.LegendText = "Mid X";
            series12.Name = "SeriesXMid";
            series12.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Single;
            this.chartX.Series.Add(series10);
            this.chartX.Series.Add(series11);
            this.chartX.Series.Add(series12);
            this.chartX.SelectionRangeChanging += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.CursorEventArgs>(this.chartX_SelectionRangeChanging);
            this.chartX.SelectionRangeChanged += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.CursorEventArgs>(this.chartX_SelectionRangeChanged);
            // 
            // chartY
            // 
            resources.ApplyResources(this.chartY, "chartY");
            this.chartY.BorderlineColor = System.Drawing.Color.Gray;
            this.chartY.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea5.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea5.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea5.AxisX.IsLabelAutoFit = false;
            chartArea5.AxisX.LabelAutoFitMaxFontSize = 8;
            chartArea5.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea5.AxisX.ScaleView.Zoomable = false;
            chartArea5.AxisX.ScrollBar.Enabled = false;
            chartArea5.AxisX.Title = "Time(ss)";
            chartArea5.AxisY.Interval = 0.3D;
            chartArea5.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea5.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea5.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea5.AxisY.IsStartedFromZero = false;
            chartArea5.BackColor = System.Drawing.Color.Black;
            chartArea5.BackSecondaryColor = System.Drawing.Color.Black;
            chartArea5.CursorX.IsUserSelectionEnabled = true;
            chartArea5.Name = "ChartArea1";
            this.chartY.ChartAreas.Add(chartArea5);
            this.chartY.Name = "chartY";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Color = System.Drawing.Color.Red;
            series13.LegendText = "Y Max Value";
            series13.MarkerBorderColor = System.Drawing.Color.Red;
            series13.MarkerColor = System.Drawing.Color.Red;
            series13.Name = "SeriesYMax";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Color = System.Drawing.Color.Red;
            series14.LegendText = "Y Min Value";
            series14.Name = "SeriesYMin";
            series15.BorderWidth = 2;
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Color = System.Drawing.Color.Fuchsia;
            series15.LegendText = "Mid Y";
            series15.Name = "SeriesYMid";
            this.chartY.Series.Add(series13);
            this.chartY.Series.Add(series14);
            this.chartY.Series.Add(series15);
            this.chartY.SelectionRangeChanging += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.CursorEventArgs>(this.chartY_SelectionRangeChanging);
            this.chartY.SelectionRangeChanged += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.CursorEventArgs>(this.chartY_SelectionRangeChanged);
            // 
            // chartZ
            // 
            resources.ApplyResources(this.chartZ, "chartZ");
            this.chartZ.BorderlineColor = System.Drawing.Color.Gray;
            this.chartZ.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea6.AxisX.IsLabelAutoFit = false;
            chartArea6.AxisX.LabelAutoFitMaxFontSize = 8;
            chartArea6.AxisX.LabelStyle.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea6.AxisX.ScaleView.Zoomable = false;
            chartArea6.AxisX.ScrollBar.Enabled = false;
            chartArea6.AxisY.Interval = 0.2D;
            chartArea6.AxisY.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea6.AxisY.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea6.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea6.AxisY.IsStartedFromZero = false;
            chartArea6.BackColor = System.Drawing.Color.Black;
            chartArea6.CursorX.IsUserSelectionEnabled = true;
            chartArea6.Name = "ChartArea1";
            this.chartZ.ChartAreas.Add(chartArea6);
            this.chartZ.Name = "chartZ";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.Color = System.Drawing.Color.Red;
            series16.LegendText = "Z Max Value";
            series16.MarkerBorderColor = System.Drawing.Color.Red;
            series16.MarkerColor = System.Drawing.Color.Red;
            series16.Name = "SeriesZMax";
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series17.Color = System.Drawing.Color.Red;
            series17.LegendText = "Z Min Value";
            series17.Name = "SeriesZMin";
            series18.BorderWidth = 2;
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series18.Color = System.Drawing.Color.Fuchsia;
            series18.LegendText = "Mid Z";
            series18.Name = "SeriesZMid";
            this.chartZ.Series.Add(series16);
            this.chartZ.Series.Add(series17);
            this.chartZ.Series.Add(series18);
            this.chartZ.SelectionRangeChanging += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.CursorEventArgs>(this.chartZ_SelectionRangeChanging);
            this.chartZ.SelectionRangeChanged += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.CursorEventArgs>(this.chartZ_SelectionRangeChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // DataSetValues
            // 
            this.DataSetValues.DataSetName = "NewDataSet";
            this.DataSetValues.Tables.AddRange(new System.Data.DataTable[] {
            this.AllValues});
            // 
            // AllValues
            // 
            this.AllValues.Columns.AddRange(new System.Data.DataColumn[] {
            this.XValue,
            this.YValue,
            this.ZValue,
            this.Numb,
            this.TimeValue,
            startNumber,
            this.dataColumn1});
            this.AllValues.TableName = "AllValues";
            // 
            // XValue
            // 
            this.XValue.ColumnName = "XValue";
            this.XValue.DataType = typeof(double);
            // 
            // YValue
            // 
            this.YValue.ColumnName = "YValue";
            this.YValue.DataType = typeof(double);
            // 
            // ZValue
            // 
            this.ZValue.ColumnName = "ZValue";
            this.ZValue.DataType = typeof(double);
            // 
            // Numb
            // 
            this.Numb.ColumnName = "Number";
            this.Numb.DataType = typeof(short);
            // 
            // TimeValue
            // 
            this.TimeValue.ColumnName = "Time";
            this.TimeValue.DataType = typeof(System.DateTime);
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "SeriesNumber";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            resources.ApplyResources(this.файлToolStripMenuItem, "файлToolStripMenuItem");
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьКакXMLToolStripMenuItem,
            this.загрузитьИзXMLToolStripMenuItem,
            this.экспортВCSVToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            // 
            // сохранитьКакXMLToolStripMenuItem
            // 
            resources.ApplyResources(this.сохранитьКакXMLToolStripMenuItem, "сохранитьКакXMLToolStripMenuItem");
            this.сохранитьКакXMLToolStripMenuItem.Name = "сохранитьКакXMLToolStripMenuItem";
            this.сохранитьКакXMLToolStripMenuItem.Click += new System.EventHandler(this.сохранитьКакXMLToolStripMenuItem_Click);
            // 
            // загрузитьИзXMLToolStripMenuItem
            // 
            resources.ApplyResources(this.загрузитьИзXMLToolStripMenuItem, "загрузитьИзXMLToolStripMenuItem");
            this.загрузитьИзXMLToolStripMenuItem.Name = "загрузитьИзXMLToolStripMenuItem";
            this.загрузитьИзXMLToolStripMenuItem.Click += new System.EventHandler(this.загрузитьИзXMLToolStripMenuItem_Click);
            // 
            // экспортВCSVToolStripMenuItem
            // 
            resources.ApplyResources(this.экспортВCSVToolStripMenuItem, "экспортВCSVToolStripMenuItem");
            this.экспортВCSVToolStripMenuItem.Name = "экспортВCSVToolStripMenuItem";
            this.экспортВCSVToolStripMenuItem.Click += new System.EventHandler(this.экспортВCSVToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            // 
            // allSettingsToolStripMenuItem
            // 
            resources.ApplyResources(this.allSettingsToolStripMenuItem, "allSettingsToolStripMenuItem");
            this.allSettingsToolStripMenuItem.Name = "allSettingsToolStripMenuItem";
            this.allSettingsToolStripMenuItem.Click += new System.EventHandler(this.allSettingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.какПользоватьсяToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // какПользоватьсяToolStripMenuItem
            // 
            resources.ApplyResources(this.какПользоватьсяToolStripMenuItem, "какПользоватьсяToolStripMenuItem");
            this.какПользоватьсяToolStripMenuItem.Name = "какПользоватьсяToolStripMenuItem";
            this.какПользоватьсяToolStripMenuItem.Click += new System.EventHandler(this.какПользоватьсяToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            resources.ApplyResources(this.оПрограммеToolStripMenuItem, "оПрограммеToolStripMenuItem");
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // saveAsXMLDialog
            // 
            this.saveAsXMLDialog.DefaultExt = "*.xml";
            resources.ApplyResources(this.saveAsXMLDialog, "saveAsXMLDialog");
            this.saveAsXMLDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveAsXMLDialog_FileOk);
            // 
            // saveAsCSVDialog
            // 
            this.saveAsCSVDialog.DefaultExt = "*.CSV";
            resources.ApplyResources(this.saveAsCSVDialog, "saveAsCSVDialog");
            this.saveAsCSVDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveAsCSVDialog_FileOk);
            // 
            // openXMLDialog
            // 
            this.openXMLDialog.DefaultExt = "*.xml";
            resources.ApplyResources(this.openXMLDialog, "openXMLDialog");
            this.openXMLDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openXMLDialog_FileOk);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllValues)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.DataSet DataSetValues;
        private System.Data.DataTable AllValues;
        private System.Data.DataColumn XValue;
        private System.Data.DataColumn YValue;
        private System.Data.DataColumn ZValue;
        private System.Data.DataColumn Numb;
        private System.Data.DataColumn TimeValue;
        private System.IO.Ports.SerialPort comPort;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem какПользоватьсяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьКакXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьИзXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem экспортВCSVToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveAsXMLDialog;
        private System.Windows.Forms.SaveFileDialog saveAsCSVDialog;
        private System.Windows.Forms.OpenFileDialog openXMLDialog;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Data.DataColumn dataColumn1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allSettingsToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartX;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartY;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartZ;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.MaskedTextBox timerTextBox;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
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
    }
}

