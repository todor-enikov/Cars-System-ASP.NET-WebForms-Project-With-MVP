using CarsSystem.Services.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsMvp;

namespace CarsSystem.MVP.AllCars
{
    public class AllCarsPresenter : Presenter<IAllCarsViewModel>
    {
        private readonly ICarsService service;

        public AllCarsPresenter(IAllCarsViewModel view, ICarsService service)
            : base(view)
        {
            this.service = service;

            this.View.OnCarsGetData += this.View_OnCarsGetData;
        }

        private void View_OnCarsGetData(object sender, EventArgs e)
        {
            this.View.Model.Cars = this.service.GetAllCars();
        }
    }
}
