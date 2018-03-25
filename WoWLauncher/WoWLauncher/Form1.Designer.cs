namespace WoWLauncher
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startButton = new System.Windows.Forms.Button();
            this.warmane = new System.Windows.Forms.RadioButton();
            this.gamerDistrict = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Black;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Image = ((System.Drawing.Image)(resources.GetObject("startButton.Image")));
            this.startButton.Location = new System.Drawing.Point(224, 398);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(132, 40);
            this.startButton.TabIndex = 0;
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // warmane
            // 
            this.warmane.AutoSize = true;
            this.warmane.BackColor = System.Drawing.Color.Transparent;
            this.warmane.Checked = true;
            this.warmane.Cursor = System.Windows.Forms.Cursors.Hand;
            this.warmane.Image = ((System.Drawing.Image)(resources.GetObject("warmane.Image")));
            this.warmane.Location = new System.Drawing.Point(12, 227);
            this.warmane.Name = "warmane";
            this.warmane.Size = new System.Drawing.Size(142, 145);
            this.warmane.TabIndex = 1;
            this.warmane.TabStop = true;
            this.warmane.Text = "Warmane";
            this.warmane.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.warmane.UseVisualStyleBackColor = false;
            this.warmane.CheckedChanged += new System.EventHandler(this.Warmane_CheckedChanged);
            // 
            // gamerDistrict
            // 
            this.gamerDistrict.AutoSize = true;
            this.gamerDistrict.BackColor = System.Drawing.Color.Transparent;
            this.gamerDistrict.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gamerDistrict.Image = ((System.Drawing.Image)(resources.GetObject("gamerDistrict.Image")));
            this.gamerDistrict.Location = new System.Drawing.Point(428, 227);
            this.gamerDistrict.Name = "gamerDistrict";
            this.gamerDistrict.Size = new System.Drawing.Size(142, 145);
            this.gamerDistrict.TabIndex = 2;
            this.gamerDistrict.Text = "GamerDistrict";
            this.gamerDistrict.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.gamerDistrict.UseVisualStyleBackColor = false;
            this.gamerDistrict.CheckedChanged += new System.EventHandler(this.GamerDistrict_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(12, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 90);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.comboBox1.DisplayMember = "text";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft YaHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(58, 134);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(71, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.Tag = "";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.gamerDistrict);
            this.Controls.Add(this.warmane);
            this.Controls.Add(this.startButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleWoWLauncher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.RadioButton warmane;
        private System.Windows.Forms.RadioButton gamerDistrict;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

