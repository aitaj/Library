   M S B A M L   `   `   `  ����L  HLibraryFnlProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:LibraryFnlProject.WindowsLibraryFnlProject.Windows  5   	   /    )LibraryFnlProject.Windows.CustomersWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:LibraryFnlProject.Windows     5   	     � Title$  CustomersWindow��5   	   $	��450��6!   $	��800��6.   .��5	      � .+�5
   
   �� -   5         ��Name$ LblFullname��5
      $��Fullname��6%   $
��Left=�68   $��	36,10,0,0q�6S   $	��Top=�6f   $��27��6~   $	��132��6�   �� 5   
   -   5         ��Name$ TxtFullname��5      $
��Left=�6'   $��	36,42,0,0q�6B   $�� ��6U    �� TextWrapping$
 Wrap=�6]   $	��Top=�6q   $	��120��6�   �� 5   
   -   5        $ 
LblFinCode��5      $��Fin Code��6$   $
��Left=�67   $��	36,96,0,0q�6R   $	��Top=�6e    J� RenderTransformOrigin$ 0.417,1.851&�6}   $��29��6�   $	��120��6�   �� 5   
   -   5        $ 
TxtFinCode��5      $
��Left=�6&   $��
36,130,0,0q�6A   $�� ��6U   $
 Wrap=�6]   $	��Top=�6q   $	��120��6�   �� 5   
   -   5        $ LblPhone��5      $��Phone Number��6"   $
��Left=�69   $��
36,195,0,0q�6T   $	��Top=�6h   $ 0.417,2.869&�6�   $��22��6�   $	��120��6�   �� 5   
   -   5        $ TxtPhone��5      $
��Left=�6$   $��
36,241,0,0q�6?   $�� ��6S   $
 Wrap=�6[   $	��Top=�6o   $	��120��6�   �� 5   
   -   5         ��Name$ BtnAddCustomer��5      $	��Add��6)   $
��Left=�67   $��
36,297,0,0q�6R   $	��Top=�6f   $	��120��6~   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DgvCustomer��5   /      AutoGenerateColumns$ False��6   $��	217,0,0,0q�6D      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Width5  /System.Windows.Controls.DataGridLengthConverter$
	 0.1* 6%   
   Header$
 Id��62   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6>   ��  �� Path$ Id�  5      $
	 0.3* 6%   $
 Fullname��62    6D   �� $ FullName�  5      $
	 0.3* 6%   $
 Fin Code��62    6D   �� $	 Fin�  5      $
	 0.3* 6%   $
 Phone Number��62    6H   �� $ Phone�5      �� 5   
   -	   5        $ 	BtnUpdate��5      $��Update��6$   $
��Left=�65   $y�Hidden=�6P   $��
36,334,0,0q�6d   $	��Top=�6x   $	��120��6�   6�   �� 5   
   -
   5        $ 	BtnDelete��5      $��Delete��6$   $
��Left=�65   $y�Hidden=�6Q   $��
36,297,0,0q�6e   $	��Top=�6y   $	��120��6�   6�   5      5      