using Candidate_BussinessObjs;
using Candidate_Services;
using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace PRN221PE_FA22_TrialTest_NguyenPhuCuong
{
    public partial class JobPostingWindow : Window
    {
        private readonly IJobPostingService jobService;
        public JobPostingWindow()
        {
            InitializeComponent();
            this.jobService = new JobPostingService();
            LoadGrid();
        }
        private void LoadGrid()
        {
            try
            {
                this.dataGridJobPostings.ItemsSource = jobService.GetJobPostings(); // Ensure this returns data
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading job postings: {ex.Message}");
            }
        }
        private void dataGridJobPostings_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DataGrid dataGrid = sender as DataGrid;
            if (dataGrid.SelectedItem != null)
            {
                JobPosting jobPosting = dataGrid.SelectedItem as JobPosting;
                if (jobPosting != null)
                {
                    txtPostingID.Text = jobPosting.PostingId;
                    txtJobPostingTitle.Text = jobPosting.JobPostingTitle;
                    txtDescription.Text = jobPosting.Description;
                    PostedDate.SelectedDate = jobPosting.PostedDate; // Use SelectedDate for DatePicker
                }
            }
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (dataGridJobPostings.SelectedItem == null)
                {
                    MessageBox.Show("Please select a candidate profile to delete.");
                    return;
                }
                DataGridRow row = (DataGridRow)dataGridJobPostings.ItemContainerGenerator.ContainerFromItem(dataGridJobPostings.SelectedItem);
                if (row == null)
                {
                    MessageBox.Show("Error: Could not retrieve the selected candidate row.");
                    return;
                }
                DataGridCell RowColumn = dataGridJobPostings.Columns[0].GetCellContent(row).Parent as DataGridCell;
                if (RowColumn == null)
                {
                    MessageBox.Show("RowColumn == null.");
                }
                string postingId = ((TextBlock)RowColumn.Content).Text;
                if (postingId == null)
                {
                    MessageBox.Show("postingId == null.");
                }
                bool isDelete = jobService.deleteJobPosting(postingId);
                if (isDelete)
                {
                    MessageBox.Show("Candidate profile deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to delete candidate profile.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {

                this.LoadGrid();
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (!string.IsNullOrWhiteSpace(txtPostingID.Text))
                {
                    IJobPostingService jobPostingService = new JobPostingService();

                    JobPosting existingPosting = jobPostingService.GetJobPostingByID(txtPostingID.Text);

                    if (existingPosting != null)
                    {
                        existingPosting.JobPostingTitle = txtJobPostingTitle.Text;
                        existingPosting.Description = txtDescription.Text;
                        existingPosting.PostedDate = PostedDate.SelectedDate;

                        bool isUpdated = jobPostingService.updateJobPosting(existingPosting);
                        if (isUpdated)
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
                LoadGrid();
            }


        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            JobPosting jobPosting = new JobPosting();
            jobPosting.PostingId = txtPostingID.Text;
            jobPosting.JobPostingTitle = txtJobPostingTitle.Text;
            jobPosting.Description = txtDescription.Text;
            jobPosting.PostedDate = PostedDate.SelectedDate;
            bool isAdded = jobService.addJobPosting(jobPosting);
            if (isAdded)
            {
                MessageBox.Show("Candidate profile added successfully.");
                this.LoadGrid();
            }
            else
            {
                MessageBox.Show("Failed to add candidate profile.");
            }
        }

        private void btnCandidateProfile_Click(object sender, RoutedEventArgs e)
        {
            CandidateProfileWindow candidateProfileWindow = new CandidateProfileWindow();
            candidateProfileWindow.Show();
            this.Close();
        }

    }
}
