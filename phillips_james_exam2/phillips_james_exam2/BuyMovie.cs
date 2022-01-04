using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace phillips_james_exam2
{
    public partial class BuyMovie : Form
    {
        int index;
        public BuyMovie(Movies movie, int i)
        {
            // setting form to show selected movie from main form
            InitializeComponent();
            OpenForm(movie);
            index = i;
        }

        private void OpenForm(Movies movie)
        {
            // this sets all the labels, image, and description text to the selected
            // movie from the main form.
            MovieImage.ImageLocation = string.Format(@"{0}", movie.Image);
            MovieImage.Show();
            MovieTitleLabel.Text = movie.Title;
            MovieYearLabel.Text = movie.Year.ToString();
            MoviePriceLabel.Text = movie.Price.ToString();
            MovieDescLabel.Text = movie.Description;
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            // clicking buy should remove the price of the movie from the balance.
            // it should also remove the movie from the list box
            double price = Convert.ToDouble(MoviePriceLabel.Text);
            Balance.Total -= price;
            Movies.movieList.Remove(Movies.movieList[index]);
            MainForm mainForm = new MainForm();
            BuyMovie.ActiveForm.Close();
            mainForm.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            // the cancel button should return you to the main screen
            MainForm mainForm = new MainForm();
            BuyMovie.ActiveForm.Close();
            mainForm.Show();
        }
    }
}
