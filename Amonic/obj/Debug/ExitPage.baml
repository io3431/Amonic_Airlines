   M S B A M L   `   `   `  ����A  =Amonic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:AmonicAmonic  5          Amonic.ExitPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Amonic     5        N� Title$  ExitPage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��150 �6   �� 5      $��* �6   .+�5   
   ��  �� Orientation$ Vertical=�6   $��20q�6,   $��Center=�68   .+�5      �� -   5        $��helloTextBlock��5      $�� ��6.   $��20(�66   $��0 0 0 20q�6D   $��Center=�6V   6u   �� 5      -   5         ��Name$ timerBtn��5      6)   5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DGridLogout��5         AutoGenerateColumns .     
IsReadOnly . $��1��6V      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$
 Date��6N   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 120 6\   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6%   �� *Date+ �� StringFormat$ d��6j     5      $ 
Login time��6S   $		 120 6g   
 6%   �� *	LoginTime+$ T��6u     5      $ Logout time��6T   $		 120 6i   
 6%   �� *
LogoutTime+$ T��6w     5      $ Time Spent on System��6>   $		 170 6\   
 6%   �� *Time+6j     5      $  Unsuccesfull logout reason��6@   $	 * 6d   
 6%   �� *Reason+6p   5       5!      5"      