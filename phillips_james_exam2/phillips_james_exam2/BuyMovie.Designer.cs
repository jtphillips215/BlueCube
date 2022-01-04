
namespace phillips_james_exam2
{
    partial class BuyMovie
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
            this.MainLabel = new System.Windows.Forms.Label();
            this.BuyButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.MovieImage = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MovieDescLabel = new System.Windows.Forms.Label();
            this.MovieTitleLabel = new System.Windows.Forms.Label();
            this.MovieYearLabel = new System.Windows.Forms.Label();
            this.MoviePriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MovieImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.MainLabel.Location = new System.Drawing.Point(219, 21);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(322, 69);
            this.MainLabel.TabIndex = 11;
            this.MainLabel.Text = "BlueCube";
            // 
            // BuyButton
            // 
            this.BuyButton.Location = new System.Drawing.Point(219, 389);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(94, 29);
            this.BuyButton.TabIndex = 12;
            this.BuyButton.Text = "Buy";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(447, 389);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 29);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // MovieImage
            // 
            this.MovieImage.Location = new System.Drawing.Point(219, 93);
            this.MovieImage.Name = "MovieImage";
            this.MovieImage.Size = new System.Drawing.Size(125, 150);
            this.MovieImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MovieImage.TabIndex = 14;
            this.MovieImage.TabStop = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(367, 132);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(38, 20);
            this.TitleLabel.TabIndex = 15;
            this.TitleLabel.Text = "Title";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(367, 165);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(37, 20);
            this.YearLabel.TabIndex = 16;
            this.YearLabel.Text = "Year";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(367, 204);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(41, 20);
            this.PriceLabel.TabIndex = 17;
            this.PriceLabel.Text = "Price";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(6, 9);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(88, 20);
            this.DescriptionLabel.TabIndex = 18;
            this.DescriptionLabel.Text = "Description:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Azure;
            this.panel1.Controls.Add(this.MovieDescLabel);
            this.panel1.Controls.Add(this.DescriptionLabel);
            this.panel1.Location = new System.Drawing.Point(219, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 124);
            this.panel1.TabIndex = 19;
            // 
            // MovieDescLabel
            // 
            this.MovieDescLabel.AutoSize = true;
            this.MovieDescLabel.Location = new System.Drawing.Point(6, 29);
            this.MovieDescLabel.Name = "MovieDescLabel";
            this.MovieDescLabel.Size = new System.Drawing.Size(88, 20);
            this.MovieDescLabel.TabIndex = 19;
            this.MovieDescLabel.Text = "placeholder";
            // 
            // MovieTitleLabel
            // 
            this.MovieTitleLabel.AutoSize = true;
            this.MovieTitleLabel.Location = new System.Drawing.Point(411, 132);
            this.MovieTitleLabel.Name = "MovieTitleLabel";
            this.MovieTitleLabel.Size = new System.Drawing.Size(88, 20);
            this.MovieTitleLabel.TabIndex = 20;
            this.MovieTitleLabel.Text = "placeholder";
            // 
            // MovieYearLabel
            // 
            this.MovieYearLabel.AutoSize = true;
            this.MovieYearLabel.Location = new System.Drawing.Point(411, 165);
            this.MovieYearLabel.Name = "MovieYearLabel";
            this.MovieYearLabel.Size = new System.Drawing.Size(88, 20);
            this.MovieYearLabel.TabIndex = 21;
            this.MovieYearLabel.Text = "placeholder";
            // 
            // MoviePriceLabel
            // 
            this.MoviePriceLabel.AutoSize = true;
            this.MoviePriceLabel.Location = new System.Drawing.Point(414, 204);
            this.MoviePriceLabel.Name = "MoviePriceLabel";
            this.MoviePriceLabel.Size = new System.Drawing.Size(88, 20);
            this.MoviePriceLabel.TabIndex = 22;
            this.MoviePriceLabel.Text = "placeholder";
            // 
            // BuyMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MoviePriceLabel);
            this.Controls.Add(this.MovieYearLabel);
            this.Controls.Add(this.MovieTitleLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.MovieImage);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.MainLabel);
            this.Name = "BuyMovie";
            this.Text = "Buy Movie";
            ((System.ComponentModel.ISupportInitialize)(this.MovieImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Button BuyButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.PictureBox MovieImage;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label MovieTitleLabel;
        private System.Windows.Forms.Label MovieDescLabel;
        private System.Windows.Forms.Label MovieYearLabel;
        private System.Windows.Forms.Label MoviePriceLabel;
    }
}