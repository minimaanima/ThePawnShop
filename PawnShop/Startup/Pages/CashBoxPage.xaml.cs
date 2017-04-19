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
using PawnShop.CommunicationService.Core;
using PawnShop.CommunicationService.Interfaces;
using PawnShop.CommunicationService.Utilities;
using PawnShop.Data;
using PawnShop.Models.Enums;

namespace Startup.Pages
{
    /// <summary>
    /// Interaction logic for CashBoxPage.xaml
    /// </summary>
    public partial class CashBoxPage : Page,ISwitchable
    {
        private ICommandParser parser;

        public CashBoxPage()
        {
            InitializeComponent();
            ImportMoney();
            this.parser = new CommandParser();
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
            descriptionIn.Text = "";
        }
        private void descriptionIn_LostFocus(object sender, RoutedEventArgs e)
        {
            if (descriptionIn.Text == "")
            {
                descriptionIn.Text = "Leave some description";
            }
           
        }
        private void descriptionOut_Focus(object sender, RoutedEventArgs e)
        {
            descriptionOut.Text = "";
        }
        private void descriptionOut_LostFocus(object sender, RoutedEventArgs e)
        {
            if (descriptionOut.Text == "")
            {
                descriptionOut.Text = "Leave some description";
            }  
        }
        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        private void ImportMoney()
        {
            using (var context = new PawnShopContext())
            {
                context.Users.Attach(LoginUser.User);
                var cashBox = LoginUser.User.Office.CashBox;

                allCashAvailability.Text = cashBox.Balance.ToString();
            }
        }

        private void CashOutButtonClicked(object sender, RoutedEventArgs e)
        {
            var description = descriptionOut.Text;
            var moneyAmount = amount.Text;
            ComboBoxItem typeItem = (ComboBoxItem)ComboBox.SelectedItem;
            string operation = typeItem.Content.ToString();

            var command = this.parser.ParseCommand(new[]
            {
                "CashBoxTransaction",
                operation,
                moneyAmount,
                description
            });

            try
            {
                command.Execute();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Invalid data provided.");
            }

            ImportMoney();
            descriptionOut.Text = "Leave some description";
            amount.Text = "";
        }

        private void CashInButtonClicked(object sender, RoutedEventArgs e)
        {
            var description = descriptionIn.Text;
            var moneyAmount = amountIn.Text;
            string operation = OperationType.Deposit.ToString();

            var command = this.parser.ParseCommand(new[]
            {
                "CashBoxTransaction",
                operation,
                moneyAmount,
                description
            });


            try
            {
                command.Execute();
            }
            catch (Exception exp)
            {
                MessageBox.Show("Invalid data provided.");
            }
           
            ImportMoney();
            descriptionIn.Text = "Leave some description";
            amountIn.Text = "";
        }
    }
}
