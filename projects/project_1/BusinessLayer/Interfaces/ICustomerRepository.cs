using ModelsLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Interfaces
{
    public interface ICustomerRepository
    {
        Task<List<ViewModelCustomer>> CustomerListAsync();
    }
}
