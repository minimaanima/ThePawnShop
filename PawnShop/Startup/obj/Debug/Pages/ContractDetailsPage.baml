   M S B A M L   `   `   `  ����B  >Startup, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Startup.PagesStartup.Pages  5      '    !Startup.Pages.ContractDetailsPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Startup.Pages     5        N� Title$  ClientsPage��5	      .��5      ��    ForegroundLightBrush#��[  6   ._�5   
   �  � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $	��81* �6    �� 5      $
��644* �6    .+�5      � $��0��6   $��75��6      WordLightBlueBrush#��[ 6,   .+�5      �� $��1��6    �� Orientation$ 
Horizontal=�6/   $��Center=�6H   .+�5      �� -   5          
IconButton#��[ 5        FontAwesomeClientsIcon#��[ 6A    � Cursor$
 Hand��6t    � ToolTip 5      _� 5      .��5   "   �� $
��Bold"�6,   $��16(�6>   Clients Page6[   5      5!      �� 5"      -   5        #��[ 5"        FontAwesomeContractsIcon#��[ 6A   $
 Hand��6u    5#      _� 5$      .��5%   "   �� $
��Bold"�6,   $��16(�6>   Contracts Page6]   5&      5(      �� 5)      -   5        #��[ 5)        FontAwesomeCogIcon#��[ 6B   $
 Hand��6p    5*      _� 5+      .��5,   "   �� $
��Bold"�6,   $��16(�6>   CashBox Page6[   5-      5/      �� 50      -   5        #��[ 50        FontAwesomeAddClientIcon#��[ 6B   $
 Hand��6v    51      _� 52      .��53   "   �� $
��Bold"�6,   $��16(�6>   Add Client Page6^   54      56      �� 57      -   5        #��[ 57        FontAwesomeChangeUserIcon#��[ 6B   $
 Hand��6w    58      _� 59      .��5:   "   �� $
��Bold"�6,   $��16(�6>   Change User Page6_   5;      5=      5>      5@      &   System.Windows.Controls.DataGrid  5B      -   5          Name$ 
myDataGrid��5B   $   $��1��6   
�������$��0,0,0,10q�6K   $��2��6]      CanUserResizeColumns . $��Stretch=�6�   $��Stretch=�5C         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 62   $��15(�6B      CanUserAddRows .  5E      5F      5G      5I      