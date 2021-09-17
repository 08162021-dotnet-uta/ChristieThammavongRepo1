using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelsLayer.EFModels;
using ModelsLayer.ViewModels;

namespace BusinessLayer.Interfaces
{
    public interface IModelMapper
    {
        ViewModelCustomer CustomerToViewModelCustomer(Customer c) { throw new NotImplementedException(); }
        Customer ViewModelCustomerToCustomer(ViewModelCustomer c) { throw new NotImplementedException(); }
        ViewModelStore StoreToViewModelStore(Store s) { throw new NotImplementedException(); }
        Store ViewModelStoreToStore(ViewModelStore s) { throw new NotImplementedException(); }
    }
}
