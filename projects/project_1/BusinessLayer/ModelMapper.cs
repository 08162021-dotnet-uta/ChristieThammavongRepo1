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

        /// <summary>
        /// This method takes a Store and returns the mapping to a ViewModelStore
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static ViewModelStore StoreToViewModelStore(Store s)
        {
            ViewModelStore vms = new ViewModelStore();
            vms.VLocation = s.Location;
            return vms;
        }

        /// <summary>
        /// This method takes a ViewModelStore and returns the mapping to a Store
        /// </summary>
        /// <param name="vms"></param>
        /// <returns></returns>
        public static Store ViewModelStoreToStore(ViewModelStore vms)
        {
            Store s = new Store();
            s.Location = vms.VLocation;
            return s;
        }

        /// <summary>
        /// This method takes a Book and returns the mapping to a ViewModelBook
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public static ViewModelBook BookToViewModelBook(Book b)
        {
            ViewModelBook vmb = new ViewModelBook();
            vmb.VBookTypeId = b.BookTypeId;
            vmb.VBookGenreId = b.BookGenreId;
            vmb.VBookPrice = b.BookPrice;
            vmb.VQuantityAvailable = b.QuantityAvailable;
            return vmb;
        }

        /// <summary>
        /// This method takes a ViewModelBook and returns the mapping to a Book
        /// </summary>
        /// <param name="vmb"></param>
        /// <returns></returns>
        public static Book ViewModelBookToBook(ViewModelBook vmb)
        {
            Book b = new Book();
            b.BookTypeId = vmb.VBookTypeId;
            b.BookGenreId = vmb.VBookGenreId;
            b.BookPrice = vmb.VBookPrice;
            b.QuantityAvailable = vmb.VQuantityAvailable;
            return b;
        }
    }
}
