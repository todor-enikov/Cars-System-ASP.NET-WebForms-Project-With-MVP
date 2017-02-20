using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsMvp;

namespace CarsSystem.MVP.AllCars
{
    public interface IAllCarsViewModel : IView<AllCarsViewModel>
    {
        event EventHandler OnCarsGetData;
    }
}
