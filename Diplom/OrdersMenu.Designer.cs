namespace Diplom
{
    partial class OrdersMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersMenu));
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.OrdersdataGridView1 = new System.Windows.Forms.DataGridView();
            this.VirtusLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddOrderButton = new System.Windows.Forms.Button();
            this.DeleteOrderButton = new System.Windows.Forms.Button();
            this.EditOrderButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.CheckItemsInOrder = new System.Windows.Forms.Button();
            this.ItemsInOrderLabel = new System.Windows.Forms.Label();
            this.UpDownForOrderCheck = new System.Windows.Forms.NumericUpDown();
            this.Errorlabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.OrdersdataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownForOrderCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Location = new System.Drawing.Point(12, 155);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(176, 20);
            this.SearchtextBox.TabIndex = 8;
            this.SearchtextBox.TextChanged += new System.EventHandler(this.SearchtextBox_TextChanged);
            // 
            // OrdersdataGridView1
            // 
            this.OrdersdataGridView1.AllowUserToAddRows = false;
            this.OrdersdataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrdersdataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdersdataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.OrdersdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdersdataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.OrdersdataGridView1.Location = new System.Drawing.Point(0, 184);
            this.OrdersdataGridView1.Name = "OrdersdataGridView1";
            this.OrdersdataGridView1.ReadOnly = true;
            this.OrdersdataGridView1.Size = new System.Drawing.Size(800, 266);
            this.OrdersdataGridView1.TabIndex = 7;
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
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.VirtusLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 57);
            this.panel1.TabIndex = 6;
            // 
            // AddOrderButton
            // 
            this.AddOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddOrderButton.BackColor = System.Drawing.Color.White;
            this.AddOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddOrderButton.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddOrderButton.Location = new System.Drawing.Point(610, 63);
            this.AddOrderButton.Name = "AddOrderButton";
            this.AddOrderButton.Size = new System.Drawing.Size(178, 35);
            this.AddOrderButton.TabIndex = 13;
            this.AddOrderButton.Text = "Добавить заказ";
            this.AddOrderButton.UseVisualStyleBackColor = false;
            this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // DeleteOrderButton
            // 
            this.DeleteOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteOrderButton.BackColor = System.Drawing.Color.White;
            this.DeleteOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteOrderButton.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteOrderButton.Location = new System.Drawing.Point(610, 145);
            this.DeleteOrderButton.Name = "DeleteOrderButton";
            this.DeleteOrderButton.Size = new System.Drawing.Size(178, 35);
            this.DeleteOrderButton.TabIndex = 13;
            this.DeleteOrderButton.Text = "Удалить заказ";
            this.DeleteOrderButton.UseVisualStyleBackColor = false;
            this.DeleteOrderButton.Click += new System.EventHandler(this.DeleteOrderButton_Click);
            // 
            // EditOrderButton
            // 
            this.EditOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditOrderButton.BackColor = System.Drawing.Color.White;
            this.EditOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditOrderButton.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditOrderButton.Location = new System.Drawing.Point(610, 104);
            this.EditOrderButton.Name = "EditOrderButton";
            this.EditOrderButton.Size = new System.Drawing.Size(178, 35);
            this.EditOrderButton.TabIndex = 13;
            this.EditOrderButton.Text = "Изменить заказ";
            this.EditOrderButton.UseVisualStyleBackColor = false;
            this.EditOrderButton.Click += new System.EventHandler(this.EditOrderButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(131, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.White;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UpdateButton.Image = global::Diplom.Properties.Resources.Repeat_font_awesome2;
            this.UpdateButton.Location = new System.Drawing.Point(193, 151);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(27, 27);
            this.UpdateButton.TabIndex = 9;
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // CheckItemsInOrder
            // 
            this.CheckItemsInOrder.BackColor = System.Drawing.Color.White;
            this.CheckItemsInOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckItemsInOrder.Font = new System.Drawing.Font("Sylfaen", 13F);
            this.CheckItemsInOrder.Location = new System.Drawing.Point(411, 96);
            this.CheckItemsInOrder.Name = "CheckItemsInOrder";
            this.CheckItemsInOrder.Size = new System.Drawing.Size(169, 35);
            this.CheckItemsInOrder.TabIndex = 13;
            this.CheckItemsInOrder.Text = "Просмотреть заказ";
            this.CheckItemsInOrder.UseVisualStyleBackColor = false;
            this.CheckItemsInOrder.Click += new System.EventHandler(this.CheckItemsInOrder_Click);
            // 
            // ItemsInOrderLabel
            // 
            this.ItemsInOrderLabel.AutoSize = true;
            this.ItemsInOrderLabel.Font = new System.Drawing.Font("Sylfaen", 14F);
            this.ItemsInOrderLabel.Location = new System.Drawing.Point(333, 68);
            this.ItemsInOrderLabel.Name = "ItemsInOrderLabel";
            this.ItemsInOrderLabel.Size = new System.Drawing.Size(252, 25);
            this.ItemsInOrderLabel.TabIndex = 1;
            this.ItemsInOrderLabel.Text = "Просмотреть товары в заказе";
            // 
            // UpDownForOrderCheck
            // 
            this.UpDownForOrderCheck.Location = new System.Drawing.Point(338, 104);
            this.UpDownForOrderCheck.Name = "UpDownForOrderCheck";
            this.UpDownForOrderCheck.Size = new System.Drawing.Size(72, 20);
            this.UpDownForOrderCheck.TabIndex = 14;
            // 
            // Errorlabel
            // 
            this.Errorlabel.AutoSize = true;
            this.Errorlabel.BackColor = System.Drawing.SystemColors.Control;
            this.Errorlabel.Font = new System.Drawing.Font("Sylfaen", 13F);
            this.Errorlabel.ForeColor = System.Drawing.Color.DarkRed;
            this.Errorlabel.Location = new System.Drawing.Point(344, 134);
            this.Errorlabel.Name = "Errorlabel";
            this.Errorlabel.Size = new System.Drawing.Size(236, 23);
            this.Errorlabel.TabIndex = 15;
            this.Errorlabel.Text = "Такого заказа не существует!";
            this.Errorlabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 14F);
            this.label1.Location = new System.Drawing.Point(254, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id заказа:";
            // 
            // OrdersMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Errorlabel);
            this.Controls.Add(this.UpDownForOrderCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ItemsInOrderLabel);
            this.Controls.Add(this.EditOrderButton);
            this.Controls.Add(this.DeleteOrderButton);
            this.Controls.Add(this.CheckItemsInOrder);
            this.Controls.Add(this.AddOrderButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SearchtextBox);
            this.Controls.Add(this.OrdersdataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrdersMenu";
            this.Text = "OrdersMenu";
            this.Activated += new System.EventHandler(this.OrdersMenu_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.OrdersdataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownForOrderCheck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.DataGridView OrdersdataGridView1;
        private System.Windows.Forms.Label VirtusLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddOrderButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button DeleteOrderButton;
        private System.Windows.Forms.Button EditOrderButton;
        private System.Windows.Forms.Button CheckItemsInOrder;
        private System.Windows.Forms.Label ItemsInOrderLabel;
        private System.Windows.Forms.NumericUpDown UpDownForOrderCheck;
        private System.Windows.Forms.Label Errorlabel;
        private System.Windows.Forms.Label label1;
    }
}