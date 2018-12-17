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
using Microsoft.Extensions.Logging;

namespace MVCCoreAppSandbox.Controllers
{
    public class LoggingEvents
    {
        public const int GenerateItems = 1000;
        public const int ListItems = 1001;
        public const int GetItem = 1002;
        public const int InsertItem = 1003;
        public const int UpdateItem = 1004;
        public const int DeleteItem = 1005;

        public const int GetItemNotFound = 4000;
        public const int UpdateItemNotFound = 4001;
    }

    public class HomeController : Controller
    {
        private IQuestionService _questionService;
        private readonly ILogger _logger;

        public HomeController(IQuestionService questionService,
            ILogger<HomeController> logger)
        {
            this._questionService = questionService;
            this._logger = logger;
        }

        public IActionResult Index()
        {
            var questionDto = _questionService.Get(4143);
            using (_logger.BeginScope("In a scope"))
            {
                //_logger.LogInformation(LoggingEvents.GetItem, "Getting Index Page {ID}");
                //_logger.LogWarning(LoggingEvents.GetItem, "Getting Index Page {ID}");
                //_logger.LogError(LoggingEvents.GetItem, "Getting Index Page {ID}");
                //_logger.LogDebug(LoggingEvents.GetItem, "Getting Index Page {ID}");
                _logger.LogTrace(LoggingEvents.GetItem, "Getting Index Page {ID}");
            //https://docs.microsoft.com/en-us/aspnet/core/mvc/controllers/filters?view=aspnetcore-2.2#dependency-injection
            }
            //_logger.LogInformation(LoggingEvents.GetItem, "Getting Index Page {ID}");
            //_logger.LogWarning(LoggingEvents.GetItem, "Getting Index Page {ID}");
            //_logger.LogError(LoggingEvents.GetItem, "Getting Index Page {ID}");
            //_logger.LogDebug(LoggingEvents.GetItem, "Getting Index Page {ID}");
            //_logger.LogTrace(LoggingEvents.GetItem, "Getting Index Page {ID}");


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
