   M S B A M L   `   `   `  ����R  NHMTDPTeamLibraryProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW0clr-namespace:HMTDPTeamLibraryProject.ViewModels"HMTDPTeamLibraryProject.ViewModels  5      -    'HMTDPTeamLibraryProject.LibraryListPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      G
viewModels0clr-namespace:HMTDPTeamLibraryProject.ViewModels     5        N� Title$  LibraryListPage��5	       � DataContext 5
      >   8HMTDPTeamLibraryProject.ViewModels.ArticleStoreViewModel  5   
   .��5      � ��5   
   �� 5       �� Opacity$	 0.1Q�6"   .��5      �  � Color$ HotPink��6    � Offset$	 0.5Q�60   � 5      $ 	RosyBrown��6   $	 0.6Q�62   5       � RowDefinitions 5   
   �� 5      $��45 �6   �� 5      $��1* �6   �� 5      $��30 �6   .+�5   
   �� $��0��6    �� Orientation$ 
Horizontal=�6"   .+�5      �� -   5        $	��120��5      
�������$��1q�5       
���OO/�$��14(�5"      $��Oblique$�5#      $��SemiBold"�5$      $��Center=�5%      $��Center=�5&      $��New Article��5'       � ToolTip$ Write New Article��6+   $��5,5,5,5q�6G   ��5(      �� 5)      $
 0.01Q�6*   5*      5,      �� 5.      -   5        $	��120��5.      
�������$��1q�51      
���OO/�$��14(�53      $��Oblique$�54      $��SemiBold"�55      $��Center=�56      $��Center=�57      $��Open Article��58      $ Open Selected Article��6,   $��5,5,5,5q�6L   ��59      �� 5:      $
 0.01Q�6*   5;      5=      �� 5@      $��0��6   $	��120��6A   
�������$��1q�5B      
���OO/�$��14(�5D      $��Oblique$�5E      $��SemiBold"�5F      $��Center=�5G      $��Center=�5H      $��Remove Article��5I      $ Remove Selected Article��6.   $��5,5,5,5q�6P   ��5@   %   �� *Remove+��5J      �� 5K      $
 0.01Q�6*   5L      5N      �� 5P      -   5        $��0��5P      $	��120��6A   
�������$��1q�5R      
���OO/�$��14(�5T      $��Oblique$�5U      $��SemiBold"�5V      $��Center=�5W      $��Center=�5X      $��Search Article��5Y      $ Search Article��6.   $��5,5,5,5q�6G   ��5Z      �� 5[      $
 0.01Q�6*   5\      5^      �� 5`      -   5        $��0��5`      $	��120��6%   
�������$��1q�5b      
���OO/�$��14(�5d      $��Oblique$�5e      $��SemiBold"�5f      $��Center=�5g      $��Center=�5h      $��All Authors��5i      $ Open Authors Page��6+   $��5,5,5,5q�6G   ��5j      �� 5k      $
 0.01Q�6*   5l      5n      �� 5p      -   5        $��0��5p      $	��120��6%   
�������$��1q�5r      
���OO/�$��14(�5t      $��Oblique$�5u      $��SemiBold"�5v      $��Center=�5w      $��Center=�5x      $��	All Books��5y      $ Open Books Page��6)   $��5,5,5,5q�6C   ��5z      �� 5{      $
 0.01Q�6*   5|      5~      5�      �� 5�   
   -   5        $��mainOperateList��5�      $��1��5�      
������ $��13(�5�      ��5�      �� *
Articles+ �� View 5�      �� 5�      P�5�      �� 5�      	 �� Width$		 130��6)   $��Author��65   
 �� DisplayMemberBinding
 6E   �� *Author+�� 5�      $		 130��6)   $��Title��65   
 6D   �� *Title+�� 5�      $	 50��6)   $
��Year��64   
 6B   �� *Year+�� 5�      $	 50��6)   $��Month��64   
 6C   �� *Month+�� 5�      $	 50��6)   $	��Day��64   
 6A   �� *Day+�� 5�      $	 70��6)   $��Image��64    �� CellTemplate 5�      �� 5�   "   .R�5�   &   �� $��60��6I   $��40��6T   ��6,   �� *	ImagePath+6T   5�   #   5�      �� 5�      $		 120��6)   $��Category��65   
 6G   �� *
Category+�� 5�      $		 155��6)   $��Description��65   
 6J   �� *Description+5�      5�      � 5�   
   $��2��6    � ColumnDefinitions 5�      �� 5�      $	��100 �6#   �� 5�      $	��300 �6#   5�      5�      5�      