   M S B A M L   `   `   `  ����H  DDesktopAWSGUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:DesktopAWSGUI.ViewsDesktopAWSGUI.Views  5      C&clr-namespace:DesktopAWSGUI.ViewModelsDesktopAWSGUI.ViewModels  5      *    $DesktopAWSGUI.Views.CreateBucketView   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:DesktopAWSGUI.Views     5      =
viewmodels&clr-namespace:DesktopAWSGUI.ViewModels     5      $	��812��5	   #     � 	Resources  5
       �� DataType5  /DesktopAWSGUI.ViewModels.OperateBucketViewModel+   %DesktopAWSGUI.Views.OperateBucketView � DataContext��%q   (��       5   8   *, +)�� 6
   bucketOperationTemplate��"  68   .R�5         6&   �� 5      5      .��5      � 
�������$��	0,0,0,-98q�6   .+�5   
   �� -   5        $��Create Bucket��5      $
��Left=�6)   $��
591,21,0,0q�6D   $	��Top=�6X   $��26��6p   $	��199��6|   $��15(�6�   6�   �� 5   
   -   5        $��	bNameTBox��5      $
��Left=�6$   $��
175,21,0,0q�6?    �� TextWrapping$
 Wrap=�6S   $	��Top=�6g   $	��379��6   $��26��6�   $��15(�6�   �� 5   
   $��Bucket Name:��6   $
��Left=�6'   $��	40,16,0,0q�6B   $	��Top=�6U   $��31��6m   $��98��6y   $��15(�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
bucketInfo��5      $��40,65,40,333q�6'      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$	 360 6%      Header$ Bucket Name��61   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5      �� *
BucketName+  5      $ * 6%   $ Creation Date��6/    5      �� *
BucketDate+5      �� 5   
   -   5        $��Back To Main Menu��5      $��Center=�6-   $��296,390,258,0q�6J   $	��Top=�6a   $��32��6y   $	��258��6�   $��15(�6�   6�   �� 5   
   $K��EBucket Name must not contain any uppercase characters and whitespaces��6   $
��Left=�6`   $��
175,43,0,0q�6{   $	��Top=�6�   $��9(�6�   ���	#FF9433CB6�   �� 5   
   $��0,0,10,0q�6?   ��6   �� *CurrentViewModel+6?   5       5!      