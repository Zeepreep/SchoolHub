   M S B A M L   `   `   `  ����D  @SchoolHub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:SchoolHub.MVVM.ViewSchoolHub.MVVM.View  5      "    SchoolHub.MVVM.View.HomeView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:SchoolHub.MVVM.View     5        � 	Resources  5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $' !/Theme/NavigationButtonTheme.xaml?�6%   �� 5      $ /Theme/InputBoxTheme.xaml?�6%   %    5      .��5      � -   5        $��HomeScreenGrid��5       � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      .+�5   
   �� $��0��6   ���#FFB3006"   �� 5   
   $��1��6   ���#FFFFFF.+�5      �� $
��Home��6   $	��SST)�5      $
��Bold"�5      
���   �$��32(�5!      $
��Left=�5"      $��	75,40,0,0q�5#      �� 5%      $��1��6   
���   �$��Stretch=�60   $��75,0,0,0q�6N   �� 5'       �� Orientation$ 
Horizontal=�6   .+�5)      �� $ Vertical=�6   $��
75,30,0,10q�5*      .+�5,      �� $��Assignments��6      NavigationButtonTheme#��[  5-      ��5.      �� *AssignmentViewCommand+�� 51      $��1��6    
���   �$	��400��68   $
��Left=�6D   $��0,25,0,0q�6_   �� 53      $��Tools��6   $��0,25,0,0q�54      #��[  55      ��56      �� *PomodoroViewCommand+�� 58      $��1��6    
���   �$	��400��68   $
��Left=�6D   $��0,25,0,0q�6_   �� 5:      $��Calendar��6   $��0,25,0,0q�5;      #��[  5<      ��5=      �� *CalendarViewCommand+5>      �� 5@      $ Vertical=�6   .+�5A      �� $��Upcoming Reminders��6    $��20, 0, 0 , 5q�5B       $	��SST)�5C       $
��Bold"�5D       �� 5F        InputBoxTheme#��[ 6   $��80��6D   $	��300��6P   ._�5G      �� $��80��5H   "   $��0q�5I   "   $��Center=�5J   "   $��5q�5K   "   $��
0, 5, 0, 0q�5L   "   ��5G   "   �� *'%CalendarVM.SortedAndFilteredReminders+��5M      �� 5N   "   .R�5O   &   �� ��5P   *   `� 5Q   .    �� StringFormat$ {0} ({1:dd/MM/yyyy})��6;   .1�5R   2   ��  �� Path$ ReminderText�6:   �� 5S   2   $
 Date�6:   5T   /   5V   '   5W   #   5Y      5Z      5[      5\      5]      5^      5`      