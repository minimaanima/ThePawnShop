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
using Startup.Interfaces;
using Startup.SwitchingService;

namespace Startup.Pages
{
    /// <summary>
    /// Interaction logic for PerformedOperationsPage.xaml
    /// </summary>
    public partial class PerformedOperationsPage : Page, ISwitchable
    {
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
        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }
    }
}
