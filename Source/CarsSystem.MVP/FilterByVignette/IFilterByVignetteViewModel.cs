using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsMvp;

namespace CarsSystem.MVP.FilterByVignette
{
    public interface IFilterByVignetteViewModel : IView<FilterByVignetteViewModel>
    {
        event EventHandler OnFilteredCars;
    }
}
