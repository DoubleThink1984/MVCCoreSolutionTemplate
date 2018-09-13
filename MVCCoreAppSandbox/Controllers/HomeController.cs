using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCCoreAppSandbox.Models;
using Sandbox.Services;
using Sandbox.Services.ServiceInterfaces;
using Mapster;
using MVCCoreAppSandbox.ViewModels;

namespace MVCCoreAppSandbox.Controllers
{
    public class HomeController : Controller
    {
        private IQuestionService _questionService;

        public HomeController(IQuestionService questionService)
        {
            this._questionService = questionService;
        }

        public IActionResult Index()
        {
            var questionDto = _questionService.Get(4143);

            return View(questionDto.Adapt<QuestionViewModel>());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
