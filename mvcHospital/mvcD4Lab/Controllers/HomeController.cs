﻿using Microsoft.AspNetCore.Mvc;
using Hospital.DAL;
using Hospital.MVC.Models;
using System.Diagnostics;

namespace Hospital.MVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly HospitalContext _context;
    public HomeController(ILogger<HomeController> logger, HospitalContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
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