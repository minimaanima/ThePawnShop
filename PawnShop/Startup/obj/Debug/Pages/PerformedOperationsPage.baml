   M S B A M L   `   `   `  ����B  >Startup, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Startup.PagesStartup.Pages  5      +    %Startup.Pages.PerformedOperationsPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Startup.Pages     5        N� Title$  PerformedOperationsPage��5	      .��5      ��    ForegroundLightBrush#��[  6   ._�5   
   � ��5      �� 5       j� TileMode$
 Tile=�6    j� ViewportUnits$ Absolute=�6-    j� Viewport$ 0 0 500 500�6F    �� ImageSource$$ ..\Images\backgroundSignIn.png��6]    �� Opacity$	 0.5Q�6�    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $��* �6    .+�5      � $��0��6   $��75��6      WordLightBlueBrush#��[ 6,   .+�5!      �� $��1��6    �� Orientation$ 
Horizontal=�6/   $��Center=�6H   .+�5"      �� -   5          
IconButton#��[ 5"        FontAwesomeClientsIcon#��[ 6A    � Cursor$
 Hand��6t   	 � ToolTip	 5#      _� 5$      .��5%   "   �� $
��Bold"�6,   $��16(�6>   Clients Page6[   5&      5(      �� 5)      -   5        #��[ 5)        FontAwesomeContractsIcon#��[ 6A   $
 Hand��6u   	 5*      _� 5+      .��5,   "   �� $
��Bold"�6,   $��16(�6>   Contracts Page6]   5-      5/      �� 50      -   5        #��[ 50        FontAwesomeCogIcon#��[ 6B   $
 Hand��6p   	 51      _� 52      .��53   "   �� $
��Bold"�6,   $��16(�6>   CashBox Page6[   54      56      �� 57      -   5        #��[ 57        FontAwesomeAddClientIcon#��[ 6B   $
 Hand��6v   	 58      _� 59      .��5:   "   �� $
��Bold"�6,   $��16(�6>   Add Client Page6^   5;      5=      �� 5>      -   5        #��[ 5>        FontAwesomeChangeUserIcon#��[ 6B   $
 Hand��6w   	 5?      _� 5@      .��5A   "   �� $
��Bold"�6,   $��16(�6>   Change User Page6_   5B      5D      5E      5F      � 5J      $��1��6   $��50��6      WordDarkBlueBrush#��[ 6,   .+�5L      �� $ 
Horizontal=�6    $
��Left=�69   .+�5M      �� -   5         	 IconSearchButton#��[	 5M       
 FontAwesomeBackIcon#��[
 6H   $��10 0 0 0q�6w   6�   5N      5O      � 5S      $��2��6   $��50��6    #��[ 6,   .+�5T      �� 
�������$��0 1 0 0q�6-   ._�5U      �� $ 
Horizontal=�6"   $
��Left=�6;   .+�5V      �� -   5        
 ��Name$
 fromDate��5V   3   $��	From Date��6"   
 � Tag$ 	From Date��6E   $	��200��6U   $��30��6a   $��20(�6m   $��0 0 10 0q�6{   6�   �� 5W      -   5        $
 toDate��5W   1   $��To Date��6"   $ To Date��6A   $	��200��6O   $��30��6[   $��20(�6g   $��0 0 10 0q�6u   6�   �� 5X      -	   5        #��[	 5X   "     FontAwesomeSearchIcon#��[ 6L   6}   5Y      5Z      5[      � 5]      $��3��6   .+�5^      �� $ 
Horizontal=�6   .+�5_      �� -
   5         ��Name$ amount��5_   5   $��Amount Before��6    $ Amount Before��6E   $	��200��6Y   $��30��6e   $��20(�6q   $��0 0 10 0q�6   �� 5`      -   5        $ amountAfter��5`   4   $��Amount After��6    $ Amount After��6I   $	��200��6\   $��30��6h   $��20(�6t   $��0 0 10 0q�6�   5a      5c      �� 5e      $��4��6   � 5f      $��4��6   .+�5i      &   System.Windows.Controls.DataGrid  -   5          Name$ 
myDataGrid��5i      
�������$��0,0,0,10q�6C   $��2��6U      CanUserResizeColumns . $��Stretch=�6�   $��Stretch=�5j         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 62   $��15(�6B      CanUserAddRows .  5l      5m      5n      5q      5r      