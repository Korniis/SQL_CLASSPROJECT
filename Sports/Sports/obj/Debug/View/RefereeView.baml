   M S B A M L   `   `   `  ����A  =Sports, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Sports.ViewSports.View  5          Sports.View.RefereeView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:Sports.View     5      _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        � DataContext  5
      ��    Locator �� Source# [   �� Path$ Referee�.��5      �  � RowDefinitions 5   
   �� 5      $	�� 50 �6   �� 5      $��9* �6   �� 5      $	��31* �6   .+�5   
   �� 
������� �� Orientation$ 
Horizontal=�6/   .+�5      �� $��🏚️ ��6   $��23(�6$   $
��Left=�62   $��Center=�6M   6j   �� 5      $��23(�6   $
��Left=�6&   $��Center=�6A   �� 6]   $�首页>��6a   �� 6q    � Language$ zh-cn�6u   $� 裁判��6�   �� 6�   $�报名��6�   6�   5      � 5   
   $��1��6    5      �� 5      $	��30  �6    �� 5      .+�5      �� 
�������._�5      �� $��添加数据��6   $��Center=�6(   $��18(�6C   6S   5      �� 5       $��1��6   $ 
Horizontal=�6&   .+�5!      �� $��Center=�6   $��20(�67   ID:6J   �� 5"      $��80��6   $��20��6%   $��10q�61   $��Center=�6=    �� IsInputMethodEnabled .  ��5%      �� *Referee.RefereeID+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6p   �� 5&      $��Center=�6   $��20(�67   	名字:6K   �� 5'      $��80��6   $��27��6%   $��10q�61   $��Center=�6=   ��6X   �� *Referee.RefereeName+$ TwoWay=�$ PropertyChanged=�6�   �� 5(      $��Center=�6   $
��Left=�67   $��20(�6N   	备注:6b   �� 5)      $��10q�6   )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 联系方式 QQ 微信��6(   $��24��6�   $	��400��6�   ��6T   �� *
Referee.PS+$ TwoWay=�$ PropertyChanged=�6�   �� 5*      $��60��6   ��6$   �� *
AddCommand+��6C   �� 
 �� RelativeSource
 ��  �� Mode$ FindAncestor=� �� AncestorType$ local:RefereeViewL�.��6�   添加6�   5+      5,      � 5-   
   $��2��6   .+�5/      &   System.Windows.Controls.DataGrid     
IsReadOnly .    AutoGenerateColumns .  ��6*   �� *RefereeTables+   Columns 50      0  *System.Windows.Controls.DataGridTextColumn  51      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *	RefereeID+  52      $ 名称��6)    65   �� *RefereeName+  54      $ 比赛名字��6)    67   �� *MatchTable.MatchName+  55      $ 备注��6)    65   �� *PS+6N   4  .System.Windows.Controls.DataGridTemplateColumn  5:      $ change��6.      CellTemplate 5;      �� 5<      .R�5=   "   �� $ 
Horizontal=�6-   .+�5>   &   �� $��分配��6-   
���������5?   +   �� 
 �� $
 Self=���5@   +   �� 
 �� $ FindAncestor=�$ local:RefereeViewL�$ DataContext.EditCommand�
 � Tag 5A   ,   �� 6?   �� 5B   &   $��删除��6-   
���������5C   /   �� 
 �� $
 Self=���5D   +   �� 
 �� $ FindAncestor=�$ local:RefereeViewL�$ DataContext.DeleteCommand� 5E   ,   �� 6>   5F   #   5G      5I      5K      5N      5P      5Q      