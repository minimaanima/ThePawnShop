   M S B A M L   `   `   `  ����B  >Startup, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Startup.PagesStartup.Pages  5      !    Startup.Pages.ContractsPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Startup.Pages     5        N� Title$  ContractsPage��5	      .��5      ��    ForegroundLightBrush#��[  6   ._�5   
   � ��5      �� 5       j� TileMode$
 Tile=�6    j� ViewportUnits$ Absolute=�6-    j� Viewport$ 0 0 500 500�6F    �� ImageSource$$ ..\Images\backgroundSignIn.png��6]    �� Opacity$	 0.5Q�6�    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $��* �6    .+�5      � $��0��6   $��75��6      WordLightBlueBrush#��[ 6,   .+�5      �� $��1��6    �� Orientation$ 
Horizontal=�6/   $��Center=�6H   .+�5      �� -   5          
IconButton#��[ 5        FontAwesomeClientsIcon#��[ 6A    � Cursor$
 Hand��6t   	 � ToolTip	 5       _� 5!      .��5"   "   �� $
��Bold"�6,   $��16(�6>   Clients Page6[   5#      5%      �� 5&      -   5        #��[ 5&        FontAwesomeContractsIcon#��[ 6A   $
 Hand��6u   	 5'      _� 5(      .��5)   "   �� $
��Bold"�6,   $��16(�6>   Contracts Page6]   5*      5,      �� 5-      -   5        #��[ 5-        FontAwesomeCogIcon#��[ 6B   $
 Hand��6p   	 5.      _� 5/      .��50   "   �� $
��Bold"�6,   $��16(�6>   CashBox Page6[   51      53      �� 54      -   5        #��[ 54        FontAwesomeAddClientIcon#��[ 6B   $
 Hand��6v   	 55      _� 56      .��57   "   �� $
��Bold"�6,   $��16(�6>   Add Client Page6^   58      5:      �� 5;      -   5        #��[ 5;        FontAwesomeChangeUserIcon#��[ 6B   $
 Hand��6w   	 5<      _� 5=      .��5>   "   �� $
��Bold"�6,   $��16(�6>   Change User Page6_   5?      5A      5B      5C      � 5E      $��1��6   $��50��6      WordDarkBlueBrush#��[ 6,   .+�5H      �� $ 
Horizontal=�6   $��Center=�67   .+�5I      �� -   5         "	 rectangleNavigationWhiteButton#��[	 5I      $��Saled��6V   $��80��6f   6q   �� 5J      -   5        #��[	 5J      $��Active��6V   $��80��6g   6r   �� 5K      -   5        #��[	 5K      $��Ended��6V   $��80��6f   6q   �� 5L      -	   5        #��[	 5L      $��	Overtimed��6V   $��80��6j   6u   �� 5M      -
   5        #��[	 5M      $	��New��6V   $��80��6d   6o   5N      5O      &   System.Windows.Controls.DataGrid  5R      -   5        
  Name$
 
myDataGrid��5R   $   $��2��6   
�������$��0,0,0,10q�6K   $��2��6]      CanUserResizeColumns . $��Stretch=�6�   $��Stretch=�5S         ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 62      SelectionMode$ Single=�6B   $��15(�6Y      CanUserAddRows .  5U      5W      5Y      5Z      