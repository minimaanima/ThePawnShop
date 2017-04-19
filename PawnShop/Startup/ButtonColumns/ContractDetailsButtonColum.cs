using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using PawnShop.CommunicationService.Core;
using PawnShop.Data;
using PawnShop.Data.DTOs;
using PawnShop.Models.Enums;

namespace Startup.ButtonColumns
{
    public class ContractDetailsButtonColum: DataGridColumn
    {
        protected override FrameworkElement GenerateElement(DataGridCell cell, object dataItem)
        {
            ComboBox button = cell.Content as ComboBox;

            if (button == null)
            {
                button = SeedComboBox();
            }

            return button;
        }

        private ComboBox SeedComboBox()
        {
            var button = new ComboBox();
            button.Background = Brushes.White;
            
            var cboxitem = new ComboBoxItem();
            cboxitem.Content = "New";
            button.Items.Add(cboxitem);
            var cboxitem2 = new ComboBoxItem();
            cboxitem2.Content = "Active";
            button.Items.Add(cboxitem2);
            var cboxitem3 = new ComboBoxItem();
            cboxitem3.Content = "Overtimed";
            button.Items.Add(cboxitem3);
            var cboxitem4 = new ComboBoxItem();
            cboxitem4.Content = "Saled";
            button.Items.Add(cboxitem4);
            var cboxitem5 = new ComboBoxItem();
            cboxitem5.Content = "Ended";
            button.Items.Add(cboxitem5);
            button.SelectionChanged += new SelectionChangedEventHandler(Button_Click);
            return button;
        }

        protected override FrameworkElement GenerateEditingElement(DataGridCell cell, object dataItem)
        {
            throw new NotImplementedException();
        }

        private void Button_Click(object sender, SelectionChangedEventArgs e)
        {
            string text = (e.AddedItems[0] as ComboBoxItem).Content as string;


            ContractDetailsDto contractDetails = ((FrameworkElement)sender).DataContext as ContractDetailsDto;
            ChangeStatus(contractDetails, text);

        }

        private static void ChangeStatus(ContractDetailsDto contractDetails, string text)
        {
            using (var context = new PawnShopContext())
            {
                var contract = context.Contracts.Find(contractDetails.Id);
                contract.Status = (Status) Enum.Parse(typeof(Status), text);

                if (text == "Saled")
                {
                    CommandParser parser = new CommandParser();
                    var command =
                        parser.ParseCommand(new[]
                            {"CashBoxTransaction", "Deposit", contract.PropertyValue.ToString(), "Sold item"});
                    command.Execute();
                }

                if (text == "Ended")
                {
                    CommandParser parser = new CommandParser();
                    var command =
                        parser.ParseCommand(new[]
                        {
                            "CashBoxTransaction", "Deposit", (contract.PropertyValue * contract.Interest).ToString(),
                            "Ended item"
                        });
                    command.Execute();
                }

                context.SaveChanges();
            }
        }
    }
}
