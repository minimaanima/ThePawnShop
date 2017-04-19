using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using PawnShop.CommunicationService.ModelFactories;
using PawnShop.Data.DTOs;
using Startup.Pages;
using Startup.SwitchingService;

namespace Startup.ButtonColumns
{
    public class ContractsButtonColumn: DataGridColumn
    {
        protected override FrameworkElement GenerateElement(DataGridCell cell, object dataItem)
        {
            Button button = cell.Content as Button;

            if (button == null)
            {
                button = new Button();
                button.SetResourceReference(Control.StyleProperty, "GridButton");
                button.Content = "Details";
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
            ContractDto obj = ((FrameworkElement)sender).DataContext as ContractDto;
            var contracts = ContractFactory.GetContractDetails(obj);
            Switcher.Switch(new ContractDetailsPage(new List<ContractDetailsDto> {contracts}));
        }
    }
}
