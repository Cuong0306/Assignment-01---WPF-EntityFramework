   M S B A M L   `   `   `  ����a  ]PRN221PE_FA22_TrialTest_NguyenPhuCuong, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null_4clr-namespace:PRN221PE_FA22_TrialTest_NguyenPhuCuong&PRN221PE_FA22_TrialTest_NguyenPhuCuong  5   	   C    =PRN221PE_FA22_TrialTest_NguyenPhuCuong.CandidateProfileWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Flocal4clr-namespace:PRN221PE_FA22_TrialTest_NguyenPhuCuong     5   	   -   5          � Title$  CandidateProfileWindow��5   	   $	��450��6(   $	��800��65   .��5	      � .+�5
   
   �� $
��Left=�6   $��
215,20,0,0q�6/   $
��Wrap=�6C   $"��CANDIDATE PROFILE MANAGEMENT��6W   $	��Top=�6{   $	��404��6�   $��24(�6�   �� 5   
   $
��Left=�6   $��	83,65,0,0q�6/   $
��Wrap=�6B   $��Candidate ID:��6V   $	��Top=�6k   �� 5   
   -   5         ��Name$% txtCandidateID_CandidateProfile��5      $
��Left=�6;   $��
173,65,0,0q�6V    �� TextWrapping$
 Wrap=�6j   $	��Top=�6~   $	��214��6�   �� 5   
   $
��Left=�6   $��
83,108,0,0q�6/   $
��Wrap=�6C   $��
Full Name:��6W   $	��Top=�6i   �� 5   
   -   5        $" txtFullName_CandidateProfile��5      $
��Left=�68   $��173,108,0,0q�6S   $
 Wrap=�6h   $	��Top=�6|   $	��214��6�   �� 5   
   -   5         ��Name$ Birthday_CandidateProfile��5      $
��Left=�67   $��
83,196,0,0q�6R   $
��Wrap=�6f   $��	Birthday:��6z   $	��Top=�6�   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$" txtBirthday_CandidateProfile��5      $
��Left=�6;   $��173,192,0,0q�6V   $	��Top=�6k   $	��214��6�   �� 5   
   $
��Left=�6   $��
83,154,0,0q�6/   $
��Wrap=�6C   $��
Image URL:��6W   $	��Top=�6i   �� 5   
   -   5        $" txtImageURL_CandidateProfile��5      $
��Left=�68   $��173,154,0,0q�6S   $
 Wrap=�6h   $	��Top=�6|   $	��214��6�   �� 5   
   -   5        $! JobPosting_CandidateProfile��5      $
��Left=�69   $��
431,66,0,0q�6T   $
��Wrap=�6h   $��Job Posting:��6|   $	��Top=�6�   �� 5   
   -   5         ��Name$$ cbxJobPosting_CandidateProfile��5      $
��Left=�6;   $��
499,63,0,0q�6V   $	��Top=�6j   $	��224��6�   �� 5   
   $
��Left=�6   $��431,108,0,0q�6/   $
��Wrap=�6D   $��Description:��6X   $	��Top=�6l   �� 5   
   -	   5        $1 +txtProfileShortDescription_CandidateProfile��5      $
��Left=�6G   $��431,129,0,0q�6b   $
 Wrap=�6w   $��TextBox��6�   $	��Top=�6�   $	��292��6�   $��83��6�   �� 5   
   -
   5         ��Name$ btnAdd_CandidateProfile��5      $	��Add��62   $
��Left=�6@   $��205,345,0,0q�6[   $	��Top=�6p   $��43��6�   $	��116��6�   ���	#FF7EF9606�   �� 5   
   -   5        $  btnUpdate_CandidateProfile��5      $��Update��65   $��Center=�6F   $��	0,345,0,0q�6c   $	��Top=�6v   $��43��6�   $	��116��6�   ���	#FFB4F15C6�   �� 5    
   -   5        $  btnDelete_CandidateProfile��5       $��Delete��65   $
��Left=�6F   $��480,345,0,0q�6a   $	��Top=�6v   $��43��6�   $	��116��6�   ���	#FFFF9C266�   �� 5!   
   -   5        $ btnClose_CandidateProfile��5!      $��Closes��64   $
��Left=�6E   $��607,345,0,0q�6`   $	��Top=�6u   $��43��6�   $	��116��6�   ���	#FF57C1F46�   &   System.Windows.Controls.DataGrid  5"   
   -   5          Name$ DataGrid_CandidateProfile��5"      $��83,228,77,102q�6a   6x   �� 5$   
   -   5        $��Job Posting��5$      $
��Left=�6'   $��Bottom=�6B   $��	76,0,0,36q�6]   $��42��6�   $	��102��6�   5'      5(      