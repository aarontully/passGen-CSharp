   M S B A M L   `   `   `  ����B  >passGen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:passGenpassGen  5   	       passGen.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:passGen     5   	     � Title$  passGen��5   	   $	��500��5	   	   $	��850��5
   	    � 
ResizeMode$ NoResize=�5   	   .��5      � ���	#FFF7F7F7.+�5   
   �� .+�5      �� -   5         ��Name$ lblPassword��5      $��36(�5       �� TextAlignment$ Center=�5      
�������$
��Wrap=�5      $	��200��5      $��30 10q�5      �� 5      -   5         ��Name$ btnGenerate��5      $��Generate Password��5      $��Center=�5      $��Center=�5      $��20q�5       J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5         ShadowDepth$ 2Q�6'   5      �� 5      -   5         ��Name$ 	Uppercase��5      $��	Uppercase��5        d� 	IsChecked$
 TrueY�5!      �� 5"      -   5        $ 	Lowercase��5"      $��	Lowercase��5#      $
 TrueY�5$      �� 5%      -   5        $ Numbers��5%      $��Numbers��5&      $
 TrueY�5'      �� 5(      -   5        $ Symbols��5(      $��Symbols��5)      $
 TrueY�5*      �� 5+      -   5        	 ��Name$	 
passSlider��5+      
 �� IsSnapToTickEnabled
 .  � SmallChange$ 1Q�5-       � LargeChange$ 10Q�5.       � Maximum$	 128Q�5/       � Minimum$ 8Q�50       �� TickPlacement$ TopLeft=�51      �� 52      ��6   ��  �� ElementName$ 
passSlider�� �� Path$ Value�53      54      55      