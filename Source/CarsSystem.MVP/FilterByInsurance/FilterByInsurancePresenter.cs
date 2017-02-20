using CarsSystem.Services.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsMvp;

namespace CarsSystem.MVP.FilterByInsurance
{
    public class FilterByInsurancePresenter : Presenter<IFilterByInsuranceViewModel>
    {
        private readonly IFilterService service;

        public FilterByInsurancePresenter(IFilterByInsuranceViewModel view, IFilterService service)
            : base(view)
        {
            this.service = service;

            this.View.OnFilteredCars += this.View_OnFilteredCars;
        }

        private void View_OnFilteredCars(object sender, EventArgs e)
        {
            this.View.Model.FilteredCars = this.service.FilterExpiringInsurance();
            this.View.Model.FilteredEmails = this.service.GetMailsForCarsInsuranceExpiration();
        }
    }
}
