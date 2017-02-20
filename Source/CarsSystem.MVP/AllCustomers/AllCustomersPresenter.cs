using CarsSystem.Services.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsMvp;

namespace CarsSystem.MVP.AllCustomers
{
    public class AllCustomersPresenter : Presenter<IAllCustomersViewModel>
    {
        private readonly IUsersService service;

        public AllCustomersPresenter(IAllCustomersViewModel view, IUsersService service)
            : base(view)
        {
            this.service = service;

            this.View.OnUsersGetData += this.View_OnUsersGetData;
        }

        private void View_OnUsersGetData(object sender, UserGetDataEventArgs e)
        {
            this.View.Model.Users = this.service.GetAllUsers();
            this.View.Model.UserByEGN = this.service.GetUserByEGN(e.EGN);
        }
    }
}
