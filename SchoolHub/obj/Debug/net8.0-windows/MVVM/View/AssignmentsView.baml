   M S B A M L   `   `   `  ����D  @SchoolHub, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:SchoolHub.MVVM.ViewSchoolHub.MVVM.View  5      C&clr-namespace:SchoolHub.MVVM.ViewModelSchoolHub.MVVM.ViewModel  5      )    #SchoolHub.MVVM.View.AssignmentsView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:SchoolHub.MVVM.View     5      <	viewModel&clr-namespace:SchoolHub.MVVM.ViewModel     5        � 	Resources  5       �� MergedDictionaries �� Source �� DataType.   (SchoolHub.MVVM.ViewModel.Class1ViewModel.   (SchoolHub.MVVM.ViewModel.Class2ViewModel�� 5   
    5      �� 5      $' !/Theme/NavigationButtonTheme.xaml?�6%   �� 5      $ /Theme/InputBoxTheme.xaml?�6%   %^  (��       5      *, +)(�� �     5      *, +)�� 5      "  6   .R�5      �� .+�5      �� ��6    �� *	ClassName+�� 5      $��This is Class 1 view��6    5      5      �� 5      "  6   .R�5      �� .+�5      �� ��6    �� *	ClassName+�� 5      $��This is Class 2 view��6    5      5      5      .��5"      � -   5        $��AssignmentGrid��5"       � RowDefinitions 5$   
   �� 5%      $��60 �6   �� 5&      .+�5)   
   �� $��0��6   ���#FFB3006"   �� 5+   
   $��1��6   ���#FFFFFF.+�5,      �� $��Assignments��6   $	��SST)�5-      $
��Bold"�5.      
���   �$��32(�50      $
��Left=�51      $��	75,40,0,0q�52      �� 54      $��1��6   
���   �$��Stretch=�60   $��75,0,0,0q�6N   �� 56       �� Orientation$ 
Horizontal=�6   .+�58      �� $ Vertical=�6   $��
75,30,0,10q�59      .+�5;      �� $��Class 1��6      NavigationButtonTheme#��[  5<      $��Class1��5>      ��5=      �� *ShowClassCommand+5>      �� 5@      $��1��6    
���   �$	��210��68   $
��Left=�6D   $��0,25,0,0q�6_   �� 5B      $��Class 2��6   $��0,25,0,0q�5C      #��[  5D      $��Class2��5F      ��5E      �� *ShowClassCommand+5F      �� 5H      $��1��6    
���   �$	��210��68   $
��Left=�6D   $��0,25,0,0q�6_   �� 5J      $��Class 3��6   $��0,25,0,0q�5K      #��[  5L      ��5M      �� *CalendarViewCommand+�� 5O      $��1��6    
���   �$	��210��68   $
��Left=�6D   $��0,25,0,0q�6_   �� 5Q      $��Class 4��6   $��0,25,0,0q�5R      #��[  5S      ��5T      �� *CalendarViewCommand+�� 5V      $��1��6    
���   �$	��210��68   $
��Left=�6D   $��0,25,0,0q�6_   �� 5X      $��	Add Class��6   $��0,25,0,0q�5Y      $��50��5Z      #��[  5[      ��5\      �� *CalendarViewCommand+5]      �� 5_      $	��575��6   
���   �$��1��66   $
��Left=�6@   $��0,25,0,0q�6[   �� 5a      $ Vertical=�6   $��	0,30,0,10q�5b      .+�5d      �� ��6%   �� *CurrentViewModel+5f      5g      5h      5i      5l      