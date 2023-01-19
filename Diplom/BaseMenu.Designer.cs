namespace Diplom
{
    partial class BaseMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BaseMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.VirtusLabel = new System.Windows.Forms.Label();
            this.BazadataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.AddPartButton = new System.Windows.Forms.Button();
            this.DeletePartButton = new System.Windows.Forms.Button();
            this.EditPartButton = new System.Windows.Forms.Button();
            this.PartsButton = new System.Windows.Forms.Button();
            this.PeriButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BazadataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 0;
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
            // BazadataGridView1
            // 
            this.BazadataGridView1.AllowUserToAddRows = false;
            this.BazadataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BazadataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BazadataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.BazadataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BazadataGridView1.Location = new System.Drawing.Point(0, 184);
            this.BazadataGridView1.MultiSelect = false;
            this.BazadataGridView1.Name = "BazadataGridView1";
            this.BazadataGridView1.ReadOnly = true;
            this.BazadataGridView1.Size = new System.Drawing.Size(800, 266);
            this.BazadataGridView1.TabIndex = 6;
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Location = new System.Drawing.Point(10, 157);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(176, 20);
            this.SearchtextBox.TabIndex = 0;
            this.SearchtextBox.TextChanged += new System.EventHandler(this.SearchtextBox_TextChanged);
            // 
            // AddPartButton
            // 
            this.AddPartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPartButton.BackColor = System.Drawing.Color.White;
            this.AddPartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPartButton.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPartButton.Location = new System.Drawing.Point(513, 67);
            this.AddPartButton.Name = "AddPartButton";
            this.AddPartButton.Size = new System.Drawing.Size(275, 33);
            this.AddPartButton.TabIndex = 3;
            this.AddPartButton.Text = "Добавить комплектующие";
            this.AddPartButton.UseVisualStyleBackColor = false;
            this.AddPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // DeletePartButton
            // 
            this.DeletePartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeletePartButton.BackColor = System.Drawing.Color.White;
            this.DeletePartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletePartButton.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeletePartButton.Location = new System.Drawing.Point(513, 145);
            this.DeletePartButton.Name = "DeletePartButton";
            this.DeletePartButton.Size = new System.Drawing.Size(275, 33);
            this.DeletePartButton.TabIndex = 4;
            this.DeletePartButton.Text = "Удалить комплектующие";
            this.DeletePartButton.UseVisualStyleBackColor = false;
            this.DeletePartButton.Click += new System.EventHandler(this.DeletePartButton_Click);
            // 
            // EditPartButton
            // 
            this.EditPartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditPartButton.BackColor = System.Drawing.Color.White;
            this.EditPartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditPartButton.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditPartButton.Location = new System.Drawing.Point(513, 106);
            this.EditPartButton.Name = "EditPartButton";
            this.EditPartButton.Size = new System.Drawing.Size(275, 33);
            this.EditPartButton.TabIndex = 5;
            this.EditPartButton.Text = "Изменить комплектующие";
            this.EditPartButton.UseVisualStyleBackColor = false;
            this.EditPartButton.Click += new System.EventHandler(this.EditPartButton_Click);
            // 
            // PartsButton
            // 
            this.PartsButton.BackColor = System.Drawing.Color.White;
            this.PartsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PartsButton.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.PartsButton.Location = new System.Drawing.Point(286, 150);
            this.PartsButton.Name = "PartsButton";
            this.PartsButton.Size = new System.Drawing.Size(117, 28);
            this.PartsButton.TabIndex = 5;
            this.PartsButton.Text = "Комплектующие";
            this.PartsButton.UseVisualStyleBackColor = false;
            this.PartsButton.Click += new System.EventHandler(this.PartsButton_Click);
            // 
            // PeriButton
            // 
            this.PeriButton.BackColor = System.Drawing.Color.White;
            this.PeriButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PeriButton.Font = new System.Drawing.Font("Sylfaen", 9.75F);
            this.PeriButton.Location = new System.Drawing.Point(409, 150);
            this.PeriButton.Name = "PeriButton";
            this.PeriButton.Size = new System.Drawing.Size(98, 28);
            this.PeriButton.TabIndex = 5;
            this.PeriButton.Text = "Периферия";
            this.PeriButton.UseVisualStyleBackColor = false;
            this.PeriButton.Click += new System.EventHandler(this.PeriButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackColor = System.Drawing.Color.White;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UpdateButton.Image = global::Diplom.Properties.Resources.Repeat_font_awesome2;
            this.UpdateButton.Location = new System.Drawing.Point(192, 154);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(27, 28);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(131, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BaseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.EditPartButton);
            this.Controls.Add(this.DeletePartButton);
            this.Controls.Add(this.PeriButton);
            this.Controls.Add(this.PartsButton);
            this.Controls.Add(this.AddPartButton);
            this.Controls.Add(this.SearchtextBox);
            this.Controls.Add(this.BazadataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BaseMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaseMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Activated += new System.EventHandler(this.BaseMenu_Activated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BazadataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label VirtusLabel;
        private System.Windows.Forms.DataGridView BazadataGridView1;
        private System.Windows.Forms.TextBox SearchtextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AddPartButton;
        private System.Windows.Forms.Button DeletePartButton;
        private System.Windows.Forms.Button EditPartButton;
        private System.Windows.Forms.Button PartsButton;
        private System.Windows.Forms.Button PeriButton;
        public System.Windows.Forms.Button UpdateButton;
    }
}