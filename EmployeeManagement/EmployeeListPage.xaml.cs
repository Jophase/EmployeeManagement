using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace EmployeeManagement
{
    public partial class EmployeeListPage : Page
    {
        private List<Employee> employees;

        public EmployeeListPage()
        {
            InitializeComponent();
            LoadEmployees();
        }

        private void LoadEmployees()
        {
           
            employees = new List<Employee>
            {
                new Employee { Name = "John Doe", Position = "Developer" },
                new Employee { Name = "Jane Smith", Position = "Manager" }
            };

            EmployeeDataGrid.ItemsSource = employees;
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            if (EmployeeDataGrid.SelectedItem is Employee selectedEmployee)
            {
                NavigationService.Navigate(new EmployeeEditPage(selectedEmployee));
            }
            else
            {
                MessageBox.Show("Внимание ! Выберите элемент который хотите отредактировать.");
            }
        }

        private void EmployeeDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
        }
    }
}

