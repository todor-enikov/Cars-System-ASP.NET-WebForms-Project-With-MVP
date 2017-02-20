using CarsSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsSystem.MVP.CarDetails
{
    public class CarDetailsViewModel 
    {
        public Car Car { get; set; }
        public string UserId { get; set; }
    }
}
