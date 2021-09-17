using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsLayer.ViewModels
{
    /// <summary>
    /// ViewModelStore displays store Location
    /// </summary>
    public class ViewModelStore
    {
        [StringLength(100, MinimumLength = 1)]
        public string VLocation { get; set; }

        public ViewModelStore() { }

        public ViewModelStore(string Location)
        {
            VLocation = Location;
        }
    }
}
