using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DockerMVC.Models;
using System.Net.Http;

namespace DockerMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string employees = string.Empty;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://172.30.127.25/api/");
                //HTTP GET
                var responseTask = client.GetAsync("Values");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();

                    employees = readTask.Result;
                }
            }
            return View(employees);
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
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
