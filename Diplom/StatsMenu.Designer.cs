namespace Diplom
{
    partial class StatsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatsMenu));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AccessLevelLabel = new System.Windows.Forms.Label();
            this.VirtusLabel = new System.Windows.Forms.Label();
            this.OrderHistoryButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.StatsCombobox = new System.Windows.Forms.ComboBox();
            this.TableStatLabel = new System.Windows.Forms.Label();
            this.DGVForChart = new System.Windows.Forms.DataGridView();
            this.ShowChartButton = new System.Windows.Forms.Button();
            this.DGVForChart2 = new System.Windows.Forms.DataGridView();
            this.ChartType = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.DTPickerBetween1 = new System.Windows.Forms.DateTimePicker();
            this.DTPickerBetween2 = new System.Windows.Forms.DateTimePicker();
            this.Datelabeltip = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVForChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVForChart2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.AccessLevelLabel);
            this.panel1.Controls.Add(this.VirtusLabel);
            this.panel1.Controls.Add(this.OrderHistoryButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 57);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(126, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // AccessLevelLabel
            // 
            this.AccessLevelLabel.AutoSize = true;
            this.AccessLevelLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AccessLevelLabel.Font = new System.Drawing.Font("Sylfaen", 15F);
            this.AccessLevelLabel.Location = new System.Drawing.Point(558, 14);
            this.AccessLevelLabel.Name = "AccessLevelLabel";
            this.AccessLevelLabel.Size = new System.Drawing.Size(116, 26);
            this.AccessLevelLabel.TabIndex = 3;
            this.AccessLevelLabel.Text = "Должность:";
            this.AccessLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VirtusLabel
            // 
            this.VirtusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VirtusLabel.AutoSize = true;
            this.VirtusLabel.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VirtusLabel.Location = new System.Drawing.Point(3, 8);
            this.VirtusLabel.Name = "VirtusLabel";
            this.VirtusLabel.Size = new System.Drawing.Size(130, 35);
            this.VirtusLabel.TabIndex = 1;
            this.VirtusLabel.Text = "Virtus ИС";
            // 
            // OrderHistoryButton
            // 
            this.OrderHistoryButton.AutoSize = true;
            this.OrderHistoryButton.BackColor = System.Drawing.Color.White;
            this.OrderHistoryButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.OrderHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderHistoryButton.Font = new System.Drawing.Font("Sylfaen", 12F);
            this.OrderHistoryButton.Location = new System.Drawing.Point(324, 10);
            this.OrderHistoryButton.Name = "OrderHistoryButton";
            this.OrderHistoryButton.Size = new System.Drawing.Size(137, 34);
            this.OrderHistoryButton.TabIndex = 21;
            this.OrderHistoryButton.Text = "История заказов";
            this.OrderHistoryButton.UseVisualStyleBackColor = false;
            this.OrderHistoryButton.Click += new System.EventHandler(this.OrderHistoryButton_Click);
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(15, 97);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series3.ChartArea = "ChartArea1";
            series3.IsValueShownAsLabel = true;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Ваши данные";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(334, 330);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "StatsChart";
            // 
            // StatsCombobox
            // 
            this.StatsCombobox.FormattingEnabled = true;
            this.StatsCombobox.Items.AddRange(new object[] {
            "Состояние заказов",
            "Товарам в П.Д.",
            "Заказы за промежуток времени",
            "Выручка по типу товара",
            "Количество заказов по типу"});
            this.StatsCombobox.Location = new System.Drawing.Point(156, 70);
            this.StatsCombobox.Name = "StatsCombobox";
            this.StatsCombobox.Size = new System.Drawing.Size(193, 21);
            this.StatsCombobox.TabIndex = 7;
            this.StatsCombobox.SelectedIndexChanged += new System.EventHandler(this.StatsCombobox_SelectedIndexChanged);
            // 
            // TableStatLabel
            // 
            this.TableStatLabel.AutoSize = true;
            this.TableStatLabel.BackColor = System.Drawing.Color.Transparent;
            this.TableStatLabel.Font = new System.Drawing.Font("Sylfaen", 15F);
            this.TableStatLabel.Location = new System.Drawing.Point(12, 65);
            this.TableStatLabel.Name = "TableStatLabel";
            this.TableStatLabel.Size = new System.Drawing.Size(147, 26);
            this.TableStatLabel.TabIndex = 3;
            this.TableStatLabel.Text = "Статистика по:";
            this.TableStatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DGVForChart
            // 
            this.DGVForChart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVForChart.Location = new System.Drawing.Point(504, 63);
            this.DGVForChart.Name = "DGVForChart";
            this.DGVForChart.Size = new System.Drawing.Size(310, 169);
            this.DGVForChart.TabIndex = 8;
            // 
            // ShowChartButton
            // 
            this.ShowChartButton.AutoSize = true;
            this.ShowChartButton.BackColor = System.Drawing.Color.White;
            this.ShowChartButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.ShowChartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowChartButton.Font = new System.Drawing.Font("Sylfaen", 10F);
            this.ShowChartButton.Location = new System.Drawing.Point(357, 65);
            this.ShowChartButton.Name = "ShowChartButton";
            this.ShowChartButton.Size = new System.Drawing.Size(113, 30);
            this.ShowChartButton.TabIndex = 21;
            this.ShowChartButton.Text = "Применить";
            this.ShowChartButton.UseVisualStyleBackColor = false;
            this.ShowChartButton.Click += new System.EventHandler(this.ShowChartButton_Click);
            // 
            // DGVForChart2
            // 
            this.DGVForChart2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVForChart2.Location = new System.Drawing.Point(504, 238);
            this.DGVForChart2.Name = "DGVForChart2";
            this.DGVForChart2.Size = new System.Drawing.Size(310, 189);
            this.DGVForChart2.TabIndex = 22;
            // 
            // ChartType
            // 
            this.ChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ChartType.FormattingEnabled = true;
            this.ChartType.Items.AddRange(new object[] {
            "Горизонтальная Гистограмма",
            "Вертикальная Гистограмма",
            "Круговая",
            "График"});
            this.ChartType.Location = new System.Drawing.Point(357, 101);
            this.ChartType.Name = "ChartType";
            this.ChartType.Size = new System.Drawing.Size(113, 21);
            this.ChartType.TabIndex = 7;
            this.ChartType.SelectedIndexChanged += new System.EventHandler(this.ChartType_SelectedIndexChanged);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Sylfaen", 11F);
            this.Label1.Location = new System.Drawing.Point(357, 125);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(112, 19);
            this.Label1.TabIndex = 23;
            this.Label1.Text = "Вид диаграммы";
            // 
            // DTPickerBetween1
            // 
            this.DTPickerBetween1.Location = new System.Drawing.Point(357, 175);
            this.DTPickerBetween1.Name = "DTPickerBetween1";
            this.DTPickerBetween1.Size = new System.Drawing.Size(113, 20);
            this.DTPickerBetween1.TabIndex = 24;
            this.DTPickerBetween1.Visible = false;
            this.DTPickerBetween1.ValueChanged += new System.EventHandler(this.DTPickerBetween1_ValueChanged);
            // 
            // DTPickerBetween2
            // 
            this.DTPickerBetween2.Location = new System.Drawing.Point(357, 201);
            this.DTPickerBetween2.Name = "DTPickerBetween2";
            this.DTPickerBetween2.Size = new System.Drawing.Size(113, 20);
            this.DTPickerBetween2.TabIndex = 24;
            this.DTPickerBetween2.Visible = false;
            this.DTPickerBetween2.ValueChanged += new System.EventHandler(this.DTPickerBetween1_ValueChanged);
            // 
            // Datelabeltip
            // 
            this.Datelabeltip.AutoSize = true;
            this.Datelabeltip.Font = new System.Drawing.Font("Sylfaen", 10.75F);
            this.Datelabeltip.Location = new System.Drawing.Point(363, 153);
            this.Datelabeltip.Name = "Datelabeltip";
            this.Datelabeltip.Size = new System.Drawing.Size(97, 19);
            this.Datelabeltip.TabIndex = 23;
            this.Datelabeltip.Text = "Даты заказов";
            this.Datelabeltip.Visible = false;
            // 
            // StatsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(474, 455);
            this.Controls.Add(this.DTPickerBetween2);
            this.Controls.Add(this.DTPickerBetween1);
            this.Controls.Add(this.Datelabeltip);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.DGVForChart2);
            this.Controls.Add(this.ShowChartButton);
            this.Controls.Add(this.DGVForChart);
            this.Controls.Add(this.ChartType);
            this.Controls.Add(this.StatsCombobox);
            this.Controls.Add(this.TableStatLabel);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StatsMenu";
            this.Text = "StatsMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVForChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVForChart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label AccessLevelLabel;
        private System.Windows.Forms.Label VirtusLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox StatsCombobox;
        public System.Windows.Forms.Label TableStatLabel;
        private System.Windows.Forms.DataGridView DGVForChart;
        private System.Windows.Forms.Button ShowChartButton;
        private System.Windows.Forms.DataGridView DGVForChart2;
        private System.Windows.Forms.ComboBox ChartType;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.DateTimePicker DTPickerBetween1;
        private System.Windows.Forms.DateTimePicker DTPickerBetween2;
        private System.Windows.Forms.Label Datelabeltip;
        private System.Windows.Forms.Button OrderHistoryButton;
    }
}