   M S B A M L   `   `   `  ����B  >Forgets, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ForgetsForgets  5   	       Forgets.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Forgets     5   	   -   5          � Title$  Forgets��5   	   $��448.978��6   $	��800��6*    � 	Resources 5	      %  Forgets.TEventToStringConverter   TEventToStringConverter#  Forgets.ColorToBrushConverter  ColorToBrushConverter��%:   &	        &	        5
   
   6(     5   
   6&   5      .��5      � ���	#FFE5E5E5$��0,0,0,-6q�6"   .+�5   
   � $��0,0,0,-3q�6   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF004080��6#    � Offset$ 0Q�65   � 5      $ 	#FFABD5FF��6#   $ 1Q�65   5       � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5      &   System.Windows.Controls.Calendar  -   5          Name$ Calendar��5      $��0��6)   $
��Left=�69   $��	10,10,0,0q�6T   $	��Top=�6g   $	��166��6�   $	��183��6�   ���	#FF0075E8��5      �� 5      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5      � $ 	#FFE4EAF0��6'   $ 0Q�69   � 5      $ 	#FFECF0F4��6'   $
 0.16Q�69   � 5      $ 	#FFFCFCFD��6'   $
 0.16Q�69   � 5      $ 	#FFE6E6E6��6'   $ 1Q�69   5       ��5"      �� 5#      $ 0.5,1&�6*   $ 0.5,0&�6;   .��5$      � $ 	#FFA3AEB9��6'   $ 0Q�69   � 5%      $ 	#FF8399A9��6'   $ 0.375Q�69   � 5&      $ 	#FF718597��6'   $ 0.375Q�69   � 5'      $ 	#FF071A29��6'   $ 1Q�69   5(      5*      �� 5+      -   5         ��Name$ dailySchedule��5+      $��2��6M   $��	198,0,0,0q�6a   
�������
����������	#FF77A8D8��6.   �� *Events+ 5,      	 �� 
TargetType
 �� Property �� Value �� Triggers �� Binding �� Value �� Color �� Opacity��%/  '��       '�� J     �� 5-      "	 ��6   .�5.      �� 
 � ��$
 Left=�6G   5/      �� 50      "	 ��6    51      �� 52       6*   �� *IsImportant+ True6J   .a�53   "   �� 
 � �� 54   &   �� 55   *   $ Crimson��6:   $
 0.15Q�6J   57   #   58      5:      5;       �� View 5<      �� 5=       �� AllowsColumnReorder .  .P�5>      ��  �� Width$
 Auto��6)   ��5?      �� 5@   "   -   5        
 � Tag$ 
RecordType��5@   7   .��6k   Type6q    �� CellTemplate 5B      �� 5C   "   .R�5D   &   ��  ��Name$ RecordTypeBlock��60   ��6I   �� *
RecordType+ �� 	Converter# [  ��6�   �� *RecordTypeColor+# [ 5E   #   5G      �� 5H      $
 Auto��6U    �� DisplayMemberBinding 6)   �� *
RecordName+��5I      �� 5J   "   -   5        $ 
RecordName��5J   7   .��6k   Name6q   5L      �� 5M      $
 Auto��6u    6)   �� *	StartTime+ �� StringFormat$ dd-MM-yyyy HH:mm����5N      �� 5O   "   -   5        $ 	StartTime��5O   7   .��6j   
Start Time6v   5Q      �� 5R      $
 Auto��6s    6)   �� *	EndTime+$ dd-MM-yyyy HH:mm����5S      �� 5T   "   -   5        $ EndTime��5T   7   .��6h   
End Time6r   5V      �� 5W      $
 Auto��6S    6)   �� *
Location+��5X      �� 5Y   "   -   5        $ Location��5Y   7   .��6i   
Location6s   5[      �� 5\      $
 Auto��6V    6)   �� *Description+��5]      �� 5^   "   -	   5        $ Description��5^   7   .��6l   Description6y   5`      5a      5c      �� 5d      -
   5         ��Name$ newEventButton��5d      $��Add new event��6-   $
��Left=�6E   $��
25,196,0,0q�6`   $	��Top=�6t   $	��155��6�   $��30��6�   6�   �� 5e      -   5        $ removeEventButton��5e      $��Remove selected event��60   $
��Left=�6P   $��
25,231,0,0q�6k   $	��Top=�6   $	��155��6�   $��30��6�   6�   5f      5g      5h      