   M S B A M L   `   `   `  ����F  BeBookReader, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:eBookReader.ViewseBookReader.Views  5      #    eBookReader.Views.ProfileView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:eBookReader.Views     5      .��5	      � ���	#FF418FFF.+�5
   
   �� $��	    Hello��6   $
��Left=�6$   $	��Top=�6?   $��92��6W   $��48��6b   $��20(�6n   $��-4,6,0,0q�6|   �� 5   
   -   5          ��Name$  userNameLbl��5      $
��Left=�6%   $	��Top=�6@   $	��301��6X   $��43��6d   $��20(�6p   $��74,6,0,0q�6~   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ BooksDataGrid��5      $��
10,59,10,5q�6*      
IsReadOnly$
 true��6>   $��15(�6y      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 	Book Name��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 500 6U   1  +System.Windows.Controls.DataGridBoundColumn   Binding 68   �� *
BookName+6U     5      $ Author��6%   $ * 6U    65   �� *
BookAuthor+6U   5      �� 5   
   -   5        $��Back To Login��5      $��576,8,10,409q�6)   $��14(�6?   
�������6i   5      5      