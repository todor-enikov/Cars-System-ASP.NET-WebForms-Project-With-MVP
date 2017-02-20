using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsSystem.MVP.CarDetails
{
    public class CarGetDataEventArgs : EventArgs
    {
        public int Id { get; private set; }

        public CarGetDataEventArgs(int id)
        {
            this.Id = id;
        }
    }
}
