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

namespace Startup.Pages
{
    /// <summary>
    /// Interaction logic for CashBoxPage.xaml
    /// </summary>
    public partial class CashBoxPage : Page,ISwitchable
    {
        public CashBoxPage()
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
        private void operations_btn(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new PerformedOperationsPage());
        }
        private void descriptionIn_Focus(object sender, RoutedEventArgs e)
        {
            descriptionIn.Text="";
        }
        private void descriptionIn_LostFocus(object sender, RoutedEventArgs e)
        {
            descriptionIn.Text="Leave some description";
        }
        private void descriptionOut_Focus(object sender, RoutedEventArgs e)
        {
            descriptionOut.Text = "";
        }
        private void descriptionOut_LostFocus(object sender, RoutedEventArgs e)
        {
            descriptionOut.Text = "Leave some description";
        }
        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }
    }
}
