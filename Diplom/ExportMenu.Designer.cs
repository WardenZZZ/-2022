namespace Diplom
{
    partial class ExportMenu
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExportMenu));
            this.ExportLabel = new System.Windows.Forms.Label();
            this.TableChooseCB = new System.Windows.Forms.ComboBox();
            this.ItemsInOrderLabel = new System.Windows.Forms.Label();
            this.PreviewdataGridView = new System.Windows.Forms.DataGridView();
            this.FilterCheckbox1 = new System.Windows.Forms.CheckBox();
            this.ResetFilters = new System.Windows.Forms.Button();
            this.FilterCheckbox2 = new System.Windows.Forms.CheckBox();
            this.FilterCheckbox3 = new System.Windows.Forms.CheckBox();
            this.FilterCheckbox4 = new System.Windows.Forms.CheckBox();
            this.FilterCheckbox5 = new System.Windows.Forms.CheckBox();
            this.FilterCheckbox6 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exitlabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.VirtusLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.Notelabel = new System.Windows.Forms.Label();
            this.Notelabel2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PreviewdataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ExportLabel
            // 
            this.ExportLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExportLabel.AutoSize = true;
            this.ExportLabel.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExportLabel.Location = new System.Drawing.Point(68, 63);
            this.ExportLabel.Name = "ExportLabel";
            this.ExportLabel.Size = new System.Drawing.Size(304, 35);
            this.ExportLabel.TabIndex = 15;
            this.ExportLabel.Text = "Экспорт данных (Word)";
            this.ExportLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TableChooseCB
            // 
            this.TableChooseCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableChooseCB.FormattingEnabled = true;
            this.TableChooseCB.Items.AddRange(new object[] {
            "База товаров",
            "Заказы",
            "Пункты выдачи"});
            this.TableChooseCB.Location = new System.Drawing.Point(12, 138);
            this.TableChooseCB.Name = "TableChooseCB";
            this.TableChooseCB.Size = new System.Drawing.Size(382, 21);
            this.TableChooseCB.TabIndex = 16;
            this.TableChooseCB.SelectedIndexChanged += new System.EventHandler(this.TableChooseCB_SelectedIndexChanged);
            // 
            // ItemsInOrderLabel
            // 
            this.ItemsInOrderLabel.AutoSize = true;
            this.ItemsInOrderLabel.Font = new System.Drawing.Font("Sylfaen", 14F);
            this.ItemsInOrderLabel.Location = new System.Drawing.Point(3, 108);
            this.ItemsInOrderLabel.Name = "ItemsInOrderLabel";
            this.ItemsInOrderLabel.Size = new System.Drawing.Size(380, 25);
            this.ItemsInOrderLabel.TabIndex = 17;
            this.ItemsInOrderLabel.Text = "Выберите экспортируемую таблицу данных";
            // 
            // PreviewdataGridView
            // 
            this.PreviewdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PreviewdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PreviewdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PreviewdataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.PreviewdataGridView.Location = new System.Drawing.Point(12, 165);
            this.PreviewdataGridView.MultiSelect = false;
            this.PreviewdataGridView.Name = "PreviewdataGridView";
            this.PreviewdataGridView.ReadOnly = true;
            this.PreviewdataGridView.Size = new System.Drawing.Size(382, 158);
            this.PreviewdataGridView.TabIndex = 19;
            // 
            // FilterCheckbox1
            // 
            this.FilterCheckbox1.AutoSize = true;
            this.FilterCheckbox1.Location = new System.Drawing.Point(400, 165);
            this.FilterCheckbox1.Name = "FilterCheckbox1";
            this.FilterCheckbox1.Size = new System.Drawing.Size(32, 17);
            this.FilterCheckbox1.TabIndex = 21;
            this.FilterCheckbox1.Text = "1";
            this.FilterCheckbox1.UseVisualStyleBackColor = true;
            this.FilterCheckbox1.Visible = false;
            this.FilterCheckbox1.CheckedChanged += new System.EventHandler(this.FilterCheckbox1_CheckedChanged);
            // 
            // ResetFilters
            // 
            this.ResetFilters.AutoSize = true;
            this.ResetFilters.BackColor = System.Drawing.Color.White;
            this.ResetFilters.Cursor = System.Windows.Forms.Cursors.Default;
            this.ResetFilters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetFilters.Font = new System.Drawing.Font("Sylfaen", 14F);
            this.ResetFilters.Location = new System.Drawing.Point(185, 348);
            this.ResetFilters.Name = "ResetFilters";
            this.ResetFilters.Size = new System.Drawing.Size(177, 37);
            this.ResetFilters.TabIndex = 20;
            this.ResetFilters.Text = "Очистка фильтров";
            this.ResetFilters.UseVisualStyleBackColor = false;
            this.ResetFilters.Click += new System.EventHandler(this.ResetFilters_Click);
            // 
            // FilterCheckbox2
            // 
            this.FilterCheckbox2.AutoSize = true;
            this.FilterCheckbox2.Location = new System.Drawing.Point(400, 193);
            this.FilterCheckbox2.Name = "FilterCheckbox2";
            this.FilterCheckbox2.Size = new System.Drawing.Size(32, 17);
            this.FilterCheckbox2.TabIndex = 21;
            this.FilterCheckbox2.Text = "1";
            this.FilterCheckbox2.UseVisualStyleBackColor = true;
            this.FilterCheckbox2.Visible = false;
            this.FilterCheckbox2.CheckedChanged += new System.EventHandler(this.FilterCheckbox2_CheckedChanged);
            // 
            // FilterCheckbox3
            // 
            this.FilterCheckbox3.AutoSize = true;
            this.FilterCheckbox3.Location = new System.Drawing.Point(400, 222);
            this.FilterCheckbox3.Name = "FilterCheckbox3";
            this.FilterCheckbox3.Size = new System.Drawing.Size(32, 17);
            this.FilterCheckbox3.TabIndex = 21;
            this.FilterCheckbox3.Text = "1";
            this.FilterCheckbox3.UseVisualStyleBackColor = true;
            this.FilterCheckbox3.Visible = false;
            // 
            // FilterCheckbox4
            // 
            this.FilterCheckbox4.AutoSize = true;
            this.FilterCheckbox4.Location = new System.Drawing.Point(400, 250);
            this.FilterCheckbox4.Name = "FilterCheckbox4";
            this.FilterCheckbox4.Size = new System.Drawing.Size(32, 17);
            this.FilterCheckbox4.TabIndex = 21;
            this.FilterCheckbox4.Text = "1";
            this.FilterCheckbox4.UseVisualStyleBackColor = true;
            this.FilterCheckbox4.Visible = false;
            // 
            // FilterCheckbox5
            // 
            this.FilterCheckbox5.AutoSize = true;
            this.FilterCheckbox5.Location = new System.Drawing.Point(400, 278);
            this.FilterCheckbox5.Name = "FilterCheckbox5";
            this.FilterCheckbox5.Size = new System.Drawing.Size(32, 17);
            this.FilterCheckbox5.TabIndex = 21;
            this.FilterCheckbox5.Text = "1";
            this.FilterCheckbox5.UseVisualStyleBackColor = true;
            this.FilterCheckbox5.Visible = false;
            // 
            // FilterCheckbox6
            // 
            this.FilterCheckbox6.AutoSize = true;
            this.FilterCheckbox6.Location = new System.Drawing.Point(400, 306);
            this.FilterCheckbox6.Name = "FilterCheckbox6";
            this.FilterCheckbox6.Size = new System.Drawing.Size(32, 17);
            this.FilterCheckbox6.TabIndex = 21;
            this.FilterCheckbox6.Text = "1";
            this.FilterCheckbox6.UseVisualStyleBackColor = true;
            this.FilterCheckbox6.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 11F);
            this.label1.Location = new System.Drawing.Point(16, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Эти данные будут выведены в документ при экспорте";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Exitlabel);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.VirtusLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(439, 57);
            this.panel1.TabIndex = 22;
            // 
            // Exitlabel
            // 
            this.Exitlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exitlabel.AutoSize = true;
            this.Exitlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Exitlabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exitlabel.Font = new System.Drawing.Font("Tahoma", 18F);
            this.Exitlabel.Location = new System.Drawing.Point(409, -2);
            this.Exitlabel.Name = "Exitlabel";
            this.Exitlabel.Size = new System.Drawing.Size(29, 31);
            this.Exitlabel.TabIndex = 25;
            this.Exitlabel.Text = "X";
            this.Exitlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exitlabel.Click += new System.EventHandler(this.Exitlabel_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.ErrorImage = null;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(137, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(69, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // VirtusLabel
            // 
            this.VirtusLabel.AutoSize = true;
            this.VirtusLabel.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VirtusLabel.Location = new System.Drawing.Point(3, 8);
            this.VirtusLabel.Name = "VirtusLabel";
            this.VirtusLabel.Size = new System.Drawing.Size(130, 35);
            this.VirtusLabel.TabIndex = 1;
            this.VirtusLabel.Text = "Virtus ИС";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Sylfaen", 14F);
            this.button1.Location = new System.Drawing.Point(59, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 37);
            this.button1.TabIndex = 20;
            this.button1.Text = "Экспорт";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // Notelabel
            // 
            this.Notelabel.AutoSize = true;
            this.Notelabel.Font = new System.Drawing.Font("Sylfaen", 10F);
            this.Notelabel.Location = new System.Drawing.Point(419, 125);
            this.Notelabel.Name = "Notelabel";
            this.Notelabel.Size = new System.Drawing.Size(150, 18);
            this.Notelabel.TabIndex = 17;
            this.Notelabel.Text = "Фильтр по типу данных ";
            this.Notelabel.Visible = false;
            // 
            // Notelabel2
            // 
            this.Notelabel2.AutoSize = true;
            this.Notelabel2.Font = new System.Drawing.Font("Sylfaen", 10F);
            this.Notelabel2.Location = new System.Drawing.Point(419, 143);
            this.Notelabel2.Name = "Notelabel2";
            this.Notelabel2.Size = new System.Drawing.Size(145, 18);
            this.Notelabel2.TabIndex = 17;
            this.Notelabel2.Text = "может быть лишь один";
            this.Notelabel2.Visible = false;
            // 
            // ExportMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(439, 412);
            this.Controls.Add(this.FilterCheckbox6);
            this.Controls.Add(this.FilterCheckbox5);
            this.Controls.Add(this.FilterCheckbox4);
            this.Controls.Add(this.FilterCheckbox3);
            this.Controls.Add(this.FilterCheckbox2);
            this.Controls.Add(this.FilterCheckbox1);
            this.Controls.Add(this.ResetFilters);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PreviewdataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Notelabel2);
            this.Controls.Add(this.Notelabel);
            this.Controls.Add(this.ItemsInOrderLabel);
            this.Controls.Add(this.TableChooseCB);
            this.Controls.Add(this.ExportLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExportMenu";
            this.Text = "ExportMenu";
            ((System.ComponentModel.ISupportInitialize)(this.PreviewdataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ExportLabel;
        private System.Windows.Forms.ComboBox TableChooseCB;
        private System.Windows.Forms.Label ItemsInOrderLabel;
        private System.Windows.Forms.DataGridView PreviewdataGridView;
        private System.Windows.Forms.CheckBox FilterCheckbox1;
        private System.Windows.Forms.Button ResetFilters;
        private System.Windows.Forms.CheckBox FilterCheckbox2;
        private System.Windows.Forms.CheckBox FilterCheckbox3;
        private System.Windows.Forms.CheckBox FilterCheckbox4;
        private System.Windows.Forms.CheckBox FilterCheckbox5;
        private System.Windows.Forms.CheckBox FilterCheckbox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label VirtusLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label Notelabel;
        private System.Windows.Forms.Label Notelabel2;
        private System.Windows.Forms.Label Exitlabel;
    }
}