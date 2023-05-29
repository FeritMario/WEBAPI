using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.Net.Http;
using System.Data;

using WebApp.Models;

namespace WebApp.Controllers
{
    public class MovieController : ApiController
    {

        public HttpResponseMessage Get()
        {
            IEnumerable<Movie> movie = null;

            movie = Movierep.Get();

            if (movie.Count() != 0)
            {
                return Request.CreateResponse(System.Net.HttpStatusCode.OK, movie);
            }
            return Request.CreateResponse(System.Net.HttpStatusCode.NotFound);
        }
        public HttpResponseMessage Get(int id)
        {
            Movie movie = Movierep.Get(id);
            if (movie != null)
            {
                return Request.CreateResponse(System.Net.HttpStatusCode.OK, movie);
            }
            else
            {
                return Request.CreateResponse(System.Net.HttpStatusCode.NotFound);
            }
        }

        public HttpResponseMessage Post(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(System.Net.HttpStatusCode.BadRequest, "Invalid ");
            }
            Movierep.AddMovie(movie);
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, "Successfully.");
        }
       

        public HttpResponseMessage Put(int id, Movie movie)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(System.Net.HttpStatusCode.BadRequest, "Invalid");
            }
            Movie currentMovie = Movierep.Get(id);
            if (currentMovie != null)
            {
                
                return Request.CreateResponse(System.Net.HttpStatusCode.OK, "Successfully updated.");
            }
            else
            {
                return Request.CreateResponse(System.Net.HttpStatusCode.NotFound);
            }
        }

        public HttpResponseMessage Delete(int id)
        {
            if (id <= 0)
            {
                return Request.CreateResponse(System.Net.HttpStatusCode.BadRequest, "Invalid");
            }
            Movierep.Delete(id);
            return Request.CreateResponse(System.Net.HttpStatusCode.OK, "Successfully deleted.");
        }

    }
}
