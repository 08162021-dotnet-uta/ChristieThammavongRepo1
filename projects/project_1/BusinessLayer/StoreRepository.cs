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
    public class StoreRepository : IStoreRepository
    {
        private readonly P1_StoreApplicationDBContext _context;
        public StoreRepository(P1_StoreApplicationDBContext context)
        {
            _context = context;
        }

        /// <summary>
        /// This method returns a list of Stores
        /// </summary>
        /// <returns></returns>
        public async Task<List<ViewModelStore>> StoreListAsync()
        {
            List<Store> stores = await _context.Stores.FromSqlRaw<Store>("Select * FROM Store").ToListAsync();
            List<ViewModelStore> vms = new List<ViewModelStore>();
            foreach (Store s in stores)
            {
                vms.Add(ModelMapper.StoreToViewModelStore(s));
            }
            return vms;
        }
    }
}
