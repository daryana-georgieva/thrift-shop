   M S B A M L   `   `   `  ����G  Cfinalproject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:finalprojectfinalproject  5   	       finalproject.Cart   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:finalproject     5   	   -   5          � Title$
  Cart��5   	   $	��832��6   $
��1280��6#    � 	Resources 5	      *   $finalproject.vtorataupotrebaDataSet3   vtorataupotrebaDataSet3  cartViewSource �� Source �� Source��%U   &	        &	      7     5
   
   6(   �� 5   
    66   �� *Cart+8   5      .��5      � ���	#FFBBBBF6 � DataContext# [ 6"   .+�5   
   �� -   5         ��Name$ 	shoplabel��5      $��vtorata upotreba��6#   $��96(�6>   $��Center=�6L   $4��./finalproject;component/resourcess/#Barriecito)�6i   
�������$	��715��6�   $��296,-14,262.6,684.4q�6�   �� 5   
   -   5        $ signuplabel_Copy��5      $��
Your Item:��6*   $
��Left=�6?   $��296,58,0,648.4q�6Z   $��Center=�6r   $��48(�6�   $6��0/finalproject;component/resourcess/#Bungee Shade)�6�   $��Center=�6�   $	��669��6�    J� RenderTransformOrigin$ 0.685,0.442&�6	  $��96��6-  �� 5   
   -   5         ��Name$ 
cardnumtxt��5      $��Global Monospace)�6&   $
��Left=�6D   $��45��6_   $��384,517,0,0q�6k    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��552��6�   $y�Hidden=�6�   �� 5   
   -   5        $ cardnumlabel��5      $��Card number��6&   $
��Left=�6<   $��384,480,0,0q�6W   $	��Top=�6l   $��24(�6�   $$��Gill Sans Ultra Bold Condensed)�6�   $y�Hidden=�6�   �� 5   
   -   5        $ usernametxt��5      $
��Left=�6'   $��45��6B   $��383,607,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��552��6�   $��24(�6�   $��Global Monospace)�6�   $y�Hidden=�6�   �� 5   
   -   5        $ usernamelabel��5      $��24(�6'   $��Username��65   $
��Left=�6H   $	��Top=�6c   $$��Gill Sans Ultra Bold Condensed)�6{   $��384,567,0,0q�6�   $y�Hidden=�6�   �� 5   
   -   5        	 ��Name$	 	buynowbtn��5      $��BUY NOW��6$   $
��Left=�66   $��363,557,0,0q�6Q   $	��Top=�6f   $��Center=�6~   $	��229��6�   $��60��6�   $��24(�6�   
�������
�������$��Rockwell Extra Bold)�6�   ���	#FFBBBBF6 5      
 �� 
TargetType �� Property �� Value��%^   '��       �� 5      "
 ��6   .�5      ��  �@��CornerRadius$ 7��65   5      5      5      �� 5   
   -	   5        $ itemnamelabel��5      $��36(�6'   $��	Item name��65   $��Center=�6I   $��Center=�6m   $	��Top=�6�   $$��Gill Sans Ultra Bold Condensed)�6�   $��63��6�   $��588,184,30.6,0q�6�   $	��655��6�   �� 5   
   -
   5        $ 
pricelabel��5      $��36(�6$   $��Price��62   $��Center=�6B   $��Center=�6f   $	��Top=�6�   $$��Gill Sans Ultra Bold Condensed)�6�   $��63��6�   $��862,257,245.6,0q�6�   �� 5   
   -   5        $ conditionlabel��5      $��36(�6(   $��	Condition��66   $��Center=�6J   $��Center=�6n   $	��Top=�6�   $$��Gill Sans Ultra Bold Condensed)�6�   $��63��6�   $��787,315,187.6,0q�6�   �� 5   
   -   5        $ ogvaluelabel��5      $��36(�6&   $��Original value��64   $��Center=�6M   $��Center=�6q   $	��Top=�6�   $$��Gill Sans Ultra Bold Condensed)�6�   $��63��6�   $��735,383,110.6,0q�6�   �� 5   
   -   5        $	 	cancelbtn��5      $��CANCEL��6$   $
��Left=�65   $��670,557,0,0q�6P   $	��Top=�6e   $��Center=�6}   $	��229��6�   $��60��6�   $��24(�6�   
�������
�������$��Rockwell Extra Bold)�6�   ���	#FFBBBBF6 5       ��%^   '��       �� 5!      "
 ��6   .�5"      ��  �@��CornerRadius$ 7��65   5#      5$      5%      �� 5&   
   -   5        $ 	sizelabel��5&      $��36(�6#   $
��Size��61   $��Center=�6@   $��Center=�6d   $	��Top=�6�   $$��Gill Sans Ultra Bold Condensed)�6�   $��63��6�   $��883,435,262.6,0q�6�   �� 5'   
   -   5        $ signuplabel_Copy1��5'      $��
Item name:��6+   $
��Left=�6@   $��10,151,0,555.4q�6[   $��Center=�6s   $��48(�6�   $6��0/finalproject;component/resourcess/#Bungee Shade)�6�   $��Center=�6�   $	��669��6�   $ 0.685,0.442&�6
  $��96��6.  �� 5(   
   -   5        $ signuplabel_Copy2��5(      $��price:��6+   $
��Left=�6<   $��10,219,0,487.4q�6W   $��Center=�6o   $��48(�6�   $6��0/finalproject;component/resourcess/#Bungee Shade)�6�   $��Center=�6�   $	��669��6�   $ 0.685,0.442&�6  $��96��6*  �� 5)   
   -   5        $ signuplabel_Copy3��5)      $��
condition:��6+   $
��Left=�6@   $��10,282,0,424.4q�6[   $��Center=�6s   $��48(�6�   $6��0/finalproject;component/resourcess/#Bungee Shade)�6�   $��Center=�6�   $	��669��6�   $ 0.685,0.442&�6
  $��96��6.  �� 5*   
   -   5        $ signuplabel_Copy4��5*      $��original value:��6+   $
��Left=�6E   $��0,344,0,362.4q�6`   $��Center=�6w   $��48(�6�   $6��0/finalproject;component/resourcess/#Bungee Shade)�6�   $��Center=�6�   $	��669��6  $ 0.685,0.442&�6  $��96��62  �� 5+   
   -   5        $ signuplabel_Copy5��5+      $��size:��6+   $
��Left=�6;   $��0,402,0,304.4q�6V   $��Center=�6m   $��48(�6�   $6��0/finalproject;component/resourcess/#Bungee Shade)�6�   $��Center=�6�   $	��669��6�   $ 0.685,0.442&�6  $��96��6(  5-      5.      