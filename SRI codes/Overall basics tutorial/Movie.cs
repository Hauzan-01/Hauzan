using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class Movie
    {
        public string title;
        public string director;
        private string rating;

        public Movie(string Atitle, string Adirector, string Arating)
        {
            title = Atitle; 
            director = Adirector;
            Rating = Arating;
        }

        public string Rating
        {
            get { return rating; }
            set
            {
                if(value == "P" || value == "PG" || value == "PG-13" || value=="R" || value=="NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
    }
}
