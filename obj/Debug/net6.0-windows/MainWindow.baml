   M S B A M L   `   `   `  ����>  :DMF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DMFDMF  5   	       DMF.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:DMF     5   	     � Title$  	DMF Panel��5   	   $	��310��6   $	��400��6(    � 
ResizeMode$ NoResize=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	   .��5      � $��0,0,0,-6q�6   .+�5   
   �� $��Center=�6   $��63��61   $��0,28,0,0q�6=   
���  ��$	��Top=�6\   $	��350��6t   �� 5   
   -   5         ��Name$ postPath��5       �� 
IsReadOnly$
 True��6$   $
��Left=�66   $��	25,47,0,0q�6Q    �� TextWrapping$
 Wrap=�6d   $��No selected file...��6x   $	��Top=�6�   $	��245��6�   $��20��6�   �� 5   
   -   5         ��Name$ postGo��5      $
��Post��6!   $
��Left=�60   $��
333,47,0,0q�6K   $	��Top=�6_   6w   �� 5   
   -   5        $ 
postBrowse��5      $��Browse��6%   $
��Left=�66   $��
281,47,0,0q�6Q   $	��Top=�6e   6}   �� 5   
   $��<Upload File>��6   $��Center=�6.   $	��Top=�6K   $
��Bold"�6c   $��14(�6u   
���  ��$��0,-1,0,0q�6�   �� 5   
   -   5        $ 	resultBox��5      $
 True��6%   $��Center=�67   $��	0,158,0,0q�6T   $
 Wrap=�6g   $	��Top=�6{   $	��336��6�   $��89��6�   $��Disabled=�6�   $
��Auto=�6�   $��No pending response...��6  
���   �
���   �6B  �� 5   
   $��
<Response>��6   $��Center=�6+   $	��Top=�6H   $
��Bold"�6`   $��14(�6r   
��� � �$��	0,107,0,0q�6�   �� 5   
   -   5         ��Name$ 
statusCode��5      $��Status: 000��6$   $��Center=�6:   $��	0,136,0,0q�6W   $	��Top=�6j   
����  �$��68��6�   �� 5   
   $��Center=�6   $	��118��61   $��	0,136,0,0q�6>   
��� � �$	��Top=�6_   $	��350��6w   5      5      