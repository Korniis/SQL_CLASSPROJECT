   M S B A M L   `   `   `  ����A  =Sports, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Sports.ViewSports.View  5      3clr-namespace:Sports.ConverterSports.Converter  5          Sports.View.MatchView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Sports.View     5      5
convertersclr-namespace:Sports.Converter     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � DataContext  5      ��    Locator �� Source# [   �� Path$ Match� � 	Resources 5      %   Sports.Converter.RadioButtonCvt  RadioButtonCvt��%   &	         5   
   6$   5      .��5      �  � RowDefinitions 5   
   �� 5      $	�� 50 �6   �� 5      $	��63* �6   �� 5      $	��40* �6   �� 5      $
��297* �6   .+�5   
   �� 
������� �� Orientation$ 
Horizontal=�6/   .+�5      �� $��🏚️ ��6   $��23(�6$   $
��Left=�62   $��Center=�6M   6j   �� 5      $��首页>项目添加��6   $��23(�6'   $
��Left=�65   $��Center=�6P   6m   5      � 5    
   $��1��6   .+�5"      � $��0��6   $	��Top=�6     � ColumnDefinitions 5#      �� 5$      $
��102* �6'   �� 5%      $
��114* �6'   �� 5&      $
��139* �6'   �� 5'      $
��445* �6'   .+�5)      �� $��0��6   .+�5+      �� $��0 0 0 0q�6    $��20(�61   �� 6@   $�项目��6D   �� 6P    � Language$ zh-cn�6T   $�编号��6e   �� 6q   $�:��6u   6�   �� 5-      -   5         �� IsInputMethodEnabled .   % !MaterialDesignFloatingHintTextBox#��[ 5/      $��	0 0 10 0 q�51      $
��Left=�6   $	��100��6�   ��61   �� *MatchType.MatchID+	 �� Mode$	 TwoWay=�
 �� UpdateSourceTrigger$
 PropertyChanged=�6�   53      �� 54      $��1��6   .+�56      �� $��0 0 0 0q�6    $��20(�61   �� 6@   $�项目��6D   �� 6P   $ zh-cn�6T   $�名称��6e   �� 6q   $�:��6u   6�   �� 58      #��[ 5:      $��	0 0 10 0 q�6>   $
��Left=�6Q   $	��100��6�   ��6l   �� *MatchType.MatchName+$	 TwoWay=�$
 PropertyChanged=�6�   5<      �� 5=      $��2��6   .+�5>      �� $��0 0 0 0q�6    $��性别:��61   $��20(�6<   �� 5?      $ 
Horizontal=�6!   .+�5@      	� $��Center=�6�   $	�� 20(�6�   $��Center=�6�   $	��男��6�   $
��Left=�6�    	� 	GroupName$	 sex��6   d� 	IsChecked 6&   �� *MatchType.Gender+ �� 	Converter# [  �� ConverterParameter$	 男��6  	� 5A      $��Center=�6�   $	�� 20(�6�   $��Center=�6�   $	��女��6�   $
��Left=�6�   $	 sex��6   6&   �� *MatchType.Gender+# [ $	 女��6  5B      5C      �� 5D      $��3��6   .+�5E      �� $��0 0 10 0q�6    $��项目备注:��62   $��20(�6?   �� 5F      $��40��6   $	��Top=�5G      $��15(�5H       �� TextWrapping$
 Wrap=�5K      " �� VerticalScrollBarVisibility$
 Auto=�5L      ��6*   �� *MatchType.MatchType+6R   5M      5N      5O      � 5P   
   $��2��6   .+�5Q      �� $ 
Horizontal=�6   .+�5R      �� $��0 0 0 0q�6   $��20(�6)   $��参与人数:��67   6F   �� 5S      -   5        $��Center=�5S      $	��70 ��66    .  ��5T   L   �� *MatchType.Max+6o   �� 5U      $��0 0 0 0q�6   $��20(�6-   $��比赛场地:��6;   6J   �� 5V       �� DisplayMemberPath$ LocationName��6<    �� SelectedValuePath$ 
LocationID��6]   ��6   �� *
Location+ �� SelectedValue 6|   �� *MatchType.LocationID+6�   5W      �� 5X      $��Center=�6   $��添加��60   $	��200��6=   $��
559,0,41,0q�6�   ��6J   ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType$ local:MatchViewL���6�   �� *
AddCommand+6�   5Z      � 5\   
   $��3��6   .+�5]      &   System.Windows.Controls.DataGrid     
IsReadOnly .    AutoGenerateColumns .  ��6*   �� *MatchTableList+   Columns 5^      0  *System.Windows.Controls.DataGridTextColumn  5_      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *	MatchID+  5`      $ 名称��6)    65   �� *	MatchName+  5a      $ 性别��6)    65   �� *Gender+  5b      $ 备注��6)    65   �� *	MatchType+  5c      $ 报名结束��6)    67   �� *	MatchRule+  5d      $ 最大人数��6)    67   �� *Max+  5e      $ 比赛场地��6)    67   �� *LocationTable.LocationName+4  .System.Windows.Controls.DataGridTemplateColumn  5f      $ change��6.      CellTemplate 5g      �� 5h      .R�5i   "   �� $ 
Horizontal=�6-   .+�5j   &   �� $��编辑��6-   
���������5k   +   ��  �� $
 Self=���5l   +   ��  �� $ FindAncestor=�$ local:MatchViewL�$ DataContext.EditCommand�
 � Tag 5m   ,   �� 6?   �� 5n   &   $��删除��6-   
���������6Q   ��  �� $
 Self=���5o   +   ��  �� $ FindAncestor=�$ local:MatchViewL�$ DataContext.DeleteCommand� 5p   ,   �� 6?   5q   #   5r      5t      5v      5w      5x      5y      