namespace Diplom
{
    partial class AddOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrder));
            this.VirtusLabel = new System.Windows.Forms.Label();
            this.ItemsinOrdersDGV = new System.Windows.Forms.DataGridView();
            this.OrderIDTextBox = new System.Windows.Forms.TextBox();
            this.OrderNumberTextBox = new System.Windows.Forms.TextBox();
            this.IDlabel = new System.Windows.Forms.Label();
            this.OrderNumberLabel = new System.Windows.Forms.Label();
            this.BaseItemsComboBox = new System.Windows.Forms.ComboBox();
            this.ItemAddLabel = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.ItemPriceLabel = new System.Windows.Forms.Label();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OrderDetailsAmount = new System.Windows.Forms.NumericUpDown();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Amountlabel2 = new System.Windows.Forms.Label();
            this.TotalPricelabel3 = new System.Windows.Forms.Label();
            this.CheckOrderTypelabel4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Exitlabel = new System.Windows.Forms.Label();
            this.EditItemOrderButton = new System.Windows.Forms.Button();
            this.GetorderdetailsID = new System.Windows.Forms.Label();
            this.DeleteItemButton = new System.Windows.Forms.Button();
            this.FinishOrderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsinOrdersDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // VirtusLabel
            // 
            this.VirtusLabel.AutoSize = true;
            this.VirtusLabel.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VirtusLabel.Location = new System.Drawing.Point(73, 15);
            this.VirtusLabel.Name = "VirtusLabel";
            this.VirtusLabel.Size = new System.Drawing.Size(192, 35);
            this.VirtusLabel.TabIndex = 2;
            this.VirtusLabel.Text = "Добавить заказ";
            this.VirtusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemsinOrdersDGV
            // 
            this.ItemsinOrdersDGV.AllowUserToAddRows = false;
            this.ItemsinOrdersDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemsinOrdersDGV.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.ItemsinOrdersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsinOrdersDGV.Location = new System.Drawing.Point(79, 380);
            this.ItemsinOrdersDGV.Name = "ItemsinOrdersDGV";
            this.ItemsinOrdersDGV.ReadOnly = true;
            this.ItemsinOrdersDGV.RowHeadersVisible = false;
            this.ItemsinOrdersDGV.Size = new System.Drawing.Size(259, 112);
            this.ItemsinOrdersDGV.TabIndex = 3;
            this.ItemsinOrdersDGV.TabStop = false;
            this.ItemsinOrdersDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ItemsinOrdersDGV_CellContentClick);
            this.ItemsinOrdersDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.ItemsinOrdersDGV_DataBindingComplete);
            // 
            // OrderIDTextBox
            // 
            this.OrderIDTextBox.Location = new System.Drawing.Point(79, 77);
            this.OrderIDTextBox.Name = "OrderIDTextBox";
            this.OrderIDTextBox.ReadOnly = true;
            this.OrderIDTextBox.Size = new System.Drawing.Size(51, 20);
            this.OrderIDTextBox.TabIndex = 4;
            // 
            // OrderNumberTextBox
            // 
            this.OrderNumberTextBox.Location = new System.Drawing.Point(153, 76);
            this.OrderNumberTextBox.Name = "OrderNumberTextBox";
            this.OrderNumberTextBox.ReadOnly = true;
            this.OrderNumberTextBox.Size = new System.Drawing.Size(173, 20);
            this.OrderNumberTextBox.TabIndex = 5;
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Font = new System.Drawing.Font("Sylfaen", 10.25F);
            this.IDlabel.Location = new System.Drawing.Point(76, 56);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(23, 18);
            this.IDlabel.TabIndex = 2;
            this.IDlabel.Text = "ID";
            this.IDlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OrderNumberLabel
            // 
            this.OrderNumberLabel.AutoSize = true;
            this.OrderNumberLabel.Font = new System.Drawing.Font("Sylfaen", 10.25F);
            this.OrderNumberLabel.Location = new System.Drawing.Point(150, 55);
            this.OrderNumberLabel.Name = "OrderNumberLabel";
            this.OrderNumberLabel.Size = new System.Drawing.Size(87, 18);
            this.OrderNumberLabel.TabIndex = 2;
            this.OrderNumberLabel.Text = "Номер заказа";
            this.OrderNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BaseItemsComboBox
            // 
            this.BaseItemsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BaseItemsComboBox.FormattingEnabled = true;
            this.BaseItemsComboBox.Location = new System.Drawing.Point(79, 132);
            this.BaseItemsComboBox.Name = "BaseItemsComboBox";
            this.BaseItemsComboBox.Size = new System.Drawing.Size(247, 21);
            this.BaseItemsComboBox.TabIndex = 6;
            this.BaseItemsComboBox.SelectedIndexChanged += new System.EventHandler(this.BaseItemsComboBox_SelectedIndexChanged);
            // 
            // ItemAddLabel
            // 
            this.ItemAddLabel.AutoSize = true;
            this.ItemAddLabel.Font = new System.Drawing.Font("Sylfaen", 10.25F);
            this.ItemAddLabel.Location = new System.Drawing.Point(76, 111);
            this.ItemAddLabel.Name = "ItemAddLabel";
            this.ItemAddLabel.Size = new System.Drawing.Size(144, 18);
            this.ItemAddLabel.TabIndex = 2;
            this.ItemAddLabel.Text = "Заказываемый предмет";
            this.ItemAddLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(79, 179);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.ReadOnly = true;
            this.PriceTextBox.Size = new System.Drawing.Size(171, 20);
            this.PriceTextBox.TabIndex = 7;
            // 
            // ItemPriceLabel
            // 
            this.ItemPriceLabel.AutoSize = true;
            this.ItemPriceLabel.Font = new System.Drawing.Font("Sylfaen", 10.25F);
            this.ItemPriceLabel.Location = new System.Drawing.Point(76, 158);
            this.ItemPriceLabel.Name = "ItemPriceLabel";
            this.ItemPriceLabel.Size = new System.Drawing.Size(97, 18);
            this.ItemPriceLabel.TabIndex = 2;
            this.ItemPriceLabel.Text = "Цена предмета";
            this.ItemPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(79, 225);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(247, 20);
            this.AddressTextBox.TabIndex = 8;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Sylfaen", 10.25F);
            this.AddressLabel.Location = new System.Drawing.Point(76, 204);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(116, 18);
            this.AddressLabel.TabIndex = 2;
            this.AddressLabel.Text = "Адрес покупателя";
            this.AddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 10.25F);
            this.label1.Location = new System.Drawing.Point(76, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Предполагаемая дата получения заказа";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(79, 271);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // AddItemButton
            // 
            this.AddItemButton.BackColor = System.Drawing.Color.White;
            this.AddItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItemButton.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddItemButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AddItemButton.Location = new System.Drawing.Point(79, 304);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(127, 32);
            this.AddItemButton.TabIndex = 10;
            this.AddItemButton.Text = "Добавить предмет";
            this.AddItemButton.UseVisualStyleBackColor = false;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Location = new System.Drawing.Point(62, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 53);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // OrderDetailsAmount
            // 
            this.OrderDetailsAmount.Location = new System.Drawing.Point(256, 179);
            this.OrderDetailsAmount.Name = "OrderDetailsAmount";
            this.OrderDetailsAmount.Size = new System.Drawing.Size(35, 20);
            this.OrderDetailsAmount.TabIndex = 12;
            this.OrderDetailsAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.OrderDetailsAmount.ValueChanged += new System.EventHandler(this.OrderDetailsAmount_ValueChanged);
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Sylfaen", 10.25F);
            this.AmountLabel.Location = new System.Drawing.Point(253, 156);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(77, 18);
            this.AmountLabel.TabIndex = 2;
            this.AmountLabel.Text = "Количество";
            this.AmountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(262, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Amountlabel2
            // 
            this.Amountlabel2.AutoSize = true;
            this.Amountlabel2.Location = new System.Drawing.Point(25, 250);
            this.Amountlabel2.Name = "Amountlabel2";
            this.Amountlabel2.Size = new System.Drawing.Size(35, 13);
            this.Amountlabel2.TabIndex = 14;
            this.Amountlabel2.Text = "label2";
            this.Amountlabel2.Visible = false;
            // 
            // TotalPricelabel3
            // 
            this.TotalPricelabel3.AutoSize = true;
            this.TotalPricelabel3.Location = new System.Drawing.Point(25, 278);
            this.TotalPricelabel3.Name = "TotalPricelabel3";
            this.TotalPricelabel3.Size = new System.Drawing.Size(35, 13);
            this.TotalPricelabel3.TabIndex = 14;
            this.TotalPricelabel3.Text = "label2";
            this.TotalPricelabel3.Visible = false;
            // 
            // CheckOrderTypelabel4
            // 
            this.CheckOrderTypelabel4.AutoSize = true;
            this.CheckOrderTypelabel4.Location = new System.Drawing.Point(25, 315);
            this.CheckOrderTypelabel4.Name = "CheckOrderTypelabel4";
            this.CheckOrderTypelabel4.Size = new System.Drawing.Size(35, 13);
            this.CheckOrderTypelabel4.TabIndex = 14;
            this.CheckOrderTypelabel4.Text = "label2";
            this.CheckOrderTypelabel4.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 155);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(61, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.Visible = false;
            // 
            // Exitlabel
            // 
            this.Exitlabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exitlabel.AutoSize = true;
            this.Exitlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Exitlabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exitlabel.Font = new System.Drawing.Font("Tahoma", 18F);
            this.Exitlabel.Location = new System.Drawing.Point(384, 0);
            this.Exitlabel.Name = "Exitlabel";
            this.Exitlabel.Size = new System.Drawing.Size(29, 31);
            this.Exitlabel.TabIndex = 21;
            this.Exitlabel.Text = "X";
            this.Exitlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Exitlabel.Click += new System.EventHandler(this.Exitlabel_Click);
            // 
            // EditItemOrderButton
            // 
            this.EditItemOrderButton.BackColor = System.Drawing.Color.White;
            this.EditItemOrderButton.Enabled = false;
            this.EditItemOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditItemOrderButton.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditItemOrderButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EditItemOrderButton.Location = new System.Drawing.Point(212, 304);
            this.EditItemOrderButton.Name = "EditItemOrderButton";
            this.EditItemOrderButton.Size = new System.Drawing.Size(126, 32);
            this.EditItemOrderButton.TabIndex = 10;
            this.EditItemOrderButton.Text = "Изменить";
            this.EditItemOrderButton.UseVisualStyleBackColor = false;
            this.EditItemOrderButton.Click += new System.EventHandler(this.EditItemOrderButton_Click);
            // 
            // GetorderdetailsID
            // 
            this.GetorderdetailsID.AutoSize = true;
            this.GetorderdetailsID.Location = new System.Drawing.Point(28, 342);
            this.GetorderdetailsID.Name = "GetorderdetailsID";
            this.GetorderdetailsID.Size = new System.Drawing.Size(35, 13);
            this.GetorderdetailsID.TabIndex = 22;
            this.GetorderdetailsID.Text = "label5";
            this.GetorderdetailsID.Visible = false;
            // 
            // DeleteItemButton
            // 
            this.DeleteItemButton.BackColor = System.Drawing.Color.White;
            this.DeleteItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteItemButton.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteItemButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DeleteItemButton.Location = new System.Drawing.Point(79, 342);
            this.DeleteItemButton.Name = "DeleteItemButton";
            this.DeleteItemButton.Size = new System.Drawing.Size(259, 32);
            this.DeleteItemButton.TabIndex = 10;
            this.DeleteItemButton.Text = "Удалить товар";
            this.DeleteItemButton.UseVisualStyleBackColor = false;
            this.DeleteItemButton.Click += new System.EventHandler(this.DeleteItemButton_Click);
            // 
            // FinishOrderButton
            // 
            this.FinishOrderButton.BackColor = System.Drawing.Color.White;
            this.FinishOrderButton.Enabled = false;
            this.FinishOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinishOrderButton.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FinishOrderButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FinishOrderButton.Location = new System.Drawing.Point(153, 498);
            this.FinishOrderButton.Name = "FinishOrderButton";
            this.FinishOrderButton.Size = new System.Drawing.Size(112, 32);
            this.FinishOrderButton.TabIndex = 10;
            this.FinishOrderButton.Text = "Завершить";
            this.FinishOrderButton.UseVisualStyleBackColor = false;
            this.FinishOrderButton.Click += new System.EventHandler(this.FinishOrder_Click);
            // 
            // AddOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(413, 546);
            this.Controls.Add(this.GetorderdetailsID);
            this.Controls.Add(this.Exitlabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.CheckOrderTypelabel4);
            this.Controls.Add(this.TotalPricelabel3);
            this.Controls.Add(this.Amountlabel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.OrderDetailsAmount);
            this.Controls.Add(this.FinishOrderButton);
            this.Controls.Add(this.EditItemOrderButton);
            this.Controls.Add(this.AddItemButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.BaseItemsComboBox);
            this.Controls.Add(this.OrderNumberTextBox);
            this.Controls.Add(this.OrderIDTextBox);
            this.Controls.Add(this.ItemsinOrdersDGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.ItemPriceLabel);
            this.Controls.Add(this.ItemAddLabel);
            this.Controls.Add(this.OrderNumberLabel);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.VirtusLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DeleteItemButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrder";
            this.Load += new System.EventHandler(this.AddOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsinOrdersDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDetailsAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label VirtusLabel;
        private System.Windows.Forms.DataGridView ItemsinOrdersDGV;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label OrderNumberLabel;
        private System.Windows.Forms.Label ItemAddLabel;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Label ItemPriceLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown OrderDetailsAmount;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Amountlabel2;
        private System.Windows.Forms.Label TotalPricelabel3;
        private System.Windows.Forms.Label CheckOrderTypelabel4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label Exitlabel;
        private System.Windows.Forms.Button EditItemOrderButton;
        public System.Windows.Forms.TextBox OrderIDTextBox;
        public System.Windows.Forms.TextBox OrderNumberTextBox;
        private System.Windows.Forms.ComboBox BaseItemsComboBox;
        public System.Windows.Forms.TextBox AddressTextBox;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label GetorderdetailsID;
        private System.Windows.Forms.Button DeleteItemButton;
        private System.Windows.Forms.Button FinishOrderButton;
    }
}