﻿using System;
using System.Windows;
using System.Windows.Controls;
using PawnShop.CommunicationService.ModelFactories;
using PawnShop.Data.DTOs;
using Startup.Pages;
using Startup.SwitchingService;

namespace Startup.ButtonColumns
{
    public class ShowContractsButtonColumn : DataGridColumn
    {
        protected override FrameworkElement GenerateElement(DataGridCell cell, object dataItem)
        {
            Button button = cell.Content as Button;

            if (button == null)
            {
                button = new Button();
                button.SetResourceReference(Control.StyleProperty, "GridButton");
                button.Content = "Contacts";
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
            ClientDto obj = ((FrameworkElement) sender).DataContext as ClientDto;
            var contracts = ContractFactory.GetContractsByClientsName(obj.FullName);
            Switcher.Switch(new ContractsPage(contracts));
        }
    }
}
