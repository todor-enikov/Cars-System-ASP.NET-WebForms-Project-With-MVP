using CarsSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarsSystem.MVP.FilterByInsurance
{
    public class FilterByInsuranceViewModel
    {
        public IEnumerable<Car> FilteredCars { get; set; }
        public IEnumerable<string> FilteredEmails { get; set; }
    }
}
