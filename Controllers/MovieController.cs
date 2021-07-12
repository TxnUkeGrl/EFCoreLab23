using EFCoreLab23.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreLab23.Controllers
{
    public class MovieController : Controller
    {

        private readonly MovieDBContext _context;

        public MovieController(MovieDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }

        //Create, Read, Update, Delete (C.R.U.D.) Actions

    }
}
