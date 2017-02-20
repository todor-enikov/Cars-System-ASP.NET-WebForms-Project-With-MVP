using CarsSystem.MVP.FilterByAnnualCheckUp;
using CarsSystem.Services.Data.Contracts;
using Ninject;
using System;
using System.Linq;
using System.Web.UI.WebControls;
using WebFormsMvp;
using WebFormsMvp.Web;

namespace CarsSystem.WebForms.Client.Filters
{
    [PresenterBinding(typeof(FilterByAnnualPresenter))]
    public partial class FilterByAnnualCheckUp : MvpPage<FilterByAnnualViewModel>,IFilterByAnnualViewModel
    {
        [Inject]
        public IMailService MailService { get; set; }

        public event EventHandler OnGetFilteredByAnnual;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!User.IsInRole("Admin"))
            {
                Response.Redirect("~/ErrorPages/UnauthorizedAccess.aspx");
            }
            this.OnGetFilteredByAnnual?.Invoke(this, null);

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