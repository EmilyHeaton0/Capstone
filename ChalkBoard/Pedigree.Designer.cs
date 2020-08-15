namespace ChalkBoard
{
    partial class Pedigree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedigree));
            this.ChildrenLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.CharacterPictureBox = new System.Windows.Forms.PictureBox();
            this.MotherPictureBox = new System.Windows.Forms.PictureBox();
            this.FatherPictureBox = new System.Windows.Forms.PictureBox();
            this.MotherLabel = new System.Windows.Forms.Label();
            this.FatherLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MotherPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FatherPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ChildrenLayoutPanel
            // 
            this.ChildrenLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ChildrenLayoutPanel.Location = new System.Drawing.Point(0, 290);
            this.ChildrenLayoutPanel.Name = "ChildrenLayoutPanel";
            this.ChildrenLayoutPanel.Size = new System.Drawing.Size(799, 158);
            this.ChildrenLayoutPanel.TabIndex = 0;
            // 
            // CharacterPictureBox
            // 
            this.CharacterPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CharacterPictureBox.Location = new System.Drawing.Point(346, 167);
            this.CharacterPictureBox.Name = "CharacterPictureBox";
            this.CharacterPictureBox.Size = new System.Drawing.Size(100, 100);
            this.CharacterPictureBox.TabIndex = 1;
            this.CharacterPictureBox.TabStop = false;
            // 
            // MotherPictureBox
            // 
            this.MotherPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MotherPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("MotherPictureBox.Image")));
            this.MotherPictureBox.Location = new System.Drawing.Point(111, 40);
            this.MotherPictureBox.Name = "MotherPictureBox";
            this.MotherPictureBox.Size = new System.Drawing.Size(100, 100);
            this.MotherPictureBox.TabIndex = 2;
            this.MotherPictureBox.TabStop = false;
            // 
            // FatherPictureBox
            // 
            this.FatherPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FatherPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("FatherPictureBox.Image")));
            this.FatherPictureBox.Location = new System.Drawing.Point(584, 40);
            this.FatherPictureBox.Name = "FatherPictureBox";
            this.FatherPictureBox.Size = new System.Drawing.Size(100, 100);
            this.FatherPictureBox.TabIndex = 3;
            this.FatherPictureBox.TabStop = false;
            // 
            // MotherLabel
            // 
            this.MotherLabel.AutoSize = true;
            this.MotherLabel.Location = new System.Drawing.Point(135, 84);
            this.MotherLabel.Name = "MotherLabel";
            this.MotherLabel.Size = new System.Drawing.Size(52, 17);
            this.MotherLabel.TabIndex = 4;
            this.MotherLabel.Text = "Mother";
            // 
            // FatherLabel
            // 
            this.FatherLabel.AutoSize = true;
            this.FatherLabel.Location = new System.Drawing.Point(611, 84);
            this.FatherLabel.Name = "FatherLabel";
            this.FatherLabel.Size = new System.Drawing.Size(49, 17);
            this.FatherLabel.TabIndex = 5;
            this.FatherLabel.Text = "Father";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(375, 208);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(45, 17);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Name";
            // 
            // Pedigree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.FatherLabel);
            this.Controls.Add(this.MotherLabel);
            this.Controls.Add(this.FatherPictureBox);
            this.Controls.Add(this.MotherPictureBox);
            this.Controls.Add(this.CharacterPictureBox);
            this.Controls.Add(this.ChildrenLayoutPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "Pedigree";
            this.Text = "Pedigree";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pedigree_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.CharacterPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MotherPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FatherPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel ChildrenLayoutPanel;
        private System.Windows.Forms.PictureBox CharacterPictureBox;
        private System.Windows.Forms.PictureBox MotherPictureBox;
        private System.Windows.Forms.PictureBox FatherPictureBox;
        private System.Windows.Forms.Label MotherLabel;
        private System.Windows.Forms.Label FatherLabel;
        private System.Windows.Forms.Label NameLabel;
    }
}