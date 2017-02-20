using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsMvp;

namespace CarsSystem.MVP.CarDetails
{
    public interface ICarDetailsViewModel : IView<CarDetailsViewModel>
    {
        event EventHandler<CarGetDataEventArgs> OnCarGetData;
    }
}
