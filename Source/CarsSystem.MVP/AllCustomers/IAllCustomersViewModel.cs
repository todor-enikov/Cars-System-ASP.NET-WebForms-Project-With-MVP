using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsMvp;

namespace CarsSystem.MVP.AllCustomers
{
    public interface IAllCustomersViewModel : IView<AllCustomersViewModel>
    {
        event EventHandler<UserGetDataEventArgs> OnUsersGetData;
    }
}
