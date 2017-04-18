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
    /// Interaction logic for AddClientPage.xaml
    /// </summary>
    public partial class AddClientPage : Page,ISwitchable
    {
        public AddClientPage()
        {
            InitializeComponent();
        }
        private void home_btn(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new ClientsPage());
        }
        public void UtilizeState(object state)
        {
            throw new NotImplementedException();
        }
    }
}
