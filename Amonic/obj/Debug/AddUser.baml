   M S B A M L   `   `   `  ����A  =Amonic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:AmonicAmonic  5   	       Amonic.AddUser   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Amonic     5   	     � Title$  Add User��5   	   $	��500��6   $	��400��6*   $	��500��69   $	��400��6I    � WindowStyle$
 None=�5	   	   .��5
      �  � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� $��Email��6   $��Right=�6!   $��Center=�6=   $��0 0 10 0q�6X   6l   �� 5   
   $��
First name��6   $��1��6&   $��Right=�63   $��Center=�6O   $��0 0 10 0q�6j   6~   �� 5   
   $��	Last name��6   $��2��6%   $��Right=�62   $��Center=�6N   $��0 0 10 0q�6i   6}   �� 5   
   $��Office��6   $��3��6"   $��Right=�6/   $��Center=�6K   $��0 0 10 0q�6f   6z   �� 5   
   $��	Birthdate��6   $��4��6%   $��Right=�62   $��Center=�6N   $��0 0 10 0q�6i   6}   �� 5   
   $��Password��6   $��5��6$   $��Right=�61   $��Center=�6M   $��0 0 10 0q�6h   6|   �� 5    
   $
��Role��6   $��6��6    $��Right=�6-   $��Center=�6I   $��0 0 10 0q�6d   6x   �� 5"   
   $��1��6)   $	��220��69   ��6   �� *Email+6G   �� 5#   
   $��1��6-   $��1��6:   $	��220��6J   ��6   �� *	FirstName+6J   �� 5$   
   $��2��6,   $��1��69   $	��220��6I   ��6   �� *
LastName+6I   �� 5%   
   -   5         ��Name$ ComboOffice��5%   4    �� DisplayMemberPath$ Title��6I   $��3��6c   $��1��6p   $	��220��6�    �� SelectedItem 6   �� *	Offices+6�   (  "System.Windows.Controls.DatePicker  5&   
   $��4��68   $��1��6E   $��Center=�6U   $
��Left=�6p   $��0q�6�   $	��230��6�      SelectedDate 6   �� *	Birthdate+6�   �� 5'   
   $��5��6,   $��1��69   $	��220��6I   ��6   �� *
Password+6I   �� 5(   
   -   5        $ 
ComboRoles��5(   2   $ Title��6F   $��6��6`   $��1��6m   $	��220��6}    6   �� *Roles+6}   �� 5*   
   -   5         ��Name$ ApplyBtn��5*      $��Apply��6#   $��2��63   $��7��6G   $
��Left=�6T   $��20 0 0 0q�6o   6�   �� 5+   
   -   5        $ 	CancelBtn��5+      $��Cancel��6$   $��2��65   $��7��6I   $��Right=�6V   $��0 0 20 0q�6r   6�   5,      5-      