   M S B A M L   `   `   `  ����B  >Forgets, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ForgetsForgets  5   	       Forgets.NewEventWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Forgets     5   	     � Title$  Add new event��5   	   $��405.333��6   $��584.245��60    � 
ResizeMode$ NoResize=�6@   .��5	      � $
��Left=�6   $	��578��6&   ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ White��6    � Offset$ 0Q�6-   � 5      $ 	#FFABD5FF��6   $ 1Q�61   5      .+�5   
   �� $��Event type:��6   $
��Left=�6&   $��	10,10,0,0q�6A   $	��Top=�6T   �� 5   
   $��Name:��6   $
��Left=�6    $��	10,55,0,0q�6;   $	��Top=�6N   �� 5   
   $��Description:��6   $
��Left=�6'   $��	10,86,0,0q�6B   $	��Top=�6U   �� 5   
   $��	Location:��6   $
��Left=�6$   $��
10,173,0,0q�6?   $	��Top=�6S   �� 5   
   $��Start time:��6   $
��Left=�6&   $��
10,240,0,0q�6A   $	��Top=�6U    J� RenderTransformOrigin$ 0.472,0.425&�6m   �� 5   
   $��	End time:��6   $
��Left=�6$   $��221,240,0,0q�6?   $	��Top=�6T   �� 5   
   $��Remind me at:��6   $
��Left=�6i   $��
359,41,0,0q�6�   $	��Top=�6�   {�6(   ��  �� ElementName$ RemindCheckbox�� �� Path$ 	IsChecked�6�   �� 5   
   $��
Important:��6   $
��Left=�6%   $��
10,209,0,0q�6@   $	��Top=�6T   �� 5   
   -   5        	 ��Name$	 	EventType��5      
 �� 
IsEditable
 .  �� 
IsReadOnly . $
��Left=�6J    �� Text$ (Please select)��6e   $��	83,14,0,0q�6|   $	��Top=�6�   $	��120��6�   .@�5      �� .��6   	Meeting6$   �� 5      .��6   
Reminder6%   �� 5      .��6   Appointment6(   �� 5      .��6   Class6"   �� 5      .��6   Event6"   5      �� 5   
   -   5         ��Name$ NameTextBox��5      $
��Left=�6C   $��23��6^   $��	83,58,0,0q�6j    �� TextWrapping$
 Wrap=�6}   $	��Top=�6�   $	��242��6�   4  .System.Windows.Automation.AutomationProperties   IsRequiredForForm . ��6'   �� *
RecordName+6�   �� 5    
   -   5        $ DescriptionTextBox��5       $��46��6K   $��
10,112,0,0q�6W   $
 Wrap=�6k   $	��Top=�6   $
��Left=�6�   $	��315��6�    . ��6.   �� *Description+6�   �� 5!   
   -   5        $ LocationTextBox��5!      $
��Left=�6F   $��23��6a   $��
83,177,0,0q�6m   $
 Wrap=�6�   $	��Top=�6�   $	��242��6�    . ��6,   �� *
Location+6�   (  "System.Windows.Controls.DatePicker  5"   
   -   5          Name$ EndTimeDatePicker��5"      $
��Left=�6Q   $��221,266,0,0q�6l   $	��Top=�6�      SelectedDateFormat$
 Long=�6�      IsTodayHighlighted .  .    SelectedDate 60   �� *	EndDate+6�   �� 5#   
   -   5         ��Name$ ImportantCheckBox��5#      $
��Left=�6P   $��
83,215,0,0q�6k   $	��Top=�6    .  d� 	IsChecked 6.   �� *IsImportant+6�     5$   
   -   5        $ RemindDatePicker��5$      $
��Left=�6�   $��
359,67,0,0q�6�   $	��Top=�6�   $
 Long=�6�    6/   �� *
RemindDate+{�6S   �� $ RemindCheckbox��$ 	IsChecked�6�   �� 5%   
   -   5         ��Name$ ConfirmButton��5%      $��Confirm and finish��6(   $
��Left=�6E   $��349,331,0,0q�6`   $	��207��6u   ���	#FFDDDDDD$��20��6�   $	��Top=�6�     5&   
   -	   5        $ StartTimeDatePicker��5&      $
��Left=�6U   $��
10,266,0,0q�6p   $	��Top=�6�   $
 Long=�6�    .  62   �� *	StartDate+6�   �� 5'   
   -
   5        $ CancelButton��5'      $��Cancel��6'   $
��Left=�68   $��
10,331,0,0q�6S   $	��Top=�6g   $	��193��6   6�      Forgets.TimePicker  5(   
   -   5          Name$ StartTimePicker��5(      $
��Left=�6O   $��40��6j   $��	0,286,0,0q�6v   $	��Top=�6�   $	��149��6�    .    Time 64   �� *	StartTime+6�     5)   
   -   5        $ EndTimePicker��5)      $
��Left=�6K   $��41��6f   $��211,285,0,0q�6r   $	��Top=�6�   $	��148��6�    .  62   �� *	EndTime+6�     5*   
   -   5        $ RemindTimePicker��5*      $
��Left=�6�   $��43��6�   $��
349,86,0,0q�6�   $	��Top=�6�   $	��156��6�    65   �� *
RemindTime+{�6Q   �� $ RemindCheckbox��$ 	IsChecked�6�   �� 5+   
   -   5        $ RemindCheckbox��5+      $��	Remind me��6N   $
��Left=�6b   $��
359,24,0,0q�6}   $	��Top=�6�    6+   �� *ShouldRemind+6�   5,      5-      