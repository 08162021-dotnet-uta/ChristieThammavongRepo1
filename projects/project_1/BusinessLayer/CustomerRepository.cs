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

        /// <summary>
        /// This method registers a customer
        /// </summary>
        /// <param name="vmc"></param>
        /// <returns></returns>
        public async Task<ViewModelCustomer> RegisterCustomerAsync(ViewModelCustomer vmc)
        {
            Customer c1 = ModelMapper.ViewModelCustomerToCustomer(vmc);

            int c2 = await _context.Database.ExecuteSqlRawAsync("INSERT INTO Customer (FirstName, LastName) VALUES ({0},{1})", c1.FirstName, c1.LastName);// default is NULL

            if (c2 != 1) return null;

            return await LoginCustomerAsync(vmc);
        }

        /// <summary>
        /// This method will take a ViewModelCustomer and return the ViewModelCustomer
        /// if found in the DB.
        /// Null if not found.
        /// </summary>
        /// <returns></returns>
        public async Task<ViewModelCustomer> LoginCustomerAsync(ViewModelCustomer vmc)
        {
            Customer c1 = ModelMapper.ViewModelCustomerToCustomer(vmc);

            Customer c2 = await _context.Customers.FromSqlRaw<Customer>("SELECT * FROM Customer WHERE FirstName = {0} and LastName = {1}", c1.FirstName, c1.LastName).FirstOrDefaultAsync();// default is NULL

            if (c2 == null) return null;

            ViewModelCustomer c3 = ModelMapper.CustomerToViewModelCustomer(c2);
            return c3;
        }
    }
}
