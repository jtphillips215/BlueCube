using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace phillips_james_exam2
{
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
            // this hides error label unless user makes an error
            ErrorLabel.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            // closing add form and return to main form with cancel button
            MainForm mainForm = new MainForm();
            AddMovie.ActiveForm.Hide();
            mainForm.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            // try catch to create a new movie and add to movie list
            // if success, user should be returned to main screen with updated list box
            // if fail, user should recieve an error message and remain on the screen
            // Format exception catches if year or price in wrong format
            try
            {
                if (TitleTextBox.Text == "" || ImageTextBox.Text == "" || DescriptionTextBox.Text == "")
                {
                    ErrorLabel.Show();
                }
                else
                {
                    int year = Convert.ToInt32(YearTextBox.Text);
                    double price = Convert.ToDouble(PriceTextBox.Text);
                    Movies movie = new Movies(TitleTextBox.Text, year, price,
                        ImageTextBox.Text, DescriptionTextBox.Text);
                    Movies.movieList.Add(movie);
                    MainForm mainForm = new MainForm();
                    AddMovie.ActiveForm.Hide();
                    mainForm.Show();
                }
            }
            catch (System.FormatException)
            {
                ErrorLabel.Show();
            }
        }
    }
}
