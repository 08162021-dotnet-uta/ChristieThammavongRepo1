using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelsLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StoreController : Controller
    {
        private readonly IStoreRepository _storeRepo;

        public StoreController(IStoreRepository sr)
        {
            _storeRepo = sr;
        }

        // GET: StoreController
        public ActionResult Index()
        {
            return View();
        }

        // GET: StoreController/Details/5
        [HttpGet("ListOfStores")]
        public async Task<List<ViewModelStore>> Details()
        {
            Task<List<ViewModelStore>> stores = _storeRepo.StoreListAsync();
            List<ViewModelStore> storesList = await stores;
            return storesList;
        }

        // GET: StoreController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StoreController/Create
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

        // GET: StoreController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StoreController/Edit/5
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

        // GET: StoreController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StoreController/Delete/5
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
