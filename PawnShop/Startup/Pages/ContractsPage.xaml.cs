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
using PawnShop.Data.DTOs;
using PawnShop.Models.Enums;
using Startup.ButtonColumns;

namespace Startup.Pages
{
    /// <summary>
    /// Interaction logic for ContractsPage.xaml
    /// </summary>
    public partial class ContractsPage : Page,ISwitchable
    {
        public ContractsPage()
        {
            InitializeComponent();
            ImportData();
            this.Loaded += new RoutedEventHandler(OnLoaded);
        }

        public ContractsPage(IEnumerable<ContractDto> contracts)
        {
            InitializeComponent();
            ImportData(contracts);
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

        public void ImportData(IEnumerable<ContractDto> contracts = null)
        {
            if (contracts == null)
            {
                myDataGrid.ItemsSource = ContractFactory.GetContracts();
            }
            else
            {
                myDataGrid.ItemsSource = contracts;
            }
           
        }

        private void OnLoaded(object sender, EventArgs e)
        {
            this.myDataGrid.Columns.Add(new ContractsButtonColumn()
            {
                Header = "Details"
            });
        }

        public void Active_btn(object sender, RoutedEventArgs e)
        {
            myDataGrid.ItemsSource = ContractFactory.GetContracts(Status.Active);
        }
        public void Saled_btn(object sender, RoutedEventArgs e)
        {
            myDataGrid.ItemsSource = ContractFactory.GetContracts(Status.Saled);
        }
        public void Ended_btn(object sender, RoutedEventArgs e)
        {
            myDataGrid.ItemsSource = ContractFactory.GetContracts(Status.Ended);
        }
        public void Overtimed_btn(object sender, RoutedEventArgs e)
        {
            myDataGrid.ItemsSource = ContractFactory.GetContracts(Status.Overtimed);
        }
        public void New_btn(object sender, RoutedEventArgs e)
        {
            myDataGrid.ItemsSource = ContractFactory.GetContracts(Status.New);
        }

    }
}
