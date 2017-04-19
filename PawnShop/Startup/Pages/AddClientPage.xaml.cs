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

namespace Startup.Pages
{
    /// <summary>
    /// Interaction logic for AddClientPage.xaml
    /// </summary>
    public partial class AddClientPage : Page,ISwitchable
    {
        private ICommandParser commandParser;

        public AddClientPage()
        {
            InitializeComponent();
            commandParser = new CommandParser();
        }
        private void home_btn(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new ClientsPage());
        }
        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        private void AddedButtonClick(object sender, RoutedEventArgs e)
        {
            var firstName = this.firstName.Text;
            var middleName = this.middleName.Text;
            var lastName = this.lastName.Text;
            var address = this.adress.Text;
            var personalId = this.personalId.Text;
            var idCardNumber = this.idCardNumber.Text;
            var phonenumber = this.phoneNumber.Text;
            var townName = this.town.Text;
            var property = this.property.Text;
            var propertyValue = this.propertyValue.Text;
            var interest = this.propertyValue.Text;
            var endDate = this.endDate.Text;

            var command = this.commandParser.ParseCommand(new[]
                {"AddClient", firstName, middleName, lastName, address,personalId, idCardNumber, phonenumber, townName, property, propertyValue, interest, endDate});

            try
            {
                command.Execute();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            

            Switcher.Switch(new ClientsPage());
        }
    }
}
