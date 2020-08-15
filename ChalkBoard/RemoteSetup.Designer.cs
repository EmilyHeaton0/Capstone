namespace ChalkBoard
{
    partial class RemoteSetup
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
            this.RepoNameTextbox = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.RepoNameLabel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.MainLabel = new System.Windows.Forms.Label();
            this.serverpathLabel = new System.Windows.Forms.Label();
            this.serverpathTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RepoNameTextbox
            // 
            this.RepoNameTextbox.Location = new System.Drawing.Point(191, 199);
            this.RepoNameTextbox.Name = "RepoNameTextbox";
            this.RepoNameTextbox.Size = new System.Drawing.Size(297, 22);
            this.RepoNameTextbox.TabIndex = 1;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SubmitButton.Location = new System.Drawing.Point(191, 274);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(91, 30);
            this.SubmitButton.TabIndex = 3;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // RepoNameLabel
            // 
            this.RepoNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RepoNameLabel.AutoSize = true;
            this.RepoNameLabel.Location = new System.Drawing.Point(57, 199);
            this.RepoNameLabel.Name = "RepoNameLabel";
            this.RepoNameLabel.Size = new System.Drawing.Size(83, 17);
            this.RepoNameLabel.TabIndex = 5;
            this.RepoNameLabel.Text = "Repo Name";
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.Location = new System.Drawing.Point(404, 274);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(84, 30);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // MainLabel
            // 
            this.MainLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.Location = new System.Drawing.Point(55, 42);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(424, 29);
            this.MainLabel.TabIndex = 8;
            this.MainLabel.Text = "Please Enter the following information:";
            // 
            // serverpathLabel
            // 
            this.serverpathLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverpathLabel.AutoSize = true;
            this.serverpathLabel.Location = new System.Drawing.Point(57, 147);
            this.serverpathLabel.Name = "serverpathLabel";
            this.serverpathLabel.Size = new System.Drawing.Size(120, 17);
            this.serverpathLabel.TabIndex = 10;
            this.serverpathLabel.Text = "Connection String";
            // 
            // serverpathTextbox
            // 
            this.serverpathTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.serverpathTextbox.Location = new System.Drawing.Point(191, 147);
            this.serverpathTextbox.Name = "serverpathTextbox";
            this.serverpathTextbox.Size = new System.Drawing.Size(297, 22);
            this.serverpathTextbox.TabIndex = 9;
            // 
            // RemoteSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 394);
            this.Controls.Add(this.serverpathLabel);
            this.Controls.Add(this.serverpathTextbox);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.RepoNameLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.RepoNameTextbox);
            this.Name = "RemoteSetup";
            this.Text = "Remote Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox RepoNameTextbox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label RepoNameLabel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Label serverpathLabel;
        private System.Windows.Forms.TextBox serverpathTextbox;
    }
}