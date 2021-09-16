using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer.ViewModels
{
	/// <summary>
	/// ViewModelCustomer displays only FirstName and LastName
	/// </summary>
    public class ViewModelCustomer
    {

		[StringLength(100, MinimumLength = 1)]
        public string VFirstName { get; set; }

		[StringLength(100, MinimumLength = 1)]
		public string VLastName { get; set; }

		public ViewModelCustomer() { }

		public ViewModelCustomer(string FirstName, string LastName)
        {
			VFirstName = FirstName;
			VLastName = LastName;
        }

    }
}
