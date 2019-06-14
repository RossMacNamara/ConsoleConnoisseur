using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ConsoleConnoisseur.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleConnoisseur.Controllers
{
    public class ResponseController : Controller
    {
        private readonly IResponseRepository _responseRepository;

        public ResponseController(IResponseRepository responseRepository)
        {
            _responseRepository = responseRepository;
        }

        [HttpPost]
        public IActionResult Index(Response response)
        {
            Debug.WriteLine("------------------------------------------------------------------------------------------------------------------------------------");
            if (ModelState.IsValid)
            {
                _responseRepository.AddResponse(response);
                return RedirectToAction("ResponseComplete");
            }
            return View(response);
        }

        public IActionResult ResponseComplete()
        {
            return View();
        }
    }
}