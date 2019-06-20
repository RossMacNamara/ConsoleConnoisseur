using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ConsoleConnoisseur.Models;

namespace ConsoleConnoisseur.Controllers
{
    public class HomeController : Controller
    {
        private readonly IResponseRepository _responseRepository;

        private readonly IConsoleRepository _consoleRepository;

        private readonly ICommentRepository _commentRepository;

        public HomeController(IConsoleRepository consoleRepository, IResponseRepository responseRepository, ICommentRepository commentRepository)
        {
            _consoleRepository = consoleRepository;
            _responseRepository = responseRepository;
            _commentRepository = commentRepository;

    }

    public IActionResult Index()
        {
            var consoles = _consoleRepository.GetAllConsoles().OrderBy(c => c.Name);
            return View(consoles);
        }

        public IActionResult ViewDetails(int id)
        {
            var comments = _commentRepository.GetComments();
            ViewBag.Comments = comments;

            var console = _consoleRepository.GetConsoleById(id);
            if (console == null)
            {
                return NotFound();
            }
            return View(console);
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

        public IActionResult Tournament()
        {
            return View();
        }
    }
}
