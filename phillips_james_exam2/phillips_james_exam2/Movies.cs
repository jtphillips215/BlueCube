using System;
using System.Collections.Generic;
using System.Text;

namespace phillips_james_exam2
{
    public class Movies
    {
        // instance variables
        private string title;
        private int year;
        private double price;
        private string image;
        private string description;
        public static List<Movies> movieList = new List<Movies>();

        // constructor
        public Movies(string title, int year, double price, string image, string description)
        {
            this.Title = title;
            this.Year = year;
            this.Price = price;
            this.Image = image;
            this.Description = description;
        }

        // getters and setters
        public string Title { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }

        // overriding tostring to show movie facts for list box
        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}", Title, Year, Price,
                Description, Image);
        }
    }
}