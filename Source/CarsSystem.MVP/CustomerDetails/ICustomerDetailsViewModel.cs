using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsMvp;

namespace CarsSystem.MVP.CustomerDetails
{
    public interface ICustomerDetailsViewModel : IView<CustomerDetailsViewModel>
    {
        event EventHandler<CustomerDetailsEventArgs> OnCustomerDetails;
    }
}
