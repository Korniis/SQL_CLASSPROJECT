   M S B A M L   `   `   `  ����A  =Sports, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:SportsSports  5   	   /clr-namespace:Sports.ControlSports.Control  5	   	       Sports.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:Sports     5   	   _ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      *controlclr-namespace:Sports.Control  5	   	     � WindowStartupLocation$  CenterScreen=�5
       � Title$ 运动会管理系统 ��5   	   $	��700��6   $
��1200��6'    � DataContext 5   
   ��    Locator �� Source# [   �� Path$
 Main�.��5      �  � ColumnDefinitions 5   
   �� 5      $	��276 �6   6.   �� 5      6!    � RowDefinitions 5   
   �� 5      $��61 �6   �� 5      .+�5   
   � $��0��6   $��0��6   
 � Tag$
 Logo��6-   ��5      �� 5       �� EndPoint$ 0.5,1&�6&   	 �� 
StartPoint$	 0.5,0&�67   .��5      � 
 � Offset$
 0Q�6#    � Color$ 	#FF2BCB23��6.   � 5      $ 	#FFA4FF9F��6#   $
 1Q�65   5      .+�5       �� 
���i��$��Matura MT Script Capitals)�62    �� TextAlignment$ Center=�6Y   $��30(�6w   $��sports管理系统��6�   $��Center=�6�   $��Center=�6�   5!      � 5"   
   $��0��6   $��1��6   $ Banner��6-   ���	#FFB0D1AD 5#      �� 5$      6%   �� 5%      6%   .+�5(      �� $��0��6   $
��Left=�6)    �� Orientation$ 
Horizontal=�6E   $��Center=�6^   .+�5*      �� $��43(�6   $��👨‍✈️欢迎��6+   6<   �� 5+      -   5        $��44(�5+        TextBoxBanberStyle#���  6O   ��6*   �� *AppData.User.Name+6�   5,      �� 5-      $��1��6   $��Right=�6)   $ 
Horizontal=�6E   $��Center=�6^   .+�5.      �� -   5        
�������$��20(�5.   0   $��🔒 修改密码��6>   $��	0 0 10 0 q�6M   #���  6`   6�   �� 5/      -   5        
�������$��Center=�5/   /   $��20(�6J   $��🏃‍ 退出系统��6X   #���  6i   6�   50      52      � 53   
   $
 menu��6   $��1��6   $��0��6(   ���	#FFA2CF8B 54      �� 55      $
��auto �6    �� 57      $
��auto �6    �� 59      $
��auto �6    �� 5;      $
��auto �6    .+�5?      #  MaterialDesignThemes.Wpf.Card  $��3��6"   .��5@      �� .+�5A      9� $��赛前流程��5B      .��5C      �� $��
24,8,24,16q�5D   	   $ Vertical=�5E   	     MaterialDesignBody#���  5F   	   .+�5G      �� $��2��6)   $��4q�5H      $ Vertical=�5I      .+�5J   "   	� -   5         	�Name$ 	ClassView��5J   /   $��4q�5L      $��班级添加��5M       d� 	IsChecked$ FalseY�5N       % !MaterialDesignTabRadioButtonRight#��[ 5O       	� 	GroupName$ 1��6@   	� 5P   "   -   5        $ RegistrationView��5P   /   $��4q�5R      $��运动员注册��5S      $ FalseY�5T      #��[ 5U      $ 1��6@   	� 5V   "   -   5        $ 	MatchView��5V   /   $��4q�5X      $��项目添加��5Y      $ FalseY�5Z      #��[ 5[      $ 1��6@   	� 5]   "   -   5        $ RefereeView��5]   /   $��4q�5^      $��裁判报名��5_      $ FalseY�5`      #��[ 5b      $ 1��6@   	� 5c   "   -   5        $ 
PlayerView��5c   .   $��4q�5d      $��运动员报名��5e      $ FalseY�5f      #��[ 5g      $ 1��6@   5h      5j      5k      9� 5m      
�������$��Stretch=�5n      $��比赛进行中��5o      .��5p      �� $��
24,8,24,16q�5q   	   $ Vertical=�5r   	   #���  5s   	   .+�5t      �� $��2��6)   $��4q�5u      $ Vertical=�5v      .+�5w   "   	� -	   5        $ PostView��5w   /   $��4q�5y      $��成绩录入��5z      $ FalseY�5{      #��[ 5|      $ 1��6@   	� 5}   "   $��4q�5~      $�� ��5      $ FalseY�5�      #��[ 5�      $ 1��6@   	� 5�   "   -
   5        $ PrizeTableView��5�   @   $��4q�5�      $��班级排名��5�      $ FalseY�5�      #��[ 5�      $ 1��6X   6f   5�      5�      5�      9� 5�      
�����_�$��Stretch=�5�      $��	待开发��5�      .��5�      �� $��
24,8,24,16q�5�   	   $ Vertical=�5�   	   #���  5�   	   .+�5�      �� $��Your Content��5�      5�      5�      5�      5�      (  "MaterialDesignThemes.Wpf.ColorZone  5�      -   5        
�������$��1��5�   r   $��16q�5�         Mode$ PrimaryLight=�5�      .��5�      �� $ 
Horizontal=�5�      .+�5�      d� -   5         d�Name$ 	IndexView��5�   %    ' #MaterialDesignHamburgerToggleButton#��[ 5�      �� 5�      $��16,0,0,0q�5�      $��Center=�5�      �� 5�   	    � Language$ zh-cn�6   $�首页��6   $��25(�6)   6:   5�      5�      5�      � 5�   
   $ contents��6   $��1��6   $��1��6+    5�      .+�5�      �� -   5         ��Name$ 	container��5�      $��2��60   ���	#FFE3ECEE5�      5�      5�      5�      