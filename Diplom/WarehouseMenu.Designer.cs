namespace Diplom
{
    partial class WarehouseMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WarehouseMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AccessLevelLabel = new System.Windows.Forms.Label();
            this.VirtusLabel = new System.Windows.Forms.Label();
            this.WarehouseExitButton = new System.Windows.Forms.Button();
            this.EditWareButton = new System.Windows.Forms.Button();
            this.DeleteWareButton = new System.Windows.Forms.Button();
            this.AddWareButton = new System.Windows.Forms.Button();
            this.WarehouseDataGrid = new System.Windows.Forms.DataGridView();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.AccessLevelLabel);
            this.panel1.Controls.Add(this.VirtusLabel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(727, 57);
            this.panel1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(127, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // AccessLevelLabel
            // 
            this.AccessLevelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AccessLevelLabel.AutoSize = true;
            this.AccessLevelLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.AccessLevelLabel.Font = new System.Drawing.Font("Sylfaen", 15F);
            this.AccessLevelLabel.Location = new System.Drawing.Point(465, 14);
            this.AccessLevelLabel.Name = "AccessLevelLabel";
            this.AccessLevelLabel.Size = new System.Drawing.Size(116, 26);
            this.AccessLevelLabel.TabIndex = 4;
            this.AccessLevelLabel.Text = "Должность:";
            this.AccessLevelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // VirtusLabel
            // 
            this.VirtusLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.VirtusLabel.AutoSize = true;
            this.VirtusLabel.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.VirtusLabel.Location = new System.Drawing.Point(3, 8);
            this.VirtusLabel.Name = "VirtusLabel";
            this.VirtusLabel.Size = new System.Drawing.Size(130, 35);
            this.VirtusLabel.TabIndex = 1;
            this.VirtusLabel.Text = "Virtus ИС";
            // 
            // WarehouseExitButton
            // 
            this.WarehouseExitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WarehouseExitButton.BackColor = System.Drawing.Color.White;
            this.WarehouseExitButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.WarehouseExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WarehouseExitButton.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WarehouseExitButton.Location = new System.Drawing.Point(263, 376);
            this.WarehouseExitButton.Name = "WarehouseExitButton";
            this.WarehouseExitButton.Size = new System.Drawing.Size(199, 35);
            this.WarehouseExitButton.TabIndex = 6;
            this.WarehouseExitButton.Text = "Выход";
            this.WarehouseExitButton.UseVisualStyleBackColor = false;
            this.WarehouseExitButton.Click += new System.EventHandler(this.WarehouseExitButton_Click);
            // 
            // EditWareButton
            // 
            this.EditWareButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditWareButton.BackColor = System.Drawing.Color.White;
            this.EditWareButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.EditWareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditWareButton.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditWareButton.Location = new System.Drawing.Point(459, 67);
            this.EditWareButton.Name = "EditWareButton";
            this.EditWareButton.Size = new System.Drawing.Size(258, 34);
            this.EditWareButton.TabIndex = 2;
            this.EditWareButton.Text = "Изменить данные П.Д.";
            this.EditWareButton.UseVisualStyleBackColor = false;
            this.EditWareButton.Click += new System.EventHandler(this.EditWareButton_Click);
            // 
            // DeleteWareButton
            // 
            this.DeleteWareButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteWareButton.BackColor = System.Drawing.Color.White;
            this.DeleteWareButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.DeleteWareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteWareButton.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteWareButton.Location = new System.Drawing.Point(254, 67);
            this.DeleteWareButton.Name = "DeleteWareButton";
            this.DeleteWareButton.Size = new System.Drawing.Size(199, 34);
            this.DeleteWareButton.TabIndex = 1;
            this.DeleteWareButton.Text = "Удалить П.Д.";
            this.DeleteWareButton.UseVisualStyleBackColor = false;
            this.DeleteWareButton.Click += new System.EventHandler(this.DeleteWareButton_Click);
            // 
            // AddWareButton
            // 
            this.AddWareButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddWareButton.BackColor = System.Drawing.Color.White;
            this.AddWareButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.AddWareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddWareButton.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddWareButton.Location = new System.Drawing.Point(49, 67);
            this.AddWareButton.Name = "AddWareButton";
            this.AddWareButton.Size = new System.Drawing.Size(199, 34);
            this.AddWareButton.TabIndex = 0;
            this.AddWareButton.Text = "Добавить П.Д.";
            this.AddWareButton.UseVisualStyleBackColor = false;
            this.AddWareButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // WarehouseDataGrid
            // 
            this.WarehouseDataGrid.AllowUserToAddRows = false;
            this.WarehouseDataGrid.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.WarehouseDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WarehouseDataGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.WarehouseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WarehouseDataGrid.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WarehouseDataGrid.Location = new System.Drawing.Point(52, 126);
            this.WarehouseDataGrid.MultiSelect = false;
            this.WarehouseDataGrid.Name = "WarehouseDataGrid";
            this.WarehouseDataGrid.ReadOnly = true;
            this.WarehouseDataGrid.Size = new System.Drawing.Size(616, 244);
            this.WarehouseDataGrid.TabIndex = 7;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateButton.BackColor = System.Drawing.Color.White;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UpdateButton.Image = global::Diplom.Properties.Resources.Repeat_font_awesome2;
            this.UpdateButton.Location = new System.Drawing.Point(7, 66);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(36, 35);
            this.UpdateButton.TabIndex = 4;
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Location = new System.Drawing.Point(52, 104);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(616, 20);
            this.SearchtextBox.TabIndex = 3;
            this.SearchtextBox.TextChanged += new System.EventHandler(this.SearchtextBox_TextChanged);
            // 
            // WarehouseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(726, 424);
            this.Controls.Add(this.SearchtextBox);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.WarehouseExitButton);
            this.Controls.Add(this.EditWareButton);
            this.Controls.Add(this.DeleteWareButton);
            this.Controls.Add(this.AddWareButton);
            this.Controls.Add(this.WarehouseDataGrid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WarehouseMenu";
            this.Text = "StorageMenu";
            this.Activated += new System.EventHandler(this.WarehouseMenu_Activated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarehouseDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label VirtusLabel;
        private System.Windows.Forms.Button WarehouseExitButton;
        private System.Windows.Forms.Button EditWareButton;
        private System.Windows.Forms.Button DeleteWareButton;
        private System.Windows.Forms.Button AddWareButton;
        private System.Windows.Forms.DataGridView WarehouseDataGrid;
        public System.Windows.Forms.Label AccessLevelLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox SearchtextBox;
        public System.Windows.Forms.Button UpdateButton;
    }
}