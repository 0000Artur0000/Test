   M S B A M L   `   `   `  ����?  ;JJBa, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:JJBaJJBa  5   	       JJBa.Log   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:JJBa     5   	   -   5          � Title$  Форма входа��5   	   $	��350��6   $	��250��6*    � 
ResizeMode$ NoResize=�66    � WindowStartupLocation$ CenterScreen=�6L    � 	Resources 5	         TextBox.Static.Border �� Color  TextBox.MouseOver.Border  TextBox.Focus.Border  oval �� 
TargetType �� Property �� Value-  'System.Windows.Input.KeyboardNavigation �� 
TargetType	 ��Name
 J� SnapsToDevicePixels �� CornerRadius ��Name �� Triggers P� Property P� Value �� 
TargetName �� Triggers ]� 
Conditions �� Property �� Value��%�  &	        &	 #     &	 F     &	 i     7   7  7  �� 5
   
   $ 	#FFABAdB3��68   �� 5   
   $ 	#FF7EB4EA��6;   �� 5   
   $ 	#FF569DE5��67   �� 5   
   " G�6   .�5      ��  �@G�PasswordChar$	 ●��6-   �� 5       � ��# � ��6+   �� 5       � ��8   6,   �� 5       � ��# � ��6+   �� 5       � ��$ 1q�60   �� 5       �@ TabNavigation$
 None=�6A   �� 5       � ��$
 Left=�6;   �� 5       �@�FocusVisualStyle 61   Z� �� 5       �@J�	AllowDrop . 6*   �� 5       �@��PanningMode$ VerticalFirst=�69   �� 5       �@��IsFlicksEnabled .  67   �� 5       � �� 5      �� 5      " G�6&   .R�5      �� $	 border��6!   #��z��61   #��z��6]   #��z��6�   
 . $ 5��6�   ._�5      �� $ PART_ContentHost��6+   |�.  $��Hidden=�6W   $��Hidden=�6~   5       5      P� 5        � {� .  . �5!   "   �� $ border��6<    �@J�Opacity$
 0.56Q�6P   5"      P� 5#       �@J�IsMouseOver . . �5$   "   �� $ border��6@   8   � ��6T   5%      P� 5&       �@J�IsKeyboardFocused . . �5'   "   �� $ border��6@   8   � ��6T   5(      5*      5,       5-      ]� 5.       5/      �� 50      + �@G�#IsInactiveSelectionHighlightEnabled . 6S   �� 51       �@G�IsSelectionActive .  6A   ./�53      ��  �@G�SelectionBrush# � /�67   54      56      57      .��58      � .+�59   
   �� -   5         ��Name$ T1��59      $��50,100,50,191q�6    �� TextWrapping$
 Wrap=�65    	 Oval1#���  6k   G� 5:   
   -   5         G�Name$ T2��5:      $��50,180,50,111q�6"   #���  69   �� 5;   
   $��Login:��6   $
��Left=�6!   $��	50,69,0,0q�6<   $	��Top=�6O   $	��144��6g   �� 5<   
   $��Pass:��6   $
��Left=�6    $��
50,149,0,0q�6;   $	��Top=�6O   $	��144��6g   �� 5=   
   -   5        $��Войти!��5=      $��50,253,50,35q�6"     Oval#���  68   $��16(�6W   $��Arial Black)�6e   6~   5?      5@      