   M S B A M L   `   `   `  ����P  LAssetManagementVishwa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:AssetManagementVishwa.ViewAssetManagementVishwa.View  5   	   c6clr-namespace:AssetManagementVishwa.View.CustomControl(AssetManagementVishwa.View.CustomControl  5   	   *    $AssetManagementVishwa.View.Landing_v   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   4local(clr-namespace:AssetManagementVishwa.View  5   	   Cnavpos6clr-namespace:AssetManagementVishwa.View.CustomControl  5   	   -   5          � Title$  Landing��5
   	   $	��768��6   $
��1366��6&    � WindowStyle$ SingleBorderWindow=�63    � WindowStartupLocation$ CenterScreen=�6T    � WindowState$ 	Maximized=�5   	   
�������.��5      � .+�5   
   �  � ColumnDefinitions 5      �� 5      $
��0.7* �6#   �� 5      $	��15* �6#    � RowDefinitions 5      �� 5      $��0.05* �6    �� 5      $��* �6     � 	Resources 5      '  !MaterialDesignThemes.Wpf.PackIcon �� 
TargetType �� Property	 �� Value��%�   '        �� 5      "  6   .�5      ��  � ��$	 40��6.   6;   �� 5       � ��$	 40��6/   6<   5      5      .+�5      � $��1��6   $��0��6    
�������60   � 5      $��0��6   $��1��6#   $��Center=�60   
�������.+�5"      �� -   5        
 ��Name$
 sidebar��5"   �   $��0��6   $	��Top=�6*   $��Center=�6B    �� SelectionMode$ Single=�6_   $
��0 70q�6�   $��0q�6�   .@�5$      8   2AssetManagementVishwa.View.CustomControl.NavButton  -   5          Name$ btnnn��5$   '      Navlink$! View/Pages/Dashboard_p.xaml?�66    '  #MaterialDesignNavigationListBoxItem#��[  6\   $��0 q�6�   $��0q�6�   .��5%           Kind$
 Home=�62    � Cursor$
 Hand��6>   5&        5'      $  View/Pages/NewEntry_p.xaml?�6'   #��[  6L   $	��0 5q�6�   $��0q�6�   .��5(        $	 Add=�62   $
 Hand��6=   5)        5*      $# View/Pages/UpdateEntry_p.xaml?�6'   #��[  6O   $	��0 0q�6�   $��0q�6�   .��5+        $
 Edit=�62   $
 Hand��6>   5,        5-      $ View/Pages/Audit_p.xaml?�6'   #��[  6I   $	��0 5q�6�   $��0q�6�   .��5.        $ History=�62   $
 Hand��6A   5/        50      $ View/Pages/Report_p.xaml?�6'   #��[  6J   $	��0 0q�6�   $��0q�6�   .��51        $ Report=�62   $
 Hand��6@   52      53      54       � 55      -   5          �Name$ navframe��55   1   $��1��6   $��1��6$     � NavigationUIVisibility$ Hidden=�6C   
�������6c   � 56      $��0��6   $��0��6    
�������60   � 57      $��0��6   $��1��6    
�������59      5=      5A      5X      