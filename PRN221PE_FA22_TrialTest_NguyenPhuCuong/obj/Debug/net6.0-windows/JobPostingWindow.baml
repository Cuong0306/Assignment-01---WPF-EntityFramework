   M S B A M L   `   `   `  ����*  &PRN221PE_FA22_TrialTest_NguyenPhuCuong=    7PRN221PE_FA22_TrialTest_NguyenPhuCuong.JobPostingWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  JobPostingWindow��5   	   $	��450��6"   $	��800��6/   .��5      � $��	0,0,0,-16q�6   ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5	      $ 	#FF1C6AD6��6   $ 0Q�61   � 5
      $ 	#FF134A96��6   $ 0Q�61   � 5      $ 	#FF0267F1��6   $ 0Q�61   � 5      $ 	#FF0266F0��6   $ 0.017Q�61   � 5      $ 	#FF3FD5EE��6   $ 0.979Q�61   � 5      $ 	#FF1991EF��6   $
 0.88Q�61   � 5      $ 	#FF18D8EF��6   $	 0.6Q�61   5      .+�5   
   �� $��Posting ID:��6   $
��Left=�6&   $	��Top=�6A   $��
106,64,0,0q�6Y   �� 5   
   -   5        $��txtPostingID��5      $
��Left=�6&   $	��Top=�6A   $��
182,72,0,0q�6Y   $	��531��6m    �� 
IsReadOnly$
 True��6y   �� 5   
   $��Job Posting Title:��6   $
��Left=�6-   $	��Top=�6H   $��
74,109,0,0q�6`   �� 5   
   -   5        $��txtJobPostingTitle��5      $
��Left=�6,   $	��Top=�6G   $��182,113,0,0q�6_   $	��531��6t   �� 5   
   $��Description:��6   $
��Left=�6'   $	��Top=�6B   $��100,177,0,0q�6Z   �� 5   
   -   5        $��txtDescription��5      $
��Left=�6(   $	��Top=�6C   $��178,182,0,0q�6[   $	��535��6p   $��56��6|    �� TextWrapping$
 Wrap=�6�   �� 5   
   $��Posted Date:��6   $
��Left=�6'   $	��Top=�6B   $��
98,143,0,0q�6Z   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ 
PostedDate��5      $
��Left=�6)   $��30��6D   $	��Top=�6P   $	��529��6h   $��184,143,0,0q�6t   �� 5   
   -   5         ��Name$ 	btnCreate��5      $��Create��6$   $
��Left=�65   $	��Top=�6P   $��289,392,0,0q�6h   $	��100��6}   ���	#FF02CEF16�   �� 5    
   -   5        $��	btnUpdate��5       $��Update��6"   $
��Left=�63   $	��Top=�6N   $��400,392,0,0q�6f   $	��100��6{   ���	#FF37D4286�   �� 5!   
   -   5        $��	btnDelete��5!      $��Delete��6"   $
��Left=�63   $	��Top=�6N   $��508,392,0,0q�6f   $	��100��6{   ���	#FFD4CA2E6�   �� 5"   
   -   5        $ btnClose��5"      $��Close��6#   $
��Left=�63   $	��Top=�6N   $��613,392,0,0q�6f   $	��100��6{   ���	#FFF972196�   �� 5$   
   $��Job Posting Management��6   $
��Left=�61   $	��Top=�6L   $��
277,16,0,0q�6d   $	��274��6x   $��30(�6�   
�������6�   &   System.Windows.Controls.DataGrid  5%   
   -	   5        $��dataGridJobPostings��5%      	   AutoGenerateColumns$
	 True��6.   $��178,249,87,75q�6�   �� 5&   
   -
   5        $��Candidate Profile��5&      $
��Left=�6-   $	��Top=�6H   $��167,392,0,0q�6`   $	��106��6u   ���	#FF02CEF16�   5'      5(      