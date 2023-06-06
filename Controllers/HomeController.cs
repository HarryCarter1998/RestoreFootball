﻿using Microsoft.AspNetCore.Mvc;
using RestoreFootball.Controllers;
using RestoreFootball.Data.Services;
using RestoreFootball.Models;
using RestoreFootball2.Models;
using System.Diagnostics;

namespace RestoreFootball2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPlayerService _playerService;

        public HomeController(ILogger<HomeController> logger, IPlayerService playerService)
        {
            _logger = logger;
            _playerService = playerService;
        }

        public async Task<IActionResult> IndexAsync()
        {
            ViewBag.Players = await _playerService.Index();
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