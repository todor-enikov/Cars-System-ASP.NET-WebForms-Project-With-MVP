using CarsSystem.Services.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsMvp;

namespace CarsSystem.MVP.CarDetails
{
    public class CarDetailsPresenter : Presenter<ICarDetailsViewModel>
    {
        private readonly ICarsService carsService;
        private readonly IUsersService usersService;

        public CarDetailsPresenter(ICarDetailsViewModel view, ICarsService carsService, IUsersService usersService)
            : base(view)
        {
            this.carsService = carsService;
            this.usersService = usersService;

            this.View.OnCarGetData += this.View_OnCarGetData;
        }

        private void View_OnCarGetData(object sender, CarGetDataEventArgs e)
        {
            var car = this.carsService.GetCarById(e.Id);
            this.View.Model.Car = car;
            this.View.Model.UserId = this.usersService.GetUserId(car);
        }
    }
}
