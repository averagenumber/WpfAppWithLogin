   M S B A M L   `   `   `  ����  MontiX1%    Montix1.LoginMontiX.LoginWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Authorization��5   	   $	��300��6   $	��400��6,    � WindowStartupLocation$ CenterScreen=�5   	   ���#2B2D42 � 
ResizeMode$ CanMinimize=�5   	   .��5      � .+�5
   
   �� $��Authorize :D��6   
�������$��20(�6;   $
��Bold"�6I   $��Center=�5      $	��Top=�61   $��0,30,0,0q�6I   �� 5   
   $��Center=�6   $��Center=�62   $	��250��6M   .+�5      � $��	0,10,0,10q�6   .+�5      �� -   5         ��Name$ UsernameTextBox��5      $��10q�63   ���#3B4252
����������#8FBCBB$��2q�5   0   $��Center=�6D   $��Stretch=�6_   .��6}   ��5      �� 5       �� 
TargetType" ��6    .�5      ��  �� Property � �� �� Value 5   "   �� 5   &    �� 
TargetType" ��66   .R�5   *   �� #��z��61   #��z��6[   #��z��6�    �� CornerRadius$ 10��6�   ._�5   .   �� 	 ��Name$	 PART_ContentHost��6;   5   +   5   '   5      5      .��5   %   5      �� 5      $��Login��6   
�������$��12(�6;   
 � Cursor$
 IBeam��6I   $��Center=�5       $
��Left=�67   $��14,0,0,0q�6R    J� IsHitTestVisible$ False��5!      y�5"      �� *Text+ �� ElementName$ UsernameTextBox��   TextToVisibilityConverter �� 	Converter# [  5#      � 5%      $��	0,10,0,10q�6   .+�5&      G� -   5         G�Name$ PasswordBox��5&      $��10q�63   ���#3B4252
�������$
 IBeam��6h   ��5(      �� 5)      " G�6*   .R�5*      �� #��z��6%   ���#8FBCBB$��2q�6e   $ 10��6y   ._�5+   "   �� $	 PART_ContentHost��6/   5,      5-      5/      �� 50      -   5         ��Name$ PasswordPlaceholder��50      $��Password��69   
�������$��12(�6[   $��Center=�51      $
��Left=�67   $��14,0,0,0q�6R   $ False��52      53      �� 55      -   5        $��Log in��55      $

 Hand��56      ���#4C566A
�������$��10q�57   =   $	��200��6J   $��40��6V   ���#81A1C1$��2q�58   +   ��59      �� 5:      " ��6&   .R�5;      �� #��z��6!   #��z��6K   $��2q�6w   $ 10��6�   ._�5<      �� $��Center=�6/   $��Center=�6L   5=      5>      5@      5A      �� 5C   
   -   5        $ ErrorMessage��5C      
���  ��$��12(�6;   $y�	Collapsed=�6I   $��Center=�5D      $��Bottom=�61   $��	0,20,0,30q�6L   5E      5F      