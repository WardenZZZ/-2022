namespace Diplom
{
    partial class UsersMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AccessLevelLabel = new System.Windows.Forms.Label();
            this.VirtusLabel = new System.Windows.Forms.Label();
            this.UsersdataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.DeleteUserButton = new System.Windows.Forms.Button();
            this.EditUserButton = new System.Windows.Forms.Button();
            this.UsersExitButton = new System.Windows.Forms.Button();
            this.SearchtextBox = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersdataGridView1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(829, 57);
            this.panel1.TabIndex = 1;
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
            this.AccessLevelLabel.Location = new System.Drawing.Point(624, 14);
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
            // UsersdataGridView1
            // 
            this.UsersdataGridView1.AllowUserToAddRows = false;
            this.UsersdataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsersdataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UsersdataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.UsersdataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersdataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.UsersdataGridView1.Location = new System.Drawing.Point(267, 94);
            this.UsersdataGridView1.Name = "UsersdataGridView1";
            this.UsersdataGridView1.ReadOnly = true;
            this.UsersdataGridView1.Size = new System.Drawing.Size(550, 244);
            this.UsersdataGridView1.TabIndex = 7;
            // 
            // AddUserButton
            // 
            this.AddUserButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddUserButton.BackColor = System.Drawing.Color.White;
            this.AddUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddUserButton.Font = new System.Drawing.Font("Sylfaen", 14.2F);
            this.AddUserButton.Location = new System.Drawing.Point(10, 68);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(245, 33);
            this.AddUserButton.TabIndex = 0;
            this.AddUserButton.Text = "Добавить пользователя";
            this.AddUserButton.UseVisualStyleBackColor = false;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // DeleteUserButton
            // 
            this.DeleteUserButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DeleteUserButton.BackColor = System.Drawing.Color.White;
            this.DeleteUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteUserButton.Font = new System.Drawing.Font("Sylfaen", 14.2F);
            this.DeleteUserButton.Location = new System.Drawing.Point(10, 107);
            this.DeleteUserButton.Name = "DeleteUserButton";
            this.DeleteUserButton.Size = new System.Drawing.Size(245, 33);
            this.DeleteUserButton.TabIndex = 1;
            this.DeleteUserButton.Text = "Удалить пользователя";
            this.DeleteUserButton.UseVisualStyleBackColor = false;
            this.DeleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // EditUserButton
            // 
            this.EditUserButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EditUserButton.BackColor = System.Drawing.Color.White;
            this.EditUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditUserButton.Font = new System.Drawing.Font("Sylfaen", 14.2F);
            this.EditUserButton.Location = new System.Drawing.Point(10, 146);
            this.EditUserButton.Name = "EditUserButton";
            this.EditUserButton.Size = new System.Drawing.Size(245, 60);
            this.EditUserButton.TabIndex = 2;
            this.EditUserButton.Text = "Изменить данные пользователя";
            this.EditUserButton.UseVisualStyleBackColor = false;
            this.EditUserButton.Click += new System.EventHandler(this.EditUserButton_Click);
            // 
            // UsersExitButton
            // 
            this.UsersExitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsersExitButton.BackColor = System.Drawing.Color.White;
            this.UsersExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsersExitButton.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UsersExitButton.Location = new System.Drawing.Point(483, 353);
            this.UsersExitButton.Name = "UsersExitButton";
            this.UsersExitButton.Size = new System.Drawing.Size(143, 35);
            this.UsersExitButton.TabIndex = 5;
            this.UsersExitButton.Text = "Выход";
            this.UsersExitButton.UseVisualStyleBackColor = false;
            this.UsersExitButton.Click += new System.EventHandler(this.UsersExitButton_Click);
            // 
            // SearchtextBox
            // 
            this.SearchtextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SearchtextBox.Location = new System.Drawing.Point(301, 68);
            this.SearchtextBox.Name = "SearchtextBox";
            this.SearchtextBox.Size = new System.Drawing.Size(516, 20);
            this.SearchtextBox.TabIndex = 6;
            this.SearchtextBox.TextChanged += new System.EventHandler(this.SearchtextBox_TextChanged);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UpdateButton.BackColor = System.Drawing.Color.White;
            this.UpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateButton.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpdateButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UpdateButton.Image = global::Diplom.Properties.Resources.Repeat_font_awesome2;
            this.UpdateButton.Location = new System.Drawing.Point(267, 68);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(28, 20);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.UseVisualStyleBackColor = false;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // UsersMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(829, 397);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SearchtextBox);
            this.Controls.Add(this.UsersExitButton);
            this.Controls.Add(this.EditUserButton);
            this.Controls.Add(this.DeleteUserButton);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.UsersdataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsersMenu";
            this.Text = "UsersMenu";
            this.Activated += new System.EventHandler(this.UsersMenu_Activated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersdataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label VirtusLabel;
        private System.Windows.Forms.DataGridView UsersdataGridView1;
        public System.Windows.Forms.Label AccessLevelLabel;
        private System.Windows.Forms.Button AddUserButton;
        private System.Windows.Forms.Button DeleteUserButton;
        private System.Windows.Forms.Button EditUserButton;
        private System.Windows.Forms.Button UsersExitButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox SearchtextBox;
        public System.Windows.Forms.Button UpdateButton;
    }
}