﻿#pragma checksum "..\..\..\Pages\ClientsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "5657E7111F279591FFC2CBA923AA52C7"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Startup.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace Startup.Pages {
    
    
    /// <summary>
    /// ClientsPage
    /// </summary>
    public partial class ClientsPage : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 77 "..\..\..\Pages\ClientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox clientName;
        
        #line default
        #line hidden
        
        
        #line 78 "..\..\..\Pages\ClientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox personalId;
        
        #line default
        #line hidden
        
        
        #line 79 "..\..\..\Pages\ClientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox city;
        
        #line default
        #line hidden
        
        
        #line 85 "..\..\..\Pages\ClientsPage.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.DataGrid myDataGrid;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Startup;component/pages/clientspage.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Pages\ClientsPage.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            
            #line 33 "..\..\..\Pages\ClientsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.clients_btn);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 40 "..\..\..\Pages\ClientsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.contracts_btn);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 47 "..\..\..\Pages\ClientsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.cashbox_btn);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 54 "..\..\..\Pages\ClientsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.addclient_btn);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 61 "..\..\..\Pages\ClientsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.changeuser_btn);
            
            #line default
            #line hidden
            return;
            case 6:
            this.clientName = ((System.Windows.Controls.TextBox)(target));
            
            #line 77 "..\..\..\Pages\ClientsPage.xaml"
            this.clientName.GotFocus += new System.Windows.RoutedEventHandler(this.ClientName_GotFocus);
            
            #line default
            #line hidden
            
            #line 77 "..\..\..\Pages\ClientsPage.xaml"
            this.clientName.LostFocus += new System.Windows.RoutedEventHandler(this.ClientName_LostFocus);
            
            #line default
            #line hidden
            return;
            case 7:
            this.personalId = ((System.Windows.Controls.TextBox)(target));
            
            #line 78 "..\..\..\Pages\ClientsPage.xaml"
            this.personalId.GotFocus += new System.Windows.RoutedEventHandler(this.PersonalId_GotFocus);
            
            #line default
            #line hidden
            
            #line 78 "..\..\..\Pages\ClientsPage.xaml"
            this.personalId.LostFocus += new System.Windows.RoutedEventHandler(this.PersonalId_LostFocus);
            
            #line default
            #line hidden
            return;
            case 8:
            this.city = ((System.Windows.Controls.TextBox)(target));
            
            #line 79 "..\..\..\Pages\ClientsPage.xaml"
            this.city.GotFocus += new System.Windows.RoutedEventHandler(this.City_GotFocus);
            
            #line default
            #line hidden
            
            #line 79 "..\..\..\Pages\ClientsPage.xaml"
            this.city.LostFocus += new System.Windows.RoutedEventHandler(this.City_LostFocus);
            
            #line default
            #line hidden
            return;
            case 9:
            
            #line 80 "..\..\..\Pages\ClientsPage.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SearchButtonClick);
            
            #line default
            #line hidden
            return;
            case 10:
            this.myDataGrid = ((System.Windows.Controls.DataGrid)(target));
            return;
            }
            this._contentLoaded = true;
        }
    }
}

