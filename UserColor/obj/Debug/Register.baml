   M S B A M L   `   `   `  ����D  @UserColor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:UserColor	UserColor  5   	       UserColor.Register   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   X TXceed.Wpf.Toolkit, Version=3.5.0.0, Culture=neutral, PublicKeyToken=3e4669d2f30244f44xctk)http://schemas.xceed.com/wpf/xaml/toolkit  5   	   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   #localclr-namespace:UserColor  5   	   -   5        $��window��5
   n     � Title$  Register��6	   $	��250��6   $	��400��6'    � 
ResizeMode$ NoResize=�63    � WindowStartupLocation$ CenterScreen=�6I   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   #  Xceed.Wpf.Toolkit.ColorPicker  -   5        $��colorPicker��5   C   $��0��6      DisplayColorAndName . 6�   �� 5   
   -   5        $��textBox��5      $
��Left=�5      $��Stretch=�6-   $��23��5      $
��Wrap=�5      $��Background of window��5      $��1��5      
�������5        5   
   -   5        $��colorPicker2��5   C   $��2��6    . 6�   �� 5   
   -   5        $��textBox2��5      $
��Left=�5      $��Stretch=�6-   $��23��5       $
��Wrap=�5!      $��Color of your name��5"      $��3��5#      
�������5$      �� 5&   
   -   5        $��yourName��5&   (   $��Center=�68   $��23��6U   $��4��6b    �� TextWrapping$
 Wrap=�6o   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	Your name��6�   $��Center=�6�   $	��120��6�   �� 5'   
   -   5        $��Register��5'      $��Center=�6%   $��4��6C   $��Bottom=�6P   $��85��6k   6v   �� 5(   
   -   5        $��color1��5(      $
��Left=�6"   $��127,1.6,0,0q�6=   $��1��6R   $
��Wrap=�6_   $�� ��6s   $	��Top=�6{   �� 5)   
   -	   5        $��color2��5)      $
��Left=�6"   $��	114,0,0,0q�6=   $��3��6P   $
��Wrap=�6]   $�� ��6q   $	��Top=�6y   5*      5+      