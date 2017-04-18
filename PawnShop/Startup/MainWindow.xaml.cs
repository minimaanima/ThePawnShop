using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using PawnShop.Data;
using Startup.Interfaces;
using Startup.SwitchingService;
using UserControl = System.Windows.Controls.UserControl;

namespace Startup
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Screen Size
            this.Height = (System.Windows.SystemParameters.PrimaryScreenHeight * 0.80);
            this.Width = (System.Windows.SystemParameters.PrimaryScreenWidth * 0.85);
            this.DataContext = new WindowViewModel(this);

            Switcher.currentPage = this;
            
        }

        public void Navigate(Page nextPage)
        {
            this.Content = nextPage;
        }

        public void Navigate(Page nextPage, object state)
        {
            this.Content = nextPage;
            ISwitchable s = nextPage as ISwitchable;

            if (s != null)
                s.UtilizeState(state);
            else
                throw new ArgumentException("NextPage is not ISwitchable! "
                  + nextPage.Name.ToString());
        }
    }
}
