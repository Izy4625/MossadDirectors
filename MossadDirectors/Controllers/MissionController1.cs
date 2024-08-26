using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using MossadDirectors.Models;
using Newtonsoft.Json;
using System;


namespace MossadDirectors.Controllers
{
    public class MissionController : Controller
    {
        // GET: MissionController1
        private readonly HttpClient _httpClient = new HttpClient();
        private static List<ViewAgentWithTarget> _viewAgents = new List<ViewAgentWithTarget>();
        [HttpGet]
        public async Task<ActionResult> Index()
        {
           
            var res = await this._httpClient.GetFromJsonAsync<ViewAgentWithTarget[]>("http://localhost:5053/missions");
   
            return View(res);   

        }

        // GET: MissionController1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MissionController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MissionController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MissionController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MissionController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MissionController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MissionController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
