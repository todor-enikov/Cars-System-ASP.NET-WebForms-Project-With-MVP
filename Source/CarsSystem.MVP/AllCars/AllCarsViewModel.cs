﻿using CarsSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsSystem.MVP.AllCars
{
    public class AllCarsViewModel
    {
        public IEnumerable<Car> Cars { get; set; }
    }
}
