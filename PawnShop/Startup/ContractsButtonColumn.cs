using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Startup.Pages;
using Startup.SwitchingService;

namespace Startup
{
    public class ContractsButtonColumn: DataGridColumn
    {
        protected override FrameworkElement GenerateElement(DataGridCell cell, object dataItem)
        {
            Button button = cell.Content as Button;

            if (button == null)
            {
                button = new Button();
                button.Height = 40;
                button.Width = 170;
                button.Content = "Details";
                button.FontSize = 15;
                button.Click += Button_Click;
            }

            button.CommandParameter = dataItem;

            return button;
        }

        protected override FrameworkElement GenerateEditingElement(DataGridCell cell, object dataItem)
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Switcher.Switch(new AddContractPage());

        }
    }
}
