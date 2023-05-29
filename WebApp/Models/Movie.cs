using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class Movie
    {
        public int Id { get; set; } 
        public int Rate { get; set; }   
        public string Title { get; set; }
        public Movie(int id, int rate,string title)
        {
            Id = id;
            Rate = rate;
            Title = title;
        }

        
    }
}