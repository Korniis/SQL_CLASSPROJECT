   M S B A M L   `   `   `  ����A  =Sports, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:Sports.WindowsSports.Windows  5   	   3clr-namespace:Sports.ConverterSports.Converter  5	          Sports.Windows.EditMatch   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:Sports.Windows     5   	   5
convertersclr-namespace:Sports.Converter     5	        � WindowStartupLocation$  CenterOwner=�5   	    � Title$ 	EditMatch��5   	   $	��200��6   $	��500��6(    � DataContext 5   	   ��    Locator �� Source# [   �� Path$ 	EditMatch� � 	Resources 5      %   Sports.Converter.RadioButtonCvt  RadioButtonCvt��%   &	         5   
   6$   5      .��5      �  � RowDefinitions 5   
   �� 5      6   �� 5      6   .+�5   
   � $��0��6   .+�5      � $��0��6   $	��Top=�6     � ColumnDefinitions 5      �� 5      $
��102* �6'   �� 5      $
��114* �6'   �� 5      $
��139* �6'   �� 5      $
��445* �6'   .+�5      �� $��0��6   .+�5!      �� $��0 0 0 0q�6    $��20(�61   �� 6@   $�项目��6D   �� 6P    � Language$ zh-cn�6T   $�编号��6e   �� 6q   $�:��6u   6�   �� 5#      -   5        $	��Num��5#   0   	 �� 
IsReadOnly	 . 
 �� IsInputMethodEnabled
 .   % !MaterialDesignFloatingHintTextBox#��[ 5&      $��	0 0 10 0 q�5(      $
��Left=�6   $	��100��6�   ��61   �� *MatchType.MatchID+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   5*      �� 5+      $��1��6   .+�5-      �� $��0 0 0 0q�6    $��20(�61   �� 6@   $�项目��6D   �� 6P   $ zh-cn�6T   $�名称��6e   �� 6q   $�:��6u   6�   �� 5/      #��[ 51      $��	0 0 10 0 q�6>   $
��Left=�6Q   $	��100��6�   ��6l   �� *MatchType.MatchName+$ TwoWay=�$ PropertyChanged=�6�   53      �� 54      $��2��6   .+�55      �� $��0 0 0 0q�6    $��性别:��61   $��20(�6<   �� 56       �� Orientation$ 
Horizontal=�6!   .+�57      	� $��Center=�6�   $	�� 20(�6�   $��Center=�6�   $	��男��6�   $
��Left=�6�    	� 	GroupName$	 sex��6   d� 	IsChecked 6&   �� *MatchType.Gender+ �� 	Converter# [  �� ConverterParameter$	 男��6  	� 58      $��Center=�6�   $	�� 20(�6�   $��Center=�6�   $	��女��6�   $
��Left=�6�   $	 sex��6   6&   �� *MatchType.Gender+# [ $	 女��6  59      5:      �� 5;      $��3��6   .+�5<      �� $��0 0 10 0q�6    $��项目备注:��62   $��20(�6?   �� 5=      $��40��6   $	��Top=�5>      $��15(�5?       �� TextWrapping$
 Wrap=�5B      " �� VerticalScrollBarVisibility$
 Auto=�5C      ��6)   �� *MatchType.MatchType+6Q   5D      5E      5F      � 5G   
   $��2��6    5H      �� 5I      6%   �� 5J      6%   �� 5K      6%   .+�5M      �� $��2��6   $��Center=�6�   $��修改��6�   $��48��6�   $��0,0,4,0q�6�   ��6%   ��  �� RelativeSource ��  �� Mode$ FindAncestor=� �� AncestorType$ local:EditMatchL���6�   �� *EditCommand+6�   �� 5N      $��0 0 0 0q�6   $��结束:��6)   $��20(�64   �� 5O      $ 
Horizontal=�6    � Cursor$  ��62   .+�5P      	� $��Center=�6�   $	�� 20(�6�   $��Center=�6�   $��Y��6�   $
��Left=�6�   $	 sex��6�    6   �� *MatchType.MatchRule+# [ $ Y��6  	� 5Q      $��Center=�6�   $	�� 20(�6�   $��Center=�6�   $��N��6�   $
��Left=�6�   $	 sex��6�    6   �� *MatchType.MatchRule+# [ $ N��6  5R      �� 5S      $��1��6   $ Vertical=�6)   .+�5T      �� $��最大人数:��6   $��20(�6)   69   �� 5U      -   5        
 .  $��0 20 q�5V   J   ��6Y   �� *MatchType.Max+5X      5[      5\      5]      