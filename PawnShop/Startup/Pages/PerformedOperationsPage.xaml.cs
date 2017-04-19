using Startup.Interfaces;
using Startup.SwitchingService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PawnShop.CommunicationService.ModelFactories;

namespace Startup.Pages
{
    /// <summary>
    /// Interaction logic for PerformedOperationsPage.xaml
    /// </summary>
    public partial class PerformedOperationsPage : Page, ISwitchable
    {
        public PerformedOperationsPage()
        {
            InitializeComponent();
        }
        private void clients_btn(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new ClientsPage());
        }
        private void contracts_btn(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new ContractsPage());
        }
        private void cashbox_btn(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new CashBoxPage());
        }
        private void addclient_btn(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new AddClientPage());
        }
        private void changeuser_btn(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new LoginPage());
        }
        private void back_cashbox_btn(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new CashBoxPage());
        }
        private void FromDate_Focus(object sender, RoutedEventArgs e)
        {
            if (fromDate.Text == "From Date")
            {
                fromDate.Text = "";
            }
        }
        private void FromDate_LostFocus(object sender, RoutedEventArgs e)
        {
            if (fromDate.Text == "")
            {
                fromDate.Text = "From Date";
            }
        }
        private void ToDate_Focus(object sender, RoutedEventArgs e)
        {
            if (toDate.Text == "To Date")
            {
                toDate.Text = "";
            }
        }
        private void ToDate_LostFocus(object sender, RoutedEventArgs e)
        {
            if (toDate.Text == "")
            {
                toDate.Text = "To Date";
            }
        }
        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        private void ImportOperations(object sender, RoutedEventArgs e)
        {
            var fromDate = this.fromDate.Text;
            var toDate = this.toDate.Text;

            var operations = StatisticFactory.GetOperations(fromDate, toDate);
            myDataGrid.ItemsSource = operations;

            var filtredOperations = StatisticFactory.GetFirstAndLastOperation(fromDate, toDate);
            if (filtredOperations.Any())
            {
                var firstOperation = filtredOperations.First();
                var lastOperation = filtredOperations.Last();
                this.amount.Text = firstOperation.CashBoxValueBefore.ToString();
                this.amountAfter.Text = lastOperation.CashBoxValueAfter.ToString();
            }
        }
    }
}
