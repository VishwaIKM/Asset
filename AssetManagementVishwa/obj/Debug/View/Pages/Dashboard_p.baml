   M S B A M L   `   `   `  ����P  LAssetManagementVishwa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:AssetManagementVishwa.View.Pages AssetManagementVishwa.View.Pages  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 5      Q-clr-namespace:AssetManagementVishwa.ViewModelAssetManagementVishwa.ViewModel  5	      2    ,AssetManagementVishwa.View.Pages.Dashboard_p   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      :local.clr-namespace:AssetManagementVishwa.View.Pages  5      >lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  5      ?Dashboardvm-clr-namespace:AssetManagementVishwa.ViewModel  5	        N� 
Background  �#f2e7e6 N� Title$ 	Dashboard��5       � DataContext 5      2  ,AssetManagementVishwa.ViewModel.Dashboard_vm  5   
   .��5      � .+�5   
   �� .��5      �  � RowDefinitions 5      �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$   �� 5      $��1* �6$    � ColumnDefinitions 5      �� 5      $��1* �6'   �� 5      $��1* �6'   �� 5      $��1* �6'   �� 5       $��1* �6'   �� 5!      $��1* �6'   .+�5%      �� $��7q�6   
������� �� RadiusX$ 10��64    �� RadiusY$ 10��6A   � 5&      $
��15 8q�6   .+�5'      � $��40��6   $��70��6&   
�������$
��Left=�6T   $	��Top=�6o    J� Effect 5(      3  -System.Windows.Media.Effects.DropShadowEffect  5)         
BlurRadius$ 20Q�6/   	   Color$	 	#FFEAE4E4��6?   .+�5+      '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$
 Server=�62   $��Bottom=�6@   $��Center=�6[   
�������6x   5,      �� 5-      $��Total Server��6    $��Right=�64   $��18(�6P   $��Italic$�6^   �� 5.      $��12��6    $��Right=�6*   $��Bottom=�6F   $��33(�6a   $��Italic$�6o   5/      � 52      $��1��6   $��0��6'   .+�53      �� $��7q�6    
�������$ 10��68   $ 10��6E   � 54      $
��15 8q�6   .+�55      � $��40��6   $��70��6*   
����ح�$
��Left=�6M   $	��Top=�6h    56        57   "   $ 20Q�63   $	 	#FFEAE4E4��6C   .+�59        $
 DesktopWindows=�66   $��Bottom=�6L   $��Center=�6g   
�������6�   5:      �� 5;      $��Total Desktop��6$   $��Right=�69   $��18(�6U   $��Italic$�6c   �� 5<      $	��155��6$   $��Right=�6/   $��Bottom=�6K   $��33(�6f   $��Italic$�6t   5=      5>      � 5A      $��2��6   $��0��6'   .+�5B      �� $��7q�6    
�������$ 10��68   $ 10��6E   � 5C      $
��15 8q�6   .+�5D      � $��40��6   $��70��6*   
����·�$
��Left=�6P   $	��Top=�6k    5E        5F   "   $ 20Q�63   $	 	#FFEAE4E4��6C   .+�5H        $
 ReceiptPending=�66   $��Bottom=�6L   $��Center=�6g   
�������6�   5I      �� 5J      $��Pending Request��6$   $��Right=�6;   $��18(�6W   $��Italic$�6e   �� 5K      $��1��6$   $��Right=�6-   $��Bottom=�6I   $��33(�6d   $��Italic$�6r   
���  ��6�   5L      5M      � 5P      $��3��6   $��0��6'   .+�5Q      �� $��7q�6    
�������$ 10��68   $ 10��6E   � 5R      $
��15 8q�6   .+�5S      � $��40��6   $��70��6*   
�������$
��Left=�6N   $	��Top=�6i    5T        5U   "   $ 20Q�63   $	 	#FFEAE4E4��6C   .+�5W        $
 RemoteDesktop=�66   $��Bottom=�6K   $��Center=�6f   
�������6�   5X      �� 5Y      $��Assigned Desktop��6$   $��Right=�6<   $��18(�6X   $��Italic$�6f   �� 5Z      $��11��6$   $��Right=�6.   $��Bottom=�6J   $��33(�6e   $��Italic$�6s   
���   �6�   5[      5\      � 5_      $��4��6   $��0��6'   .+�5`      �� $��7q�6    
�������$ 10��68   $ 10��6E   � 5a      $
��15 8q�6   .+�5b      � $��40��6   $��70��6*   ���	#FF52A70F$
��Left=�6M   $	��Top=�6h    5c        5d   "   $ 20Q�63   $	 	#FFEAE4E4��6C   .+�5f        $
 DesktopTowerMonitor=�66   $��Bottom=�6Q   $��Center=�6l   
�������6�   5g      �� 5h      $��Available Desktop��6$   $��Right=�6=   $��18(�6Y   $��Italic$�6g   �� 5i      $��11��6$   $��Right=�6.   $��Bottom=�6J   $��33(�6e   $��Italic$�6s   
��� � �6�   5j      5k      � 5m      $��0��6   $��2��6'   $��2��64   $��2��6E   .+�5o        LiveCharts.Wpf.PieChart  -   5        $��7q�5o   #   &   LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$ Bottom=�6.      	Hoverable .     Series 5q        LiveCharts.Wpf.PieSeries    LiveCharts.Wpf.Series   Title$ 
Windows 11��6,      Values;  5LiveCharts.Wpf.Converters.NumericChartValuesConverter$ 3 6?      
DataLabels . 6J     5s      $ 
Windows 10��6,   $ 4 6?    . 6J     5u      $ 	Windows 7��6,   $ 6 6>    . 6I     5w      $ Linux��6,   $ 5 6:    . 6E   5z      �� 5{      $��Runing OS Chart��6    $��Right=�67   $	��Top=�6S   $��14(�6k   $��Italic$�6y   5|      5�      5�      5�      5�      