   M S B A M L   `   `   `  ����D  @SchoolHub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:SchoolHub.MVVM.ViewSchoolHub.MVVM.View  5      &     SchoolHub.MVVM.View.PomodoroView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      3local!clr-namespace:SchoolHub.MVVM.View     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � DataContext  5	      �� *PomodoroViewModel+   ViewModelLocator �� Source# [   � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $' !/Theme/NavigationButtonTheme.xaml?�6%   �� 5      $ /Theme/InputBoxTheme.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $	��130 �6   �� 5      $��50 �6   �� 5      $	��125 �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��Center=�5      $��Bottom=�5      $��22(�5       $	��SST)�5!      $��Medium"�5"      $��	0, 0,0, 0q�5#      ��5   !   �� *
TimerState+5#      �� 5%   
   $��1��6   $��Center=�5&      $��Bottom=�5'      $	��SST)�5(      $
��Bold"�5)      $��40(�5*      ��5%   !   �� *
TimeLeft+5*      �� 5,   
   $��2��6    �� Orientation$ 
Horizontal=�6"   $��Center=�5-      $��Bottom=�5.      .+�50      �� $ Vertical=�6   .+�51      �� $��Start Minutes��6   $��Center=�52      $	��SST)�53      $��Medium"�54      $��
0, 0, 0, 5q�55      �� 57        InputBoxTheme#��[ 6   $��50��6@   $��25��6K    �� CornerRadius$ 5��6W   $��Center=�6h   ._�58      �� $��50��59      $��Center=�5:      $��Center=�5;      $��
5, 2, 5, 2q�5<      $��
5, 0, 5, 0q�5=      $��0q�5>      ��58      �� *StartMinutes+ �� UpdateSourceTrigger$ PropertyChanged=�5>      5?      5A      �� 5C      $ Vertical=�6   $��15, 0, 0, 0q�60   .+�5D      �� $��Short Break Minutes��6   $��Center=�67   $	��SST)�6R   $��Medium"�6c   $��
0, 0, 0, 5q�6w   �� 5E      #��[ 6   $��50��6@   $��25��6K   $ 5��6W   $��Center=�6h   ._�5F      �� $��50��5G      $��Center=�5H      $��Center=�5I      $��
5, 2, 3, 2q�5J      $��
5, 0, 0, 0q�5K      $��0q�5L      ��5F      �� *ShortBreakMinutes+$ PropertyChanged=�5L      5M      5N      �� 5P      $ Vertical=�6   $��15, 0, 0, 0q�60   .+�5Q      �� $��Long Break Minutes��6   $��Center=�66   $	��SST)�6Q   $��Medium"�6b   $��
0, 0, 0, 5q�6v   �� 5R      #��[ 6   $��50��6@   $��25��6K   $ 5��6W   $��Center=�6h   ._�5S      �� $��50��5T      $��Center=�5U      $��Center=�5V      $��
5, 2, 3, 2q�5W      $��
5, 0, 0, 0q�5X      $��0q�5Y      ��5S      �� *LongBreakMinutes+$ PropertyChanged=�5Y      5Z      5[      5]      �� 5_   
   $��3��6   $ 
Horizontal=�6"   $��Center=�5`      $��Center=�5a      $��0, 20, 0, 0q�5b      .+�5d      �� $��Start��5e        NavigationButtonTheme#��[ 5f      ��5d      �� *StartCommand+5f      �� 5h      $
��Stop��5i      #��[ 5j      $��10,0,0,0q�5k      ��5h      �� *StopCommand+5k      �� 5m      $��Reset��5n      #��[ 5o      $��10,0,0,0q�5p      ��5m      �� *ResetCommand+5p      5q      5r      5s      