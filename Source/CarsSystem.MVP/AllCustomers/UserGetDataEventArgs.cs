using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsSystem.MVP.AllCustomers
{
    public class UserGetDataEventArgs : EventArgs
    {
        public long EGN { get; set; }

        public UserGetDataEventArgs(long EGN)
        {
            this.EGN = EGN;
        }
    }
}
