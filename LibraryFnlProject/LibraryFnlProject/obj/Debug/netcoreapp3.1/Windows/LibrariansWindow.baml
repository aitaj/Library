   M S B A M L   `   `   `  ����L  HLibraryFnlProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:LibraryFnlProject.WindowsLibraryFnlProject.Windows  5   	   0    *LibraryFnlProject.Windows.LibrariansWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:LibraryFnlProject.Windows     5   	     � Title$  LibrariansWindow��5   	   $	��450��6"   $	��800��6/   .��5	      � $��10,0,0,0q�6   .+�5
   
   �� -   5         ��Name$ LblLibrarianFullname��5
      $��Fullname��6.   $
��Left=�6A   $��	36,10,0,0q�6\   $	��Top=�6o   $��27��6�   $	��132��6�   �� 5   
   -   5         ��Name$ TxtLibrarianFullname��5      $
��Left=�60   $��	36,42,0,0q�6K   $�� ��6^    �� TextWrapping$
 Wrap=�6f   $	��Top=�6z   $	��120��6�   �� 5   
   -   5        $ LblLibrarianUsername��5      $��Username��6.   $
��Left=�6A   $��	36,96,0,0q�6\   $	��Top=�6o    J� RenderTransformOrigin$ 0.417,1.851&�6�   $��29��6�   $	��120��6�   �� 5   
   -   5        $ TxtLibrarianUsername��5      $
��Left=�60   $��
36,130,0,0q�6K   $�� ��6_   $
 Wrap=�6g   $	��Top=�6{   $	��120��6�   �� 5   
   -   5        $ LblLibrarianPassword��5      $��Password��6.   $
��Left=�6A   $��
36,195,0,0q�6\   $	��Top=�6p   $ 0.417,2.869&�6�   $��22��6�   $	��120��6�   �� 5   
   -   5        $ TxtLibrarianPassword��5      $
��Left=�60   $��
36,241,0,0q�6K   $�� ��6_   $
 Wrap=�6g   $	��Top=�6{   $	��120��6�   �� 5   
   -   5         ��Name$ BtnAddLibrarian��5      $	��Add��6*   $��Right=�68   $��0,297,644,0q�6T   $	��Top=�6i   $	��120��6�   6�   �� 5   
   -   5        $ BtnUpdateLibrarian��5      $y�Hidden=�6-   $��Update��6A   $
��Left=�6R   $��
36,334,0,0q�6m   $	��Top=�6�   $	��120��6�   6�   �� 5   
   -	   5        $ BtnDeleteLibrarian��5      $y�Hidden=�6.   $��Delete��6B   $
��Left=�6S   $��
36,297,0,0q�6n   $	��Top=�6�   $	��120��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -
   5          Name$ DgvLibrarian��5   /      AutoGenerateColumns$ False��6   $��	173,0,0,0q�6E      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 0.25* 6%   
   Header$
 Id��63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   ��  �� Path$ Id�  5      $	 0.25* 6&   $
 Fullname��64    6F   �� $ FullName�  5      $	 0.25* 6&   $
 Username��64    6F   �� $ UserName�  5      $	 0.25* 6&   $
 Password��64    6F   �� $ Password�5      5      5      