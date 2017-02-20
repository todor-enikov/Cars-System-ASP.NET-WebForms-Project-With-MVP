using CarsSystem.MVP.CarDetails;
using CarsSystem.Services.Data.Contracts;
using Ninject;
using System;
using WebFormsMvp;
using WebFormsMvp.Web;

namespace CarsSystem.WebForms.Client.Cars
{
    [PresenterBinding(typeof(CarDetailsPresenter))]
    public partial class CarDetails : MvpPage<CarDetailsViewModel>, ICarDetailsViewModel
    {
        public event EventHandler<CarGetDataEventArgs> OnCarGetData;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.IsInRole("Admin"))
            {
                Response.Redirect("~/ErrorPages/UnauthorizedAccess.aspx");
            }

            var id = int.Parse(this.Request.QueryString["id"]);
            this.OnCarGetData?.Invoke(this, new CarGetDataEventArgs(id));

            var car = this.Model.Car;
            var userId = this.Model.UserId;

            this.ManufacturerLabel.Text = car.Manufacturer;
            this.ModelLabel.Text = car.Model;
            this.TypeOfEngineLabel.Text = car.TypeOfEngine.ToString();
            this.RegistrationNumberLabel.Text = car.RegistrationNumber;
            this.VINLabel.Text = car.VINNumber;
            this.CountOfTyresLabel.Text = car.CountOfTyres.ToString();
            this.CountOfDoorsLabel.Text = car.CountOfDoors.ToString();
            this.TypeOfCarLabel.Text = car.TypeOfCar.ToString();
            this.YearOfManufactoringLabel.Text = car.YearOfManufacturing.ToString("dd.MM.yyyy");
            this.AnnualCkeckLabel.Text = car.ValidUntilAnnualCheckUp.ToString("dd.MM.yyyy");
            this.VignetteLabel.Text = car.ValidUntilVignette.ToString("dd.MM.yyyy");
            this.InsuranceLabel.Text = car.ValidUntilInsurance.ToString("dd.MM.yyyy");
            this.CheckCarOwnerLabel.NavigateUrl = "~/Customers/CustomerDetails.aspx?id=" + userId;
        }
    }
}