   M S B A M L   `   `   `  ����M  IRent a Bicycle App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Rent_a_Bicycle_AppRent_a_Bicycle_App  5   	   *    $Rent_a_Bicycle_App.W_CustomerDetails   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Rent_a_Bicycle_App     5   	   -   5          � Title$  W_CustomerDetails��5   	   $	��520��6#   $	��510��60    � WindowStartupLocation$ CenterScreen=�6<    � Icon$ bicycle_icon.ico��6a   .��5      � ���	#FF314252 � RowDefinitions 5   
   �� 5      $��1 �6   �� 5      $
��120* �6    � ColumnDefinitions 5   
   �� 5      $��1 �6   �� 5      $
��120* �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $
��Left=�6,   $	��Top=�6G   $��1��6_   $��1��6l   ���	#FF1F1E44$��83��6�   $	��100��6�   .+�5      �� $
��Left=�6   $��61��6/   $	��Top=�6;   $��80��6S   $��	10,10,0,0q�6^   $��City Bike Logo.png��6q   $
��Fill=�6�   5      �� 5   
   $ 
Horizontal=�6   $��1��6.   $��1��6;   $��83��6K   $	��Top=�6W   $��	100,0,0,0q�6o   ���	#FF1F1E44.+�5      �� $��Manage Customers��6   $
��Left=�60   $��25(�6K   $
��Bold"�6Y   $��	20,40,0,0q�6k   ���	#FFF9F4F4$	��250��6�   5!      �� 5#   
   $ Vertical=�6   $
��Left=�6,   $��1��6G   $��1��6T   $	��195��6d   $��
15,92,0,10q�6p   .+�5$      �� $
��Wrap=�6   $��Select a Customer��6,   $��12(�6E   
�������$��0,10,0,0q�6m   $��25��6   �� 5%      $
��Wrap=�6   $��Filter by customer name��6,   $
��Left=�6K   $��10(�6f   
�������$��Italic$�6�   �� 5&      $ 
Horizontal=�6   $
��Left=�62   $��35��6M   $��0,05,0,0q�6Y   $	��195��6k   .+�5(      �� -   5        $��Tbx_FilterId_Customer��5(      $
��Left=�67   $	��105��6R   $��14(�6^   $	��0,0q�6l   
���   �6�   �� 5)      $��15(�6T   $
��Bold"�6b   $��24��6t   $
��Wrap=�6   $��Right=�6�   $��Center=�6�   $��5,8,0,7q�6�   ���	#FFFBF9F9��6   �� *Items.Count+ �� ElementName$ Lbx_Customers��6�   �� 5*      -   5         ��Name$ Btn_Del��5*      $��-��6*   $��25��66   $��	0,0,-25,0q�6A      Btn_Ctl#��[  6T    � ToolTip$. (Click to delete a Customer from the list��6�   6�   �� 5+      -   5        $��Btn_Add��5+      $��+��6(   $��25��64   $��35,0,0,0q�6?   #��[  6Q   $! Click to add a new Customer��6~   6�   5-      �� 5/      -   5        	 ��Name$	 Lbx_Customers��5/      $��0,5,0,0q�6-   $	��235��6>   ��50      �� 51      .R�52      �� $	��0,4q�6$   �� 53      �6"   �� *	firstName+ �� 54      $� ��6"    �� 55      �6"   �� *
lastName+�� 56      �� 57      $
��Bold"�6<   �6"   �� *
idNumber+6<    �� 58      $� ��6"    �� 59      $
�zip:��6"    �� 5:      �6"   �� *	zipCode+�� 5;      �� 5<      $
�Tel:��6"    �� 5=      �6"   �� *	telephone+5>      5?      5A      5F      �� 5H   
   $ Vertical=�6   $��1��6,   $��1��69   $
��Left=�6I   $	��250��6d   $��235,126,0,69q�6p   
 � DataContext
 6�   �� $ Lbx_Customers�� �� Path$ SelectedItem�.+�5J      � $��Stretch=�6   $��0,0,5,25q�61   .+�5K      �� $��Center=�62   $��18(�6O   $
��Bold"�6]   ���	#FFFDF9F9��6   �� *name+6o   5L      �� 5N      $ 
Horizontal=�6   $	��0,5q�62   .+�5O      �� $
��Wrap=�6   $��Customer Id��60   $��95��6C   ���	#FFFDF9F9$��12(�6e   �� 5P       �� TextWrapping$
 Wrap=�66   $	��145��6J   $��14(�6V   ��6   �� *
customerId+6V   5Q      �� 5S      $ 
Horizontal=�6   $	��0,5q�62   .+�5T      �� $
��Wrap=�6   $��
First Name��60   $��95��6B   ���	#FFFDF9F9$��12(�6d   �� 5U      $
 Wrap=�65   $	��145��6I   $��14(�6U   ��6   �� *	firstName+6U   5V      �� 5X      $ 
Horizontal=�6   $	��0,5q�62   .+�5Y      �� $
��Wrap=�6   $��	Last Name��60   $��95��6A   ���	#FFFDF9F96L   �� 5Z      $
 Wrap=�64   $	��145��6H   $��14(�6T   ��6   �� *
lastName+6T   5[      �� 5]      $ 
Horizontal=�6   $	��0,5q�62   .+�5^      �� $
��Wrap=�6   $��	Telephone��60   $��95��6A   ���	#FFFDF9F96L   �� 5_      $
 Wrap=�65   $	��145��6I   $��14(�6U   ��6   �� *	telephone+6U   5a      �� 5c      $ 
Horizontal=�6   $	��0,5q�62   .+�5d      �� $
��Wrap=�6   $��I.D. Number��60   $��95��6C   ���	#FFFDF9F96N   �� 5e      $
 Wrap=�64   $	��145��6H   $��14(�6T   ��6   �� *
idNumber+6T   5f      �� 5h      $ 
Horizontal=�6   $	��0,5q�62   .+�5i      �� $
��Wrap=�6   $��Zip Code��60   $��95��6@   ���	#FFFDF9F96K   �� 5j      $
 Wrap=�63   $	��145��6G   $��14(�6S   ��6   �� *	zipCode+6S   5l      5o      5r      5s      