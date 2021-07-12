﻿using EFCoreLab23.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public IActionResult DeleteMovie(int Id)
        {
            var foundMovie = _context.Movies.Find(Id);
            if (foundMovie != null)
            {
                _context.Movies.Remove(foundMovie);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public IActionResult MovieForm(int Id)
        {
            if (Id == 0)
            {
                return View(new Movie());
            }
            else
            {
                Movie foundMovie = _context.Movies.Find(Id);
                return View(foundMovie);
            }
        }

        public IActionResult SaveMovie(Movie newMovie)
        {
            if (ModelState.IsValid)
            {
                if (newMovie.Id == 0)
                {
                    _context.Movies.Add(newMovie);
                    _context.SaveChanges();
                }
                else
                {
                    Movie dbMovie = _context.Movies.Find(newMovie.Id);
                    dbMovie.Title = newMovie.Title;
                    dbMovie.Genre = newMovie.Genre;
                    dbMovie.Runtime = newMovie.Runtime;

                    _context.Entry(dbMovie).State = EntityState.Modified;
                    _context.Update(dbMovie);
                    _context.SaveChanges();
                }
            }

            return RedirectToAction("Index");
        }
    }
}
