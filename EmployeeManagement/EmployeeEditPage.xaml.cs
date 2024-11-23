using System.Windows;
using System.Windows.Controls;

namespace EmployeeManagement
{
    public partial class EmployeeEditPage : Page
    {
        private Employee _employee;

        public EmployeeEditPage(Employee employee)
        {
            InitializeComponent();
            _employee = employee;

            
            NameTextBox.DataContext = _employee;
            PositionTextBox.DataContext = _employee;
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            
            _employee.Name = NameTextBox.Text;
            _employee.Position = PositionTextBox.Text;

           
            NavigationService.GoBack();
        }
    }
}

