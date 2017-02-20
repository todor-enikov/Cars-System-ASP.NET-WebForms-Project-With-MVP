using CarsSystem.MVP.AllCars;
using CarsSystem.Services.Data.Contracts;
using Ninject;
using System;
using System.Linq;
using System.Web.UI.WebControls;
using WebFormsMvp;
using WebFormsMvp.Web;

namespace CarsSystem.WebForms.Client.Cars
{
    [PresenterBinding(typeof(AllCarsPresenter))]
    public partial class AllCars : MvpPage<AllCarsViewModel>, IAllCarsViewModel
    {
        public event EventHandler OnCarsGetData;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.IsInRole("Admin"))
            {
                Response.Redirect("~/ErrorPages/UnauthorizedAccess.aspx");
            }

            this.OnCarsGetData?.Invoke(this, null);

            this.AllCarsGridView.DataSource = this.Model.Cars.ToList();
            this.AllCarsGridView.DataBind();
        }
    }
}