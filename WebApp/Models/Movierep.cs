using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Movierep
    {
        
        
            public static List<Movie> movies = new List<Movie>
            {
            new Movie(1,2,"Spiderman"),
            new Movie(2,5 ,"Batman"),
            new Movie(3,10,"Yes"),
        };
            public static IEnumerable<Movie> Get()
        {
            return movies;
        }
        public static Movie Get(int id)
        {
            return movies.Find(movie => movie.Id == id);
        }
        public static void AddMovie(Movie movie)
        {
            movies.Add(movie);
        }

        public static void Delete(int id)
        {
            movies.Remove(Get(id));
        }
    }

}
