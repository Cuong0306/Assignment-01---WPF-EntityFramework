using Candidate_BussinessObjs;
using Candidate_Repositories;
using Candidate_Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace PRN221PE_FA22_TrialTest_NguyenPhuCuong
{

    public partial class CandidateProfileWindow : Window
    {

        private readonly ICandidateProfileService profileService;
        private readonly IJobPostingService jobPostingService;

        public CandidateProfileWindow()
        {
            InitializeComponent();
            profileService = new CandidateProfileService();
            jobPostingService = new JobPostingService();

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.LoadGrdCandidateProfileManagement();
        }

        private void LoadGrdCandidateProfileManagement()
        {
            this.DataGrid_CandidateProfile.ItemsSource = profileService.GetCandidateProfiles();
            this.cbxJobPosting_CandidateProfile.ItemsSource = jobPostingService.GetJobPostings();
            this.cbxJobPosting_CandidateProfile.DisplayMemberPath = "JobPostingTitle";
            this.cbxJobPosting_CandidateProfile.SelectedValuePath = "PostingId";
        }



        private void btnAdd_CandidateProfile_Click(object sender, RoutedEventArgs e)
        {
            CandidateProfile candidate = new CandidateProfile();
            candidate.Fullname = txtFullName_CandidateProfile.Text;
            candidate.CandidateId = txtCandidateID_CandidateProfile.Text;
            candidate.ProfileShortDescription = txtProfileShortDescription_CandidateProfile.Text;
            candidate.Birthday = txtBirthday_CandidateProfile.SelectedDate;
            candidate.ProfileUrl = txtImageURL_CandidateProfile.Text;

            candidate.PostingId = cbxJobPosting_CandidateProfile.SelectedValue.ToString();


            if (profileService.AddCandidateProfile(candidate))
            {
                MessageBox.Show("Add Success");
                this.LoadGrdCandidateProfileManagement();
            }
            else
            {
                MessageBox.Show("Failed.");
            }
        }

        


        private void btnDelete_CandidateProfile_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (DataGrid_CandidateProfile.SelectedItem == null)
                {
                    MessageBox.Show("Please select a candidate profile to delete.");
                    return;
                }
                DataGridRow row = (DataGridRow)DataGrid_CandidateProfile.ItemContainerGenerator.ContainerFromItem(DataGrid_CandidateProfile.SelectedItem);
                if (row == null)
                {
                    MessageBox.Show("Error: Could not retrieve the selected candidate row.");
                    return;
                }
                DataGridCell RowColumn = DataGrid_CandidateProfile.Columns[0].GetCellContent(row).Parent as DataGridCell;
                string candidateId = ((TextBlock)RowColumn.Content).Text;
                bool isDelete = profileService.DeleteCandidateProfile(candidateId);
                if (isDelete)
                {
                    MessageBox.Show("Deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                LoadGrdCandidateProfileManagement();
            }
        }
        private void DataGrid_CandidateProfile_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;

            DataGridRow row = dataGrid.ItemContainerGenerator.ContainerFromIndex(dataGrid.SelectedIndex) as DataGridRow;
            if (row != null)
            {
                DataGridCell RowColumn = dataGrid.Columns[0].GetCellContent(row).Parent as DataGridCell;
                string id = ((TextBlock)RowColumn.Content).Text;
                CandidateProfile candidateProfile = profileService.GetCandidateProfile(id);
                if (candidateProfile != null)
                {
                    txtCandidateID_CandidateProfile.Text = candidateProfile.CandidateId.ToString();
                    txtFullName_CandidateProfile.Text = candidateProfile.Fullname;
                    txtProfileShortDescription_CandidateProfile.Text = candidateProfile.ProfileShortDescription;
                    txtBirthday_CandidateProfile.Text = candidateProfile.Birthday.ToString();
                    txtImageURL_CandidateProfile.Text = candidateProfile.ProfileUrl;
                    cbxJobPosting_CandidateProfile.SelectedValue = candidateProfile.PostingId;
                }
            }
        }

        private void btnClose_CandidateProfile_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_CandidateProfile_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtCandidateID_CandidateProfile.Text))
                {
                    // Lấy profile hiện tại từ service
                    CandidateProfile existingProfile = profileService.GetCandidateProfile(txtCandidateID_CandidateProfile.Text);

                    if (existingProfile != null)
                    {
                        // Cập nhật thông tin cho candidate profile
                        existingProfile.Fullname = txtFullName_CandidateProfile.Text;
                        existingProfile.ProfileShortDescription = txtProfileShortDescription_CandidateProfile.Text;
                        existingProfile.Birthday = txtBirthday_CandidateProfile.SelectedDate;
                        existingProfile.ProfileUrl = txtImageURL_CandidateProfile.Text;
                        existingProfile.PostingId = cbxJobPosting_CandidateProfile.SelectedValue?.ToString();

                        // Gọi phương thức UpdateCandidateProfile
                        if (profileService.UpdateCandidateProfile(existingProfile))
                        {
                            MessageBox.Show("Candidate profile updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("Failed to update candidate profile.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Candidate not found.");
                    }
                }
                else
                {
                    MessageBox.Show("You must select a candidate!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                LoadGrdCandidateProfileManagement();
            }

        }
        private void btnJobPosting_Click(object sender, RoutedEventArgs e)
        {
            JobPostingWindow jobPostingWindow = new JobPostingWindow();
            jobPostingWindow.Show();
            this.Close();
        }




    }
}
                
            
    

        
    
