   M S B A M L   `   `   `  ����H  DDesktopAWSGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:DesktopAWSGUI.ViewsDesktopAWSGUI.Views  5      +    %DesktopAWSGUI.Views.OperateBucketView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:DesktopAWSGUI.Views     5      $	��600��5      $	��812��6,   .��5      � 
�������$��	0,0,0,-98q�6   .+�5	   
   �� -   5          ��Name$  
bucketCBox��5	      $
��Left=�6'   $��
157,26,0,0q�6B   $	��Top=�6V   $	��433��6n   $��47��6z   $��20(�6�   6�   �� 5
   
   $��Bucket��6   $
��Left=�6!   $��	68,26,0,0q�6<   $	��Top=�6O   $��25(�6g    J� RenderTransformOrigin$ 
0.84,0.375&�6u   �� 5   
   $
��File��6   $
��Left=�6   $��	68,88,0,0q�6:   $	��Top=�6M   $��25(�6e   $ 
0.84,0.375&�6s   �� 5   
   -   5        $��Choose File��5      $
��Left=�6'   $��
604,88,0,0q�6B   $	��Top=�6V   $	��154��6n   $��47��6z   $��25(�6�   6�   �� 5   
   -   5        $��Upload��5      $
��Left=�6"   $��604,151,0,0q�6=   $	��Top=�6R   $	��154��6j   $��47��6v   $��25(�6�   6�   �� 5   
   -   5        $��Back To Main��5      $
��Left=�6(   $��604,355,0,0q�6C   $	��Top=�6X   $	��154��6p   $��47��6|   $��25(�6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ fileInfo��5      $
��Left=�6%   $	��251��6@   $��
42,151,0,0q�6M   $	��Top=�6a   $	��548��6y      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 360 6%      Header$ 	File Name��61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5      �� *
FileName+  5      $ * 6%   $ 	File Size��6/    5      �� *
FileSize+5      �� 5   
   -   5         ��Name$ fileNameTBox��5      $
��Left=�6(   $��47��6C   $��
157,88,0,0q�6O    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��433��6�   $��20(�6�   �� 5   
   $��0,0,10,0q�6?   ��6   �� *CurrentViewModel+6?   5      5      