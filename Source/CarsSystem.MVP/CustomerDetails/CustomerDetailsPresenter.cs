using CarsSystem.Services.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsMvp;

namespace CarsSystem.MVP.CustomerDetails
{
    public class CustomerDetailsPresenter : Presenter<ICustomerDetailsViewModel>
    {
        private readonly IUsersService userService;
        private readonly ICarsService carService;

        public CustomerDetailsPresenter(ICustomerDetailsViewModel view, IUsersService userService, ICarsService carService)
            : base(view)
        {
            this.userService = userService;
            this.carService = carService;

            this.View.OnCustomerDetails += this.View_OnCustomerDetails;
        }

        private void View_OnCustomerDetails(object sender, CustomerDetailsEventArgs e)
        {
            var user = this.userService.GetUserById(e.Id);
            this.View.Model.User = user;
            this.View.Model.CarId = this.carService.GetCarId(user);
        }
    }
}
