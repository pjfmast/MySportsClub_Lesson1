using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MySportsClub.Data;
using MySportsClub.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MySportsClub.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;

        private readonly IWorkoutRepository _workoutRepository;


        public HomeController(ILogger<HomeController> logger,
            IWorkoutRepository workoutRepository) {
            _logger = logger;
            _workoutRepository = workoutRepository;
        }

        public IActionResult Index() {
            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        public IActionResult Workouts() {
            var workouts = _workoutRepository.AllWorkouts.ToList();
            return View(workouts);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
