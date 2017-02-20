using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsMvp;

namespace CarsSystem.MVP.FilterByAnnualCheckUp
{
    public interface IFilterByAnnualViewModel : IView<FilterByAnnualViewModel>
    {
        event EventHandler OnGetFilteredByAnnual;
    }
}
