   M S B A M L   `   `   `  ����M  IRent a Bicycle App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Rent_a_Bicycle_AppRent_a_Bicycle_App  5   	   #    Rent_a_Bicycle_App.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Rent_a_Bicycle_App     5   	     � Title$  Rent a Bicycle App��5   	   $	��450��6$   $	��500��61    � WindowStartupLocation$ CenterScreen=�6=    � Icon$ bicycle_icon.ico��6b   .��5	      �  � RowDefinitions 5
   
   �� 5      $��1 �6   �� 5      $
��120* �6    � ColumnDefinitions 5   
   �� 5      $��1 �6   �� 5      $
��120* �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $
��Left=�6,   $	��Top=�6G   $��1��6_   $��1��6l   ���	#FF1F1E44$	��418��6�   $	��103��6�   .+�5      �� $
��Left=�6   $��61��6/   $	��Top=�6;   $��80��6S   $��	10,10,0,0q�6^   $��City Bike Logo.png��6q   $
��Fill=�6�   �� 5      -   5        $��To Rent��5      $��14(�6'   $
��Bold"�65   $
��Left=�6G   $	��Top=�6b   $��84��6z   $��	10,60,0,0q�6�   $��34��6�   ���	#FF2B2128���	#FF13010F���	#FFF9F2F26�   �� 5      -   5        $��	To Return��5      $��14(�6)   $
��Bold"�67   $
��Left=�6I   $	��Top=�6d   $��84��6|   $��	10,60,0,0q�6�   $��34��6�   ���	#FF2B2128���	#FF13010F���	#FFF9F2F26�   �� 5      -   5        $��	Customers��5      $��14(�6)   $
��Bold"�67   $
��Left=�6I   $	��Top=�6d   $��84��6|   $��	10,70,0,0q�6�   $��34��6�   ���	#FF2B2128���	#FF13010F���	#FFF9F2F26�   5      �� 5   
   $��1��6   $��	100,0,0,0q�6%   $��1��68   ���	#FF314252.+�5      �� $ Vertical=�6   $	��110��60   $��55,100,20,0q�6=   .+�5      �� -   5        $��Tbk_Time��5      $
��Wrap=�6,   $��10.10��6@   $��40(�6M   $
��Bold"�6[   
�������$��Center=�6�   �� 5      $ 
Horizontal=�6   $��Center=�66   $��45��6S   $��Center=�6_   $	��253��6z   $��	40,0,10,0q�6�   .+�5      �� -   5         ��Name$ Tbk_Day��5       $
��Wrap=�61   $	��Thu��6E   $��28(�6P   
�������$��Center=�6x   $��Center=�6�   $��0,4,0,3q�6�   $��Italic$�6�   $��61��6�   �� 5       -   5        $ Tbk_Date��5        $
��Wrap=�62   $��Apr 26, 2020��6F   $��25(�6Z   
�������$��Center=�6�   $��Center=�6�   $	��5,6q�6�   $	��160��6�   5!      5$      5%      5'      5(      