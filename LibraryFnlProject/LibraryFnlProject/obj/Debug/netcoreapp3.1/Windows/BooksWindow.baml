   M S B A M L   `   `   `  ����L  HLibraryFnlProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:LibraryFnlProject.WindowsLibraryFnlProject.Windows  5   	   +    %LibraryFnlProject.Windows.BooksWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:LibraryFnlProject.Windows     5   	     � Title$  BooksWindow��5   	   $	��450��6   $	��800��6*   .��5	      � -   5         �Name$ NoName��5	      $��
0,16,0,-16q�6    � ColumnDefinitions 5
   
   �� 5      $	��41* �6   �� 5      $
��119* �6   .+�5   
   �� -   5         ��Name$ LblBookName��5      $��Enter name of the book��6%   $��Center=�6F   $��0,10,0,0q�6c   $	��Top=�6u   $��29��6�   $	��142��6�    J� RenderTransformOrigin$ 0.408,-0.431&�6�   �� 5   
   -   5         ��Name$ TxtBookName��5      $��Center=�6'   $��0,39,0,0q�6D   $�� ��6V    �� TextWrapping$
 Wrap=�6^   $	��Top=�6r   $	��142��6�   $��29��6�   $ 0.491,-0.361&�6�   �� 5   
   -   5        $ 
LblArticle��5      $��Enter Article of the book��6$   $��Center=�6H   $��0,73,0,0q�6e   $	��Top=�6w   $ 0.533,1.852&�6�   $��25��6�   $	��142��6�   �� 5   
   -   5        $ 
TxtArticle��5      $��Center=�6&   $��	0,103,0,0q�6C   $�� ��6V   $
 Wrap=�6^   $	��Top=�6r   $	��142��6�   $��32��6�   $ 0.482,-0.894&�6�   �� 5   
   -   5        $ LblPrice��5      $��Enter price of the book��6"   $��Center=�6D   $��	0,140,0,0q�6a   $	��Top=�6t   $ 0.581,2.559&�6�   $��24��6�   $	��142��6�   �� 5   
   -   5        $ TxtPrice��5      $��Center=�6$   $��	0,164,0,0q�6A   $�� ��6T   $
 Wrap=�6\   $	��Top=�6p   $	��142��6�   $��30��6�   $ 0.433,-1.479&�6�   �� 5   
   -   5        $ LblBookCathegory��5      $&�� Choose Cathegory                ��6*   $��Center=�5      $��Center=�6/   $ 0.593,2.182&�6J   $��23��6n   $	��142��6z   �� 5   
   -	   5        $ LblBookShelf��5      $��Enter number of the shelf��6&   $��Center=�6J   $��	0,259,0,0q�6g   $	��Top=�6z   $��31��6�   $	��142��6�   �� 5   
   -
   5        $ TxtBookShelf��5      $��Center=�6(   $��	0,290,0,0q�6E   $�� ��6X   $
 Wrap=�6`   $	��Top=�6t   $	��142��6�   $��30��6�   �� 5   
   -   5         ��Name$ 
BtnAddBook��5      $��Add Book��6%   $��Center=�68   $��	0,325,0,0q�6U   $	��Top=�6h   $	��142��6�   $��39��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ DgvBook��5      $��
1,-19,0,29q�6$   	   CanUserAddRows$	 False��68   
   AutoGenerateColumns$
 False��6O   $��1��6k      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 0.10* 6%      Header$ Id��63   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6?   �� *Id+  5      $
 0.2* 6&   $
 Name��63    6A   �� *Name+  5       $ 0.20* 6%   $ Article��63    6D   �� *	Article+  5!      $ 0.20* 6&   $ Price��64    6C   �� *Price+  5"      $ 0.20* 6%   $ 	Cathegory��63    6F   �� *	Cathegory+  5#      $ 0.05* 6&   $ 	BookShelf��64    6G   �� *	BookShelf+5%      �� 5&   
   -   5         ��Name$ CmbBookCathegory��5&      $��Center=�6-   $��	0,229,0,0q�6J   $	��Top=�6]   $	��142��6u    �� DisplayMemberPath$
 Name��5(       �� SelectedValuePath$ Id��5)      �� 5+   
   -   5        $ BtnBookUpdate��5+      $��Update��6(   $
��Left=�69   $��
27,348,0,0q�6T   $	��Top=�6h   $y�Hidden=�6�   $ 0.517,1.751&�6�   $	��147��6�   6�   �� 5,   
   -   5        $ BtnBookDelete��5,      $��Delete��6(   $y�Hidden=�69   $��Center=�6M   $��	0,369,0,0q�6j   $	��Top=�6}   $ 0.583,1.951&�6�   $��36��6�   $	��142��6�   6�   5.      5/      