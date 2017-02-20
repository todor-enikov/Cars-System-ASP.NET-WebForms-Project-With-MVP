using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsSystem.MVP.CustomerDetails
{
    public class CustomerDetailsEventArgs : EventArgs
    {
        public string Id { get; set; }

        public CustomerDetailsEventArgs(string id)
        {
            this.Id = id;
        }
    }
}
