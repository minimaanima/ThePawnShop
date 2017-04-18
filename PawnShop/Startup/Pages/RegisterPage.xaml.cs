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
    /// Interaction logic for RegisterPage.xaml
    /// </summary>
    public partial class RegisterPage : Page,ISwitchable
    {
        private ICommandParser commandParser;

        public RegisterPage()
        {
            InitializeComponent();
            commandParser = new CommandParser();
        }
        private void backTologin_btn(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new LoginPage());
        }
        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }

        private void AddButtonClicked(object sender, RoutedEventArgs e)
        {
            var officeName = this.officeName.Text;
            var email = this.usernameReg.Text;
            var password = this.passwordReg.Password;
            var confirmedPassword = this.confirmedPassword.Password;

            var command = commandParser.ParseCommand(new[] {"Register",officeName, email, password, confirmedPassword});
            command.Execute();

            Switcher.Switch(new ClientsPage());
        }
    }
}
