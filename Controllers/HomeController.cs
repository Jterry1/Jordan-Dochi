using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoDachi.Models;
using Microsoft.AspNetCore.Http;

namespace SwansonDachi.Controllers
{
    public class HomeController : Controller
    {
        public static Jordan Mike;

        [HttpGet("")]
        public IActionResult Index()
        {
            Mike = new Jordan();
            HttpContext.Session.Clear();
            HttpContext.Session.SetString("Message","Welcome, help Jordan on his Journey to a Championship");
            ViewBag.Message = HttpContext.Session.GetString("Message");
            return View(Mike);
        }

        [HttpGet("play")]
        public IActionResult Play()
        {
            ViewBag.Message = Mike.Play();
            if(Mike.didWin)
            {
                return View("Win",Mike);
            }
            else if(Mike.didLose)
            {
                return View("Dead",Mike);
            }
            return View("Index",Mike);
        }

        [HttpGet("feed")]
        public IActionResult Feed()
        {
            ViewBag.Message = Mike.Feed();
            if(Mike.didWin)
            {
                return View("Win",Mike);
            }
            else if(Mike.didLose)
            {
                return View("Dead",Mike);
            }
            return View("Index",Mike);
        }

        [HttpGet("sleep")]
        public IActionResult Sleep()
        {
            ViewBag.Message = Mike.Sleep();
            if(Mike.didWin)
            {
                return View("Win",Mike);
            }
            else if(Mike.didLose)
            {
                return View("Dead",Mike);
            }
            return View("Index",Mike);
        }

        [HttpGet("work")]
        public IActionResult Work()
        {
            ViewBag.Message = Mike.Work();
            if(Mike.didWin)
            {
                return View("Win",Mike);
            }
            else if(Mike.didLose)
            {
                return View("Dead",Mike);
            }
            return View("Index",Mike);
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