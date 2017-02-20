using CarsSystem.MVP.CustomerDetails;
using CarsSystem.Services.Data.Contracts;
using Ninject;
using System;
using WebFormsMvp;
using WebFormsMvp.Web;

namespace CarsSystem.WebForms.Client.Customers
{
    [PresenterBinding(typeof(CustomerDetailsPresenter))]
    public partial class CustomerDetails : MvpPage<CustomerDetailsViewModel>, ICustomerDetailsViewModel
    {
        public event EventHandler<CustomerDetailsEventArgs> OnCustomerDetails;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.IsInRole("Admin"))
            {
                Response.Redirect("~/ErrorPages/UnauthorizedAccess.aspx");
            }

            var id = this.Request.QueryString["id"];
            this.OnCustomerDetails?.Invoke(this, new CustomerDetailsEventArgs(id));
            var user = this.Model.User;

            this.FirstnameLabel.Text = user.FirstName;
            this.SecondNameLabel.Text = user.SecondName;
            this.LastNameLabel.Text = user.LastName;
            this.EGNLabel.Text = user.EGN.ToString();
            this.NumberOfIdCardLabel.Text = user.NumberOfIdCard.ToString();
            this.DateOfIssueLabel.Text = user.DateOfIssue.ToString("dd.MM.yyyy");
            this.CityLabel.Text = user.City;
            this.PhoneNumberLabel.Text = user.PhoneNumber;
            this.EmailLabel.Text = user.Email;


            var carId = this.Model.CarId;
            this.CheckCustomerCarLabel.NavigateUrl = "~/Cars/CarDetails.aspx?id=" + carId;
        }
    }
}