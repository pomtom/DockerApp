using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DockerMVC.Models;
using System.Net.Http;
using System.Text;

namespace DockerMVC.Controllers
{
    public class EmployeesController : Controller
    {
        string uri = "http://localhost:52424/api/";

        // GET: Employees
        public async Task<IActionResult> Index()
        {

            IEnumerable<Employee> employee = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(uri);
                var responseTask = client.GetAsync("Values");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();
                    employee = Newtonsoft.Json.JsonConvert.DeserializeObject<IEnumerable<Employee>>(readTask.Result);

                    if (employee == null)
                    {
                        return NotFound();
                    }
                }
            }

            return View(employee);
        }

        // GET: Employees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employee employee = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(uri);
                var responseTask = client.GetAsync("Values/" + id);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();
                    employee = Newtonsoft.Json.JsonConvert.DeserializeObject<Employee>(readTask.Result);
                }
            }
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // GET: Employees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,Date,Photo")] Employee employee)
        {
            if (ModelState.IsValid)
            {
                using (var client = new HttpClient())
                {
                    var jsonObject = Newtonsoft.Json.JsonConvert.SerializeObject(employee);
                    var content = new StringContent(jsonObject.ToString(), Encoding.UTF8, "application/json");

                    client.BaseAddress = new Uri(uri);
                    var responseTask = client.PostAsync("Values", content);
                    responseTask.Wait();

                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        return RedirectToAction(nameof(Index));
                    }
                }
            }
            return View(employee);
        }

        // GET: Employees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Employee employee = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(uri);
                var responseTask = client.GetAsync("Values/" + id);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsStringAsync();
                    readTask.Wait();
                    employee = Newtonsoft.Json.JsonConvert.DeserializeObject<Employee>(readTask.Result);
                }
            }
            if (employee == null)
            {
                return NotFound();
            }

            return View(employee);
        }

        // POST: Employees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,Date,Photo")] Employee employee)
        {
            if (id != employee.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    using (var client = new HttpClient())
                    {
                        var jsonObject = Newtonsoft.Json.JsonConvert.SerializeObject(employee);
                        var content = new StringContent(jsonObject.ToString(), Encoding.UTF8, "application/json");

                        client.BaseAddress = new Uri(uri);
                        var responseTask = client.PutAsync("Values/" + id, content);
                        responseTask.Wait();

                        var result = responseTask.Result;
                        if (result.IsSuccessStatusCode)
                        {
                            return RedirectToAction(nameof(Index));
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(employee);
        }

        // GET: Employees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(uri);
                var responseTask = client.DeleteAsync("Values/" + id);
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction(nameof(Index));
                }
            }

            return View();
        }

        //// POST: Employees/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var employee = await _context.Employee.SingleOrDefaultAsync(m => m.Id == id);
        //    _context.Employee.Remove(employee);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool EmployeeExists(int id)
        //{
        //    return _context.Employee.Any(e => e.Id == id);
        //}
    }
}
