using BusinessLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ModelsLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepo;

        public CustomerController(ICustomerRepository cr)
        {
            _customerRepo = cr;
        }

        // GET: CustomerController
        public ActionResult Index()
        {
            return View();
        }

        // GET: CustomerController/Details/5
        [HttpGet("ListOfCustomers")]
        public async Task<List<ViewModelCustomer>> Details()
        {
            // call the business layer method to return list of customers
            //List<ViewModelCustomer> customers = await 
            Task<List<ViewModelCustomer>> customers = _customerRepo.CustomerListAsync();
            List<ViewModelCustomer> customersList = await customers;
            return customersList;
        }

        // GET: CustomerController/Create
        [HttpPost("RegisterCustomer")]
        public async Task<ActionResult<ViewModelCustomer>> Create(ViewModelCustomer c)
        {
            if (!ModelState.IsValid) return BadRequest();

            //ViewModelCustomer c = new ViewModelCustomer() { Fname = fname, Lname = lname };
            //send fname and lname into a method of the business layer to check the Db fo that guy/gal;
            ViewModelCustomer c1 = await _customerRepo.RegisterCustomerAsync(c);

            if (c1 == null)
            {
                return NotFound();
            }

            return Created($"~customer/{c1.VCustomerId}", c1);
        }

        // POST: CustomerController/Create
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

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
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

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
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
