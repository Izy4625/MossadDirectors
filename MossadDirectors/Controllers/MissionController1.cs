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
       private static AssignMission assign = new AssignMission();
        // GET: MissionController1
        private readonly HttpClient _httpClient = new HttpClient();
       
        [HttpGet]
        public async Task<ActionResult> Index()
        {
           
            var res = await this._httpClient.GetFromJsonAsync<List<Getsuggestioncs>>("http://localhost:5053/missions");
   
            return View(res);   

        }
       
        public async Task<ActionResult> AssignMission(int id)
        {
            
            
            assign.status = "assigned"; 
            //var json = JsonSerializer.Serialize(assign);
            var result = await this._httpClient.PostAsJsonAsync<AssignMission>($"http://localhost:5053/missions/{id}", assign);
            return RedirectToAction("Index");
        }

        // GET: MissionController1/Details/5
        public async Task<ActionResult> Details(int id)
        {
            var res = await this._httpClient.GetFromJsonAsync<Mission>($"http://localhost:5053/missions/{id}");
            return View(res);
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
