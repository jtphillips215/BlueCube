using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace phillips_james_exam2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            // on opening a copy of the main form, the list box should be populated
            // and the balance should be updated depending on if the user
            // purchased a movie or not
            InitializeComponent();
            PopulateMovies();
            PersonBalance.Text = string.Format("${0}", Balance.Total.ToString());
        }

        public void PopulateMovies()
        {
            // clearing list box and adding frash copy of the list to the list box
            MoviesListBox.Items.Clear();
            MoviesListBox.Items.AddRange(Movies.movieList.ToArray());
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // add movie passes the user off to the add form
            AddMovie addMovieForm = new AddMovie();
            MainForm.ActiveForm.Hide();
            addMovieForm.Show();
        }

        private void BuyButton_Click(object sender, EventArgs e)
        {
            // buy takes the selected item in the list box and passes it into the
            // buy form for the user
            try
            {
                int i = MoviesListBox.SelectedIndex;
                BuyMovie buyMovieForm = new BuyMovie(Movies.movieList[i], i);
                MainForm.ActiveForm.Hide();
                buyMovieForm.Show();
            }
            catch (System.ArgumentOutOfRangeException)
            {
                int i = 0;
                BuyMovie buyMovieForm = new BuyMovie(Movies.movieList[i], i);
                MainForm.ActiveForm.Hide();
                buyMovieForm.Show();
            }
        }
    }
}
