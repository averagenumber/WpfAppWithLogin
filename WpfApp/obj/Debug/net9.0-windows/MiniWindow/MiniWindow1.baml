   M S B A M L   `   `   `  ����A  =WpfApp, Version=0.1.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:WpfAppWpfApp  5          WpfApp.MiniWindow1   5   	   W SPresentationCore, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=9.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=9.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      &localclr-namespace:WpfApp     5        � Icon$  /Items/image/ico.png��5         BackgroundColor#���   5       � UseLayoutRounding$
 True��5       � Title$ WpfApp Visual��5      $	��300��6%   $	��700��62    � 
ResizeMode$ CanMinimize=�5	       � 	Resources 5       �� 
TargetType �� Property �� Value �� 
TargetType	 ]� Thumb
 n�Name �� RadiusX �� RadiusY  SideButtonStyle  ButtonBackgroundColor   System.Windows.SystemFonts   MessageFontSizeKey&   System.Windows.Media.TextOptions3  -System.Windows.Media.Effects.DropShadowEffect   Color   	Direction   
BlurRadius   ShadowDepth   Opacity  ButtonBorderColor �� CornerRadius �� TextAlignment   TextRenderingMode   TextHintingMode J� SnapsToDevicePixels��%�  '��       &	 �    �� 5   
   " ��6   .�5      ��  � ��$ 6��6&   �� 5       � ��$ 6��6'   �� 5       � �� �#88C0D06+   �� 5       � ��
 ���� 6,   �� 5       � ��$ 0q�60   �� 5       � ��$ 0q�6(   �� 5       � �� 5      �� 5      " ��6&   .R�5      � .+�5      ]� $��
PART_Track��6$   $
��True��66   	 5   "   n� 5   &   $
 
PART_Thumb��6,   
������ $��1q�6Z   ��5   *   �� 5   .   " n�6>   .R�5   2   �� $��ThumbRectangle��6<   ���#88C0D0
������ $ 3��6v   $ 3��6�   5   /   5    '   5"      5#      5$      5&      5'      �� 5)   
   " ��6(   .�5*   
   ��  �@�Cursor$
 Hand��6#   �� 5+       � ��# �  6   6Q   �� 5,   
    � ��$ Khmer)�6'   �� 5-   
    � ��$ SemiBold"�6'   �� 5.   
    � ��# �  6%   �� 5/   
    � ��$
 10,5q�6$   �� 50   
    � ��$ 5q�6#   �� 51   
    �@ TextRenderingMode$ 	ClearType=�6:   �� 52   
    �@ TextHintingMode$ Fixed=�68   �� 53   
    �@J�SnapsToDevicePixels$
 True��60   �� 54   
    � ��$ Stretch=�60   �� 55   
    � ��$ Center=�6.   �� 56   
    �@J�Effect 57        58      $ Black��6#   $	 270Q�61   $ 8Q�6A   $ 4Q�6P   $	 0.4Q�6`   5:      �� 5;   
    � ��$ 70��6#   �� 5<   
    � �� 5=      �� 5>      " ��6"   .R�5?      �� #��z��6   #���  5@      #��z��5A      $ 8��5B      $
 True��5C      ._�5D      �� #��z��6$   $
��Wrap=�5E   $   $ Center=�5F   $   $��Center=�5G   $   $��Center=�5H   $   $ 	ClearType=�5I   $   $ Fixed=�5J   $   $
 True��5K   $   5L      5M      5O      5P      5R      .��5T      � .+�5U   
   ]� .+�5V      ��   MenuBackgroundColor#���  6   $ 15��6H   $��20q�6Z    �� Padding$ 10q�6f   ._�5W      � .+�5X      �� $��Mini Window 1��6      TextForegroundColor#��[ 65   $��28(�6g   $��Center=�5Y       $	��Top=�6=   $��0,20,0,0q�6U   �� 5\      $��False��6#   $��Disabled=�6<   $��20,60,20,20q�6e   .��5^      � $��10q�6   $��Stretch=�6+   $��Stretch=�6I    � RowDefinitions 5_      �� 5`   "   $
��Auto �60   �� 5a   "   $
��Auto �60   �� 5b   "   $
��Auto �60    � ColumnDefinitions 5e      �� 5f   "   $��* �63   �� 5g   "   $��* �63   .+�5j      �� -   5        $��MiniButton1��5j   %   $��MiniButton1��6;   #��[ 6Z   $��10q�6�   $��0��6�   $��0��6�   �� 5k      -   5        $��MiniButton2��5k   %   $��MiniButton2��6;   #��[ 6Z   $��10q�6�   $��0��6�   $��1��6�   6�   5m      5n      5o      5p      5q      5r      