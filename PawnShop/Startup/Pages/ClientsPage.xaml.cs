using Startup.Interfaces;
using Startup.SwitchingService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PawnShop.CommunicationService.ModelFactories;
using DataGrid = System.Windows.Controls.DataGrid;
using DataGridCell = System.Windows.Controls.DataGridCell;

namespace Startup.Pages
{
    /// <summary>
    /// Interaction logic for ClientsPage.xaml
    /// </summary>
    public partial class ClientsPage : Page, ISwitchable
    {
        public ClientsPage()
        {
            InitializeComponent();
            ImportData();
            this.Loaded += new RoutedEventHandler(OnLoaded);
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

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        public void ImportData()
        {
            myDataGrid.ItemsSource = ClientFactory.GetClients();
        }

        private void OnLoaded(object sender, EventArgs e)
        {
            this.myDataGrid.Columns.Add(new ButtonColumn()
            {
                Header = "Add"
            });
            this.myDataGrid.Columns.Add(new ShowContractsButtonColumn()
            {
                Header="Contracts"
            });
        }
        private void FirstName_GotFocus(object sender, RoutedEventArgs e)
        {
            firstName.Text = "";
        }
        private void Lastname_GotFocus(object sender, RoutedEventArgs e)
        {
            lastName.Text = "";
        }
        private void PersonalId_GotFocus(object sender, RoutedEventArgs e)
        {
            personalId.Text = "";
        }
        private void City_GotFocus(object sender, RoutedEventArgs e)
        {
            city.Text = "";
        }
        private void FirstName_LostFocus(object sender, RoutedEventArgs e)
        {
            firstName.Text = "First Name";
        }
        private void LastName_LostFocus(object sender, RoutedEventArgs e)
        {
            lastName.Text = "Last Name";
        }
        private void PersonalId_LostFocus(object sender, RoutedEventArgs e)
        {
            personalId.Text = "Personal Id";
        }
        private void City_LostFocus(object sender, RoutedEventArgs e)
        {
            city.Text = "City";
        }
    }
}
