   M S B A M L   `   `   `  ����A  =Sports, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Sports.ViewSports.View  5          Sports.View.ClassView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Sports.View     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � DataContext  5	      ��    Locator �� Source# [   �� Path$ _Class�.��5      �  � RowDefinitions 5   
   �� 5      $	�� 50 �6   �� 5      $��9* �6   �� 5      $	��31* �6   .+�5   
   �� 
������� �� Orientation$ 
Horizontal=�6/   .+�5      �� $��🏚️ ��6   $��23(�6$   $
��Left=�62   $��Center=�6M   6j   �� 5      $��23(�6   $
��Left=�6&   $��Center=�6A   �� 6]   $�首页>��6a   �� 6q    � Language$ zh-cn�6u   $� 裁判��6�   �� 6�   $�报名��6�   6�   5      � 5   
   $��1��6    5      �� 5      $	��30  �6    �� 5      .+�5      �� 
�������._�5      �� $��添加数据��6   $��Center=�6(   $��18(�6C   6S   5      �� 5       $��1��6   $ 
Horizontal=�6&   .+�5!      �� $��Center=�6   $��20(�67   ID:6J   �� 5"      -   5        $��80��5"      $��20��6%   $��10q�61   $��Center=�6=    �� IsInputMethodEnabled .  ��5&      �� *_ClassTable.ClassID+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6r   �� 5'      $��Center=�6   $��20(�67   
班级名:6L   �� 5(      $��80��6   $��27��6)   $��10q�65   $��Center=�6A   ��6\   �� *_ClassTable.ClassName+$ TwoWay=�$ PropertyChanged=�6�   �� 5)      $��Center=�6   $
��Left=�67   $��20(�6N   最大报名值6d   �� 5*      -   5         .  $��10q�5+   M   $��24��6�   $	��100��6�   ��6Z   �� *_ClassTable.ClassSize+$ TwoWay=�$ PropertyChanged=�6�   �� 5,      $��60��6   ��6$   �� *
AddCommand+��6C   �� 	 �� RelativeSource	 �� 
 �� Mode$
 FindAncestor=� �� AncestorType$ local:RefereeViewL�.��6�   添加6�   5-      5.      � 5/   
   $��2��6   .+�51      &   System.Windows.Controls.DataGrid     
IsReadOnly .    AutoGenerateColumns .  ��6*   �� *ClassTables+   Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *	ClassID+  54      $ 名称��6)    65   �� *	ClassName+  56      $ 人数��6)    65   �� *	ClassSize+4  .System.Windows.Controls.DataGridTemplateColumn  5<      $ change��6.      CellTemplate 5=      �� 5>      .R�5?   "   �� $ 
Horizontal=�6-   .+�5@   &   �� $��分配��6-   
���������5A   +   �� 	 �� $

 Self=���5B   +   �� 	 �� $
 FindAncestor=�$ local:ClassViewL�$ DataContext.ChangeCommand�
 � Tag 5C   ,   �� 6?   �� 5D   &   $��删除��6-   
������� � Cursor$  ��5G   <   ��5E   /   �� 	 �� $

 Self=���5F   +   �� 	 �� $
 FindAncestor=�$ local:ClassViewL�$ DataContext.DeleCommand� 5G   ,   �� 6H   5H   #   5I      5K      5M      5P      5Q      5R      