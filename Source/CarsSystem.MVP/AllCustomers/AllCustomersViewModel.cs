using CarsSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsSystem.MVP.AllCustomers
{
    public class AllCustomersViewModel
    {
        public IEnumerable<User> Users { get; set; }
        public IEnumerable<User> UserByEGN { get; set; }
    }
}
