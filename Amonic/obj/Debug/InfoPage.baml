   M S B A M L   `   `   `  ����A  =Amonic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:AmonicAmonic  5          Amonic.InfoPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Amonic     5        N� Title$  InfoPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $��* �6   �� 5      $��80 �6   .+�5   
   �� $
��Left=�6   $��Center=�60    �� Orientation$ 
Horizontal=�6K   $��20 0 0 0q�6d   .+�5      �� $��Office:��6   $��0 0 20 0q�6'   $��16(�69   $��Center=�6G   6d   �� 5      -   5         ��Name$ SelectOffice��5   #   $	��220��6    �� DisplayMemberPath$ Title��6j    �� SelectedIndex$ 0��6�   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 	DGridUser��5         AutoGenerateColumns .     
IsReadOnly . $��1��6T   	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Header$

 Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6Q   1  +System.Windows.Controls.DataGridBoundColumn   Binding 63   �� *	FirstName+6_     5      $
 	Last Name��6%   $	 120 6U    68   �� *
LastName+6c     5      $
 	Birthdate��6%   $	 140 6f    68   �� *	Birthdate+ �� StringFormat$ d��6t     5      $
 	User Role��6%   $	 150 6X    68   �� *Roles.Title+6f     5      $
 Email Adress��6%   $ * 6U    6;   �� *Email+6a     5      $
 Office��6%   $	 120 6W    65   �� *Offices.Title+6e   5!      �� 5"   
   $��2��6   $ 
Horizontal=�6"   $��Center=�6;   $
��Left=�6V   $��40 0 0 0q�6q   .+�5#      �� -   5         ��Name$ 	ChangeBtn��5#      $��Change Role��6(   $��0 0 40 0q�6>   6j   �� 5$      -   5        $ Disable��5$      $��Enable/Disable Login��6&   $	��200��6E   $��	0 0 200 0q�6Q   6|   5%      �� 5&   
   -   5        $ Reload��5&   :   $��2��6   $��Right=�6   $��Reload��6J   $��0 0 30 0q�6p   6�   5'      5(      