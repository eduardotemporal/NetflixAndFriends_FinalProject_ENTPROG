using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetflixAndFriends_FinalProject_ENTPROG.Models;
using NetflixAndFriends_FinalProject_ENTPROG.Data;

namespace NetflixAndFriends_FinalProject_ENTPROG.Controllers
{
    public class ReviewController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReviewController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var list = _context.Reviews.ToList();
            return View(list);
        }
        public IActionResult Create()
        {
            return View();

        }

        [HttpPost]
        public IActionResult Create(Review record)
        {
            var item = new Review();
            item.ReviewContent = record.ReviewContent;
            item.MovieTitle = record.MovieTitle;

            
            _context.Reviews.Add(item);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int? id)
        {
            if(id == null)
            {
                return RedirectToAction("Index");
            }

            var item = _context.Reviews.Where(i => i.ReviewId == id).SingleOrDefault();

            if(item == null)
            {
                return RedirectToAction("Index");
            }

            return View(item);
        }

        [HttpPost]
        public IActionResult Edit(int? id, Review record)
        {
            var item = _context.Reviews.Where(i => i.ReviewId == id).SingleOrDefault();
            item.ReviewContent = record.ReviewContent;
            item.MovieTitle = record.MovieTitle;

            _context.Reviews.Add(item);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
