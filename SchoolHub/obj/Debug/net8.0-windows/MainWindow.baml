   M S B A M L   `   `   `  ����D  @SchoolHub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:SchoolHub	SchoolHub  5   	   C&clr-namespace:SchoolHub.MVVM.ViewModelSchoolHub.MVVM.ViewModel  5   	       SchoolHub.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:SchoolHub     5   	   <	viewModel&clr-namespace:SchoolHub.MVVM.ViewModel     5   	   -   5        $	��900��5	   	   $
��1800��6     � AllowsTransparency$
  True��5
   	    � WindowStyle$
 None=�5   	    � 
ResizeMode$ 	CanResize=�5   	   
������  � DataContext 5      ,   &SchoolHub.MVVM.ViewModel.MainViewModel  5   
   .��5      �� ���#FFFFFF �� CornerRadius$ 0��5      ._�5   
   � -   5        $��MainWindowGrid��5       � RowDefinitions 5      �� 5      $��40 �6    �� 5      .+�5       �� -   5         �� Orientation$ 
Horizontal=�5!      ���#5F5F5F.+�5%      �� ���#F1F1F1._�5&      �� $��Images/house.png��6   $��20��5'      $��20��5(      $��10, 0, 10, 0q�5)      5+      �� 5-      ���#F1F1F1$ 3,3,0,0��6.   $��Bottom=�5.      $��Center=�5/      $��66��50      $��36��51      $��
4, 0, 0, 0q�52      ._�53      �� $
��Home��6    $��Center=�54       $��Center=�55       
���   �$��10(�57       58      59      �� 5<      $ 
Horizontal=�6   $��Right=�62   ���#5F5F5F.+�5=      �� $��40��6   $��40��6$   $��-��60   ���#5F5F5F���#FFFFFF��5>      �� *MinimizeWindowCommand+��5?      ��  �� RelativeSource �� *FindAncestor+ �� AncestorType" ��� 5@      $��40��6   $��40��6$   $��Maximize��60   ���#5F5F5F���#FFFFFF��5A      �� *MaximizeRestoreWindowCommand+��5B      ��  �� *FindAncestor+" ��� 5C      $��40��6   $��40��6$   $��X��60   ���#5F5F5F���#FFFFFF��5D      �� *CloseWindowCommand+��5E      ��  �� *FindAncestor+" �5F      � 5I      $��1��6   	 � ColumnDefinitions	 5K      �� 5L      $	��215 �6'   �� 5M      .+�5P      �� $��0��6   ���#F1F1F1.+�5Q      �� $��	Functions��6    $��10, 95, 0, 8q�5R       ���#4949495S       	� 5T      $��Search��6"   $��40��5U   "   ���	#BF000000���#E5E5E5$��14(�5X   "   
 d� 	IsChecked$

 TrueY�5Y   "   ��5Z   "   �� *HomeViewCommand+��5[      �� 5\      .R�5]   "   �� $ 
Horizontal=�6-   #��z��5^   -   .+�5_   &   �� $��Images/search.png��6,   $��20��5`   ,   $��20��5a   ,   $��20, 0, 0, 0q�5b   ,   �� 5c   &   $��Search��60   $	��SST)�5d   0   $��Medium"�5e   0   $��Center=�5f   0   $��
5, 0, 0, 0q�5g   0   5h   #   5i      5k      �� 5m      $��0, 110, 0, 0q�6!   .+�5n      �� $��Boards��6$   $��10, 0, 0, 8q�5o   $   ���#4949495p   $   	� 5r      $
��Home��6&   $��40��5s   &   ���	#BF000000���#E5E5E5$��14(�5v   &   $

 TrueY�5w   &   ��5x   &   �� *HomeViewCommand+��5y      �� 5z   "   .R�5{   &   �� $ 
Horizontal=�61   #��z��5|   1   .+�5}   *   �� $��Images/house.png��60   $��20��5~   0   $��20��5   0   $��20, 0, 0, 0q�5�   0   �� 5�   *   $
��Home��64   $	��SST)�5�   4   $��Medium"�5�   4   $��Center=�5�   4   $��
5, 0, 0, 0q�5�   4   5�   '   5�   #   5�      	� 5�      $��Assignments��6&   $��40��5�   &   ���	#BF000000���#E5E5E5$��14(�5�   &      MenuButtonTheme#��[  5�   &   ��5�   &   �� *AssignmentsViewCommand+��5�      �� 5�   "   .R�5�   &   �� $ 
Horizontal=�61   #��z��5�   1   .+�5�   *   �� $��Images/book.png��60   $��17��5�   0   $��17��5�   0   $��20, 0, 0, 0q�5�   0   �� 5�   *   $��Assignments��64   $	��SST)�5�   4   $��Medium"�5�   4   $��Center=�5�   4   $��
5, 0, 0, 0q�5�   4   5�   '   5�   #   5�      	� 5�      $��Tools��6&   $��40��5�   &   ���	#BF000000���#E5E5E5$��14(�5�   &   #��[  5�   &   ��5�   &   �� *PomodoroViewCommand+��5�      �� 5�   "   .R�5�   &   �� $ 
Horizontal=�61   #��z��5�   1   .+�5�   *   �� $��Images/clock.png��60   $��20��5�   0   $��20��5�   0   $��20, 0, 0, 0q�5�   0   �� 5�   *   $��Tools��64   $	��SST)�5�   4   $��Medium"�5�   4   $��Center=�5�   4   $��
5, 0, 0, 0q�5�   4   5�   '   5�   #   5�      	� 5�      $��Calendar��6&   $��40��5�   &   ���	#BF000000���#E5E5E5$��14(�5�   &   #��[  5�   &   ��5�   &   �� *CalendarViewCommand+��5�      �� 5�   "   .R�5�   &   �� $ 
Horizontal=�61   #��z��5�   1   .+�5�   *   �� $��Images/calendar.png��60   $��20��5�   0   $��20��5�   0   $��20, 0, 0, 0q�5�   0   �� 5�   *   $��Calendar��64   $	��SST)�5�   4   $��Medium"�5�   4   $��Center=�5�   4   $��
5, 0, 0, 0q�5�   4   5�   '   5�   #   5�      5�      5�      �� 5�      $��1��6!   $��1��5�   !   ��5�   !   �� *CurrentView+5�      5�      5�      5�      