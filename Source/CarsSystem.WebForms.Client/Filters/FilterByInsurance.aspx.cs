using CarsSystem.MVP.FilterByInsurance;
using CarsSystem.Services.Data.Contracts;
using Ninject;
using System;
using System.Linq;
using System.Web.UI.WebControls;
using WebFormsMvp;
using WebFormsMvp.Web;

namespace CarsSystem.WebForms.Client.Filters
{
    [PresenterBinding(typeof(FilterByInsurancePresenter))]
    public partial class FilterByInsurance : MvpPage<FilterByInsuranceViewModel>, IFilterByInsuranceViewModel
    {
        [Inject]
        public IMailService MailService { get; set; }

        public event EventHandler OnFilteredCars;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.IsInRole("Admin"))
            {
                Response.Redirect("~/ErrorPages/UnauthorizedAccess.aspx");
            }

            this.OnFilteredCars?.Invoke(this, null);

            var filteredCars = this.Model.FilteredCars.ToList();
            this.FilterGridView.DataSource = filteredCars;
            this.FilterGridView.DataBind();
        }

        protected void SendMailButton_Click(object sender, EventArgs e)
        {
            var subject = this.EmailSubjectTextBox.Text;
            var content = this.EmailContentBox.Text;

            var emails = this.Model.FilteredEmails.ToList();
            MailService.SendEmail(subject, content, emails);
        }
    }
}