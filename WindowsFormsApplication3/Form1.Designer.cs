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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
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
            this.chartModX = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartModY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartModZ = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.DataSetValues = new System.Data.DataSet();
            this.AllValues = new System.Data.DataTable();
            this.XValue = new System.Data.DataColumn();
            this.YValue = new System.Data.DataColumn();
            this.ZValue = new System.Data.DataColumn();
            this.Numb = new System.Data.DataColumn();
            this.TimeValue = new System.Data.DataColumn();
            this.chartY = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartZ = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartX = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.udpRadio = new System.Windows.Forms.RadioButton();
            this.serialRadio = new System.Windows.Forms.RadioButton();
            this.comBox = new System.Windows.Forms.ComboBox();
            this.comPort = new System.IO.Ports.SerialPort(this.components);
            this.boudRateBox = new System.Windows.Forms.ComboBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.portBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dxMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.dyMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.dzMaskedBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.flexBox = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.timerTextBox = new System.Windows.Forms.MaskedTextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.какПользоватьсяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            startNumber = new System.Data.DataColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartModX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartModY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartModZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllValues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartX)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startNumber
            // 
            startNumber.ColumnName = "startNumber";
            startNumber.DataType = typeof(short);
            // 
            // startButton
            // 
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.startButton.Location = new System.Drawing.Point(306, 25);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Старт";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stopButton.Location = new System.Drawing.Point(306, 64);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Стоп";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(306, 177);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Закрыть окно";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
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
            this.MaxFlexZ});
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGrid.Location = new System.Drawing.Point(3, 23);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.Size = new System.Drawing.Size(880, 248);
            this.dataGrid.TabIndex = 3;
            this.dataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Time
            // 
            this.Time.FillWeight = 150F;
            this.Time.HeaderText = "Время";
            this.Time.Name = "Time";
            this.Time.Width = 110;
            // 
            // Serial
            // 
            this.Serial.HeaderText = "Имя графика";
            this.Serial.Name = "Serial";
            this.Serial.Width = 60;
            // 
            // Number
            // 
            this.Number.HeaderText = "Кол-во измеренных значений";
            this.Number.Name = "Number";
            this.Number.Width = 75;
            // 
            // XModMax
            // 
            this.XModMax.HeaderText = "Размах по X";
            this.XModMax.Name = "XModMax";
            this.XModMax.Width = 70;
            // 
            // YModMax
            // 
            this.YModMax.HeaderText = "Размах по Y";
            this.YModMax.Name = "YModMax";
            this.YModMax.Width = 70;
            // 
            // ZModMax
            // 
            this.ZModMax.HeaderText = "Размах по Z";
            this.ZModMax.Name = "ZModMax";
            this.ZModMax.Width = 70;
            // 
            // MaxFlexX
            // 
            this.MaxFlexX.HeaderText = "Размах по скользящему среднему X";
            this.MaxFlexX.Name = "MaxFlexX";
            // 
            // MaxFlexY
            // 
            this.MaxFlexY.HeaderText = "Размах по скользящему среднему Y";
            this.MaxFlexY.Name = "MaxFlexY";
            // 
            // MaxFlexZ
            // 
            this.MaxFlexZ.HeaderText = "Размах по скользящему среднему Z";
            this.MaxFlexZ.Name = "MaxFlexZ";
            // 
            // chartModX
            // 
            this.chartModX.BorderlineColor = System.Drawing.Color.Gray;
            this.chartModX.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.Name = "ChartArea1";
            this.chartModX.ChartAreas.Add(chartArea1);
            this.chartModX.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartModX.Legends.Add(legend1);
            this.chartModX.Location = new System.Drawing.Point(889, 295);
            this.chartModX.Name = "chartModX";
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartModX.Series.Add(series1);
            this.chartModX.Size = new System.Drawing.Size(432, 123);
            this.chartModX.TabIndex = 5;
            this.chartModX.Text = "X";
            title1.Name = "Title1";
            title1.Text = "Динамика размаха по X";
            this.chartModX.Titles.Add(title1);
            this.chartModX.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chartModY
            // 
            this.chartModY.BorderlineColor = System.Drawing.Color.Gray;
            this.chartModY.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.chartModY.ChartAreas.Add(chartArea2);
            this.chartModY.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartModY.Legends.Add(legend2);
            this.chartModY.Location = new System.Drawing.Point(889, 440);
            this.chartModY.Name = "chartModY";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartModY.Series.Add(series2);
            this.chartModY.Size = new System.Drawing.Size(432, 113);
            this.chartModY.TabIndex = 6;
            this.chartModY.Text = "Y";
            title2.Name = "Title1";
            title2.Text = "Динамика размаха по Y";
            this.chartModY.Titles.Add(title2);
            this.chartModY.Click += new System.EventHandler(this.chart2_Click);
            // 
            // chartModZ
            // 
            this.chartModZ.BorderlineColor = System.Drawing.Color.Gray;
            this.chartModZ.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea3.Name = "ChartArea1";
            this.chartModZ.ChartAreas.Add(chartArea3);
            this.chartModZ.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartModZ.Legends.Add(legend3);
            this.chartModZ.Location = new System.Drawing.Point(889, 578);
            this.chartModZ.Name = "chartModZ";
            series3.ChartArea = "ChartArea1";
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartModZ.Series.Add(series3);
            this.chartModZ.Size = new System.Drawing.Size(432, 116);
            this.chartModZ.TabIndex = 7;
            this.chartModZ.Text = "Z";
            title3.Name = "Title1";
            title3.Text = "Динамика размаха по Z";
            this.chartModZ.Titles.Add(title3);
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
            startNumber});
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
            // chartY
            // 
            this.chartY.BorderlineColor = System.Drawing.Color.Gray;
            this.chartY.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea4.BackColor = System.Drawing.Color.Black;
            chartArea4.BackSecondaryColor = System.Drawing.Color.Black;
            chartArea4.Name = "ChartArea1";
            this.chartY.ChartAreas.Add(chartArea4);
            this.chartY.DataSource = this.DataSetValues;
            this.chartY.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.chartY.Legends.Add(legend4);
            this.chartY.Location = new System.Drawing.Point(3, 440);
            this.chartY.Name = "chartY";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.Red;
            series4.Legend = "Legend1";
            series4.LegendText = "Y Max Value";
            series4.MarkerBorderColor = System.Drawing.Color.Red;
            series4.MarkerColor = System.Drawing.Color.Red;
            series4.Name = "SeriesYMax";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Red;
            series5.Legend = "Legend1";
            series5.LegendText = "Y Min Value";
            series5.Name = "SeriesYMin";
            series6.BorderWidth = 2;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Fuchsia;
            series6.Legend = "Legend1";
            series6.LegendText = "Mid Y";
            series6.Name = "SeriesYMid";
            this.chartY.Series.Add(series4);
            this.chartY.Series.Add(series5);
            this.chartY.Series.Add(series6);
            this.chartY.Size = new System.Drawing.Size(880, 113);
            this.chartY.TabIndex = 9;
            this.chartY.Text = "chart5";
            // 
            // chartZ
            // 
            this.chartZ.BorderlineColor = System.Drawing.Color.Gray;
            this.chartZ.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea5.BackColor = System.Drawing.Color.Black;
            chartArea5.Name = "ChartArea1";
            this.chartZ.ChartAreas.Add(chartArea5);
            this.chartZ.DataSource = this.DataSetValues;
            this.chartZ.Dock = System.Windows.Forms.DockStyle.Fill;
            legend5.Name = "Legend1";
            this.chartZ.Legends.Add(legend5);
            this.chartZ.Location = new System.Drawing.Point(3, 578);
            this.chartZ.Name = "chartZ";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.Red;
            series7.Legend = "Legend1";
            series7.LegendText = "Z Max Value";
            series7.MarkerBorderColor = System.Drawing.Color.Red;
            series7.MarkerColor = System.Drawing.Color.Red;
            series7.Name = "SeriesZMax";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.Red;
            series8.Legend = "Legend1";
            series8.LegendText = "Z Min Value";
            series8.Name = "SeriesZMin";
            series9.BorderWidth = 2;
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Color = System.Drawing.Color.Fuchsia;
            series9.Legend = "Legend1";
            series9.LegendText = "Mid Z";
            series9.Name = "SeriesZMid";
            this.chartZ.Series.Add(series7);
            this.chartZ.Series.Add(series8);
            this.chartZ.Series.Add(series9);
            this.chartZ.Size = new System.Drawing.Size(880, 116);
            this.chartZ.TabIndex = 10;
            this.chartZ.Text = "chart6";
            // 
            // chartX
            // 
            this.chartX.BorderlineColor = System.Drawing.Color.DimGray;
            this.chartX.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea6.BackColor = System.Drawing.Color.Black;
            chartArea6.Name = "ChartArea1";
            this.chartX.ChartAreas.Add(chartArea6);
            this.chartX.DataSource = this.DataSetValues;
            this.chartX.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Name = "Legend1";
            this.chartX.Legends.Add(legend6);
            this.chartX.Location = new System.Drawing.Point(3, 295);
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
            this.chartX.Size = new System.Drawing.Size(880, 123);
            this.chartX.TabIndex = 12;
            this.chartX.Text = "chartX";
            this.chartX.AxisViewChanged += new System.EventHandler<System.Windows.Forms.DataVisualization.Charting.ViewEventArgs>(this.chartX_AxisViewChanged);
            // 
            // udpRadio
            // 
            this.udpRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.udpRadio.AutoSize = true;
            this.udpRadio.Checked = true;
            this.udpRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.udpRadio.Location = new System.Drawing.Point(39, 27);
            this.udpRadio.Name = "udpRadio";
            this.udpRadio.Size = new System.Drawing.Size(55, 21);
            this.udpRadio.TabIndex = 13;
            this.udpRadio.TabStop = true;
            this.udpRadio.Text = "UDP";
            this.udpRadio.UseVisualStyleBackColor = true;
            this.udpRadio.CheckedChanged += new System.EventHandler(this.udpRadio_CheckedChanged);
            // 
            // serialRadio
            // 
            this.serialRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.serialRadio.AutoSize = true;
            this.serialRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.serialRadio.Location = new System.Drawing.Point(39, 59);
            this.serialRadio.Name = "serialRadio";
            this.serialRadio.Size = new System.Drawing.Size(62, 21);
            this.serialRadio.TabIndex = 14;
            this.serialRadio.Text = "Serial";
            this.serialRadio.UseVisualStyleBackColor = true;
            this.serialRadio.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // comBox
            // 
            this.comBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comBox.FormattingEnabled = true;
            this.comBox.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7"});
            this.comBox.Location = new System.Drawing.Point(213, 23);
            this.comBox.Name = "comBox";
            this.comBox.Size = new System.Drawing.Size(58, 21);
            this.comBox.TabIndex = 15;
            // 
            // boudRateBox
            // 
            this.boudRateBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boudRateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boudRateBox.FormattingEnabled = true;
            this.boudRateBox.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400"});
            this.boudRateBox.Location = new System.Drawing.Point(213, 59);
            this.boudRateBox.Name = "boudRateBox";
            this.boudRateBox.Size = new System.Drawing.Size(58, 21);
            this.boudRateBox.TabIndex = 16;
            // 
            // clearButton
            // 
            this.clearButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearButton.Location = new System.Drawing.Point(286, 111);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(109, 45);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "Очистить значения";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // portBox
            // 
            this.portBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.portBox.Location = new System.Drawing.Point(213, 24);
            this.portBox.Mask = "00000";
            this.portBox.Name = "portBox";
            this.portBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.portBox.Size = new System.Drawing.Size(58, 20);
            this.portBox.TabIndex = 19;
            this.portBox.Text = "5555";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(128, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Port:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label3.Location = new System.Drawing.Point(128, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Boud  Rate";
            // 
            // dxMaskedBox
            // 
            this.dxMaskedBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dxMaskedBox.Location = new System.Drawing.Point(213, 99);
            this.dxMaskedBox.Mask = "0.00";
            this.dxMaskedBox.Name = "dxMaskedBox";
            this.dxMaskedBox.Size = new System.Drawing.Size(58, 20);
            this.dxMaskedBox.TabIndex = 23;
            this.dxMaskedBox.Text = "012";
            // 
            // dyMaskedBox
            // 
            this.dyMaskedBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dyMaskedBox.Location = new System.Drawing.Point(213, 124);
            this.dyMaskedBox.Mask = "0.00";
            this.dyMaskedBox.Name = "dyMaskedBox";
            this.dyMaskedBox.Size = new System.Drawing.Size(58, 20);
            this.dyMaskedBox.TabIndex = 24;
            this.dyMaskedBox.Text = "006";
            // 
            // dzMaskedBox
            // 
            this.dzMaskedBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dzMaskedBox.Location = new System.Drawing.Point(213, 150);
            this.dzMaskedBox.Mask = "0.00";
            this.dzMaskedBox.Name = "dzMaskedBox";
            this.dzMaskedBox.Size = new System.Drawing.Size(58, 20);
            this.dzMaskedBox.TabIndex = 25;
            this.dzMaskedBox.Text = "006";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(36, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Порог для X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label4.Location = new System.Drawing.Point(36, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 27;
            this.label4.Text = "Порог для Y";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(36, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 28;
            this.label5.Text = "Порог для Z";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Таблица значений акселерометра";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Значения ускорений по оси  X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 421);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Значения ускорений по оси  Y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 556);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Значения ускорений по оси  Z";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(889, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Размах  по оси X";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(889, 421);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "Размах  по оси Y";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(889, 556);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 13);
            this.label12.TabIndex = 35;
            this.label12.Text = "Размах  по оси Z";
            // 
            // flexBox
            // 
            this.flexBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flexBox.Location = new System.Drawing.Point(213, 180);
            this.flexBox.Mask = "00";
            this.flexBox.Name = "flexBox";
            this.flexBox.Size = new System.Drawing.Size(58, 20);
            this.flexBox.TabIndex = 36;
            this.flexBox.Text = "03";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label13.Location = new System.Drawing.Point(36, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(173, 17);
            this.label13.TabIndex = 37;
            this.label13.Text = "Сглаживающий интервал";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(36, 210);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 17);
            this.label14.TabIndex = 38;
            this.label14.Text = "Таймер (сек.)";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // timerTextBox
            // 
            this.timerTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timerTextBox.Location = new System.Drawing.Point(213, 207);
            this.timerTextBox.Mask = "000";
            this.timerTextBox.Name = "timerTextBox";
            this.timerTextBox.Size = new System.Drawing.Size(58, 20);
            this.timerTextBox.TabIndex = 39;
            this.timerTextBox.Text = "10";
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1324, 24);
            this.menuStrip1.TabIndex = 40;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.какПользоватьсяToolStripMenuItem,
            this.оПрограммеToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpToolStripMenuItem.Text = "Справка";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // какПользоватьсяToolStripMenuItem
            // 
            this.какПользоватьсяToolStripMenuItem.Name = "какПользоватьсяToolStripMenuItem";
            this.какПользоватьсяToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.какПользоватьсяToolStripMenuItem.Text = "Как пользоваться";
            this.какПользоватьсяToolStripMenuItem.Click += new System.EventHandler(this.какПользоватьсяToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.99396F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.00604F));
            this.tableLayoutPanel1.Controls.Add(this.dataGrid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.chartX, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.chartY, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label12, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.chartZ, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.chartModZ, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.chartModY, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.chartModX, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 27);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.38235F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.617647F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 129F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1324, 697);
            this.tableLayoutPanel1.TabIndex = 41;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.closeButton);
            this.groupBox1.Controls.Add(this.startButton);
            this.groupBox1.Controls.Add(this.timerTextBox);
            this.groupBox1.Controls.Add(this.stopButton);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.udpRadio);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.serialRadio);
            this.groupBox1.Controls.Add(this.flexBox);
            this.groupBox1.Controls.Add(this.comBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.boudRateBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.clearButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.portBox);
            this.groupBox1.Controls.Add(this.dzMaskedBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dyMaskedBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dxMaskedBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(889, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 722);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Accel Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartModX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartModY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartModZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllValues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartX)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartModX;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartModY;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartModZ;
        private System.Data.DataSet DataSetValues;
        private System.Data.DataTable AllValues;
        private System.Data.DataColumn XValue;
        private System.Data.DataColumn YValue;
        private System.Data.DataColumn ZValue;
        private System.Data.DataColumn Numb;
        private System.Data.DataColumn TimeValue;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartY;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartZ;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartX;
        private System.Windows.Forms.RadioButton udpRadio;
        private System.Windows.Forms.RadioButton serialRadio;
        private System.Windows.Forms.ComboBox comBox;
        private System.IO.Ports.SerialPort comPort;
        private System.Windows.Forms.ComboBox boudRateBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.MaskedTextBox portBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox dxMaskedBox;
        private System.Windows.Forms.MaskedTextBox dyMaskedBox;
        private System.Windows.Forms.MaskedTextBox dzMaskedBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox flexBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox timerTextBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem какПользоватьсяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Serial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn XModMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn YModMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn ZModMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxFlexX;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxFlexY;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxFlexZ;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

