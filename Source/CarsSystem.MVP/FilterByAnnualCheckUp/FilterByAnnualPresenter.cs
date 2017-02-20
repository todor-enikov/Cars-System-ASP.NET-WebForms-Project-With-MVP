using CarsSystem.Services.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFormsMvp;

namespace CarsSystem.MVP.FilterByAnnualCheckUp
{
    public class FilterByAnnualPresenter : Presenter<IFilterByAnnualViewModel>
    {
        private readonly IFilterService filterService;

        public FilterByAnnualPresenter(IFilterByAnnualViewModel view, IFilterService filterService)
            : base(view)
        {
            this.filterService = filterService;

            this.View.OnGetFilteredByAnnual += this.View_OnGetFilteredByAnnual;
        }

        private void View_OnGetFilteredByAnnual(object sender, EventArgs e)
        {
            this.View.Model.FilteredCars = this.filterService.FilterExpiringAnnualCheckUp();
            this.View.Model.FilteredEmails = this.filterService.GetMailsForCarsAnnualCheckUpExpiration();
        }
    }
}
