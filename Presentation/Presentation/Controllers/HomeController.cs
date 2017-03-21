using System.Threading.Tasks;
using Sample.Core.Recipes.Application;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Sample.Core.Presentation.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMediator _mediator;
        readonly ILogger _logger;



        //  public HomeController(IMediator mediator, ILogger logger)
        public HomeController(IMediator mediator, ILogger<HomeController> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }


        public async Task<ActionResult> Index(Index.Query query)
        {
            var model = await _mediator.Send(query);

            _logger.LogInformation("Test log information");

            return View(model);
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

        public IActionResult Error()
        {
            return View();
        }
    }
}