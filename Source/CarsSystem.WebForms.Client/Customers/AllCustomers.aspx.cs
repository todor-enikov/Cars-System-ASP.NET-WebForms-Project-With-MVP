using CarsSystem.MVP.AllCustomers;
using CarsSystem.Services.Data.Contracts;
using Ninject;
using System;
using System.Linq;
using System.Web.UI.WebControls;
using WebFormsMvp;
using WebFormsMvp.Web;

namespace CarsSystem.WebForms.Client.Customers
{
    [PresenterBinding(typeof(AllCustomersPresenter))]
    public partial class AllCustomers : MvpPage<AllCustomersViewModel>, IAllCustomersViewModel
    {
        public event EventHandler<UserGetDataEventArgs> OnUsersGetData;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.IsInRole("Admin"))
            {
                Response.Redirect("~/ErrorPages/UnauthorizedAccess.aspx");
            }

            this.OnUsersGetData?.Invoke(this, new UserGetDataEventArgs(1234));

            this.AllCustomersGridView.DataSource = this.Model.Users.ToList();
            this.AllCustomersGridView.DataBind();
        }

        protected void SearchButton_Click(object sender, EventArgs e)
        {
            var egn = long.Parse(this.SearchTextBox.Text);
            this.OnUsersGetData?.Invoke(this, new UserGetDataEventArgs(egn));

            this.AllCustomersGridView.DataSource = this.Model.UserByEGN.ToList();
            this.AllCustomersGridView.DataBind();
        }
    }
}