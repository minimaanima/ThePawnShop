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
using PawnShop.Data.DTOs;
using PawnShop.Models.BusinessModels;
using Startup.Interfaces;
using Startup.SwitchingService;

namespace Startup.Pages
{
    /// <summary>
    /// Interaction logic for AddContractPage.xaml
    /// </summary>
    public partial class AddContractPage : Page, ISwitchable
    {
        private ICommandParser commandParser;

        public AddContractPage()
        {
            InitializeComponent();
            this.commandParser = new CommandParser();
        }

        public AddContractPage(ClientDto clientDto)
        {
            InitializeComponent();
            ImportData(clientDto);
            this.commandParser = new CommandParser();
        }

        private void home_btn(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new ClientsPage());
        }

        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        private void ImportData(ClientDto clientDto)
        {
            this.fullName.Text = clientDto.FullName;
            this.personalId.Text = clientDto.PersonalID.ToString();
            this.adress.Text = clientDto.AddressName;
            this.idCardNumber.Text = clientDto.IDCardNumber;
            this.phoneNumber.Text = clientDto.PhoneNumber;
        }

        private void AddClicked(object sender, RoutedEventArgs e)
        {
            var endDate = this.endDate.Text;
            var property = this.property.Text;
            var propertyValue = this.propertyValue.Text;
            var interest = this.interest.Text;
            var fullName = this.fullName.Text;

            var command =
                this.commandParser.ParseCommand(new[]
                    {"AddContract", endDate, property, propertyValue, interest, fullName});
            try
            {
                command.Execute();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

            Switcher.Switch(new ContractsPage());
        }

    }
}
