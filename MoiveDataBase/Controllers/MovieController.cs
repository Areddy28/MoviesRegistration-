using Microsoft.AspNetCore.Mvc;
using Dapper; 
using MoiveDataBase.Models;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoiveDataBase.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            using (var connect = new MySqlConnection(Secret.Connection))
            {

              string sql = "select * from movies";

            connect.Open();

            List<Movies> movies = connect.Query<Movies>(sql).ToList();

                connect.Close();

                
               Movies m = movies[0];
               
               return View(m);
               
            }


        }


        public IActionResult Registration(Movies m)
        {
            

                return View(m); 

           
        }

        [HttpPost]
        public IActionResult Index(Movies t)
        {
            return RedirectToAction("Result", t);
        }
        public IActionResult Result(Movies m)
        {

            return RedirectToAction("Result", m);
        }
    }
}
