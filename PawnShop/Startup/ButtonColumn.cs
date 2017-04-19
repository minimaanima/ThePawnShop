using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using PawnShop.Data.DTOs;
using Startup.Pages;
using Startup.SwitchingService;

namespace Startup
{
    public class ButtonColumn: DataGridColumn
    {
        protected override FrameworkElement GenerateElement(DataGridCell cell, object dataItem)
        {
            Button button = cell.Content as Button;
            
            if (button == null)
            {
                button = new Button();
                button.Height = 40;
                button.Width = 150;
                button.Content = "Add";
                button.FontSize = 13;
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
            ClientDto obj = ((FrameworkElement)sender).DataContext as ClientDto;
            Switcher.Switch(new AddContractPage(obj));
        }

    }
}
