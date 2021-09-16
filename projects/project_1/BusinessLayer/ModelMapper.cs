using BusinessLayer.Interfaces;
using ModelsLayer.EFModels;
using ModelsLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ModelMapper : IModelMapper
    {
        /// <summary>
        /// This method takes a Customer and returns the mapping to a ViewModelCustomer
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public static ViewModelCustomer CustomerToViewModelCustomer(Customer c)
        {
            ViewModelCustomer vmc = new ViewModelCustomer();
            vmc.VFirstName = c.FirstName;
            vmc.VLastName = c.LastName;
            return vmc;
        }

        /// <summary>
        /// This method takes a ViewModelCustomer and returns the mapping to a Customer
        /// </summary>
        /// <param name="vmc"></param>
        /// <returns></returns>
        public static Customer ViewModelCustomerToCustomer(ViewModelCustomer vmc)
        {
            Customer c = new Customer();
            c.FirstName = vmc.VFirstName;
            c.LastName = vmc.VLastName;
            return c;
        }
    }
}
