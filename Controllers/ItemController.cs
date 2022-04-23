using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using NetflixAndFriends_FinalProject_ENTPROG.Models;
using NetflixAndFriends_FinalProject_ENTPROG.Data;

namespace NetflixAndFriends_FinalProject_ENTPROG.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
