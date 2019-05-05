namespace TappingData_demo
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea9 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend9 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.label1 = new System.Windows.Forms.Label();
            this.IPath = new System.Windows.Forms.TextBox();
            this.ReadCSV = new System.Windows.Forms.Button();
            this.IBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.calculate = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TappingData = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.N1 = new System.Windows.Forms.Label();
            this.N2 = new System.Windows.Forms.Label();
            this.N3 = new System.Windows.Forms.Label();
            this.N4 = new System.Windows.Forms.Label();
            this.N5 = new System.Windows.Forms.Label();
            this.N6 = new System.Windows.Forms.Label();
            this.N7 = new System.Windows.Forms.Label();
            this.N8 = new System.Windows.Forms.Label();
            this.N9 = new System.Windows.Forms.Label();
            this.N10 = new System.Windows.Forms.Label();
            this.N11 = new System.Windows.Forms.Label();
            this.N12 = new System.Windows.Forms.Label();
            this.N13 = new System.Windows.Forms.Label();
            this.N14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.IDs = new System.Windows.Forms.TextBox();
            this.grade = new System.Windows.Forms.TextBox();
            this.tapper = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.TappingData.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "輸入檔案：";
            // 
            // IPath
            // 
            this.IPath.Location = new System.Drawing.Point(83, 6);
            this.IPath.Name = "IPath";
            this.IPath.Size = new System.Drawing.Size(680, 22);
            this.IPath.TabIndex = 8;
            // 
            // ReadCSV
            // 
            this.ReadCSV.Location = new System.Drawing.Point(848, 5);
            this.ReadCSV.Name = "ReadCSV";
            this.ReadCSV.Size = new System.Drawing.Size(75, 23);
            this.ReadCSV.TabIndex = 11;
            this.ReadCSV.Text = "讀取";
            this.ReadCSV.UseVisualStyleBackColor = true;
            this.ReadCSV.Click += new System.EventHandler(this.ReadCSV_Click);
            // 
            // IBrowse
            // 
            this.IBrowse.Location = new System.Drawing.Point(768, 5);
            this.IBrowse.Name = "IBrowse";
            this.IBrowse.Size = new System.Drawing.Size(75, 23);
            this.IBrowse.TabIndex = 10;
            this.IBrowse.Text = "瀏覽";
            this.IBrowse.UseVisualStyleBackColor = true;
            this.IBrowse.Click += new System.EventHandler(this.IBrowse_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(327, 538);
            this.dataGridView1.TabIndex = 12;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(353, 162);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(155, 63);
            this.calculate.TabIndex = 13;
            this.calculate.Text = "計算14點";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // chart1
            // 
            chartArea9.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea9);
            legend9.Name = "Legend1";
            this.chart1.Legends.Add(legend9);
            this.chart1.Location = new System.Drawing.Point(527, 66);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(548, 267);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea10.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea10);
            legend10.Name = "Legend1";
            this.chart2.Legends.Add(legend10);
            this.chart2.Location = new System.Drawing.Point(527, 339);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(548, 267);
            this.chart2.TabIndex = 15;
            this.chart2.Text = "chart2";
            // 
            // TappingData
            // 
            this.TappingData.ColumnCount = 2;
            this.TappingData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TappingData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TappingData.Controls.Add(this.label3, 1, 0);
            this.TappingData.Controls.Add(this.label4, 0, 1);
            this.TappingData.Controls.Add(this.label5, 0, 2);
            this.TappingData.Controls.Add(this.label6, 0, 3);
            this.TappingData.Controls.Add(this.label7, 0, 4);
            this.TappingData.Controls.Add(this.label8, 0, 5);
            this.TappingData.Controls.Add(this.label9, 0, 6);
            this.TappingData.Controls.Add(this.label10, 0, 7);
            this.TappingData.Controls.Add(this.label11, 0, 8);
            this.TappingData.Controls.Add(this.label12, 0, 9);
            this.TappingData.Controls.Add(this.label13, 0, 10);
            this.TappingData.Controls.Add(this.label14, 0, 11);
            this.TappingData.Controls.Add(this.label15, 0, 12);
            this.TappingData.Controls.Add(this.label16, 0, 13);
            this.TappingData.Controls.Add(this.label17, 0, 14);
            this.TappingData.Controls.Add(this.N1, 1, 1);
            this.TappingData.Controls.Add(this.N2, 1, 2);
            this.TappingData.Controls.Add(this.N3, 1, 3);
            this.TappingData.Controls.Add(this.N4, 1, 4);
            this.TappingData.Controls.Add(this.N5, 1, 5);
            this.TappingData.Controls.Add(this.N6, 1, 6);
            this.TappingData.Controls.Add(this.N7, 1, 7);
            this.TappingData.Controls.Add(this.N8, 1, 8);
            this.TappingData.Controls.Add(this.N9, 1, 9);
            this.TappingData.Controls.Add(this.N10, 1, 10);
            this.TappingData.Controls.Add(this.N11, 1, 11);
            this.TappingData.Controls.Add(this.N12, 1, 12);
            this.TappingData.Controls.Add(this.N13, 1, 13);
            this.TappingData.Controls.Add(this.N14, 1, 14);
            this.TappingData.Controls.Add(this.label2, 0, 0);
            this.TappingData.Location = new System.Drawing.Point(348, 241);
            this.TappingData.Name = "TappingData";
            this.TappingData.RowCount = 15;
            this.TappingData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9F));
            this.TappingData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.5F));
            this.TappingData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.5F));
            this.TappingData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.5F));
            this.TappingData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.5F));
            this.TappingData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.5F));
            this.TappingData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.5F));
            this.TappingData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.5F));
            this.TappingData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.5F));
            this.TappingData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.5F));
            this.TappingData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.5F));
            this.TappingData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.5F));
            this.TappingData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.5F));
            this.TappingData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.5F));
            this.TappingData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.5F));
            this.TappingData.Size = new System.Drawing.Size(173, 302);
            this.TappingData.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "值";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "N1";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "N2";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "N3";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "N4";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "N5";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 122);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 19);
            this.label9.TabIndex = 7;
            this.label9.Text = "N6";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 19);
            this.label10.TabIndex = 8;
            this.label10.Text = "N7";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 19);
            this.label11.TabIndex = 9;
            this.label11.Text = "N8";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 19);
            this.label12.TabIndex = 10;
            this.label12.Text = "N9";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 19);
            this.label13.TabIndex = 11;
            this.label13.Text = "N10";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 217);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 19);
            this.label14.TabIndex = 12;
            this.label14.Text = "N11";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 236);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 19);
            this.label15.TabIndex = 13;
            this.label15.Text = "N12";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 255);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 19);
            this.label16.TabIndex = 14;
            this.label16.Text = "N13";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 274);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 28);
            this.label17.TabIndex = 15;
            this.label17.Text = "N14";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // N1
            // 
            this.N1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.N1.AutoSize = true;
            this.N1.Location = new System.Drawing.Point(54, 27);
            this.N1.Name = "N1";
            this.N1.Size = new System.Drawing.Size(116, 19);
            this.N1.TabIndex = 16;
            this.N1.Text = "-----";
            this.N1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // N2
            // 
            this.N2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.N2.AutoSize = true;
            this.N2.Location = new System.Drawing.Point(54, 46);
            this.N2.Name = "N2";
            this.N2.Size = new System.Drawing.Size(116, 19);
            this.N2.TabIndex = 17;
            this.N2.Text = "-----";
            this.N2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // N3
            // 
            this.N3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.N3.AutoSize = true;
            this.N3.Location = new System.Drawing.Point(54, 65);
            this.N3.Name = "N3";
            this.N3.Size = new System.Drawing.Size(116, 19);
            this.N3.TabIndex = 18;
            this.N3.Text = "-----";
            this.N3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // N4
            // 
            this.N4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.N4.AutoSize = true;
            this.N4.Location = new System.Drawing.Point(54, 84);
            this.N4.Name = "N4";
            this.N4.Size = new System.Drawing.Size(116, 19);
            this.N4.TabIndex = 19;
            this.N4.Text = "-----";
            this.N4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // N5
            // 
            this.N5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.N5.AutoSize = true;
            this.N5.Location = new System.Drawing.Point(54, 103);
            this.N5.Name = "N5";
            this.N5.Size = new System.Drawing.Size(116, 19);
            this.N5.TabIndex = 20;
            this.N5.Text = "-----";
            this.N5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // N6
            // 
            this.N6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.N6.AutoSize = true;
            this.N6.Location = new System.Drawing.Point(54, 122);
            this.N6.Name = "N6";
            this.N6.Size = new System.Drawing.Size(116, 19);
            this.N6.TabIndex = 21;
            this.N6.Text = "-----";
            this.N6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // N7
            // 
            this.N7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.N7.AutoSize = true;
            this.N7.Location = new System.Drawing.Point(54, 141);
            this.N7.Name = "N7";
            this.N7.Size = new System.Drawing.Size(116, 19);
            this.N7.TabIndex = 22;
            this.N7.Text = "-----";
            this.N7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // N8
            // 
            this.N8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.N8.AutoSize = true;
            this.N8.Location = new System.Drawing.Point(54, 160);
            this.N8.Name = "N8";
            this.N8.Size = new System.Drawing.Size(116, 19);
            this.N8.TabIndex = 23;
            this.N8.Text = "-----";
            this.N8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // N9
            // 
            this.N9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.N9.AutoSize = true;
            this.N9.Location = new System.Drawing.Point(54, 179);
            this.N9.Name = "N9";
            this.N9.Size = new System.Drawing.Size(116, 19);
            this.N9.TabIndex = 24;
            this.N9.Text = "-----";
            this.N9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // N10
            // 
            this.N10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.N10.AutoSize = true;
            this.N10.Location = new System.Drawing.Point(54, 198);
            this.N10.Name = "N10";
            this.N10.Size = new System.Drawing.Size(116, 19);
            this.N10.TabIndex = 25;
            this.N10.Text = "-----";
            this.N10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // N11
            // 
            this.N11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.N11.AutoSize = true;
            this.N11.Location = new System.Drawing.Point(54, 217);
            this.N11.Name = "N11";
            this.N11.Size = new System.Drawing.Size(116, 19);
            this.N11.TabIndex = 26;
            this.N11.Text = "-----";
            this.N11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // N12
            // 
            this.N12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.N12.AutoSize = true;
            this.N12.Location = new System.Drawing.Point(54, 236);
            this.N12.Name = "N12";
            this.N12.Size = new System.Drawing.Size(116, 19);
            this.N12.TabIndex = 27;
            this.N12.Text = "-----";
            this.N12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // N13
            // 
            this.N13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.N13.AutoSize = true;
            this.N13.Location = new System.Drawing.Point(54, 255);
            this.N13.Name = "N13";
            this.N13.Size = new System.Drawing.Size(116, 19);
            this.N13.TabIndex = 28;
            this.N13.Text = "-----";
            this.N13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // N14
            // 
            this.N14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.N14.AutoSize = true;
            this.N14.Location = new System.Drawing.Point(54, 274);
            this.N14.Name = "N14";
            this.N14.Size = new System.Drawing.Size(116, 28);
            this.N14.TabIndex = 29;
            this.N14.Text = "-----";
            this.N14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "項次";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(379, 562);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(39, 12);
            this.label18.TabIndex = 17;
            this.label18.Text = "label18";
            // 
            // IDs
            // 
            this.IDs.Location = new System.Drawing.Point(13, 34);
            this.IDs.Name = "IDs";
            this.IDs.Size = new System.Drawing.Size(144, 22);
            this.IDs.TabIndex = 18;
            this.IDs.Text = "IDs";
            // 
            // grade
            // 
            this.grade.Location = new System.Drawing.Point(196, 34);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(64, 22);
            this.grade.TabIndex = 19;
            this.grade.Text = "----";
            // 
            // tapper
            // 
            this.tapper.Location = new System.Drawing.Point(305, 34);
            this.tapper.Name = "tapper";
            this.tapper.Size = new System.Drawing.Size(64, 22);
            this.tapper.TabIndex = 20;
            this.tapper.Text = "----";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 616);
            this.Controls.Add(this.tapper);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.IDs);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.TappingData);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IPath);
            this.Controls.Add(this.ReadCSV);
            this.Controls.Add(this.IBrowse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.TappingData.ResumeLayout(false);
            this.TappingData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IPath;
        private System.Windows.Forms.Button ReadCSV;
        private System.Windows.Forms.Button IBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.TableLayoutPanel TappingData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label N1;
        private System.Windows.Forms.Label N2;
        private System.Windows.Forms.Label N3;
        private System.Windows.Forms.Label N4;
        private System.Windows.Forms.Label N5;
        private System.Windows.Forms.Label N6;
        private System.Windows.Forms.Label N7;
        private System.Windows.Forms.Label N8;
        private System.Windows.Forms.Label N9;
        private System.Windows.Forms.Label N10;
        private System.Windows.Forms.Label N11;
        private System.Windows.Forms.Label N12;
        private System.Windows.Forms.Label N13;
        private System.Windows.Forms.Label N14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox IDs;
        private System.Windows.Forms.TextBox grade;
        private System.Windows.Forms.TextBox tapper;
    }
}

