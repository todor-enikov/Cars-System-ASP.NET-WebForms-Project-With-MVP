using CarsSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsSystem.MVP.CustomerDetails
{
    public class CustomerDetailsViewModel
    {
        public User User { get; set; }
        public int CarId { get; set; }
    }
}
