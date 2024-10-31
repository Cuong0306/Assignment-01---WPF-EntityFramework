using Candidate_BussinessObjs;
using Candidate_Services;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PRN221PE_FA22_TrialTest_NguyenPhuCuong
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IHRAccountServices iAccountServices;
        public MainWindow()
        {
            InitializeComponent();
            iAccountServices = new HRAccountServices();
        }
        private void btLogin_Click(object sender, RoutedEventArgs e)
        {
            Hraccount hraccount = iAccountServices.GetHraccountByMail(txtEmail.Text);
            if (hraccount != null && hraccount.Password.Equals(hraccount.Password) && hraccount.MemberRole==1)
            {
                this.Hide();
                CandidateProfileWindow candidateForm = new CandidateProfileWindow();
                candidateForm.Show();
            }else
            {
                MessageBox.Show("Bye");
            }
        }

       private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}