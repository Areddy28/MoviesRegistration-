using Microsoft.AspNetCore.Mvc;
using Dapper; 
using MoiveDataBase.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MoiveDataBase.Controllers
{
    public class MovieController : Controller
    {
        public MovieDAL MovieDB = new MovieDAL();

        public IActionResult Index()
        {
            List<Movies> movies = MovieDB.GetMovies();
            return View(movies);
        }

        public IActionResult Details(int id)
        {

            Movies m = MovieDB.GetMovie(id);
            return View(m);
        }

        public IActionResult Delete(int id)
        {
            Movies m = MovieDB.GetMovie(id);
            return View(m);
        }


        public IActionResult DeleteFromDB(int id)
        {
            MovieDB.DeleteMovie(id);
            return RedirectToAction("Index", "Home");
        }

        //This action will display the view as well as pass the movie
        public IActionResult Edit(int id)
        {
            Movies m = MovieDB.GetMovie(id);
            return View(m);
        }

        [HttpPost]
        public IActionResult Edit(Movies m)
        {

            MovieDB.UpdateMovie(m);
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Create(Movies m)
        {
            //ModelState is valid checks the model against its data annotations
            //it returns if all rules are met 
            //it returns if any rule is violated
            if (ModelState.IsValid)
            {

                MovieDB.CreateMovie(m);
                return RedirectToAction("Index", "Home");

            }
            else
            {
                //If the model is bad we will return 
                return View(m);
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    
    }
}
