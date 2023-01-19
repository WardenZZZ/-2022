namespace Diplom
{
    partial class AddOrderEnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddOrderEnd));
            this.CustomerCommentTextBox = new System.Windows.Forms.TextBox();
            this.CustomerCommentLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.FinishOrderLabel = new System.Windows.Forms.Label();
            this.FinishOrderButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomerCommentTextBox
            // 
            this.CustomerCommentTextBox.Location = new System.Drawing.Point(72, 102);
            this.CustomerCommentTextBox.Multiline = true;
            this.CustomerCommentTextBox.Name = "CustomerCommentTextBox";
            this.CustomerCommentTextBox.Size = new System.Drawing.Size(439, 146);
            this.CustomerCommentTextBox.TabIndex = 0;
            // 
            // CustomerCommentLabel
            // 
            this.CustomerCommentLabel.AutoSize = true;
            this.CustomerCommentLabel.Font = new System.Drawing.Font("Sylfaen", 14.25F);
            this.CustomerCommentLabel.Location = new System.Drawing.Point(67, 74);
            this.CustomerCommentLabel.Name = "CustomerCommentLabel";
            this.CustomerCommentLabel.Size = new System.Drawing.Size(201, 25);
            this.CustomerCommentLabel.TabIndex = 3;
            this.CustomerCommentLabel.Text = "Комментарий клиента";
            this.CustomerCommentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // FinishOrderLabel
            // 
            this.FinishOrderLabel.AutoSize = true;
            this.FinishOrderLabel.Font = new System.Drawing.Font("Sylfaen", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FinishOrderLabel.Location = new System.Drawing.Point(38, 28);
            this.FinishOrderLabel.Name = "FinishOrderLabel";
            this.FinishOrderLabel.Size = new System.Drawing.Size(521, 35);
            this.FinishOrderLabel.TabIndex = 14;
            this.FinishOrderLabel.Text = "Добавление заказа - комментарий клиента\r\n";
            this.FinishOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FinishOrderButton
            // 
            this.FinishOrderButton.BackColor = System.Drawing.Color.White;
            this.FinishOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FinishOrderButton.Font = new System.Drawing.Font("Sylfaen", 15F);
            this.FinishOrderButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FinishOrderButton.Location = new System.Drawing.Point(171, 261);
            this.FinishOrderButton.Name = "FinishOrderButton";
            this.FinishOrderButton.Size = new System.Drawing.Size(247, 41);
            this.FinishOrderButton.TabIndex = 16;
            this.FinishOrderButton.Text = "Закончить";
            this.FinishOrderButton.UseVisualStyleBackColor = false;
            this.FinishOrderButton.Click += new System.EventHandler(this.FinishOrderButton_Click);
            // 
            // AddOrderEnd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(594, 317);
            this.Controls.Add(this.FinishOrderButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FinishOrderLabel);
            this.Controls.Add(this.CustomerCommentLabel);
            this.Controls.Add(this.CustomerCommentTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddOrderEnd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddOrderEnd";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CustomerCommentTextBox;
        private System.Windows.Forms.Label CustomerCommentLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label FinishOrderLabel;
        private System.Windows.Forms.Button FinishOrderButton;
    }
}