   M S B A M L   `   `   `  ����B  >Startup, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Startup.PagesStartup.Pages  5          Startup.Pages.ClientsPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Startup.Pages     5        N� Title$  ClientsPage��5	      .��5      ��    ForegroundLightBrush#��[  6   ._�5   
   � ��5      �� 5       j� TileMode$
 Tile=�6    j� ViewportUnits$ Absolute=�6-    j� Viewport$ 0 0 500 500�6F    �� ImageSource$$ ..\Images\backgroundSignIn.png��6]    �� Opacity$	 0.5Q�6�    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $��* �6    .+�5      � $��0��6   $��75��6      WordLightBlueBrush#��[ 6,   .+�5       �� $��1��6    �� Orientation$ 
Horizontal=�6/   $��Center=�6H   .+�5!      �� -   5          
IconButton#��[ 5!        FontAwesomeClientsIcon#��[ 6A    � Cursor$
 Hand��6t   	 � ToolTip	 5"      _� 5#      .��5$   "   �� $
��Bold"�6,   $��16(�6>   Clients Page6[   5%      5'      �� 5(      -   5        #��[ 5(        FontAwesomeContractsIcon#��[ 6A   $
 Hand��6u   	 5)      _� 5*      .��5+   "   �� $
��Bold"�6,   $��16(�6>   Contracts Page6]   5,      5.      �� 5/      -   5        #��[ 5/        FontAwesomeCogIcon#��[ 6B   $
 Hand��6p   	 50      _� 51      .��52   "   �� $
��Bold"�6,   $��16(�6>   CashBox Page6[   53      55      �� 56      -   5        #��[ 56        FontAwesomeAddClientIcon#��[ 6B   $
 Hand��6v   	 57      _� 58      .��59   "   �� $
��Bold"�6,   $��16(�6>   Add Client Page6^   5:      5<      �� 5=      -   5        #��[ 5=        FontAwesomeChangeUserIcon#��[ 6B   $
 Hand��6w   	 5>      _� 5?      .��5@   "   �� $
��Bold"�6,   $��16(�6>   Change User Page6_   5A      5C      5D      5F      � 5I      $��1��6   $��50��6      WordDarkBlueBrush#��[ 6,   .+�5L      �� $ 
Horizontal=�6   $
��Left=�67   .+�5M      �� -   5        
 ��Name$
 
clientName��5M   1   $��Client Name��6   
 � Tag$ Client Name��6E   $	��200��6W   $��30��6c   $��20(�6o   $��0 0 10 0q�6}   6�   �� 5N      -   5        $
 
personalId��5N   1   $��Personal Id��6   $ Personal ID��6E   $	��200��6W   $��30��6c   $��20(�6o   $��0 0 10 0q�6}   6�   �� 5O      -   5        $

 city��5O   *   $
��City��6   $
 City��68   $	��200��6C   $��30��6O   $��20(�6[   $��0 0 10 0q�6i   6�   �� 5P      -	   5         	 IconSearchButton#��[	 5P       
 FontAwesomeSearchIcon#��[
 6H   6y   5Q      5R      &   System.Windows.Controls.DataGrid  5U      -
   5          Name$ 
myDataGrid��5U   $   $��2��6   
�������$��0,0,0,10q�6L   $��2��6^      CanUserResizeColumns . $��Stretch=�6�   $��Stretch=�5V         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 62   $��15(�6B      CanUserAddRows .  5X      5Y      5Z      5\      