   M S B A M L   `   `   `  ����F  BTic Tac Toe, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Tic_Tac_ToeTic_Tac_Toe  5   	       Tic_Tac_Toe.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Tic_Tac_Toe     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � ShowInTaskbar$
 True��5	   	    � Title$ 
MainWindow��5
   	   $	��500��6   $	��500��6)    � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       �� 5   
   " ��6   .�5      ��  � ��
 �����6+   �� 5       � ��$	 0.5q�60   �� 5       � ��$ 70(�6)   5      5      .��5      � -   5         �Name$ 	Container��5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   	 � ColumnDefinitions	 5   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   .+�5   
   �� -   5        
 ��Name$
 	Button0_0��5      $��0��6$   $��0��64   6A   �� 5    
   -   5        $
 	Button1_0��5       $��1��6$   $��0��64   6A   �� 5!   
   -   5        $
 	Button2_0��5!      $��2��6$   $��0��64   6A   �� 5#   
   -   5        $
 	Button0_1��5#      $��0��6$   $��1��64   6A   �� 5$   
   -   5        $
 	Button1_1��5$      $��1��6$   $��1��64   6A   �� 5%   
   -   5        $
 	Button2_1��5%      $��2��6$   $��1��64   6A   �� 5'   
   -   5        $
 	Button0_2��5'      $��0��6$   $��2��64   6A   �� 5(   
   -	   5        $
 	Button1_2��5(      $��1��6$   $��2��64   6A   �� 5)   
   -
   5        $
 	Button2_2��5)      $��2��6$   $��2��64   6A   5*      5+      