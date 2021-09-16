using BusinessLayer.Interfaces;
using DbContextLayer.Models;
using Microsoft.EntityFrameworkCore;
using ModelsLayer.EFModels;
using ModelsLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class CustomerRepository : ICustomerRepository
    {
        // Step 1 of DI - create private instance of the dependency
        private readonly P1_StoreApplicationDBContext _context;

        // Step 2 of DI - call for an instance from the DI system in your constructor
        public CustomerRepository(P1_StoreApplicationDBContext context)
        {
            _context = context;
        }

        /// <summary>
        /// This method returns a list of Customers
        /// </summary>
        /// <returns></returns>
        public async Task<List<ViewModelCustomer>> CustomerListAsync()
        {
            List<Customer> customers = await _context.Customers.FromSqlRaw<Customer>("Select * FROM Customer").ToListAsync();
            List<ViewModelCustomer> vmc = new List<ViewModelCustomer>();
            foreach (Customer c in customers)
            {
                vmc.Add(ModelMapper.CustomerToViewModelCustomer(c));
            }
            return vmc;
        }
    }
}
