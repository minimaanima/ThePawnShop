using Startup.Pages;
using System;
using System.Diagnostics;
using System.Globalization;

namespace Startup
{
    /// <summary>
    /// Converts the <see cref="ApplicationPage"/> to an actual view/page
    /// </summary>
    public class ApplicationPageValueConverter : BaseValueConverter<ApplicationPageValueConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Find the appropriate page
            switch ((ApplicationPage)value)
            {
                case ApplicationPage.Login:
                    return new LoginPage();
                case ApplicationPage.ClientsPage:
                    return new ClientsPage();
                case ApplicationPage.ContractsPage:
                    return new ContractsPage();
                case ApplicationPage.ChangeUserPage:
                    return new ChangeUserPage();
                case ApplicationPage.CashBoxPage:
                    return new CashBoxPage();
                case ApplicationPage.AddClientPage:
                    return new AddClientPage();
                case ApplicationPage.AddContractPage:
                    return new AddContractPage();
                case ApplicationPage.ViewContractPage:
                    return new ViewContractPage();
                case ApplicationPage.RegisterPage:
                    return new RegisterPage();

                default:
                    Debugger.Break();
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}