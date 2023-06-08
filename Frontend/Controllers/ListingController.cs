using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Frontend.Models;

namespace Frontend.Controllers;

public class ListingController : Controller
{
    private readonly ILogger<ListingController> _logger;

    public ListingController(ILogger<ListingController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
}
