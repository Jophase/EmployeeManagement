using System.Windows;

namespace EmployeeManagement
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new EmployeeListPage());
        }
    }
}
