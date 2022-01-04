
namespace phillips_james_exam2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.MainLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.BuyButton = new System.Windows.Forms.Button();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.PersonBalance = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.ItemHeight = 20;
            this.MoviesListBox.Location = new System.Drawing.Point(128, 81);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(567, 244);
            this.MoviesListBox.TabIndex = 0;
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.MainLabel.Location = new System.Drawing.Point(226, 9);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(322, 69);
            this.MainLabel.TabIndex = 1;
            this.MainLabel.Text = "BlueCube";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(239, 345);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 29);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add Movie";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(434, 345);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(94, 29);
            this.BuyButton.TabIndex = 3;
            this.BuyButton.Text = "Buy Movie";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BalanceLabel.Location = new System.Drawing.Point(269, 388);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(118, 38);
            this.BalanceLabel.TabIndex = 4;
            this.BalanceLabel.Text = "Balance";
            // 
            // PersonBalance
            // 
            this.PersonBalance.AutoSize = true;
            this.PersonBalance.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PersonBalance.Location = new System.Drawing.Point(393, 388);
            this.PersonBalance.Name = "PersonBalance";
            this.PersonBalance.Size = new System.Drawing.Size(0, 38);
            this.PersonBalance.TabIndex = 5;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PersonBalance);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MainLabel);
            this.Controls.Add(this.MoviesListBox);
            this.Name = "MainForm";
            this.Text = "BlueCube";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button BuyButton;
        public System.Windows.Forms.ListBox MoviesListBox;
        private System.Windows.Forms.Label BalanceLabel;
        private System.Windows.Forms.Label PersonBalance;
    }
}

