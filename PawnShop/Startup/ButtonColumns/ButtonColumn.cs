using System;
using System.Windows;
using System.Windows.Controls;
using PawnShop.Data.DTOs;
using Startup.Pages;
using Startup.SwitchingService;

namespace Startup.ButtonColumns
{
    public class ButtonColumn: DataGridColumn
    {
        protected override FrameworkElement GenerateElement(DataGridCell cell, object dataItem)
        {
            Button button = cell.Content as Button;
            
            if (button == null)
            {
                button = new Button();
                button.Content = "Add";
                button.SetResourceReference(Control.StyleProperty, "GridButton");
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
